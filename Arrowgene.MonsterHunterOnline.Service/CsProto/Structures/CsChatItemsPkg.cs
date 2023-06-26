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
    /// 聊天发送的道具信息
    /// </summary>
    public class CsChatItemsPkg : IStructure
    {

        public CsChatItemsPkg()
        {
            Items = new List<byte>();
            SoulStoneArray = new List<int>();
        }

        /// <summary>
        /// 聊天道具数据
        /// </summary>
        public List<byte> Items;

        /// <summary>
        /// 狩魂石属性数据
        /// </summary>
        public List<int> SoulStoneArray;

        public void Write(IBuffer buffer)
        {
            int itemsCount = (int)Items.Count;
            buffer.WriteInt32(itemsCount, Endianness.Big);
            for (int i = 0; i < itemsCount; i++)
            {
                buffer.WriteByte(Items[i]);
            }
            int soulStoneArrayCount = (int)SoulStoneArray.Count;
            buffer.WriteInt32(soulStoneArrayCount, Endianness.Big);
            for (int i = 0; i < soulStoneArrayCount; i++)
            {
                buffer.WriteInt32(SoulStoneArray[i], Endianness.Big);
            }
        }

    }
}
