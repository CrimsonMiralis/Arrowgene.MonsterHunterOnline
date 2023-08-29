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
using Arrowgene.Logging;
using Arrowgene.MonsterHunterOnline.Service.CsProto.Core;
using Arrowgene.MonsterHunterOnline.Service.CsProto.Enums;

namespace Arrowgene.MonsterHunterOnline.Service.CsProto.Structures
{

    /// <summary>
    /// 战斗动画出队消息
    /// </summary>
    public class CSBattleRemoveAnim : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSBattleRemoveAnim));

        public CSBattleRemoveAnim()
        {
            NetObjId = 0;
            Layer = 0;
            Token = 0;
        }

        /// <summary>
        /// 需要执行该动画的Actor的NetObjId
        /// </summary>
        public uint NetObjId;

        /// <summary>
        /// 需要执行的动画
        /// </summary>
        public int Layer;

        public uint Token;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteUInt32(NetObjId, Endianness.Big);
            buffer.WriteInt32(Layer, Endianness.Big);
            buffer.WriteUInt32(Token, Endianness.Big);
        }

        public void ReadCs(IBuffer buffer)
        {
            NetObjId = buffer.ReadUInt32(Endianness.Big);
            Layer = buffer.ReadInt32(Endianness.Big);
            Token = buffer.ReadUInt32(Endianness.Big);
        }

    }
}
