using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace LinqSession
{
    class Program
    {
        static void Main(string[] args)
        {
            Action Lambda = () => { Console.WriteLine("Hello"); };
            Action<string> Lambda2 = (msg) => { Console.WriteLine(msg); };
            Action<string,bool> Lambda3 = (msg,canPrint) => { Console.WriteLine(msg); };//Action is used when we dont have to return anything.
            Func<string,string> Lambda4 = (name) => { return "Hello" + name; };//Function is used only when we have to return something.
            Func<byte, bool> Lambda5 = (age) => { return age >= 18; };
            Predicate<byte> lammbda6= (age) => { return age >= 18; };//In predicate and wedont have to mention bool//whenever using a predicate it should always return boolean
            /*simplified*/
            Action<string> Lambdasim2 = msg =>  Console.WriteLine(msg);//if there is only one parameter we dont have to give brackets and same for single line statement
            Func<byte, bool> Lambdasim5 = age => age >= 18;
            /*calling the lambda epx*/
            Lambda2("Keerthi");
            Func<int, int, double> multiply = (x,y)=>x * y;
            //public static double multiply(int x,int y)
            // {
            //     return x * y;
            // }
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
            list1.OrderBy(x => x);//to arrange it in a order we use orderby
            Func<int, bool> isEven = i => i % 2 == 0;
            var result = list1.Where(isEven);
            //Func<int,bool>Predicate
            //var result=list1.Where(i => i % 2 == 0);
            var res2 = list1.First();
            var res = list1.First(x => x < 0);//if this condition is not satisfied it will throw an error...inorder to prevent this we go with FirstOrDefault
            var res1 = list1.FirstOrDefault(x => x < 0);
            //1*2 + 2*2 + 3*2 + 4*2 + 5*2
            var res3 = list1.Sum(x=>x*2);
            //github
            var res6 = list1.Select(x => (x * 2).ToString()).ToList();//it will get a one type of input and can display as anyother type.
            //Single() and SingleOrDefault
            bool anyoneless =list1.Any(x => x.weight < 50);







        }
    }
}