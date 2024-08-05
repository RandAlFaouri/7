internal class Program
{
    private static void Main(string[] args)
    {
        Demo d1 = new Demo();
        Demo.PrintEvens(new int[] {1,2,3,4,5,6,7,8,9});
        
        //var result = d1.IsEven(6);
    //    Console.WriteLine(result);

    //    d1.Promote(100, "Amman-Istanbul-Amman", "Kampenski 3days/2night ");
    }
        //int age;
        //var age = 18;
        // d1.DoSomething(ref age);
       // d1.DoSomething(out age);
        //Console.WriteLine(age);
        //var z = 100+ d1.DoSomething();//primary exp
      /*  var numString = "123456";
        int number;
        if (!int.TryParse(numString, out number))
        {
            Console.WriteLine("invalid number");

        }
        else
        {
            Console.WriteLine($"you provided a valid number");
        }
        Console.ReadKey();
    }*/
   
    public class Demo
    {
        public static void PrintEvens(int[] original)
        {
            foreach(var n in original)
            {
                if(isEven(n))
                    Console.WriteLine(n+" ");
            }
            bool isEven(int number) => number % 2 == 0;
           

        }
       
        /* public void Promote (double amount)
         {
             Console.WriteLine($"You've got a promotion of ${amount}");
         }
         public void Promote(double amount, string trip)
         {
             Console.WriteLine($"You've got a promotion of ${amount} and a trip {trip}");
         }
         public void Promote(double amount, string trip,string hotel)
         {
             Console.WriteLine($"You've got a promotion of ${amount} and a trip {trip} with {hotel} ");
         }*/
        /*  public void DoSomething(int x, double y)
          {
          }
          public void DoSomething( double y,int x) { 
          }*/
        /* public void DoSomething()
           {
               Console.WriteLine("Do something.....");
           }*/
        /* public int DoSomething(){
             var x = 100;

             return x*x;
             }*/
        /*  public void DoSomething(out int age)
           {
               age = 18;
               age = age + 3;
           }
       */
      //  public bool IsEven(int number) => number % 2 == 0;
      
    }
}