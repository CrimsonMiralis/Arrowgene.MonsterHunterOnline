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
    /// 客户端本地副本响应
    /// </summary>
    public class CSLocalBatOPRsp : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSLocalBatOPRsp));

        public CSLocalBatOPRsp()
        {
            Op = new CSLocalBatOPReq();
            Result = 0;
            ResultParam1 = 0;
            ResultParam2 = 0;
            ResultParam3 = 0;
            ResultParam4 = 0;
            ResultParamStr = "";
        }

        /// <summary>
        /// op
        /// </summary>
        public CSLocalBatOPReq Op;

        /// <summary>
        /// result
        /// </summary>
        public int Result;

        /// <summary>
        /// result
        /// </summary>
        public int ResultParam1;

        /// <summary>
        /// result
        /// </summary>
        public int ResultParam2;

        /// <summary>
        /// result
        /// </summary>
        public int ResultParam3;

        /// <summary>
        /// result
        /// </summary>
        public int ResultParam4;

        public string ResultParamStr;

        public void WriteCs(IBuffer buffer)
        {
            Op.WriteCs(buffer);
            buffer.WriteInt32(Result, Endianness.Big);
            buffer.WriteInt32(ResultParam1, Endianness.Big);
            buffer.WriteInt32(ResultParam2, Endianness.Big);
            buffer.WriteInt32(ResultParam3, Endianness.Big);
            buffer.WriteInt32(ResultParam4, Endianness.Big);
            buffer.WriteInt32(ResultParamStr.Length + 1, Endianness.Big);
            buffer.WriteCString(ResultParamStr);
        }

        public void ReadCs(IBuffer buffer)
        {
            Op.ReadCs(buffer);
            Result = buffer.ReadInt32(Endianness.Big);
            ResultParam1 = buffer.ReadInt32(Endianness.Big);
            ResultParam2 = buffer.ReadInt32(Endianness.Big);
            ResultParam3 = buffer.ReadInt32(Endianness.Big);
            ResultParam4 = buffer.ReadInt32(Endianness.Big);
            int ResultParamStrEntryLen = buffer.ReadInt32(Endianness.Big);
            ResultParamStr = buffer.ReadString(ResultParamStrEntryLen);
        }

    }
}
