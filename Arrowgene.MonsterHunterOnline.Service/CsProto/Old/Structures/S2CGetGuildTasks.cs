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

    /// <summary>
    /// 获取猎团任务
    /// </summary>
    public class S2CGetGuildTasks : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(S2CGetGuildTasks));

        public S2CGetGuildTasks()
        {
            NextRefreshTime = 0;
            Task = new List<byte>();
        }

        /// <summary>
        /// 下次刷新时间
        /// </summary>
        public uint NextRefreshTime;

        /// <summary>
        /// 任务数据
        /// </summary>
        public List<byte> Task;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteUInt32(NextRefreshTime, Endianness.Big);
            int taskCount = (int)Task.Count;
            buffer.WriteInt32(taskCount, Endianness.Big);
            for (int i = 0; i < taskCount; i++)
            {
                buffer.WriteByte(Task[i]);
            }
        }

        public void ReadCs(IBuffer buffer)
        {
            NextRefreshTime = buffer.ReadUInt32(Endianness.Big);
            Task.Clear();
            int taskCount = buffer.ReadInt32(Endianness.Big);
            for (int i = 0; i < taskCount; i++)
            {
                byte TaskEntry = buffer.ReadByte();
                Task.Add(TaskEntry);
            }
        }

    }
}
