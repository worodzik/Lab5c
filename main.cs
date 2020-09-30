using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter your number");
    int num = Convert.ToInt32(Console.ReadLine());
    int test = 0;
     for (int count = 2 ; count < num ; count ++){
       if ((num % count) ==0){
         Console.WriteLine("The number is non-prime");
          test = 1;
         break;
       }
     }
     if (test== 0){
       Console.WriteLine("The number is prime");
     }
  }
}