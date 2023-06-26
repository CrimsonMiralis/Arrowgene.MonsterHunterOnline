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
    /// 队伍设置,需要与ss消息SSTeamSetting保持完全一致！！
    /// </summary>
    public class CSTeamSetting : IStructure
    {

        public CSTeamSetting()
        {
            TeamName = "";
            Mode = 0;
            Map = 0;
            LevelGrp = 0;
            Difficulty = 0;
            MemberMax = 0;
            FreeJoin = 0;
            OpenRecruit = 0;
            Pwd = "";
            auth = 0;
            MinLevel = 0;
            MaxLevel = 0;
        }

        /// <summary>
        /// 队伍名
        /// </summary>
        public string TeamName;

        /// <summary>
        /// 模式
        /// </summary>
        public short Mode;

        /// <summary>
        /// 地区（即地图ID）
        /// </summary>
        public uint Map;

        /// <summary>
        /// 关卡（即关卡组ID）
        /// </summary>
        public uint LevelGrp;

        /// <summary>
        /// 难度
        /// </summary>
        public short Difficulty;

        /// <summary>
        /// 最大队伍人数
        /// </summary>
        public ushort MemberMax;

        /// <summary>
        /// 自由入队（队长认证则设为0）
        /// </summary>
        public int FreeJoin;

        /// <summary>
        /// 是否允许公开招募（不允许：0；允许：1）
        /// </summary>
        public int OpenRecruit;

        /// <summary>
        /// 入队密码
        /// </summary>
        public string Pwd;

        /// <summary>
        /// 入队认证权限
        /// </summary>
        public int auth;

        /// <summary>
        /// 最小等级限制
        /// </summary>
        public ushort MinLevel;

        /// <summary>
        /// 最大等级限制
        /// </summary>
        public ushort MaxLevel;

        public void Write(IBuffer buffer)
        {
            buffer.WriteInt32(TeamName.Length + 1, Endianness.Big);
            buffer.WriteCString(TeamName);
            buffer.WriteInt16(Mode, Endianness.Big);
            buffer.WriteUInt32(Map, Endianness.Big);
            buffer.WriteUInt32(LevelGrp, Endianness.Big);
            buffer.WriteInt16(Difficulty, Endianness.Big);
            buffer.WriteUInt16(MemberMax, Endianness.Big);
            buffer.WriteInt32(FreeJoin, Endianness.Big);
            buffer.WriteInt32(OpenRecruit, Endianness.Big);
            buffer.WriteInt32(Pwd.Length + 1, Endianness.Big);
            buffer.WriteCString(Pwd);
            buffer.WriteInt32(auth, Endianness.Big);
            buffer.WriteUInt16(MinLevel, Endianness.Big);
            buffer.WriteUInt16(MaxLevel, Endianness.Big);
        }

    }
}
