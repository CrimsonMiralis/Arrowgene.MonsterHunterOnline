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
    /// 开通VIP成长助力请求
    /// </summary>
    public class CSVIPOpenGrowthReq : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSVIPOpenGrowthReq));

        public CSVIPOpenGrowthReq()
        {
            OpenType = 0;
            OpenPeriod = 0;
        }

        /// <summary>
        /// 开通类型
        /// </summary>
        public int OpenType;

        /// <summary>
        /// 开通时长
        /// </summary>
        public int OpenPeriod;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteInt32(OpenType, Endianness.Big);
            buffer.WriteInt32(OpenPeriod, Endianness.Big);
        }

        public void ReadCs(IBuffer buffer)
        {
            OpenType = buffer.ReadInt32(Endianness.Big);
            OpenPeriod = buffer.ReadInt32(Endianness.Big);
        }

    }
}
