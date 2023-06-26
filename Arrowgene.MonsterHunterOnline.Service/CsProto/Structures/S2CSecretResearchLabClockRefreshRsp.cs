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
    /// 机密研究院定时刷新 服务端->客户端
    /// </summary>
    public class S2CSecretResearchLabClockRefreshRsp : IStructure
    {

        public S2CSecretResearchLabClockRefreshRsp()
        {
            LotteryItemList = new LotteryItemType[CsProtoConstant.SECRET_RESEARCH_LAB_LOTTERY_ITEM_MAX_LEN];
            for (int i = 0; i < CsProtoConstant.SECRET_RESEARCH_LAB_LOTTERY_ITEM_MAX_LEN; i++)
            {
                LotteryItemList[i] = new LotteryItemType();
            }
            BoxId = 0;
        }

        /// <summary>
        /// 奖励槽信息
        /// </summary>
        public LotteryItemType[] LotteryItemList;

        /// <summary>
        /// 盒子ID
        /// </summary>
        public int BoxId;

        public void Write(IBuffer buffer)
        {
            for (int i = 0; i < CsProtoConstant.SECRET_RESEARCH_LAB_LOTTERY_ITEM_MAX_LEN; i++)
            {
                LotteryItemList[i].Write(buffer);
            }
            buffer.WriteInt32(BoxId, Endianness.Big);
        }

    }
}
