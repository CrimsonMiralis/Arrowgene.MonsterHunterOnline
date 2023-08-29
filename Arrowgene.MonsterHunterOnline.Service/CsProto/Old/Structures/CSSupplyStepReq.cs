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
    /// 快捷补给step1
    /// </summary>
    public class CSSupplyStepReq : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSSupplyStepReq));

        public CSSupplyStepReq()
        {
            iPlanID = 0;
            StepType = 0;
            StepList = new List<SupplyStep>();
        }

        /// <summary>
        /// 方案ID
        /// </summary>
        public int iPlanID;

        /// <summary>
        /// 步骤类型
        /// </summary>
        public int StepType;

        /// <summary>
        /// 步骤列表
        /// </summary>
        public List<SupplyStep> StepList;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteInt32(iPlanID, Endianness.Big);
            buffer.WriteInt32(StepType, Endianness.Big);
            int stepListCount = (int)StepList.Count;
            buffer.WriteInt32(stepListCount, Endianness.Big);
            for (int i = 0; i < stepListCount; i++)
            {
                StepList[i].WriteCs(buffer);
            }
        }

        public void ReadCs(IBuffer buffer)
        {
            iPlanID = buffer.ReadInt32(Endianness.Big);
            StepType = buffer.ReadInt32(Endianness.Big);
            StepList.Clear();
            int stepListCount = buffer.ReadInt32(Endianness.Big);
            for (int i = 0; i < stepListCount; i++)
            {
                SupplyStep StepListEntry = new SupplyStep();
                StepListEntry.ReadCs(buffer);
                StepList.Add(StepListEntry);
            }
        }

    }
}
