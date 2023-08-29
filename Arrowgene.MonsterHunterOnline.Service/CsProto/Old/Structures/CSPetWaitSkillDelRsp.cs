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
    /// 宠物删除等待装备技能应答
    /// </summary>
    public class CSPetWaitSkillDelRsp : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSPetWaitSkillDelRsp));

        public CSPetWaitSkillDelRsp()
        {
            Result = 0;
            Idx = 0;
            UID = 0;
            Skill = 0;
        }

        /// <summary>
        /// 结果
        /// </summary>
        public int Result;

        /// <summary>
        /// pet index
        /// </summary>
        public int Idx;

        /// <summary>
        /// pet UID
        /// </summary>
        public int UID;

        /// <summary>
        /// skill id
        /// </summary>
        public int Skill;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteInt32(Result, Endianness.Big);
            buffer.WriteInt32(Idx, Endianness.Big);
            buffer.WriteInt32(UID, Endianness.Big);
            buffer.WriteInt32(Skill, Endianness.Big);
        }

        public void ReadCs(IBuffer buffer)
        {
            Result = buffer.ReadInt32(Endianness.Big);
            Idx = buffer.ReadInt32(Endianness.Big);
            UID = buffer.ReadInt32(Endianness.Big);
            Skill = buffer.ReadInt32(Endianness.Big);
        }

    }
}
