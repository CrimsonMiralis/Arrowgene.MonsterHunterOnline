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
    /// 副本奖励数据
    /// </summary>
    public class CSLevelRewardInfo : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(CSLevelRewardInfo));

        public CSLevelRewardInfo()
        {
            RewardType = 0;
            ExtId = 0;
            AttrRewardType = new List<short>();
            AttrRewardValue = new List<int>();
            RewardAffectList = new List<CSLevelRewardAffectInfo>();
            ItemLootList = new CSInstanceItemLootInfoList();
            BoxItemLootList = new CSInstanceItemLootInfoList();
            InstanceItemData = new List<CSRewardInstanceData>();
        }

        /// <summary>
        /// 奖励类型
        /// </summary>
        public short RewardType;

        /// <summary>
        /// 奖励扩展字段
        /// </summary>
        public int ExtId;

        /// <summary>
        /// 属性类型
        /// </summary>
        public List<short> AttrRewardType;

        /// <summary>
        /// 属性奖励值
        /// </summary>
        public List<int> AttrRewardValue;

        /// <summary>
        /// 加成列表
        /// </summary>
        public List<CSLevelRewardAffectInfo> RewardAffectList;

        /// <summary>
        /// 道具奖励列表
        /// </summary>
        public CSInstanceItemLootInfoList ItemLootList;

        /// <summary>
        /// 宝箱奖励道具列表
        /// </summary>
        public CSInstanceItemLootInfoList BoxItemLootList;

        public List<CSRewardInstanceData> InstanceItemData;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteInt16(RewardType, Endianness.Big);
            buffer.WriteInt32(ExtId, Endianness.Big);
            int attrRewardTypeCount = (int)AttrRewardType.Count;
            buffer.WriteInt32(attrRewardTypeCount, Endianness.Big);
            for (int i = 0; i < attrRewardTypeCount; i++)
            {
                buffer.WriteInt16(AttrRewardType[i], Endianness.Big);
            }
            int attrRewardValueCount = (int)AttrRewardValue.Count;
            buffer.WriteInt32(attrRewardValueCount, Endianness.Big);
            for (int i = 0; i < attrRewardValueCount; i++)
            {
                buffer.WriteInt32(AttrRewardValue[i], Endianness.Big);
            }
            int rewardAffectListCount = (int)RewardAffectList.Count;
            buffer.WriteInt32(rewardAffectListCount, Endianness.Big);
            for (int i = 0; i < rewardAffectListCount; i++)
            {
                RewardAffectList[i].WriteCs(buffer);
            }
            ItemLootList.WriteCs(buffer);
            BoxItemLootList.WriteCs(buffer);
            int instanceItemDataCount = (int)InstanceItemData.Count;
            buffer.WriteInt32(instanceItemDataCount, Endianness.Big);
            for (int i = 0; i < instanceItemDataCount; i++)
            {
                InstanceItemData[i].WriteCs(buffer);
            }
        }

        public void ReadCs(IBuffer buffer)
        {
            RewardType = buffer.ReadInt16(Endianness.Big);
            ExtId = buffer.ReadInt32(Endianness.Big);
            AttrRewardType.Clear();
            int attrRewardTypeCount = buffer.ReadInt32(Endianness.Big);
            for (int i = 0; i < attrRewardTypeCount; i++)
            {
                short AttrRewardTypeEntry = buffer.ReadInt16(Endianness.Big);
                AttrRewardType.Add(AttrRewardTypeEntry);
            }
            AttrRewardValue.Clear();
            int attrRewardValueCount = buffer.ReadInt32(Endianness.Big);
            for (int i = 0; i < attrRewardValueCount; i++)
            {
                int AttrRewardValueEntry = buffer.ReadInt32(Endianness.Big);
                AttrRewardValue.Add(AttrRewardValueEntry);
            }
            RewardAffectList.Clear();
            int rewardAffectListCount = buffer.ReadInt32(Endianness.Big);
            for (int i = 0; i < rewardAffectListCount; i++)
            {
                CSLevelRewardAffectInfo RewardAffectListEntry = new CSLevelRewardAffectInfo();
                RewardAffectListEntry.ReadCs(buffer);
                RewardAffectList.Add(RewardAffectListEntry);
            }
            ItemLootList.ReadCs(buffer);
            BoxItemLootList.ReadCs(buffer);
            InstanceItemData.Clear();
            int instanceItemDataCount = buffer.ReadInt32(Endianness.Big);
            for (int i = 0; i < instanceItemDataCount; i++)
            {
                CSRewardInstanceData InstanceItemDataEntry = new CSRewardInstanceData();
                InstanceItemDataEntry.ReadCs(buffer);
                InstanceItemData.Add(InstanceItemDataEntry);
            }
        }

    }
}
