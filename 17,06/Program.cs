using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace _17_06
{
  class Program
  {
    static void Main(string[] args)
    {
      var threads = new Thread[20];
      User user = new User
      {
        Name = "Saske",
        BankAccount= new Money
        {
          Score = 1000
        }
      };
      foreach (Thread thread in threads)
      {
        Thread.Sleep(5 * new Random().Next(100));
        thread.Start(user);
      }

      Console.ReadLine();
    }
  }
}
