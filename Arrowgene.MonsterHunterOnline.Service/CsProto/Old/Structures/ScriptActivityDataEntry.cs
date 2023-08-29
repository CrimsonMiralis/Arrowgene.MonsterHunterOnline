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
    /// 脚本活动数据结构
    /// </summary>
    public class ScriptActivityDataEntry : ICsStructure
    {
        private static readonly ILogger Logger = LogProvider.Logger(typeof(ScriptActivityDataEntry));

        public ScriptActivityDataEntry(ScriptActivityDataUnion _Data)
        {
            ID = 0;
            State = 0;
            Data = _Data;
        }

        /// <summary>
        /// 数据项的唯一标识，不为0
        /// </summary>
        public byte ID;

        /// <summary>
        /// 类型 @EScriptActivityDataType
        /// </summary>

        /// <summary>
        /// 状态 @see EScriptActivityDataState
        /// </summary>
        public byte State;

        /// <summary>
        /// 变量值
        /// </summary>
        public ScriptActivityDataUnion Data;

        public void WriteCs(IBuffer buffer)
        {
            buffer.WriteByte(ID);
            buffer.WriteByte((byte)Data.Type);
            buffer.WriteByte(State);
            Data.WriteCs(buffer);
        }

        public void ReadCs(IBuffer buffer)
        {
            ID = buffer.ReadByte();
            EScriptActivityDataType ScriptActivityDataUnion_Type = (EScriptActivityDataType)buffer.ReadByte();
            State = buffer.ReadByte();
            switch (ScriptActivityDataUnion_Type)
            {
                case EScriptActivityDataType.kScriptActivityDataType_Marqueen:
                    Data = new ScriptActivityDataMarqueen();
                    break;
                case EScriptActivityDataType.kScriptActivityDataType_ButtonScript:
                    Data = new ScriptActivityDataButtonScript();
                    break;
                case EScriptActivityDataType.kScriptActivityDataType_ButtonCharge:
                    Data = new ScriptActivityDataButtonCharge();
                    break;
                case EScriptActivityDataType.kScriptActivityDataType_ButtonInternalWeb:
                    Data = new ScriptActivityDataButtonInternalWeb();
                    break;
                case EScriptActivityDataType.kScriptActivityDataType_ButtonExternalWeb:
                    Data = new ScriptActivityDataButtonExternalWeb();
                    break;
                case EScriptActivityDataType.kScriptActivityDataType_ButtonAcceptTask:
                    Data = new ScriptActivityDataButtonAcceptTask();
                    break;
                case EScriptActivityDataType.kScriptActivityDataType_ButtonEnterLevel:
                    Data = new ScriptActivityDataButtonEnterLevel();
                    break;
                case EScriptActivityDataType.kScriptActivityDataType_Item:
                    Data = new ScriptActivityDataItem();
                    break;
                case EScriptActivityDataType.kScriptActivityDataType_Param:
                    Data = new ScriptActivityDataParam();
                    break;
                case EScriptActivityDataType.kScriptActivityDataType_LevelHidden:
                    Data = new ScriptActivityDataLevelHidden();
                    break;
                case EScriptActivityDataType.kScriptActivityDataType_HubHidden:
                    Data = new ScriptActivityDataHubHidden();
                    break;
                case EScriptActivityDataType.kScriptActivityDataType_LevelControl:
                    Data = new ScriptActivityDataLevelControl();
                    break;
                case EScriptActivityDataType.kScriptActivityDataType_Script:
                    Data = new ScriptActivityDataScript();
                    break;
                case EScriptActivityDataType.kScriptActivityDataType_ScriptAttachParam:
                    Data = new ScriptActivityDataScriptAttachParam();
                    break;
                case EScriptActivityDataType.kScriptActivityDataType_Hunt:
                    Data = new ScriptActivityHunt();
                    break;
            }
            if (Data != null) {
                Data.ReadCs(buffer);
            }
            else {
                Logger.Error("Failed to create 'Data' instance of type 'ScriptActivityDataUnion'");
            }
        }

    }
}
