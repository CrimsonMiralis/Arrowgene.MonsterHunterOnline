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
    /// 宠物技能使用信息同步
    /// </summary>
    public class CSPetSkillUseInfo : IStructure
    {

        public CSPetSkillUseInfo()
        {
            SkillInfo = 0;
            SkillID = 0;
            SyncTime = 0;
            ServerTimeHour = 0;
            ServerTimeMin = 0;
            ServerTimeSec = 0;
        }

        /// <summary>
        /// 技能信息
        /// </summary>
        public int SkillInfo;

        /// <summary>
        /// 技能ID
        /// </summary>
        public int SkillID;

        /// <summary>
        /// 同步时间
        /// </summary>
        public long SyncTime;

        /// <summary>
        /// 同步时间时
        /// </summary>
        public int ServerTimeHour;

        /// <summary>
        /// 同步时间分
        /// </summary>
        public int ServerTimeMin;

        /// <summary>
        /// 同步时间秒
        /// </summary>
        public int ServerTimeSec;

        public void Write(IBuffer buffer)
        {
            buffer.WriteInt32(SkillInfo, Endianness.Big);
            buffer.WriteInt32(SkillID, Endianness.Big);
            buffer.WriteInt64(SyncTime, Endianness.Big);
            buffer.WriteInt32(ServerTimeHour, Endianness.Big);
            buffer.WriteInt32(ServerTimeMin, Endianness.Big);
            buffer.WriteInt32(ServerTimeSec, Endianness.Big);
        }

    }
}
