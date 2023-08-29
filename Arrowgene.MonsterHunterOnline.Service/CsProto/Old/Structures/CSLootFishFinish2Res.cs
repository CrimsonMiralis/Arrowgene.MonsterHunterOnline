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
    /// 钓鱼结束回复
    /// </summary>
    public class CSLootFishFinish2Res : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSLootFishFinish2Res));

        public CSLootFishFinish2Res()
        {
            LogicEntityId = 0;
            Ret = 0;
            ItemError = 0;
            PlayerId = 0;
            FishId = 0;
            RemainingFishCount = 0;
        }

        /// <summary>
        /// 资源点ID
        /// </summary>
        public uint LogicEntityId;

        /// <summary>
        /// 结果
        /// </summary>
        public int Ret;

        /// <summary>
        /// 道具错误
        /// </summary>
        public int ItemError;

        /// <summary>
        /// 玩家ID
        /// </summary>
        public uint PlayerId;

        /// <summary>
        /// 掉到鱼ID
        /// </summary>
        public uint FishId;

        /// <summary>
        /// 剩余鱼数量
        /// </summary>
        public int RemainingFishCount;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteUInt32(LogicEntityId, Endianness.Big);
            buffer.WriteInt32(Ret, Endianness.Big);
            buffer.WriteInt32(ItemError, Endianness.Big);
            buffer.WriteUInt32(PlayerId, Endianness.Big);
            buffer.WriteUInt32(FishId, Endianness.Big);
            buffer.WriteInt32(RemainingFishCount, Endianness.Big);
        }

        public void ReadCs(IBuffer buffer)
        {
            LogicEntityId = buffer.ReadUInt32(Endianness.Big);
            Ret = buffer.ReadInt32(Endianness.Big);
            ItemError = buffer.ReadInt32(Endianness.Big);
            PlayerId = buffer.ReadUInt32(Endianness.Big);
            FishId = buffer.ReadUInt32(Endianness.Big);
            RemainingFishCount = buffer.ReadInt32(Endianness.Big);
        }

    }
}
