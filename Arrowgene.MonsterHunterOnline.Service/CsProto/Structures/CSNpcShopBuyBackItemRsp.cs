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
    /// 回购物品的返回
    /// </summary>
    public class CSNpcShopBuyBackItemRsp : IStructure
    {

        public CSNpcShopBuyBackItemRsp()
        {
            Ret = 0;
            Index = 0;
            ItemType = 0;
            ItemCount = 0;
        }

        /// <summary>
        /// 返回值，0为成功
        /// </summary>
        public int Ret;

        /// <summary>
        /// 回购列表位置
        /// </summary>
        public int Index;

        /// <summary>
        /// 回购的物品类型
        /// </summary>
        public int ItemType;

        /// <summary>
        /// 回购的物品数量
        /// </summary>
        public int ItemCount;

        public void Write(IBuffer buffer)
        {
            buffer.WriteInt32(Ret, Endianness.Big);
            buffer.WriteInt32(Index, Endianness.Big);
            buffer.WriteInt32(ItemType, Endianness.Big);
            buffer.WriteInt32(ItemCount, Endianness.Big);
        }

    }
}
