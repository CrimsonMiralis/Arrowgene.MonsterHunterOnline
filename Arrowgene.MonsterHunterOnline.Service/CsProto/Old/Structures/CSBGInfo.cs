/*
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

/* THIS IS AN AUTOGENERATED FILE. DO NOT EDIT THIS FILE DIRECTLY. */

using System.Collections.Generic;
using Arrowgene.Buffers;
using Arrowgene.Logging;
using Arrowgene.MonsterHunterOnline.Service.CsProto.Core;
using Arrowgene.MonsterHunterOnline.Service.CsProto.Enums;

namespace Arrowgene.MonsterHunterOnline.Service.CsProto.Structures
{

    public class CSBGInfo : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSBGInfo));

        public CSBGInfo()
        {
            BattleSvrID = 0;
            InstanceID = 0;
            LevelName = "";
            PlayerName = new List<string>();
        }

        public uint BattleSvrID;

        public uint InstanceID;

        public string LevelName;

        public List<string> PlayerName;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteUInt32(BattleSvrID, Endianness.Big);
            buffer.WriteUInt32(InstanceID, Endianness.Big);
            buffer.WriteInt32(LevelName.Length + 1, Endianness.Big);
            buffer.WriteCString(LevelName);
            short playerNameCount = (short)PlayerName.Count;
            buffer.WriteInt16(playerNameCount, Endianness.Big);
            for (int i = 0; i < playerNameCount; i++)
            {
                buffer.WriteInt32(PlayerName[i].Length + 1, Endianness.Big);
                buffer.WriteCString(PlayerName[i]);
            }
        }

        public void ReadCs(IBuffer buffer)
        {
            BattleSvrID = buffer.ReadUInt32(Endianness.Big);
            InstanceID = buffer.ReadUInt32(Endianness.Big);
            int LevelNameEntryLen = buffer.ReadInt32(Endianness.Big);
            LevelName = buffer.ReadString(LevelNameEntryLen);
            PlayerName.Clear();
            short playerNameCount = buffer.ReadInt16(Endianness.Big);
            for (int i = 0; i < playerNameCount; i++)
            {
                string PlayerNameEntry = "";
                int PlayerNameEntryEntryLen = buffer.ReadInt32(Endianness.Big);
                PlayerNameEntry = buffer.ReadString(PlayerNameEntryEntryLen);
                PlayerName.Add(PlayerNameEntry);
            }
        }

    }
}
