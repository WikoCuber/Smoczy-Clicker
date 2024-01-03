﻿namespace SC_Data
{
    public class Data
    {
        public Settings Settings { get; set; } = new();
        public Delays Delays { get; set; } = new();
        public Coordinates Coordinates { get; set; } = new();
        public Mining Mining { get; set; } = new();
        public Clicker Clicker { get; set; } = new();
        public ScriptsBinds ScriptsBinds { get; set; } = new();
        public SlotsBinds SlotsBinds { get; set; } = new();
        public Commands Commands { get; set; } = new();
    }
}
