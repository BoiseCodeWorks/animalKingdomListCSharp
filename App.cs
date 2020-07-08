using System;
using System.Collections.Generic;
using System.Threading;
using AnimalKingdom.Models;

namespace AnimalKingdom
{
  public class App
  {
    public Kingdom kd { get; set; }
    public List<string> Messages { get; set; } = new List<string>();
    public Node CurrentNode { get; set; } = new Node("Classifications of Animals");
    public void Run()
    {
      Console.Clear();
      kd = new Kingdom(CurrentNode);
      Messages.Add("Welcome to the Animalia Kingdom");
      while (true)
      {
        Messages.Add(kd.viewKingdoms(CurrentNode));
        Print();
        GetUserInput();

      }
    }

    public void GetUserInput()
    {
      Messages.Add("Enter a number to visit that kingdom or p to go previous");
      Print();
      string input = Console.ReadLine();
      switch (input.ToLower())
      {
        case "q":
          //quit
          Environment.Exit(0);
          break;
        case "p":
          //previous
          System.Console.Write("Loading");
          for (int i = 0; i < 3; i++)
          {
            Console.Write(".");
            Thread.Sleep(200);
          }
          Console.Clear();
          PreviousNode();
          break;
        default:
          if (int.TryParse(input, out int num))
          {
            System.Console.Write("Loading");
            for (int i = 0; i < 3; i++)
            {
              Console.Write(".");
              Thread.Sleep(200);
            }
            Console.Clear();
            changeNode(num - 1);
          }
          break;
      }
    }

    public void PreviousNode()
    {

      CurrentNode = CurrentNode.Parent;
    }
    public void changeNode(int index)
    {
      if (index < 0 || index > CurrentNode.Children.Count)
      {
        Messages.Add("Invalid Num");
        return;
      }
      CurrentNode = CurrentNode.Children[index];
    }
    public void Print()
    {
      foreach (string m in Messages)
      {
        System.Console.WriteLine(m);
      }
      Messages.Clear();
    }
  }
}