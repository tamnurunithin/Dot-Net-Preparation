📂 Day-7_Practice_Problems
1. Practice Problems
You’ll create small, focused C# programs for each concept.

Problem 1: Single Inheritance

using System;
class Program{
static void Main(){
Dog mydog= new Dog();
mydog.sound();
mydog.voice();

}
class Animal{
   public void sound()=>Console.writeLine("Animal sounds");
}
class Dog: Animal{
   public void voice()=>Console.writeLine("Dog barks");
}
output:
Animal sounds
Dog barks


Problem 2: Method Overloading

using System;
class Program{
static void Main(){
Calculator c1= new Calculator(2,3);
Calculator c2= new Calculator(2.23,3.25);
Calculator c3= new Calculator(2,3,4);
  }
}
class Calculator{
public int add(int a,int b)=>a+b;
public double add(double a,double b)=>a+b;
public int add(int a,int b,int c)=>a+b+c;
}
output:
5
5.43
9


Problem 3: Method Overriding

using System;
class Program{
static void Main(){
Animal a = new Cat();
      a.sound();
  }
}
class Animal{
public void sound()=>Console.WriteLine(" animals sounds");
}
class Dog: Animal{
public void sound()=>Console.WriteLine("dogs bark");
}
class Cat: Animal{
public void sound()=>Console.WriteLine("cats meow");
}
output:
cats meow






















