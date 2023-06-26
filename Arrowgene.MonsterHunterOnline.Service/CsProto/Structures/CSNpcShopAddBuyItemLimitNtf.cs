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
    /// 物品购买限制数据添加
    /// </summary>
    public class CSNpcShopAddBuyItemLimitNtf : IStructure
    {

        public CSNpcShopAddBuyItemLimitNtf()
        {
            FromConfigType = 0;
            LimitType = 0;
            ItemID = 0;
            ItemCount = 0;
            LastBuyTm = 0;
        }

        /// <summary>
        /// 配置类型
        /// </summary>
        public int FromConfigType;

        /// <summary>
        /// 限制类型
        /// </summary>
        public int LimitType;

        /// <summary>
        /// 购买的物品数量
        /// </summary>
        public int ItemID;

        /// <summary>
        /// 购买的物品数量
        /// </summary>
        public int ItemCount;

        /// <summary>
        /// 最后一次购买时间
        /// </summary>
        public int LastBuyTm;

        public void Write(IBuffer buffer)
        {
            buffer.WriteInt32(FromConfigType, Endianness.Big);
            buffer.WriteInt32(LimitType, Endianness.Big);
            buffer.WriteInt32(ItemID, Endianness.Big);
            buffer.WriteInt32(ItemCount, Endianness.Big);
            buffer.WriteInt32(LastBuyTm, Endianness.Big);
        }

    }
}
