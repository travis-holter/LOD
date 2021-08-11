﻿using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace LOD.Classes
{
    class GameData
    {
        public string Title { get; } = "";
        public string TitleArt { get; } = @" /$$$$$$$$ /$$                       /$$                                                     /$$      
|__  $$__/| $$                      | $$                                                    | $$      
   | $$   | $$$$$$$   /$$$$$$       | $$        /$$$$$$   /$$$$$$   /$$$$$$  /$$$$$$$   /$$$$$$$      
   | $$   | $$__  $$ /$$__  $$      | $$       /$$__  $$ /$$__  $$ /$$__  $$| $$__  $$ /$$__  $$      
   | $$   | $$  \ $$| $$$$$$$$      | $$      | $$$$$$$$| $$  \ $$| $$$$$$$$| $$  \ $$| $$  | $$      
   | $$   | $$  | $$| $$_____/      | $$      | $$_____/| $$  | $$| $$_____/| $$  | $$| $$  | $$      
   | $$   | $$  | $$|  $$$$$$$      | $$$$$$$$|  $$$$$$$|  $$$$$$$|  $$$$$$$| $$  | $$|  $$$$$$$      
   |__/   |__/  |__/ \_______/      |________/ \_______/ \____  $$ \_______/|__/  |__/ \_______/      
                                                         /$$  \ $$                                    
                                                        |  $$$$$$/                                    
                                                         \______/                                     
            /$$$$$$        /$$$$$$$            /$$ /$$                                                
           /$$__  $$      | $$__  $$          | $$| $$                                                
  /$$$$$$ | $$  \__/      | $$  \ $$  /$$$$$$ | $$| $$  /$$$$$$  /$$$$$$$                             
 /$$__  $$| $$$$          | $$  | $$ |____  $$| $$| $$ /$$__  $$| $$__  $$                            
| $$  \ $$| $$_/          | $$  | $$  /$$$$$$$| $$| $$| $$$$$$$$| $$  \ $$                            
| $$  | $$| $$            | $$  | $$ /$$__  $$| $$| $$| $$_____/| $$  | $$                            
|  $$$$$$/| $$            | $$$$$$$/|  $$$$$$$| $$| $$|  $$$$$$$| $$  | $$                            
 \______/ |__/            |_______/  \_______/|__/|__/ \_______/|__/  |__/                            
                                                                                                      
                                                                                                      
                                                                                                     ";
        public string VictoryArt { get; } = @"██╗   ██╗ ██████╗ ██╗   ██╗    ██╗    ██╗ ██████╗ ███╗   ██╗██╗
╚██╗ ██╔╝██╔═══██╗██║   ██║    ██║    ██║██╔═══██╗████╗  ██║██║
 ╚████╔╝ ██║   ██║██║   ██║    ██║ █╗ ██║██║   ██║██╔██╗ ██║██║
  ╚██╔╝  ██║   ██║██║   ██║    ██║███╗██║██║   ██║██║╚██╗██║╚═╝
   ██║   ╚██████╔╝╚██████╔╝    ╚███╔███╔╝╚██████╔╝██║ ╚████║██╗
   ╚═╝    ╚═════╝  ╚═════╝      ╚══╝╚══╝  ╚═════╝ ╚═╝  ╚═══╝╚═╝
                                                               ";
        
        public string GameoverArt { get; } = @"  ▄████  ▄▄▄       ███▄ ▄███▓▓█████  ▒█████   ██▒   █▓▓█████  ██▀███  
 ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀ ▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒
▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███   ▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒
░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄ ▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄  
░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒
 ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░
  ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░  ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░
░ ░   ░   ░   ▒   ░      ░      ░   ░ ░ ░ ▒       ░░     ░     ░░   ░ 
      ░       ░  ░       ░      ░  ░    ░ ░        ░     ░  ░   ░     
                                                  ░     ";

        public string Exposition { get; } = "A bright flash of light blinds your eyes as the world around you dissolves. After a moment of disorientation you find yourself standing in a small courtyard atop a calm mountain. What happened? How did you get here? How do you get home? The answers are hidden in the world around you.";
        //newline

    }
}