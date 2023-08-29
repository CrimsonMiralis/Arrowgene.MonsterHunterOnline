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
    /// 请求交互
    /// </summary>
    public class CSInteractRequest : CSPlayerExtRequestData
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSInteractRequest));

        public CSInteractRequest(CSInteractRequestData _Request)
        {
            Request = _Request;
        }

        public CS_PLAYER_EXT_TYPE ExtType => CS_PLAYER_EXT_TYPE.CS_PLAYER_EXT_INTERACT;

        /// <summary>
        /// 交互请求类型
        /// </summary>

        /// <summary>
        /// 请求数据
        /// </summary>
        public CSInteractRequestData Request;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteInt32((int)Request.RequestType, Endianness.Big);
            Request.WriteCs(buffer);
        }

        public void ReadCs(IBuffer buffer)
        {
            INTERACT_REQUEST_TYPE CSInteractRequestData_RequestType = (INTERACT_REQUEST_TYPE)buffer.ReadInt32(Endianness.Big);
            switch (CSInteractRequestData_RequestType)
            {
                case INTERACT_REQUEST_TYPE.INTERACT_REQUEST_TYPE_BEGIN:
                    Request = new CSInteractRequestBegin();
                    break;
                case INTERACT_REQUEST_TYPE.INTERACT_REQUEST_TYPE_END:
                    Request = new CSInteractRequestEnd();
                    break;
            }
            if (Request != null) {
                Request.ReadCs(buffer);
            }
            else {
                Logger.Error("Failed to create 'Request' instance of type 'CSInteractRequestData'");
            }
        }

    }
}
