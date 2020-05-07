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
      Console.WriteLine("\nYou wake up from a deep slumber, not remembering how long it has been since you fell asleep. Under warm blankets in bed, you slowly rouse to consciousness and remember it is just another day in Quarantine. But something inside you tells you you need to leave.\n \nWhat would you like to do? [Enter Livingroom/Stay in Bed/Look Around]");
      string startInput = (Console.ReadLine()).ToLower();
      if (startInput == "enter livingroom")
      {
        Console.WriteLine(Rooms.EnterLivingRoom());
      }
      else if (startInput == "stay in bed")
      {
        Console.WriteLine("\nYou drift back to sleep as a sense of dread slowly eats at you in the pit of your stomach.");
      }
      else if (startInput == "look around")
      {
        Console.WriteLine("\nIn the bedroom, you can see:\n\nA " + Rooms.itemsInRoom.Keys.ElementAt(0) + "\nA " + Rooms.itemsInRoom.Keys.ElementAt(1) + "\n");

        Console.WriteLine("What would you like to pick up?");
        string userAction = (Console.ReadLine()).ToLower();
        Rooms.PickUp(userAction);
        Console.WriteLine("\nIn the bedroom, you can see:\n\nA " + Rooms.itemsInRoom.Keys.ElementAt(0) + "\nA " + "\n");
      }
      else
      { Console.WriteLine("I'm sorry, I can't do that right now."); }
    }

    public void DisplayItems()
    {

    }
  }
}