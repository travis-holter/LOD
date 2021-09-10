﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LOD.Classes
{
    class Room
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Dictionary<string, Room> Directions { get; set; }
        public Room(string name, string description)
        {
            Name = name;
            Description = description;
            Directions = new Dictionary<string, Room>();
        }
    }
}
