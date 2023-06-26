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
    /// 玩家弩车开火
    /// </summary>
    public class CSPlayerVehicleFire : IStructure
    {

        public CSPlayerVehicleFire()
        {
            AmmoItemID = 0;
            AmmoType = 0;
            AmmoItemNum = 0;
            FireType = 0;
        }

        /// <summary>
        /// 弩车子弹道具ID
        /// </summary>
        public int AmmoItemID;

        /// <summary>
        /// 子弹ID
        /// </summary>
        public int AmmoType;

        /// <summary>
        /// 消耗弩车子弹道具数量
        /// </summary>
        public byte AmmoItemNum;

        /// <summary>
        /// 射击类型，0道具主炮 1道具副炮 2Buff子弹主炮
        /// </summary>
        public byte FireType;

        public void Write(IBuffer buffer)
        {
            buffer.WriteInt32(AmmoItemID, Endianness.Big);
            buffer.WriteInt32(AmmoType, Endianness.Big);
            buffer.WriteByte(AmmoItemNum);
            buffer.WriteByte(FireType);
        }

    }
}
