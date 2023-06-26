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

    public class MailAccDataItem : CsAccessoryDataUnion
    {

        public MailAccDataItem()
        {
            ItemId = 0;
            ItemType = 0;
            ItemCount = 0;
            BindType = 0;
            Buffer = new List<byte>();
        }

        public EMailAccessoryType Type => EMailAccessoryType.EMailAccessoryType_Item;

        /// <summary>
        /// 道具实例ID
        /// </summary>
        public ulong ItemId;

        /// <summary>
        /// 附件道具类型ID
        /// </summary>
        public uint ItemType;

        /// <summary>
        /// 附件数量
        /// </summary>
        public uint ItemCount;

        /// <summary>
        /// 附件道具绑定类型
        /// </summary>
        public byte BindType;

        /// <summary>
        /// 道具序列化数据
        /// </summary>
        public List<byte> Buffer;

        public void Write(IBuffer buffer)
        {
            buffer.WriteUInt64(ItemId, Endianness.Big);
            buffer.WriteUInt32(ItemType, Endianness.Big);
            buffer.WriteUInt32(ItemCount, Endianness.Big);
            buffer.WriteByte(BindType);
            int bufferCount = (int)Buffer.Count;
            buffer.WriteInt32(bufferCount, Endianness.Big);
            for (int i = 0; i < bufferCount; i++)
            {
                buffer.WriteByte(Buffer[i]);
            }
        }

    }
}
