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
    /// 发送给客户端的聊天请求错误返回
    /// </summary>
    public class CSChatRsp : IStructure
    {

        public CSChatRsp()
        {
            Ret = 0;
            TargetName = "";
            ChannelType = 0;
        }

        /// <summary>
        /// 错误返回码
        /// </summary>
        public int Ret;

        /// <summary>
        /// 目的玩家角色名字
        /// </summary>
        public string TargetName;

        /// <summary>
        /// 频道类型ID
        /// </summary>
        public int ChannelType;

        public void Write(IBuffer buffer)
        {
            buffer.WriteInt32(Ret, Endianness.Big);
            buffer.WriteInt32(TargetName.Length + 1, Endianness.Big);
            buffer.WriteCString(TargetName);
            buffer.WriteInt32(ChannelType, Endianness.Big);
        }

    }
}
