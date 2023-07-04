﻿/*
 * This file is part of Arrowgene.MonsterHunterOnline
 *
 * Arrowgene.MonsterHunterOnline is a server implementation for the game "Monster Hunter Online".
 * Copyright (C) 2023-2024 "all contributors"
 *
 * Github: https://github.com/sebastian-heinz/Arrowgene.MonsterHunterOnline
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU Affero General Public License as published
 *  by the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Affero General Public License for more details.
 *
 *  You should have received a copy of the GNU Affero General Public License
 *  along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using Arrowgene.Logging;
using Arrowgene.MonsterHunterOnline.Cli.Command;
using Arrowgene.MonsterHunterOnline.Service;

namespace Arrowgene.MonsterHunterOnline.Cli
{
    internal class Program
    {
        private const char CliSeparator = ' ';
        private const char CliValueSeparator = '=';
        private static readonly ILogger Logger = LogProvider.Logger(typeof(Program));


        private static void Main(string[] args)
        {
            Console.WriteLine("Program started");
            Console.WriteLine($"Version: {Util.GetVersion("Cli")}");
            Program program = new Program();
            program.RunArguments(args);
            Console.WriteLine("Program ended");
        }

        private readonly CancellationTokenSource _cancellationTokenSource;
        private readonly Dictionary<string, ICommand> _commands;
        private ICommand _lastCommand;
        private readonly object _consoleLock;
        private readonly DirectoryInfo _logDir;

        private Program()
        {
            _logDir = new DirectoryInfo(Path.Combine(Util.ExecutingDirectory(), "Logs"));
            if (!_logDir.Exists)
            {
                Directory.CreateDirectory(_logDir.FullName);
            }

            _lastCommand = null;
            _consoleLock = new object();
            _commands = new Dictionary<string, ICommand>();
            _cancellationTokenSource = new CancellationTokenSource();
            Console.CancelKeyPress += ConsoleOnCancelKeyPress;
            LogProvider.OnLogWrite += LogProviderOnLogWrite;
        }

        private void LoadCommands()
        {
            AddCommand(new ShowCommand());
            AddCommand(new HelpCommand(_commands));
            AddCommand(new ServiceCommand());
            AddCommand(new IIPSCommand());
        }

        private void RunArguments(string[] arguments)
        {
            LogProvider.Start();
            if (arguments.Length <= 0)
            {
                Logger.Error("No Arguments Provided");
                return;
            }

            LoadCommands();
            ShowCopyright();
            CommandParameter parameter = ParseParameter(arguments);
            CommandResultType result = ProcessArguments(parameter);

            if (result != CommandResultType.Exit)
            {
                Logger.Info("Press `e'-key to exit.");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                while (keyInfo.Key != ConsoleKey.E)
                {
                    keyInfo = Console.ReadKey();
                }
            }

            if (_lastCommand != null)
            {
                _lastCommand.Shutdown();
            }

            // Wait for logs to be flushed to console
            Thread.Sleep(1000);
            LogProvider.Stop();
        }

        private CommandResultType ProcessArguments(CommandParameter parameter)
        {
            if (!_commands.ContainsKey(parameter.Key))
            {
                Logger.Error(
                    $"Command: '{parameter.Key}' not available. Type `help' for a list of available commands.");
                return CommandResultType.Continue;
            }

            _lastCommand = _commands[parameter.Key];
            return _lastCommand.Run(parameter);
        }

        /// <summary>
        /// Parses the input text into arguments and switches.
        /// </summary>
        private CommandParameter ParseParameter(string[] args)
        {
            if (args.Length <= 0)
            {
                Logger.Error("Invalid input. Type 'help' for a list of available commands.");
                return null;
            }

            string paramKey = args[0];
            int cmdLength = args.Length - 1;
            string[] newArguments = new string[cmdLength];
            if (cmdLength > 0)
            {
                Array.Copy(args, 1, newArguments, 0, cmdLength);
            }

            args = newArguments;

            CommandParameter parameter = new CommandParameter(paramKey);
            foreach (string arg in args)
            {
                int count = CountChar(arg, CliValueSeparator);
                if (count == 1)
                {
                    string[] keyValue = arg.Split(CliValueSeparator);
                    if (keyValue.Length == 2)
                    {
                        string key = keyValue[0];
                        string value = keyValue[1];
                        if (key.StartsWith('-'))
                        {
                            if (key.Length <= 2 || parameter.SwitchMap.ContainsKey(key))
                            {
                                Logger.Error($"Invalid switch key: '{key}' is empty or duplicated.");
                                continue;
                            }

                            parameter.SwitchMap.Add(key, value);
                            continue;
                        }

                        if (key.Length <= 0 || parameter.ArgumentMap.ContainsKey(key))
                        {
                            Logger.Error($"Invalid argument key: '{key}' is empty or duplicated.");
                            continue;
                        }

                        parameter.ArgumentMap.Add(key, value);
                        continue;
                    }
                }

                if (arg.StartsWith('-'))
                {
                    string switchStr = arg;
                    if (switchStr.Length <= 2 || parameter.Switches.Contains(switchStr))
                    {
                        Logger.Error($"Invalid switch: '{switchStr}' is empty or duplicated.");
                        continue;
                    }

                    parameter.Switches.Add(switchStr);
                    continue;
                }

                if (arg.Length <= 0 || parameter.Switches.Contains(arg))
                {
                    Logger.Error($"Invalid argument: '{arg}' is empty or duplicated.");
                    continue;
                }

                parameter.Arguments.Add(arg);
            }

            return parameter;
        }

        private int CountChar(string str, char chr)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (c == chr)
                {
                    count++;
                }
            }

            return count;
        }

        private void ConsoleOnCancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            _cancellationTokenSource.Cancel();
        }

        private void AddCommand(ICommand command)
        {
            _commands.Add(command.Key, command);
        }

        private void ShowCopyright()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            sb.Append("Arrowgene.MonsterHunterOnline.Cli Copyright (C) 2023-2024 all contributors");
            sb.Append(Environment.NewLine);
            sb.Append("This program comes with ABSOLUTELY NO WARRANTY; for details type `show w'.");
            sb.Append(Environment.NewLine);
            sb.Append("This is free software, and you are welcome to redistribute it");
            sb.Append(Environment.NewLine);
            sb.Append("under certain conditions; type `show c' for details.");
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            Logger.Info(sb.ToString());
        }

        private void LogProviderOnLogWrite(object sender, LogWriteEventArgs e)
        {
            Log log = e.Log;
            LogLevel logLevel = log.LogLevel;


            if (logLevel == LogLevel.Debug || logLevel == LogLevel.Info)
            {
                if (log.LoggerIdentity.StartsWith("Arrowgene.WebServer.Server.Kestrel"))
                {
                    // ignore internal web server logs
                    return;
                }

                if (log.LoggerIdentity.StartsWith("Arrowgene.WebServer.Route.WebRouter"))
                {
                    // ignore web route logs
                    //return;
                }
            }

            ConsoleColor consoleColor;
            switch (logLevel)
            {
                case LogLevel.Debug:
                    consoleColor = ConsoleColor.DarkCyan;
                    break;
                case LogLevel.Info:
                    consoleColor = ConsoleColor.Cyan;
                    break;
                case LogLevel.Error:
                    consoleColor = ConsoleColor.Red;
                    break;
                default:
                    consoleColor = ConsoleColor.Gray;
                    break;
            }


            string text = log.ToString();
            if (text == null)
            {
                return;
            }

            lock (_consoleLock)
            {
                Console.ForegroundColor = consoleColor;
                Console.WriteLine(text);
                Console.ResetColor();

                // TODO perhaps some buffering and only flush after X logs
                string filePath = Path.Combine(_logDir.FullName, $"{log.DateTime:yyyy-MM-dd}.log.txt");
                using StreamWriter sw = new StreamWriter(filePath, append: true);
                sw.WriteLine(text);
            }
        }
    }
}