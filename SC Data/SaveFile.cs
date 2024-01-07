using System.Text;
using System.Text.Json;

namespace SC_Data
{
    public static class SaveFile
    {
        private static readonly string FILE_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Smoczy Clicker/save.json";

        //Loads data and creates save file if it doesn't exists
        public static Data Init()
        {
            Data data;

            if (!File.Exists(FILE_PATH))
            {
                Directory.CreateDirectory(FILE_PATH.Replace("/save.json", ""));

                data = CreateDataWithDefaults();
                DataProvider.Set(data);

                Save(); //Write in file
            }
            else
            {
                data = Load();
                DataProvider.Set(data);
            }

            return data;
        }

        //Saves data to file
        public static void Save()
        {
            string json = JsonSerializer.Serialize(DataProvider.Get());
            File.WriteAllBytes(FILE_PATH, Encoding.UTF8.GetBytes(json));
        }

        //Load data from file
        private static Data Load()
        {
            Data? data = JsonSerializer.Deserialize<Data>(File.ReadAllBytes(FILE_PATH));

            //Empty file
            if (data == null)
            {
                File.Delete(FILE_PATH); //To create new file with default
                data = Init();
            }

            return data;
        }

        private static Data CreateDataWithDefaults()
        {
            Data data = new();

            ScriptsBinds scriptsBinds = new()
            {
                Deposit = Keys.F12,
                Armor1 = Keys.B,
                Armor2 = Keys.N,
                Armor3 = Keys.M,
                Void = Keys.F12,
                Mining = Keys.F12,
                Snowball = Keys.C,
                LeftClicker = Keys.R,
                RightClicker = Keys.F,
                Dabing = Keys.F12,
                FishingRod = Keys.C,
                Alting = Keys.F12,
                Mathew = Keys.F12,
                Effects = Keys.F12,
                Drawing = Keys.F12
            };
            data.ScriptsBinds = scriptsBinds;

            SlotsBinds slotsBinds = new()
            {
                Meat = Keys.D8,
                Snowball = Keys.D4,
                Sword = Keys.D1,
                Chat = Keys.T,
                Drop = Keys.Q,
                Eq = Keys.E,
                Pickaxe = Keys.D9,
                Slot1 = Keys.D1,
                Slot2 = Keys.D2,
                Slot3 = Keys.D3,
                Slot4 = Keys.D4,
                Slot5 = Keys.D5,
                Dab = Keys.O,
                FishingRod = Keys.D4,
                Block = Keys.D4
            };
            data.SlotsBinds = slotsBinds;

            Delays delays = new()
            {
                Void = 50,
                Armor = 50,
                Snowball = 50,
                Deposit = 20,
                FishingRod = 50,
                Backgorund = 20,
                Command = 70,
            };
            data.Delays = delays;

            Settings settings = new()
            {
                IsArmor1On = true,
                IsArmor2On = true,
                IsArmor3On = false,
                IsFishingRodOn = false,
                IsSnowballOn = true,
                PickaxeType = 1,
                DabingType = 1,
                IsEffectsOn = true,
                IsDrawingOn = true
            };
            data.Settings = settings;

            Clicker clicker = new()
            {
                LeftCps = 13,
                RightCps = 100,
                LeftType = 1,
                RightType = 1
            };
            data.Clicker = clicker;

            Mining mining = new()
            {
                Length = 9,
                IsDropOn = true,
                IsSlot1On = true,
                IsSlot2On = true,
                IsSlot3On = true,
                IsSlot4On = false,
                IsSlot5On = false,
                WhichLapDrop = 9,
                IsEatingOn = false,
                WhichLapEating = 20,
                IsBackground = false
            };
            data.Mining = mining;

            Commands commands = new()
            {
                IsCommandType = true,
                CommandsContent = { "/sellall", "/repair" },
                IsCommandsOn = { true, true },
                WhichLapCommands = { 3, 20 },
                BindsList = { Keys.L, Keys.K },
                IsBindsOn = { true, true },
                WhichLapBinds = { 3, 20 },
            };
            data.Commands = commands;

            Coordinates coordinates = new(); //All coordinates are 0 at default
            data.Coordinates = coordinates;

            return data;
        }
    }
}
