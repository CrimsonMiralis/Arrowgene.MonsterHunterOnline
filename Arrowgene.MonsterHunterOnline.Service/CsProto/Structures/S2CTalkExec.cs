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
    /// 对话执行
    /// </summary>
    public class S2CTalkExec : IStructure
    {

        public S2CTalkExec()
        {
            Npc = 0;
            Type = 0;
            Talk = 0;
            Round = 0;
            Proc = 0;
        }

        /// <summary>
        /// Npc
        /// </summary>
        public uint Npc;

        /// <summary>
        /// 对话-类型
        /// </summary>
        public int Type;

        /// <summary>
        /// 对话-标识
        /// </summary>
        public int Talk;

        /// <summary>
        /// Round
        /// </summary>
        public int Round;

        /// <summary>
        /// 操作
        /// </summary>
        public int Proc;

        public void Write(IBuffer buffer)
        {
            buffer.WriteUInt32(Npc, Endianness.Big);
            buffer.WriteInt32(Type, Endianness.Big);
            buffer.WriteInt32(Talk, Endianness.Big);
            buffer.WriteInt32(Round, Endianness.Big);
            buffer.WriteInt32(Proc, Endianness.Big);
        }

    }
}
