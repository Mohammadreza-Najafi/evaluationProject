using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    class ConcurrentIntegerList
    {
        private static object lockObject = new object();

        List<int> NumberList = new List<int>();
     
        public ConcurrentIntegerList(List<int> number)
        {
            lock (lockObject)
            {
                NumberList = number;
            }

        }

        public void Add(int num)
        {
            lock (lockObject)
            {
                NumberList.Add(num);
            }

        }

        public int this[int index]
        {

            get
            {
                lock (lockObject)
                {
                    if (index >= 0 && index < NumberList.Count)
                        return NumberList[index];
                    else
                       return 0;
                }
            }


            set
            {
                lock (lockObject)
                {
                    if (index >= 0 && index < NumberList.Count)
                        NumberList[index] = value;
                    else
                        throw new IndexOutOfRangeException();
                }
            }
        }

        public override string ToString()
        {
            string result = string.Join(", ", NumberList);
            return result;
        }
    }
}
