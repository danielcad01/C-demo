



using System;

namespace  program.cs
{
  class Program
  {
     static int mymethod(int x, int y)
    {
         return x+y;
    }

     static void Main(string[] args)
     {
      
      //  int myInt = 10;
      // double myDouble = 5.25D;
      // float myfloat = 5.23F;
      // bool myBool = true;
      // long mylong = 245855565457454544L;
      // String myname = "dani";
      // char mychar = 'd';
      // String firstname = "daniel";
      // String lastname = "raj";
      // int x = 5+5;
      // int y = 10-15;
      // int z = 5/5;
      // int  g = 5%5;
      // int h = 6;
      // h++;
      // int j = 6;
      // j--;
      // int r =7;
     // r +=3;
     
      Console.WriteLine (mymethod(3,4));




      // Console.WriteLine(myInt);  
      // Console.WriteLine(myDouble);
      // Console.WriteLine(myfloat); 
      // Console.WriteLine(myBool);
      // Console.WriteLine(mylong);
      // Console.WriteLine(myname);
      // Console.WriteLine(mychar);
      // Console.WriteLine(x);
      // Console.WriteLine(y);
      // Console.WriteLine(z);
      // Console.WriteLine(g);
      // Console.WriteLine(h);
      // Console.WriteLine(j);
      // Console.WriteLine(r);
      // Console.WriteLine(Math.Max(10,5));
      // Console.WriteLine(Math.Min(10,5));
      // Console.WriteLine(Math.Sqrt(64));
      //Console.WriteLine(firstname + lastname);
        int x = 10;
      int y = 34;
      Console.WriteLine(x < y);

     int time=17;
      if (time<10)
      {
        Console.WriteLine("hi dani");
      }
      else if(time<16)
      {
        Console.WriteLine("hi aarif");
      }
     
      else if(time<18)
      {
        Console.WriteLine("hi nancy");

      }
       else if(time<23)
      {
        Console.WriteLine("hi pavi");

      }
      else
      {
         Console.WriteLine("hi alex");

      }
      int dani=30;
      String result = (dani<10) ? "go to the the hotel" : "go the tea shop";
      Console.WriteLine(result);

      String name="revi";
      switch(name)
      {
        case("dani"):
        Console.WriteLine("go to tea shop");
        break;
         case("aarif"):
        Console.WriteLine("go to hotel");
        break;
         case("nancy"):
        Console.WriteLine("go to school");
        break;
         case("pavi"):
        Console.WriteLine("go to college");
        break;
         case("alex"):
        Console.WriteLine("go to hospital");
        break;
         case("anjuka"):
        Console.WriteLine("go to gym");
        break;
        // defualt 
        //   Console.WriteLine("go to gym");
        //  break;

      }

      //  int i=0;
      //  while(i < 5)
      //  {
      //   Console.WriteLine("yes sir ok sir just sir");
      //   i++;
      //  }
      //  int j=5;
      //  while(i>0)
      //  {
      //   Console.WriteLine("nan rolex is all right ");
      //   i--;
      //  }
      //  for (int i =0;i <=10;i = i +1)
      //  {
      //   if (i==5)
      //   {
      //     continue;

      //   }
      //   Console.WriteLine("yes sir ok sir just sir nan rolex is all right");
      //  }


    
    //    mymethod("santhos",23);
    //    mymethod("praveen",24);
    //  mymethod("alex",24);
    //    mymethod("aarif" ,25);
    //    mymethod("nancy", 24);
    //    mymethod("pavi" ,22);
    Console.WriteLine(Math.Round(9.99));
     Console.WriteLine(Math.Max(10,5));
      Console.WriteLine(Math.Min(10,5));
     Console.WriteLine(Math.Sqrt(64));
      Console.WriteLine(Math.Abs(-4.7));  




    
    



      
    

     }
  }
}