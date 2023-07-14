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
    /// 根据配方进行生产的请求
    /// </summary>
    public class CSManufactureProduceReq : IStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSManufactureProduceReq));

        public CSManufactureProduceReq()
        {
            ManufactureId = 0;
            ItemPlaceMent = 0;
            BindFlag = 0;
        }

        /// <summary>
        /// 配方ID
        /// </summary>
        public int ManufactureId;

        /// <summary>
        /// 物品生产放置位置1表示包包，2表示仓库
        /// </summary>
        public int ItemPlaceMent;

        /// <summary>
        /// 是否绑定
        /// </summary>
        public int BindFlag;

        public void Write(IBuffer buffer)
        {
            buffer.WriteInt32(ManufactureId, Endianness.Big);
            buffer.WriteInt32(ItemPlaceMent, Endianness.Big);
            buffer.WriteInt32(BindFlag, Endianness.Big);
        }

        public void Read(IBuffer buffer)
        {
            ManufactureId = buffer.ReadInt32(Endianness.Big);
            ItemPlaceMent = buffer.ReadInt32(Endianness.Big);
            BindFlag = buffer.ReadInt32(Endianness.Big);
        }

    }
}