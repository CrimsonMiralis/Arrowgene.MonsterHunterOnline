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
    /// PVP玩家分数改变通知
    /// </summary>
    public class CSPVPPlayerScoreNtf : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSPVPPlayerScoreNtf));

        public CSPVPPlayerScoreNtf()
        {
            NetId = 0;
            CampType = 0;
            AddScore = 0;
            CatCar = 0;
        }

        /// <summary>
        /// 玩家的NETID
        /// </summary>
        public int NetId;

        /// <summary>
        /// 阵营
        /// </summary>
        public int CampType;

        /// <summary>
        /// 分数
        /// </summary>
        public int AddScore;

        /// <summary>
        /// 猫车次数
        /// </summary>
        public int CatCar;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteInt32(NetId, Endianness.Big);
            buffer.WriteInt32(CampType, Endianness.Big);
            buffer.WriteInt32(AddScore, Endianness.Big);
            buffer.WriteInt32(CatCar, Endianness.Big);
        }

        public void ReadCs(IBuffer buffer)
        {
            NetId = buffer.ReadInt32(Endianness.Big);
            CampType = buffer.ReadInt32(Endianness.Big);
            AddScore = buffer.ReadInt32(Endianness.Big);
            CatCar = buffer.ReadInt32(Endianness.Big);
        }

    }
}
