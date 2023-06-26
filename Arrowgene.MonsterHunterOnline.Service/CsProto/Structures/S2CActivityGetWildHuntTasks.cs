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
using Arrowgene.MonsterHunterOnline.Service.CsProto.Core;
using Arrowgene.MonsterHunterOnline.Service.CsProto.Enums;

namespace Arrowgene.MonsterHunterOnline.Service.CsProto.Structures
{

    /// <summary>
    /// 红黄对抗获得任务
    /// </summary>
    public class S2CActivityGetWildHuntTasks : IStructure
    {

        public S2CActivityGetWildHuntTasks()
        {
            ResetTimes = 0;
            Tasks = new List<int>();
            Ratios = new List<float>();
            CompleteTasks = new List<int>();
        }

        /// <summary>
        /// 重置次数
        /// </summary>
        public int ResetTimes;

        /// <summary>
        /// 任务集
        /// </summary>
        public List<int> Tasks;

        /// <summary>
        /// 任务系数集
        /// </summary>
        public List<float> Ratios;

        /// <summary>
        /// 已完成任务集
        /// </summary>
        public List<int> CompleteTasks;

        public void Write(IBuffer buffer)
        {
            buffer.WriteInt32(ResetTimes, Endianness.Big);
            int tasksCount = (int)Tasks.Count;
            buffer.WriteInt32(tasksCount, Endianness.Big);
            for (int i = 0; i < tasksCount; i++)
            {
                buffer.WriteInt32(Tasks[i], Endianness.Big);
            }
            int ratiosCount = (int)Ratios.Count;
            buffer.WriteInt32(ratiosCount, Endianness.Big);
            for (int i = 0; i < ratiosCount; i++)
            {
                buffer.WriteFloat(Ratios[i], Endianness.Big);
            }
            int completeTasksCount = (int)CompleteTasks.Count;
            buffer.WriteInt32(completeTasksCount, Endianness.Big);
            for (int i = 0; i < completeTasksCount; i++)
            {
                buffer.WriteInt32(CompleteTasks[i], Endianness.Big);
            }
        }

    }
}
