using System;

namespace AbstractFactory
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome user! What cell phone do you want to buy?");
      Console.WriteLine(" 1-Good cell phone\n 2-Premium cell phone");
      string choice = Console.ReadLine();
      CellPhone phone = ExecuteAbstractFactory.assemblyCellPhone(choice);
      
    }
  }
}