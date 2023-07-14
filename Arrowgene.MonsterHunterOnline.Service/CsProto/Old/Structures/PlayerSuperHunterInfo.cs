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
    /// 超级大连续信息
    /// </summary>
    public class PlayerSuperHunterInfo : IStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(PlayerSuperHunterInfo));

        public PlayerSuperHunterInfo()
        {
            LastResetTime = 0;
            GainChallangeRewardTimes = 0;
            GainSuccessRewardTimes = 0;
            GainVipChallangeRewardTimes = 0;
            GainVipSuccessRewardTimes = 0;
        }

        /// <summary>
        /// 上次重置挑战信息时间
        /// </summary>
        public uint LastResetTime;

        /// <summary>
        /// 今日领取挑战奖励次数
        /// </summary>
        public int GainChallangeRewardTimes;

        /// <summary>
        /// 今日领取成功奖励次数
        /// </summary>
        public int GainSuccessRewardTimes;

        /// <summary>
        /// 今日领取Vip挑战奖励次数
        /// </summary>
        public int GainVipChallangeRewardTimes;

        /// <summary>
        /// 今日领取Vip成功奖励次数
        /// </summary>
        public int GainVipSuccessRewardTimes;

        public void Write(IBuffer buffer)
        {
            buffer.WriteUInt32(LastResetTime, Endianness.Big);
            buffer.WriteInt32(GainChallangeRewardTimes, Endianness.Big);
            buffer.WriteInt32(GainSuccessRewardTimes, Endianness.Big);
            buffer.WriteInt32(GainVipChallangeRewardTimes, Endianness.Big);
            buffer.WriteInt32(GainVipSuccessRewardTimes, Endianness.Big);
        }

        public void Read(IBuffer buffer)
        {
            LastResetTime = buffer.ReadUInt32(Endianness.Big);
            GainChallangeRewardTimes = buffer.ReadInt32(Endianness.Big);
            GainSuccessRewardTimes = buffer.ReadInt32(Endianness.Big);
            GainVipChallangeRewardTimes = buffer.ReadInt32(Endianness.Big);
            GainVipSuccessRewardTimes = buffer.ReadInt32(Endianness.Big);
        }

    }
}