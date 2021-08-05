﻿using System;

namespace prac1
{
 class Program
 {

  //public function visible from outside the class
  //void - Does not return any value

  public void SayHello()
  {
   Console.WriteLine("Hello ");
  }

  public int MyAge()
  {
   return 53;
  }


  static void Main(string[] args)
  {
   var t = new Program();
   t.SayHello();

   var age = t.MyAge();

   Console.WriteLine("David is {0} years old", age);

   //Displays console window and awaits key entry eg. Enter
   Console.ReadKey();

  }
 }
}

//function x-tics :
//access level - public private 
//return value - void or int
//Method name - sayhello()
