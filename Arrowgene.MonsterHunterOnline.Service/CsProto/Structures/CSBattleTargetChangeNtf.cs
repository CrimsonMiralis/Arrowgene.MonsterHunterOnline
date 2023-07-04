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
    /// 关卡目标变更
    /// </summary>
    public class CSBattleTargetChangeNtf : IStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSBattleTargetChangeNtf));

        public CSBattleTargetChangeNtf()
        {
            TargetID = 0;
            ConditionID = 0;
            CurCount = 0;
            State = 0;
        }

        /// <summary>
        /// 目标ID
        /// </summary>
        public int TargetID;

        /// <summary>
        /// 子条件ID
        /// </summary>
        public int ConditionID;

        /// <summary>
        /// 当前完成个数
        /// </summary>
        public int CurCount;

        /// <summary>
        /// 状态
        /// </summary>
        public int State;

        public void Write(IBuffer buffer)
        {
            buffer.WriteInt32(TargetID, Endianness.Big);
            buffer.WriteInt32(ConditionID, Endianness.Big);
            buffer.WriteInt32(CurCount, Endianness.Big);
            buffer.WriteInt32(State, Endianness.Big);
        }

        public void Read(IBuffer buffer)
        {
            TargetID = buffer.ReadInt32(Endianness.Big);
            ConditionID = buffer.ReadInt32(Endianness.Big);
            CurCount = buffer.ReadInt32(Endianness.Big);
            State = buffer.ReadInt32(Endianness.Big);
        }

    }
}