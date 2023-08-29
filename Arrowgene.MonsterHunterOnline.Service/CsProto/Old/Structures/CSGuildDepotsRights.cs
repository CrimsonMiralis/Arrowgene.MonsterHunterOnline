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
    /// 猎团头衔仓库权限
    /// </summary>
    public class CSGuildDepotsRights : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSGuildDepotsRights));

        public CSGuildDepotsRights()
        {
            DepotsRights = new List<CSGuildDepotRights>();
        }

        /// <summary>
        /// 仓库权限集
        /// </summary>
        public List<CSGuildDepotRights> DepotsRights;

        public void WriteCs(IBuffer buffer)
        {
            int depotsRightsCount = (int)DepotsRights.Count;
            buffer.WriteInt32(depotsRightsCount, Endianness.Big);
            for (int i = 0; i < depotsRightsCount; i++)
            {
                DepotsRights[i].WriteCs(buffer);
            }
        }

        public void ReadCs(IBuffer buffer)
        {
            DepotsRights.Clear();
            int depotsRightsCount = buffer.ReadInt32(Endianness.Big);
            for (int i = 0; i < depotsRightsCount; i++)
            {
                CSGuildDepotRights DepotsRightsEntry = new CSGuildDepotRights();
                DepotsRightsEntry.ReadCs(buffer);
                DepotsRights.Add(DepotsRightsEntry);
            }
        }

    }
}
