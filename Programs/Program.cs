using System;
using System.Collections.Generic;
using System.Linq;
using Game;

namespace NewGame
{
  public class Program
  {
    public static void Main()
    {
      string currentRoom = "bedroom";
      Rooms game = new Rooms();
      Rooms.EnterBedroom();
      Rooms.ItemsAvailable();
      // Start:
      // Console.WriteLine("\nYou wake up from a deep slumber, not remembering how long it has been since you fell asleep. Under warm blankets in bed, you slowly rouse to consciousness and remember it is just another day in Quarantine. But something inside you tells you you need to leave.\n \nWhat would you like to do? [Enter Livingroom/Stay in Bed/Look Around]");
      // string startInput = (Console.ReadLine()).ToLower();

      while (Rooms._bedroom == true)
      {
      Start:
        Console.WriteLine("\nYou wake up from a deep slumber, not remembering how long it has been since you fell asleep. Under warm blankets in bed, you slowly rouse to consciousness and remember it is just another day in Quarantine. But something inside you tells you you need to leave.\n \nWhat would you like to do? [Enter Livingroom/Stay in Bed/Look Around/Look At Inventory]");
        string startInput = (Console.ReadLine()).ToLower();
        if (startInput == "enter livingroom")
        {
          Console.WriteLine("The door is locked by a heavy padlock. You don't know who put it there. Maybe it was you. You can try a combination if you like:");
          string padlock = (Console.ReadLine().ToLower());
          if (padlock == "3667" || padlock == "36 67")
          {
            Console.WriteLine(Rooms.EnterLivingRoom());
          }
        }
        else if (startInput == "stay in bed")
        {
          Console.WriteLine("\nYou drift back to sleep as a sense of dread slowly eats at you in the pit of your stomach.");
        }
        else if (startInput == "look around")
        {
          Console.WriteLine("\nThe bedroom is small, cramped with a messy bed, a small computer desk, office chair, and dresser. On the floor is scattered many sundry items, and a large pile of dirty clothes is in the corner. \n\n On the desk, you can see:\n\n");
          DisplayItems();

          Console.WriteLine("What would you like to pick up?\n\n");
          string userAction = (Console.ReadLine()).ToLower();
          Rooms.PickUp(userAction);
          Console.WriteLine("In the room remains:\n");
          DisplayItems();
          goto Start;
        }
        else if (startInput == "look at inventory")
        {
          foreach (KeyValuePair<string, string> item in Rooms.inventory)
          {
            Console.WriteLine(item.Key + " - " + item.Value);
          }
          goto Start;
        }
        else if (startInput == "clean room" || startInput == "pick up clothes" || startInput == "search room")
        {
          Console.WriteLine("You spend some time moving things about in the bedroom, and beneath the pile of clothes find another scrap of paper with the numbers '67' written on it. It looks to be the other half of the note that was on the desk.");
          Rooms.inventory["note2"] = "The other half of the note on the desk. It reads '67'";
          goto Start;
        }
        else
        {
          Console.WriteLine("I'm sorry, I can't do that right now.");
          goto Start;
        }
      }
      while (Rooms._livingroom == true)
      {
      Start:
        Console.WriteLine("The livingroom");
      }
    }

    public static void DisplayItems()
    {
      foreach (KeyValuePair<string, string> item in Rooms.itemsInRoom)
      {
        Console.WriteLine(item.Key + " - " + item.Value);
      }
    }
  }
}