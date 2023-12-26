namespace SC_Data
{
    public class Commands
    {
        public bool IsCommandType { get; set; }
        public List<string> CommandsContent { get; set; } = [];
        public List<bool> IsCommandsOn { get; set; } = [];
        public List<int> WhichLapCommands { get; set; } = [];
        public List<Keys> BindsList { get; set; } = [];
        public List<bool> IsBindsOn { get; set; } = [];
        public List<int> WhichLapBinds { get; set; } = [];
    }
}
