using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Practice4
{
    class Program
    {
       
        static void Main(string[] args)
        {
         
            List<int> listNum = new List<int>();

            Task[] tasks = new Task[12];

            listNum.Add(10);
            listNum.Add(20);

            ConcurrentIntegerList temp = new ConcurrentIntegerList(listNum);


            tasks[0] = Task.Run(() => { temp.Add(120);});
            tasks[1] = Task.Run(() => { temp.Add(100);});
            tasks[2] = Task.Run(() => { temp.Add(30); });
            tasks[3] = Task.Run(() => { temp.Add(40); });
            tasks[4] = Task.Run(() => { temp.Add(50); });
            tasks[5] = Task.Run(() => { temp.Add(60); });
            tasks[6] = Task.Run(() => { temp.Add(70); });
            tasks[7] = Task.Run(() => { temp.Add(80); });
            tasks[8] = Task.Run(() => { temp.Add(90); });


            tasks[9] = Task.Run(() => { Console.WriteLine(temp); });

            tasks[10] = Task.Run(() => { Console.WriteLine(temp[1]); });
            tasks[11] = Task.Run(() => { Console.WriteLine(temp[8]); });

            Task.WaitAll(tasks);

            Console.WriteLine("After Task Wait:");

            Console.WriteLine(temp);
     
            Console.ReadKey();
        }

        
    }
}
