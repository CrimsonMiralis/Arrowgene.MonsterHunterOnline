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
    /// GameObjectEvent网络发送的格式
    /// </summary>
    public class CSBattleGameObjEevnt : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSBattleGameObjEevnt));

        public CSBattleGameObjEevnt()
        {
            NetObjId = 0;
            Event = 0;
            Target = 0;
            Flags = 0;
            PtrSize = 0;
            ParamSize = 0;
            Param1Size = 0;
            Data = new List<byte>();
        }

        /// <summary>
        /// 发送消息的Actor的NetObjId
        /// </summary>
        public uint NetObjId;

        public uint Event;

        public ushort Target;

        public ushort Flags;

        /// <summary>
        /// 原SGameObjectEvent中Ptr指向内容的大小
        /// </summary>
        public int PtrSize;

        /// <summary>
        /// 原SGameObjectEvent中Param指向内容的大小
        /// </summary>
        public int ParamSize;

        /// <summary>
        /// 原SGameObjectEvent中Param1指向内容的大小
        /// </summary>
        public int Param1Size;

        /// <summary>
        /// 3个指针指向内容的buffer
        /// </summary>
        public List<byte> Data;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteUInt32(NetObjId, Endianness.Big);
            buffer.WriteUInt32(Event, Endianness.Big);
            buffer.WriteUInt16(Target, Endianness.Big);
            buffer.WriteUInt16(Flags, Endianness.Big);
            buffer.WriteInt32(PtrSize, Endianness.Big);
            buffer.WriteInt32(ParamSize, Endianness.Big);
            buffer.WriteInt32(Param1Size, Endianness.Big);
            int dataCount = (int)Data.Count;
            buffer.WriteInt32(dataCount, Endianness.Big);
            for (int i = 0; i < dataCount; i++)
            {
                buffer.WriteByte(Data[i]);
            }
        }

        public void ReadCs(IBuffer buffer)
        {
            NetObjId = buffer.ReadUInt32(Endianness.Big);
            Event = buffer.ReadUInt32(Endianness.Big);
            Target = buffer.ReadUInt16(Endianness.Big);
            Flags = buffer.ReadUInt16(Endianness.Big);
            PtrSize = buffer.ReadInt32(Endianness.Big);
            ParamSize = buffer.ReadInt32(Endianness.Big);
            Param1Size = buffer.ReadInt32(Endianness.Big);
            Data.Clear();
            int dataCount = buffer.ReadInt32(Endianness.Big);
            for (int i = 0; i < dataCount; i++)
            {
                byte DataEntry = buffer.ReadByte();
                Data.Add(DataEntry);
            }
        }

    }
}
