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
    /// 超级大连续获取信息
    /// </summary>
    public class CSSuperSeriesGetInfoRsp : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSSuperSeriesGetInfoRsp));

        public CSSuperSeriesGetInfoRsp()
        {
            RetCode = 0;
            GainChallangeRewardTimes = 0;
            GainSuccessRewardTimes = 0;
            GainVipChallangeRewardTimes = 0;
            GainVipSuccessRewardTimes = 0;
            SuperSeqId = 0;
            DelayRefreshTime = 0;
        }

        /// <summary>
        /// 错误码
        /// </summary>
        public int RetCode;

        public int GainChallangeRewardTimes;

        public int GainSuccessRewardTimes;

        public int GainVipChallangeRewardTimes;

        public int GainVipSuccessRewardTimes;

        /// <summary>
        /// 当前大连续id
        /// </summary>
        public int SuperSeqId;

        /// <summary>
        /// 0点后延时刷新时间
        /// </summary>
        public int DelayRefreshTime;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteInt32(RetCode, Endianness.Big);
            buffer.WriteInt32(GainChallangeRewardTimes, Endianness.Big);
            buffer.WriteInt32(GainSuccessRewardTimes, Endianness.Big);
            buffer.WriteInt32(GainVipChallangeRewardTimes, Endianness.Big);
            buffer.WriteInt32(GainVipSuccessRewardTimes, Endianness.Big);
            buffer.WriteInt32(SuperSeqId, Endianness.Big);
            buffer.WriteInt32(DelayRefreshTime, Endianness.Big);
        }

        public void ReadCs(IBuffer buffer)
        {
            RetCode = buffer.ReadInt32(Endianness.Big);
            GainChallangeRewardTimes = buffer.ReadInt32(Endianness.Big);
            GainSuccessRewardTimes = buffer.ReadInt32(Endianness.Big);
            GainVipChallangeRewardTimes = buffer.ReadInt32(Endianness.Big);
            GainVipSuccessRewardTimes = buffer.ReadInt32(Endianness.Big);
            SuperSeqId = buffer.ReadInt32(Endianness.Big);
            DelayRefreshTime = buffer.ReadInt32(Endianness.Big);
        }

    }
}
