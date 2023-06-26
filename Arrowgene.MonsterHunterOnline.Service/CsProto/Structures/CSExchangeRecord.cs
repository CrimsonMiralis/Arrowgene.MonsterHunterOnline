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
    /// 拍卖记录
    /// </summary>
    public class CSExchangeRecord : IStructure
    {

        public CSExchangeRecord()
        {
            RecordId = 0;
            DBId = 0;
            RoleName = "";
            LeftTime = 0;
            Money = 0;
            Credit = 0;
            RecordTime = 0;
            BidDBId = 0;
            BidRoleName = "";
            BidLevel = 0;
        }

        /// <summary>
        /// 记录ID
        /// </summary>
        public ulong RecordId;

        /// <summary>
        /// 所属玩家dbid
        /// </summary>
        public ulong DBId;

        /// <summary>
        /// 玩家名字
        /// </summary>
        public string RoleName;

        /// <summary>
        /// 剩余时间
        /// </summary>
        public uint LeftTime;

        /// <summary>
        /// 金币
        /// </summary>
        public uint Money;

        /// <summary>
        /// 点券
        /// </summary>
        public uint Credit;

        /// <summary>
        /// 记录时间
        /// </summary>
        public uint RecordTime;

        /// <summary>
        /// 当前出价最高人
        /// </summary>
        public ulong BidDBId;

        /// <summary>
        /// 出价玩家名字
        /// </summary>
        public string BidRoleName;

        /// <summary>
        /// 买家等级
        /// </summary>
        public uint BidLevel;

        public void Write(IBuffer buffer)
        {
            buffer.WriteUInt64(RecordId, Endianness.Big);
            buffer.WriteUInt64(DBId, Endianness.Big);
            buffer.WriteInt32(RoleName.Length + 1, Endianness.Big);
            buffer.WriteCString(RoleName);
            buffer.WriteUInt32(LeftTime, Endianness.Big);
            buffer.WriteUInt32(Money, Endianness.Big);
            buffer.WriteUInt32(Credit, Endianness.Big);
            buffer.WriteUInt32(RecordTime, Endianness.Big);
            buffer.WriteUInt64(BidDBId, Endianness.Big);
            buffer.WriteInt32(BidRoleName.Length + 1, Endianness.Big);
            buffer.WriteCString(BidRoleName);
            buffer.WriteUInt32(BidLevel, Endianness.Big);
        }

    }
}
