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
using Arrowgene.MonsterHunterOnline.Service.CsProto.Core;
using Arrowgene.MonsterHunterOnline.Service.CsProto.Enums;

namespace Arrowgene.MonsterHunterOnline.Service.CsProto.Structures
{

    /// <summary>
    /// monster appear notify
    /// </summary>
    public class CSMonsterAppearNtf : IStructure
    {

        public CSMonsterAppearNtf()
        {
            NetID = 0;
            SpawnType = 0;
            MonsterInfoID = 0;
            EntGUID = 0;
            Name = "";
            Class = "";
            Pose = new CSQuatT();
            Faction = 0;
            BTState = "";
            BBVars = new CSBBVarList();
            Dead = 0;
            LcmState = new CSMonsterLocomotion();
            AttrInit = new List<CSAttrData>();
            ProjIds = new List<CSAmmoInfo>();
            Buff = new List<byte>();
            ParentGUID = 0;
            LastChildID = 0;
        }

        /// <summary>
        /// logic entity id
        /// </summary>
        public int NetID;

        /// <summary>
        /// SpawnType
        /// </summary>
        public short SpawnType;

        /// <summary>
        /// monster static data id
        /// </summary>
        public int MonsterInfoID;

        /// <summary>
        /// entity guid
        /// </summary>
        public ulong EntGUID;

        /// <summary>
        /// monster name
        /// </summary>
        public string Name;

        /// <summary>
        /// monster class
        /// </summary>
        public string Class;

        /// <summary>
        /// Appear location
        /// </summary>
        public CSQuatT Pose;

        /// <summary>
        /// 阵营
        /// </summary>
        public int Faction;

        /// <summary>
        /// BT state
        /// </summary>
        public string BTState;

        /// <summary>
        /// Blackboard vars
        /// </summary>
        public CSBBVarList BBVars;

        /// <summary>
        /// is dead
        /// </summary>
        public byte Dead;

        /// <summary>
        /// Locomotion state
        /// </summary>
        public CSMonsterLocomotion LcmState;

        public List<CSAttrData> AttrInit;

        public List<CSAmmoInfo> ProjIds;

        /// <summary>
        /// buff数据
        /// </summary>
        public List<byte> Buff;

        /// <summary>
        /// cry parent entity guid
        /// </summary>
        public ulong ParentGUID;

        /// <summary>
        /// last child logic entity id
        /// </summary>
        public int LastChildID;

        public void Write(IBuffer buffer)
        {
            buffer.WriteInt32(NetID, Endianness.Big);
            buffer.WriteInt16(SpawnType, Endianness.Big);
            buffer.WriteInt32(MonsterInfoID, Endianness.Big);
            buffer.WriteUInt64(EntGUID, Endianness.Big);
            buffer.WriteInt32(Name.Length + 1, Endianness.Big);
            buffer.WriteCString(Name);
            buffer.WriteInt32(Class.Length + 1, Endianness.Big);
            buffer.WriteCString(Class);
            Pose.Write(buffer);
            buffer.WriteInt32(Faction, Endianness.Big);
            buffer.WriteInt32(BTState.Length + 1, Endianness.Big);
            buffer.WriteCString(BTState);
            BBVars.Write(buffer);
            buffer.WriteByte(Dead);
            LcmState.Write(buffer);
            short attrInitCount = (short)AttrInit.Count;
            buffer.WriteInt16(attrInitCount, Endianness.Big);
            for (int i = 0; i < attrInitCount; i++)
            {
                AttrInit[i].Write(buffer);
            }
            int projIdsCount = (int)ProjIds.Count;
            buffer.WriteInt32(projIdsCount, Endianness.Big);
            for (int i = 0; i < projIdsCount; i++)
            {
                ProjIds[i].Write(buffer);
            }
            short buffCount = (short)Buff.Count;
            buffer.WriteInt16(buffCount, Endianness.Big);
            for (int i = 0; i < buffCount; i++)
            {
                buffer.WriteByte(Buff[i]);
            }
            buffer.WriteUInt64(ParentGUID, Endianness.Big);
            buffer.WriteInt32(LastChildID, Endianness.Big);
        }

    }
}
