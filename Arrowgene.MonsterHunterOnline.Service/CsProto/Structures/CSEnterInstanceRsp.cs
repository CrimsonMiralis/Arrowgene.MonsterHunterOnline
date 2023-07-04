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
    /// 进入战斗副本响应
    /// </summary>
    public class CSEnterInstanceRsp : IStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSEnterInstanceRsp));

        public CSEnterInstanceRsp()
        {
            ErrNo = 0;
            RoleId = 0;
            InstanceID = 0;
            BattleSvr = "";
            ServiceID = 0;
            Key = "";
            InstanceInfo = new CSInstanceInitInfo();
            SameBS = 0;
            CrossRegion = 0;
            MatchRoom = 0;
        }

        /// <summary>
        /// 响应码, 0为成功
        /// </summary>
        public int ErrNo;

        /// <summary>
        /// 角色Id
        /// </summary>
        public int RoleId;

        /// <summary>
        /// 副本实例ID
        /// </summary>
        public int InstanceID;

        /// <summary>
        /// BattleSvr连接URL
        /// </summary>
        public string BattleSvr;

        /// <summary>
        /// Battlesvr的serviceID
        /// </summary>
        public int ServiceID;

        /// <summary>
        /// 验证码
        /// </summary>
        public string Key;

        public CSInstanceInitInfo InstanceInfo;

        /// <summary>
        /// 是否切换BS
        /// </summary>
        public byte SameBS;

        /// <summary>
        /// 是否跨区
        /// </summary>
        public byte CrossRegion;

        /// <summary>
        /// 是否匹配
        /// </summary>
        public byte MatchRoom;

        public void Write(IBuffer buffer)
        {
            buffer.WriteInt32(ErrNo, Endianness.Big);
            buffer.WriteInt32(RoleId, Endianness.Big);
            buffer.WriteInt32(InstanceID, Endianness.Big);
            buffer.WriteInt32(BattleSvr.Length + 1, Endianness.Big);
            buffer.WriteCString(BattleSvr);
            buffer.WriteInt32(ServiceID, Endianness.Big);
            buffer.WriteInt32(Key.Length + 1, Endianness.Big);
            buffer.WriteCString(Key);
            InstanceInfo.Write(buffer);
            buffer.WriteByte(SameBS);
            buffer.WriteByte(CrossRegion);
            buffer.WriteByte(MatchRoom);
        }

        public void Read(IBuffer buffer)
        {
            ErrNo = buffer.ReadInt32(Endianness.Big);
            RoleId = buffer.ReadInt32(Endianness.Big);
            InstanceID = buffer.ReadInt32(Endianness.Big);
            int BattleSvrEntryLen = buffer.ReadInt32(Endianness.Big);
            BattleSvr = buffer.ReadString(BattleSvrEntryLen);
            ServiceID = buffer.ReadInt32(Endianness.Big);
            int KeyEntryLen = buffer.ReadInt32(Endianness.Big);
            Key = buffer.ReadString(KeyEntryLen);
            InstanceInfo.Read(buffer);
            SameBS = buffer.ReadByte();
            CrossRegion = buffer.ReadByte();
            MatchRoom = buffer.ReadByte();
        }

    }
}