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
    /// 个人赛季数据
    /// </summary>
    public class S2CLeaguePlayerInfo : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(S2CLeaguePlayerInfo));

        public S2CLeaguePlayerInfo()
        {
            CurSeason = 0;
            Score = 0;
            ScoreTop = 0;
            WeekReward = 0;
            Streak = 0;
            WinNum = 0;
            LoseNum = 0;
            TotalNum = 0;
            RewardMask = 0;
            ExRewardNum = 0;
            StepReward = 0;
            ExMedalNum = 0;
        }

        /// <summary>
        /// 当前赛季
        /// </summary>
        public int CurSeason;

        /// <summary>
        /// 当前赛季积分
        /// </summary>
        public int Score;

        /// <summary>
        /// 当前赛季最高积分
        /// </summary>
        public int ScoreTop;

        /// <summary>
        /// 本周获得的荣誉勋章数量
        /// </summary>
        public int WeekReward;

        /// <summary>
        /// 连胜连负记录
        /// </summary>
        public int Streak;

        /// <summary>
        /// 胜利场数
        /// </summary>
        public int WinNum;

        /// <summary>
        /// 失败场数
        /// </summary>
        public int LoseNum;

        /// <summary>
        /// 总场数
        /// </summary>
        public int TotalNum;

        /// <summary>
        /// 发奖记录
        /// </summary>
        public int RewardMask;

        /// <summary>
        /// 每日额外奖励次数
        /// </summary>
        public int ExRewardNum;

        /// <summary>
        /// 阶段领奖记录
        /// </summary>
        public int StepReward;

        /// <summary>
        /// 每日额外勋章次数
        /// </summary>
        public int ExMedalNum;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteInt32(CurSeason, Endianness.Big);
            buffer.WriteInt32(Score, Endianness.Big);
            buffer.WriteInt32(ScoreTop, Endianness.Big);
            buffer.WriteInt32(WeekReward, Endianness.Big);
            buffer.WriteInt32(Streak, Endianness.Big);
            buffer.WriteInt32(WinNum, Endianness.Big);
            buffer.WriteInt32(LoseNum, Endianness.Big);
            buffer.WriteInt32(TotalNum, Endianness.Big);
            buffer.WriteInt32(RewardMask, Endianness.Big);
            buffer.WriteInt32(ExRewardNum, Endianness.Big);
            buffer.WriteInt32(StepReward, Endianness.Big);
            buffer.WriteInt32(ExMedalNum, Endianness.Big);
        }

        public void ReadCs(IBuffer buffer)
        {
            CurSeason = buffer.ReadInt32(Endianness.Big);
            Score = buffer.ReadInt32(Endianness.Big);
            ScoreTop = buffer.ReadInt32(Endianness.Big);
            WeekReward = buffer.ReadInt32(Endianness.Big);
            Streak = buffer.ReadInt32(Endianness.Big);
            WinNum = buffer.ReadInt32(Endianness.Big);
            LoseNum = buffer.ReadInt32(Endianness.Big);
            TotalNum = buffer.ReadInt32(Endianness.Big);
            RewardMask = buffer.ReadInt32(Endianness.Big);
            ExRewardNum = buffer.ReadInt32(Endianness.Big);
            StepReward = buffer.ReadInt32(Endianness.Big);
            ExMedalNum = buffer.ReadInt32(Endianness.Big);
        }

    }
}
