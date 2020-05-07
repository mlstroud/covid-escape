using System;
using System.Collections.Generic;

namespace Game
{
  public class Rooms
  {
    public bool _bedroom { get; set; }
    public bool _kitchen { get; set; }
    public bool _livingroom { get; set; }
    public bool _basement { get; set; }

    public List<string> inventory { get; set; }
    public string EnterBedroom()
    {
      if (_bedroom = true)
      {
        return "You are already in the bedroom.";
      }
      else
      {
        _bedroom = true;
        _kitchen = false;
        _livingroom = false;
        _basement = false;
        return "You enter the bedroom.";
      }
    }
    public string EnterKitchen()
    {
      if (_kitchen = true)
      {
        return "You are already in the kitchen.";
      }
      else
      {
        _bedroom = false;
        _kitchen = true;
        _livingroom = false;
        _basement = false;
        return "You enter the kitchen.";
      }
    }
    public string EnterLivingRoom()
    {
      if (_livingroom = true)
      {
        return "You are already in the livingroom.";
      }
      else
      {
        _bedroom = false;
        _kitchen = false;
        _livingroom = true;
        _basement = false;
        return "You enter the livingroom.";
      }
    }
    public string EnterBasement()
    {
      if (_basement = true)
      {
        return "You are already in the basement.";
      }
      else
      {
        _bedroom = false;
        _kitchen = false;
        _livingroom = false;
        _basement = true;
        return "You cautiously enter the basement.";
      }
    }

  }
}