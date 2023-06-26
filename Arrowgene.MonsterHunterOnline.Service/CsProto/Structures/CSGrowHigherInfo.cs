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

    public class CSGrowHigherInfo : IStructure
    {

        public CSGrowHigherInfo()
        {
            DateDay = 0;
            CurHigher = 0;
            MeetTime = 0;
            GiantTime = 0;
            DailyRewardFlag = 0;
            RewardFlag = 0;
        }

        /// <summary>
        /// 日期天
        /// </summary>
        public int DateDay;

        /// <summary>
        /// 当前长高量
        /// </summary>
        public int CurHigher;

        /// <summary>
        /// 上次领迷之龙肉时间
        /// </summary>
        public int MeetTime;

        /// <summary>
        /// 上次领巨龙肉时间
        /// </summary>
        public int GiantTime;

        /// <summary>
        /// 每日领圣诞礼物的记录
        /// </summary>
        public int DailyRewardFlag;

        /// <summary>
        /// 领圣诞礼物的记录
        /// </summary>
        public int RewardFlag;

        public void Write(IBuffer buffer)
        {
            buffer.WriteInt32(DateDay, Endianness.Big);
            buffer.WriteInt32(CurHigher, Endianness.Big);
            buffer.WriteInt32(MeetTime, Endianness.Big);
            buffer.WriteInt32(GiantTime, Endianness.Big);
            buffer.WriteInt32(DailyRewardFlag, Endianness.Big);
            buffer.WriteInt32(RewardFlag, Endianness.Big);
        }

    }
}
