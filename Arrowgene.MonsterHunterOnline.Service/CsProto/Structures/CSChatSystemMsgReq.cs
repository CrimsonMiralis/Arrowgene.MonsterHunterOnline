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
    /// 系统提示请求
    /// </summary>
    public class CSChatSystemMsgReq : IStructure
    {

        public CSChatSystemMsgReq()
        {
            MsgType = 0;
            MsgArea = 0;
            Dbid = 0;
            MsgPramList = new List<CSMsgParam>();
        }

        /// <summary>
        /// MessageList.xlsx配置项
        /// </summary>
        public uint MsgType;

        /// <summary>
        /// 通知区域（个人/全服/...）
        /// </summary>
        public uint MsgArea;

        /// <summary>
        /// 玩家dbid
        /// </summary>
        public ulong Dbid;

        /// <summary>
        /// 参数数量
        /// </summary>
        public byte MsgParamNum => (byte)MsgPramList.Count;

        /// <summary>
        /// 参数列表
        /// </summary>
        public List<CSMsgParam> MsgPramList;

        public void Write(IBuffer buffer)
        {
            buffer.WriteUInt32(MsgType, Endianness.Big);
            buffer.WriteUInt32(MsgArea, Endianness.Big);
            buffer.WriteUInt64(Dbid, Endianness.Big);
            buffer.WriteByte(MsgParamNum);
            for (int i = 0; i < MsgParamNum; i++)
            {
                MsgPramList[i].Write(buffer);
            }
        }

    }
}
