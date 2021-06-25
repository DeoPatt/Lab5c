using System;

class MainClass {
  public static void Main (string[] args) {
    
    Console.WriteLine ("Enter a number");
  double num = Convert.ToDouble(Console.ReadLine());
  


  if(num % 2 == 0 )
  {
    Console.WriteLine("This isnt a prime number");
  }
  else 
  {
    Console.WriteLine("This is a prime number");
  }
  
  }
}