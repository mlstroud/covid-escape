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
        else if (startInput == "clean room" || startInput == "pick up clothes" || startInput == "search room" || startInput == "clothes")
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
        Rooms.ItemsAvailable();
      }
      while (Rooms._livingroom == true)
      {
      Start:
        Console.WriteLine("The livingroom is unusually warm, and you smell the distinct aroma of smoke. Where it is coming from is a mystery, however. A couch that looks like it has never been cleaned sits against the right wall, and to your left is a television with nothing but static on the screen. \n\nWhat would you like to do[Look Around/Enter Kitchen]");
        string livingInput = (Console.ReadLine().ToLower());

        if (livingInput == "enter kitchen")
        {
          Console.WriteLine(Rooms.EnterKitchen());
        }
        else if (livingInput == "look around")
        {
          Console.WriteLine("There isn't much too this room. It looks as though it has been uninhabited for a long time. However, peeking out from between two couch cushions is a face-mask. You wonder what else you might find if you look in the right place.\n\n");
          DisplayItems();
          Console.WriteLine("\n\nWhat would you like to do? [Pick-up Mask]");
          string userInput = (Console.ReadLine().ToLower());
          if (userInput == "pick-up mask" || userInput == "pick up mask" || userInput == "get mask")
          {
            Rooms.PickUp("mask");
            goto Start;
          }
          else if (userInput == "pick up glass" || userInput == "pick-up glass")
          {
            Rooms.PickUp("glass");
            Console.WriteLine("You pick up the shard of glass carefully.");
          }
        }
        else if (livingInput == "move couch" || livingInput == "look under couch" || livingInput == "look in couch")
        {
          Console.WriteLine("You check under the couch cushions and find nothing else. However, a thought strikes you to move the couch and behind it you find a baseball bat. You pick it up. Something tells you it might be useful.");
          Rooms.inventory["baseball bat"] = "An aluminum baseball bat. Light in the hand, but sturdy enough to break things with.";
          goto Start;
        }
        else if (Rooms.inventory.ContainsKey("baseball bat") && livingInput == "smash tv")
        {
          Console.WriteLine("You swing hard and smash the television screen. It shatters into pieces and sparks fly. It was fun, but you can't figure out what you did that for.");
          Rooms.itemsInRoom["glass"] = "A large shard of glass from the television screen. Handle with caution; It's sharp!";
          goto Start;

        }
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