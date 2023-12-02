using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class GenericDictionary<Tkey,Tvalue> {

        public void Offer(Tkey key,Tvalue value) { 
        
        }
    }


    class Generic<T>
    {
        public void Add(T value) { }
    }
    internal class Program
    {
        private const int Arg2 = 20;

        static void Main(string[] args)
        {
          List<string> list = new List<string>();

            //while (true)
            //{
            //   var user=Console.ReadLine();
            //    if (String.IsNullOrEmpty(user)) {

            //        break;
            //    }
            //    list.Add(user);

            //    }
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //var store = list.Count;


            //if (store == 1)
            //{
            //    Console.WriteLine("Your Friend " + list[0] + " Like Your Post");
            //}
            //else if (store == 2)
            //{
            //    Console.WriteLine("Your Friend " + list[0] + " " + list[1] + " Like Your Post");
            //}
            //else
            //{
            //    Console.WriteLine("No one like your post");
            //}


            //var user = Console.ReadLine();
            //for (int i = user.Length-1;i>=0;i--)
            //{
            //    Console.Write(user[i]);
            //}
            //Console.WriteLine();

            //var stopWatch = new StopWatch();
            //Console.WriteLine("Press \'start\' to Start the StopWatch");
            //var user=Console.ReadLine();
            //if(user =="start") {
            //stopWatch.StartTime();

            //}
            //Console.WriteLine("Press \'stop\' to Stop the StopWatch");
            //var user1=Console.ReadLine();
            //if(user1=="stop") {
            //    stopWatch.StopTime();
            //}
            //Console.WriteLine("Total Duration: "+stopWatch.GetInterval());

            //Stack stack= new Stack();
            //while (true)
            //{
            //    var user=Console.ReadLine();
            //    if (String.IsNullOrEmpty(user))
            //    {
            //        break;
            //    }
            //    stack.Push(user);

            //}
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Enter \'Pop\' to Pop the Elements");
            //var user1=Console.ReadLine();
            //if(user1=="pop" ||user1=="Pop")
            //{ 
            //    stack.Pop();
            //}
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //var work = new WorkFlow();
            //work.Add(new Video());
            //work.Add(new Webservice());
            //work.Add(new Email());

            //var engine = new WorkFlowEngine();
            //engine.run(work);

            //var ger=new Generic<int>();
            //ger.Add(1);

            //var dictionary = new GenericDictionary<string, int>();
            //dictionary.Offer("jeet",1);

            
            Func<int,int>mul=x=>x*x;
            Console.WriteLine(mul(5));

            const int num = 5;
            Func<int, int> Factotial = s => s * num;
            Console.WriteLine(Factotial(10));

            Func<int, int,int> Sum = (a, b) => a + b;
            Console.WriteLine(Sum(10,10));








        }
        
    }
}
