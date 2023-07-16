using Arrowgene.Buffers;
using Arrowgene.Logging;
using Arrowgene.MonsterHunterOnline.Service.CsProto.Core;
using Arrowgene.MonsterHunterOnline.Service.CsProto.Enums;
using Arrowgene.MonsterHunterOnline.Service.CsProto.Structures;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using System;
using Arrowgene.MonsterHunterOnline.Service.CsProto.Constant;
using System.Globalization;
using Microsoft.AspNetCore.Routing;

namespace Arrowgene.MonsterHunterOnline.Service.CsProto.Handler;

public class LeaveInstanceReqHandler : CsProtoStructureHandler<LeaveInstanceReq>
{
    private static readonly ServiceLogger Logger =
        LogProvider.Logger<ServiceLogger>(typeof(LeaveInstanceReq));
    public override CS_CMD_ID Cmd => CS_CMD_ID.CS_CMD_LEAVE_INSTANCE_REQ;

    public override void Handle(Client client, LeaveInstanceReq req)
    {
        //Type 离开方式，0：退出游戏，1：回到城镇的副本进入点 2:回到城镇的主城
        //Exit method, 0: exit the game, 1: return to the entry point of the copy of the town, 2: return to the main city of the town

        string staticFolder = Path.Combine(Util.ExecutingDirectory(), "Files\\Static");
        string csvPath = Path.Combine(staticFolder, "ChangeTown.csv");
        if (req.Type == 1)
        {
            string triggerName = "Minimap";
            int level = client.State.prevLevelId;

            CsProtoStructurePacket<TownInstanceVerifyRsp> townServerInitNtf = CsProtoResponse.TownServerInitNtf;
            TownInstanceVerifyRsp verifyRsp = townServerInitNtf.Structure;
            verifyRsp.ErrNo = 0;
            verifyRsp.LineId = 0;
            verifyRsp.LevelEnterType = 0;

            InstanceInitInfo instanceInitInfo = verifyRsp.InstanceInitInfo;
            instanceInitInfo.BattleGroundId = 0;
            instanceInitInfo.LevelId = level;
            instanceInitInfo.CreateMaxPlayerCount = 4;
            instanceInitInfo.GameMode = GameMode.Town;
            instanceInitInfo.TimeType = TimeType.Noon;
            instanceInitInfo.WeatherType = WeatherType.Sunny;
            instanceInitInfo.Time = 1;
            instanceInitInfo.LevelRandSeed = 1;
            instanceInitInfo.WarningFlag = 0;
            instanceInitInfo.CreatePlayerMaxLv = 99;
            if (triggerName.Length > 5)
            {
                using (TextFieldParser parser = new TextFieldParser(csvPath))
                {
                    string level_comp = level.ToString();
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    // Skip the header line
                    parser.ReadLine();
                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                        string levelId = fields[0];
                        bool isMatch = !string.IsNullOrEmpty(levelId) &&
                            !string.IsNullOrEmpty(level_comp) &&
                            (level_comp.Contains(levelId) || levelId.Contains(level_comp));
                        if (isMatch)
                        {
                            //string filename = fields[1];
                            //string areaName = fields[2];
                            string name = fields[3].Trim();
                            string pos = fields[5];
                            string rotate = fields[6];
                            //string dstPoint = fields[7];

                            if (name.Contains(triggerName) || triggerName.Contains(name))
                            {

                                string[] posValues = pos.Split(',');
                                string[] rotateValues = rotate.Split(',');

                                float posX = float.Parse(posValues[0], CultureInfo.InvariantCulture);
                                float posY = float.Parse(posValues[1], CultureInfo.InvariantCulture);
                                float posZ = float.Parse(posValues[2], CultureInfo.InvariantCulture);

                                float rotateX = float.Parse(rotateValues[0], CultureInfo.InvariantCulture);
                                float rotateY = float.Parse(rotateValues[1], CultureInfo.InvariantCulture);
                                float rotateZ = float.Parse(rotateValues[2], CultureInfo.InvariantCulture);
                                float rotateW = float.Parse(rotateValues[3], CultureInfo.InvariantCulture);


                                CSQuatT TargetPosition = new CSQuatT()
                                {

                                    q = new CSQuat()
                                    {
                                        v = new CSVec3() { x = rotateX, y = rotateY, z = rotateZ },
                                        w = rotateW
                                    },
                                    t = new CSVec3() { x = (float)posX, y = (float)posY, z = (float)posZ }
                                };

                                CsProtoStructurePacket<LeaveInstanceRsp> LeaveInstance = CsProtoResponse.LeaveInstanceRsp;
                                LeaveInstance.Structure.ErrNo = 0;

                                client.SendCsProtoStructurePacket(LeaveInstance);


                                CsProtoStructurePacket<PlayerTeleport> PlayerTeleport = CsProtoResponse.PlayerTeleport;
                                PlayerTeleport.Structure.SyncTime = 1;
                                PlayerTeleport.Structure.NetObjId = client.Character.Id;
                                PlayerTeleport.Structure.Region = level;
                                PlayerTeleport.Structure.TargetPos = TargetPosition;
                                PlayerTeleport.Structure.ParentGuid = 1;
                                PlayerTeleport.Structure.InitState = 1;
                                client.SendCsProtoStructurePacket(PlayerTeleport);

                                client.SendCsProtoStructurePacket(townServerInitNtf);
                                client.State.prevLevelId = client.State.levelId;
                                client.State.levelId = instanceInitInfo.LevelId;
                                return;
                            }
                        }
                    }
                }

            }
            else
            {


                CSQuatT TargetPosition = new CSQuatT()
                {

                    q = new CSQuat()
                    {
                        v = new CSVec3() { x = 0, y = 0, z = 0 },
                        w = 0
                    },
                    t = new CSVec3() { x = 300f, y = 200f, z = 150f }
                };

                CsProtoStructurePacket<LeaveInstanceRsp> LeaveInstance = CsProtoResponse.LeaveInstanceRsp;
                LeaveInstance.Structure.ErrNo = 0;

                client.SendCsProtoStructurePacket(LeaveInstance);


                CsProtoStructurePacket<PlayerTeleport> PlayerTeleport = CsProtoResponse.PlayerTeleport;
                PlayerTeleport.Structure.SyncTime = 1;
                PlayerTeleport.Structure.NetObjId = client.Character.Id;
                PlayerTeleport.Structure.Region = level;
                PlayerTeleport.Structure.TargetPos = TargetPosition;
                PlayerTeleport.Structure.ParentGuid = 1;
                PlayerTeleport.Structure.InitState = 1;
                client.SendCsProtoStructurePacket(PlayerTeleport);

                client.SendCsProtoStructurePacket(townServerInitNtf);
                client.State.prevLevelId = client.State.levelId;
                client.State.levelId = instanceInitInfo.LevelId;
                return;
            }


        }
    }
}