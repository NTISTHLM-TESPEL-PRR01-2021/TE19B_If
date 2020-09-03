using System;

namespace Ifsatser
{
  class Program
  {
    static void Main(string[] args)
    {
      string name;

      name = Console.ReadLine();

      //Console.WriteLine("micke" != "herbert");

      // Kolla ifall användaren skrev "Micke"
      if (name == "micke")
      {
        Console.WriteLine("Hej!");

        Console.WriteLine("Vad ska du göra idag?");

        string todo = Console.ReadLine();

        if (todo == "sleep")
        {
          Console.WriteLine("Zzzzz");
        }

      }
      else if (name == "herbert")
      {
        Console.WriteLine("Tjena!");
      }
      else
      {
        Console.WriteLine("Nej!");
      }

      // if (name != "micke")
      // {
      // }


      Console.ReadLine();

    }
  }
}
