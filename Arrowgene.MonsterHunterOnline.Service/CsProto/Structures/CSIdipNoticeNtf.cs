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
    /// 滚动公告IDIP
    /// </summary>
    public class CSIdipNoticeNtf : IStructure
    {

        public CSIdipNoticeNtf()
        {
            NoticeType = 0;
            RollCnt = 0;
            RollSpeed = 0;
            PreLevel = 0;
            sContent = "";
        }

        /// <summary>
        /// 广播类型
        /// </summary>
        public byte NoticeType;

        /// <summary>
        /// 滚动次数
        /// </summary>
        public int RollCnt;

        /// <summary>
        /// 滚动速度
        /// </summary>
        public byte RollSpeed;

        /// <summary>
        /// 优先等级
        /// </summary>
        public byte PreLevel;

        /// <summary>
        /// idip推送公告
        /// </summary>
        public string sContent;

        public void Write(IBuffer buffer)
        {
            buffer.WriteByte(NoticeType);
            buffer.WriteInt32(RollCnt, Endianness.Big);
            buffer.WriteByte(RollSpeed);
            buffer.WriteByte(PreLevel);
            buffer.WriteInt32(sContent.Length + 1, Endianness.Big);
            buffer.WriteCString(sContent);
        }

    }
}
