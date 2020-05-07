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
    public static string EnterBasement()
    {
      if (_basement == true)
      {
        return "\nYou are already in the basement.";
      }
      else
      {
        _bedroom = false;
        _kitchen = false;
        _livingroom = false;
        _basement = true;
        return "\nYou cautiously enter the basement.";
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
    }
  }
}