using EasyMid.Champions;
using EnsoulSharp;
using EnsoulSharp.SDK;
using EnsoulSharp.SDK.MenuUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMid
{
    class Program
    {
        public static void Main(string[] args)
        {
          
                    GameEvent.OnGameLoad += On_LoadGame;
             
        }

private static void On_LoadGame()
{
    if (ObjectManager.Player.CharacterName == "Brand")
    {
        Brand.OnLoad();
    }
    if (ObjectManager.Player.CharacterName == "Diana")
    {
        Diana.OnLoad();
        Chat.Print("Easy Mid Fixed By Memory");
        Notifications.Add(new Notification("Easy Mid Fixed By Memory", "Credit  Memory"));
    }
        }
 
    }

}