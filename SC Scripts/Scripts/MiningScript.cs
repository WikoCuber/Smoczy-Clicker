using SC_Data;
using SC_Scripts.Scripts_Managment;
using SC_Scripts.Utilities;

namespace SC_Scripts.Scripts
{
    public static class MiningScript
    {
        private static bool isClicking;
        private static bool isWorking;

        public static void Mining(ScriptUtility su)
        {
            isWorking = true;

            Data data = DataProvider.Get();

            su.BackgorundWindow = ScriptUtility.GetForegroundWindow(); //Sets backgorund window
            Thread backgroundClicking = new(() => BackgroundClicking(su)); //Thread to mine in background

            ScriptsManager.GetScriptByName("Mining")!.EndWithMethod += () => isWorking = false;

            if (data.Mining.IsBackground)
            {
                backgroundClicking.Start();
                su.IsBackground = true;
            }

            //Copy of commands lists
            List<int> WhichLapcommandOrBinds;
            List<bool> IsCommandsOrBindsOn;
            if (data.Commands.IsCommandType)
            {
                WhichLapcommandOrBinds = data.Commands.WhichLapCommands;
                IsCommandsOrBindsOn = data.Commands.IsCommandsOn;
            }
            else
            {
                WhichLapcommandOrBinds = data.Commands.WhichLapBinds;
                IsCommandsOrBindsOn = data.Commands.IsBindsOn;
            }

            //Main logic
            int currentLap = 0;
            while (true)
            {
                currentLap++;

                if (!data.Mining.IsBackground)
                    su.HoldMouseButton(MouseButtons.Left, true);
                else
                    isClicking = true; //Run clicking

                //Mining
                su.HoldKey(Keys.S, true);
                su.Sleep(data.Mining.Length * 205);
                su.HoldKey(Keys.S, false);
                su.HoldKey(Keys.D, true);
                su.Sleep(250);
                su.HoldKey(Keys.D, false);
                su.HoldKey(Keys.W, true);
                su.Sleep(data.Mining.Length * 205);
                su.HoldKey(Keys.W, false);
                su.HoldKey(Keys.A, true);
                su.Sleep(250);
                su.HoldKey(Keys.A, false);

                //Write commands to chat
                for (int i = 0; i < WhichLapcommandOrBinds.Count; i++)
                {
                    if (IsCommandsOrBindsOn[i]) //If command is on
                    {
                        if (currentLap % WhichLapcommandOrBinds[i] == 0) //If it's correct lap
                        {
                            //Turn off mining
                            if (!su.IsBackground)
                                su.HoldMouseButton(MouseButtons.Left, false);
                            else
                                isClicking = false;

                            if (data.Commands.IsCommandType)
                            {
                                su.SendCommand(data.Commands.CommandsContent[i]);
                                su.Sleep(500);
                            }
                            else //Binds
                            {
                                su.SendKey(data.Commands.BindsList[i]);
                                su.Sleep(data.Delays.Command);
                                su.SendKey(Keys.Enter);
                                su.Sleep(500);
                            }
                        }
                    }
                }

                //Eating
                if (data.Mining.IsEatingOn)
                {
                    //Only in non background mode
                    if (currentLap % data.Mining.WhichLapEating == 0 && !su.IsBackground)
                    {
                        //Turn off mining
                        su.HoldMouseButton(MouseButtons.Left, false);

                        su.SendKey(data.SlotsBinds.Meat);
                        su.Sleep(100);
                        su.HoldMouseButton(MouseButtons.Right, true);
                        su.Sleep(2000);
                        su.HoldMouseButton(MouseButtons.Right, false);
                        su.Sleep(100);
                        su.SendKey(data.SlotsBinds.Pickaxe);
                        su.Sleep(100);
                    }
                }

                //Drop items
                if (data.Mining.IsDropOn)
                {
                    if (currentLap % data.Mining.WhichLapDrop == 0)
                    {
                        //Turn off mining
                        if (!su.IsBackground)
                            su.HoldMouseButton(MouseButtons.Left, false);
                        else
                            isClicking = false;

                        //Go back and drop pattern
                        su.HoldKey(Keys.S, true);
                        su.Sleep(1000);
                        su.HoldKey(Keys.S, false);

                        DropSlots(su, data);

                        //Go to hoppers
                        su.HoldKey(Keys.D, true);
                        su.HoldKey(Keys.W, true);
                        su.Sleep(2000);
                        su.HoldKey(Keys.D, false);
                        su.HoldKey(Keys.W, false);

                        //Open EQ to correctly hold control
                        su.SendKey(data.SlotsBinds.Eq);
                        su.Sleep(200);

                        //Turn on background for hold control key to avoid mistakes
                        if (!su.IsBackground)
                        {
                            su.IsBackground = true;
                            su.HoldKey(Keys.LControlKey, true);
                            su.IsBackground = false;
                        }
                        else
                            su.HoldKey(Keys.LControlKey, true);

                        //Close Eq
                        su.SendKey(Keys.Escape);
                        su.Sleep(200);

                        //Drop rest items
                        DropSlots(su, data);

                        su.HoldKey(Keys.LControlKey, false);

                        //Back for pattern
                        su.HoldKey(Keys.A, true);
                        su.Sleep(1000);
                        su.HoldKey(Keys.A, false);
                        su.HoldKey(Keys.S, true);
                        su.Sleep(1200);
                        su.HoldKey(Keys.S, false);
                        su.HoldKey(Keys.W, true);
                        su.Sleep(1200);
                        su.HoldKey(Keys.W, false);

                        su.SendKey(data.SlotsBinds.Pickaxe);

                        //Fix ghost blocks
                        for (int i = 0; i < 6; i++)
                        {
                            su.SendMouseButton(MouseButtons.Right);
                            su.Sleep(20);
                        }
                    }
                }
            }
        }

        //Clicking left button to backgorund mining
        private static void BackgroundClicking(ScriptUtility suOrginal)
        {
            //Do another ScriptUtility to don't throw cancel in clicking thread
            ScriptUtility su = new()
            {
                IsBackground = true,
                BackgorundWindow = suOrginal.BackgorundWindow
            };

            while (isWorking)
            {
                su.Sleep(40);
                if (isClicking)
                    su.SendMouseButton(MouseButtons.Left);
            }
        }

        private static void DropSlot(ScriptUtility su, Keys slot, Keys dropBind)
        {
            su.SendKey(slot);
            su.Sleep(120);
            su.SendKey(dropBind);
            su.Sleep(50);
        }

        private static void DropSlots(ScriptUtility su, Data data)
        {
            if (data.Mining.IsSlot1On)
                DropSlot(su, data.SlotsBinds.Slot1, data.SlotsBinds.Drop);

            if (data.Mining.IsSlot2On)
                DropSlot(su, data.SlotsBinds.Slot2, data.SlotsBinds.Drop);

            if (data.Mining.IsSlot3On)
                DropSlot(su, data.SlotsBinds.Slot3, data.SlotsBinds.Drop);

            if (data.Mining.IsSlot4On)
                DropSlot(su, data.SlotsBinds.Slot4, data.SlotsBinds.Drop);

            if (data.Mining.IsSlot5On)
                DropSlot(su, data.SlotsBinds.Slot5, data.SlotsBinds.Drop);
        }
    }
}
