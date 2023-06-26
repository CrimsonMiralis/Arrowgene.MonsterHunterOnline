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

    public class CSBSMRoomUIPlayerInfo : IStructure
    {

        public CSBSMRoomUIPlayerInfo()
        {
            RoleIndex = 0;
            CharLevel = 0;
            Weapon = 0;
            BoxID = 0;
            RoleName = "";
            StarLevel = "";
            Faction = 0;
            Officer = 0;
            HRLevel = 0;
            BigRand = 0;
        }

        /// <summary>
        /// 角色Index
        /// </summary>
        public uint RoleIndex;

        public int CharLevel;

        public int Weapon;

        /// <summary>
        /// 狩猎包ID
        /// </summary>
        public int BoxID;

        public string RoleName;

        /// <summary>
        /// 星级
        /// </summary>
        public string StarLevel;

        /// <summary>
        /// 阵营
        /// </summary>
        public int Faction;

        /// <summary>
        /// 是否教官
        /// </summary>
        public byte Officer;

        /// <summary>
        /// HRLevel
        /// </summary>
        public int HRLevel;

        /// <summary>
        /// 是否大随机玩家
        /// </summary>
        public byte BigRand;

        public void Write(IBuffer buffer)
        {
            buffer.WriteUInt32(RoleIndex, Endianness.Big);
            buffer.WriteInt32(CharLevel, Endianness.Big);
            buffer.WriteInt32(Weapon, Endianness.Big);
            buffer.WriteInt32(BoxID, Endianness.Big);
            buffer.WriteInt32(RoleName.Length + 1, Endianness.Big);
            buffer.WriteCString(RoleName);
            buffer.WriteInt32(StarLevel.Length + 1, Endianness.Big);
            buffer.WriteCString(StarLevel);
            buffer.WriteInt32(Faction, Endianness.Big);
            buffer.WriteByte(Officer);
            buffer.WriteInt32(HRLevel, Endianness.Big);
            buffer.WriteByte(BigRand);
        }

    }
}
