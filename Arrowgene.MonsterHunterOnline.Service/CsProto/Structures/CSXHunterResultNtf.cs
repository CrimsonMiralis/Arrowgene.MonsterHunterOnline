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

    public class CSXHunterResultNtf : IStructure
    {

        public CSXHunterResultNtf()
        {
            RedBounds = 0;
            BlueBounds = 0;
            RedTotalScore = 0;
            BlueTotalScore = 0;
            RedSpeedScore = 0;
            BlueSpeedScore = 0;
            RedDamageScore = 0;
            BlueDamageScore = 0;
            RedHitedScore = 0;
            BlueHitedScore = 0;
            PlayereInfo = new List<CSXHunterPlayerInfo>();
        }

        /// <summary>
        /// 红方分数
        /// </summary>
        public int RedBounds;

        /// <summary>
        /// 蓝方分数
        /// </summary>
        public int BlueBounds;

        /// <summary>
        /// 红方总分
        /// </summary>
        public int RedTotalScore;

        /// <summary>
        /// 蓝方总分
        /// </summary>
        public int BlueTotalScore;

        /// <summary>
        /// 红方速度分
        /// </summary>
        public int RedSpeedScore;

        /// <summary>
        /// 蓝方速度分
        /// </summary>
        public int BlueSpeedScore;

        /// <summary>
        /// 红方伤害分
        /// </summary>
        public int RedDamageScore;

        /// <summary>
        /// 蓝方伤害分
        /// </summary>
        public int BlueDamageScore;

        /// <summary>
        /// 红方无伤分
        /// </summary>
        public int RedHitedScore;

        /// <summary>
        /// 蓝方无伤分
        /// </summary>
        public int BlueHitedScore;

        /// <summary>
        /// 玩家信息
        /// </summary>
        public List<CSXHunterPlayerInfo> PlayereInfo;

        public void Write(IBuffer buffer)
        {
            buffer.WriteInt32(RedBounds, Endianness.Big);
            buffer.WriteInt32(BlueBounds, Endianness.Big);
            buffer.WriteInt32(RedTotalScore, Endianness.Big);
            buffer.WriteInt32(BlueTotalScore, Endianness.Big);
            buffer.WriteInt32(RedSpeedScore, Endianness.Big);
            buffer.WriteInt32(BlueSpeedScore, Endianness.Big);
            buffer.WriteInt32(RedDamageScore, Endianness.Big);
            buffer.WriteInt32(BlueDamageScore, Endianness.Big);
            buffer.WriteInt32(RedHitedScore, Endianness.Big);
            buffer.WriteInt32(BlueHitedScore, Endianness.Big);
            int playereInfoCount = (int)PlayereInfo.Count;
            buffer.WriteInt32(playereInfoCount, Endianness.Big);
            for (int i = 0; i < playereInfoCount; i++)
            {
                PlayereInfo[i].Write(buffer);
            }
        }

    }
}
