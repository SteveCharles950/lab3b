using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter salespersons name");
    var x = Console.ReadLine();
    Console.WriteLine ("Enter sales amount");
    var y = Console.ReadLine();
    double y1 = Convert.ToDouble(y);
    double e1 = 200 + (0.09 * y1);
    Console.WriteLine ("Sales commission for " + (x) + " is $" + (e1));
    if (e1 >= 0 && e1 <= 299)
    {
      Console.WriteLine ("Performance is poor");
    }
    else if (e1 >= 300 && e1 <= 499)
   {
     Console.WriteLine ("Performance is average");
   }
    else if (e1 >= 500 && e1 <= 999)
   {
     Console.WriteLine ("Performance is good");
   }
   else if (e1 >= 1000 && e1 <= 1499)
   {
     Console.WriteLine ("Performance is excellent");
   }
   else
   {
     Console.WriteLine ("Performance is outstanding");
   }
   




  }
}