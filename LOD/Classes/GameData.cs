﻿using System;
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
        public string winnerCongrats { get; } = "Congragulations, you won!";
        
        public string Gameover { get; } = @"  ▄████  ▄▄▄       ███▄ ▄███▓▓█████  ▒█████   ██▒   █▓▓█████  ██▀███  
 ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀ ▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒
▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███   ▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒
░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄ ▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄  
░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒
 ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░
  ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░  ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░
░ ░   ░   ░   ▒   ░      ░      ░   ░ ░ ░ ▒       ░░     ░     ░░   ░ 
      ░       ░  ░       ░      ░  ░    ░ ░        ░     ░  ░   ░     
                                                  ░     ";
        public Room CurrentRoom { get; set; } 
        public GameData()
        {
            CurrentRoom = SetUpRooms();
        }

        public Room SetUpRooms()
        {
            Room test_starting_room = new Room("This is the default description before you flip a switch in room 1. In room 2, ypu die. Instructions: Type the number of your choice and hit enter.\n1. Go to Room 1\n2.Go to Room 2");
            Room test_room_1 = new Room("There is a switch in this room. Neato! Type 'A' to flip it. (A is for Action)\n1. Go back to the starting room\nA. Flip the switch!");
            Room test_room_2 = new Room("Oh no! You died!");


            test_starting_room.Choices.Add("1", test_room_1);
            test_starting_room.Choices.Add("2", test_room_2);

            test_room_1.Choices.Add("1", test_starting_room);
            return test_starting_room;
        }
    }
}
