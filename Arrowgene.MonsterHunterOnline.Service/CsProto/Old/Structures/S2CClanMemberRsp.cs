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
    /// 返回战队成员列表
    /// </summary>
    public class S2CClanMemberRsp : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(S2CClanMemberRsp));

        public S2CClanMemberRsp()
        {
            ClanerNames = new List<ClanerNameInfo>();
        }

        public List<ClanerNameInfo> ClanerNames;

        public void WriteCs(IBuffer buffer)
        {
            int clanerNamesCount = (int)ClanerNames.Count;
            buffer.WriteInt32(clanerNamesCount, Endianness.Big);
            for (int i = 0; i < clanerNamesCount; i++)
            {
                ClanerNames[i].WriteCs(buffer);
            }
        }

        public void ReadCs(IBuffer buffer)
        {
            ClanerNames.Clear();
            int clanerNamesCount = buffer.ReadInt32(Endianness.Big);
            for (int i = 0; i < clanerNamesCount; i++)
            {
                ClanerNameInfo ClanerNamesEntry = new ClanerNameInfo();
                ClanerNamesEntry.ReadCs(buffer);
                ClanerNames.Add(ClanerNamesEntry);
            }
        }

    }
}
