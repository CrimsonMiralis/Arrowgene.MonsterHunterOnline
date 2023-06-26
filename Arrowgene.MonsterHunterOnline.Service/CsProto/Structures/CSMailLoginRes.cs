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

    public class CSMailLoginRes : IStructure
    {

        public CSMailLoginRes()
        {
            mailType = 0;
            mailRemind = 0;
            mailRemindCount = 0;
        }

        /// <summary>
        /// 邮件类型
        /// </summary>
        public byte mailType;

        /// <summary>
        /// 0：没有未读邮件 1：有未读邮件
        /// </summary>
        public byte mailRemind;

        /// <summary>
        /// -1：此字段无意义 非负：未读邮件总数
        /// </summary>
        public int mailRemindCount;

        public void Write(IBuffer buffer)
        {
            buffer.WriteByte(mailType);
            buffer.WriteByte(mailRemind);
            buffer.WriteInt32(mailRemindCount, Endianness.Big);
        }

    }
}
