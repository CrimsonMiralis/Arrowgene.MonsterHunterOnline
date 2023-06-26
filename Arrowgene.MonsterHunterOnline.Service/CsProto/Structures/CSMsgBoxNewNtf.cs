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
    /// 通知客户端新建msg
    /// </summary>
    public class CSMsgBoxNewNtf : IStructure
    {

        public CSMsgBoxNewNtf()
        {
            MsgBoxId = 0;
            MsgBoxModule = 0;
            MsgBoxType = 0;
            MsgPramList = new List<CSMsgParam>();
        }

        /// <summary>
        /// 实例ID
        /// </summary>
        public uint MsgBoxId;

        /// <summary>
        /// 所属逻辑模块,CS_MSGBOX_TYPE
        /// </summary>
        public byte MsgBoxModule;

        /// <summary>
        /// msgbox MessageList.xlsx配置项
        /// </summary>
        public uint MsgBoxType;

        /// <summary>
        /// 参数列表
        /// </summary>
        public List<CSMsgParam> MsgPramList;

        public void Write(IBuffer buffer)
        {
            buffer.WriteUInt32(MsgBoxId, Endianness.Big);
            buffer.WriteByte(MsgBoxModule);
            buffer.WriteUInt32(MsgBoxType, Endianness.Big);
            byte msgPramListCount = (byte)MsgPramList.Count;
            buffer.WriteByte(msgPramListCount);
            for (int i = 0; i < msgPramListCount; i++)
            {
                MsgPramList[i].Write(buffer);
            }
        }

    }
}
