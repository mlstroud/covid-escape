using System;
using System.Collections.Generic;

namespace Game
{
  public class Rooms
  {
    public static bool _bedroom { get; set; }
    public static bool _kitchen { get; set; }
    public static bool _livingroom { get; set; }
    public static bool _basement { get; set; }

    public static Dictionary<string, string> inventory = new Dictionary<string, string>();
    public static Dictionary<string, string> itemsInRoom = new Dictionary<string, string>();
    public static string EnterBedroom()
    {
      if (_bedroom == true)
      {
        return "\nYou are already in the bedroom.";
      }
      else
      {
        _bedroom = true;
        _kitchen = false;
        _livingroom = false;
        _basement = false;
        return "\nYou enter the bedroom.";
      }
    }
    public static string EnterKitchen()
    {
      if (_kitchen == true)
      {
        return "\nYou are already in the kitchen.";
      }
      else
      {
        _bedroom = false;
        _kitchen = true;
        _livingroom = false;
        _basement = false;
        return "\nYou enter the kitchen.";
      }
    }
    public static string EnterLivingRoom()
    {
      if (_livingroom == true)
      {
        return "\nYou are already in the livingroom.";
      }
      else
      {
        _bedroom = false;
        _kitchen = false;
        _livingroom = true;
        _basement = false;
        return "\nYou enter the livingroom.";
      }
    }
    public static void ItemsAvailable()
    {
      if (_bedroom == true)
      {
        itemsInRoom.Clear();
        itemsInRoom["note"] = "A torn scrap of paper, on which is written the numbers '36'";
        itemsInRoom["mirror"] = "A small handheld mirror.";

      }
      else if (_livingroom == true)
      {
        itemsInRoom.Clear();
        itemsInRoom["mask"] = "A C95 protective mask. A recent staple in everyone's inventory.";
      }
      else if (_kitchen == true)
      {
        itemsInRoom.Clear();
        itemsInRoom["potatoes"] = "A small cloth sack of potatoes. It is sealed shut with multiple industrial staples, as if someone did not want you to look inside.";
        itemsInRoom["pot"] = "A medium-sized pot with a lid. Seems noisy.";
      }
    }

    public static void PickUp(string item)
    {
      if (itemsInRoom.ContainsKey(item))
      {
        inventory.Add(item, itemsInRoom[item]);
        itemsInRoom.Remove(item);
      }
    }
  }
}
