using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class HugeInteger
    {
        private int[] NumArray = new int[40];

        public int[] GetNumber()
        {
            return NumArray;
        }


        public char Sign = '+';

        private int i = 39;

        public HugeInteger()
        {
            new HugeInteger("0");
        }

        public HugeInteger(string number)
        {

            int index = number.IndexOf("-", 0, 1);

            if (index >= 0)
            {
                Sign = '-';
            }

            

            char[] charNumArray = number.ToCharArray();

            Array.Reverse(charNumArray);

            if (charNumArray.Length <= 40 && charNumArray.Length >= 1)
            {
                foreach (char c in charNumArray)
                {
                    int num = (int)char.GetNumericValue(c);
                    if (num != -1)
                    {
                        if (Sign == '-')
                        {
                            NumArray[i] = -num;

                        }
                        else if (Sign == '+')
                        {
                            NumArray[i] = num;
                        }
                        i--;

                    }

                }


            }
            else
            {
                Console.WriteLine("Entered number is greater than range");
            }

        }

        public bool Equals(HugeInteger hugeInteger)
        {
            int a = CompareTo(hugeInteger);

            if (a == 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool IsGreaterThan(HugeInteger hugeInteger)
        {
            int a = CompareTo(hugeInteger);


            if (a == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsLessThan(HugeInteger hugeInteger)
        {
            int a = CompareTo(hugeInteger);

            if (a == -1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private int CompareTo(HugeInteger hugeInteger)
        {

            //hugeInteger1
            int[] hugeInteger1 = NumArray;

            int indexHugeInteger1 = -1;

            for (int i = 0; i < hugeInteger1.Length; i++)
            {
                if (hugeInteger1[i] != 0)
                {
                    indexHugeInteger1 = i;
                    break;
                }
            }

            int lengthHugeInteger1 = 0;// length pure number in hugeInteger1. exapale : no->0000000000000123 , yes-> 123
            if (indexHugeInteger1 >= 0)
            {
                lengthHugeInteger1 = hugeInteger1.Length - indexHugeInteger1;
            }
            //----------------------------------------------


            //hugeInteger2
            int[] hugeInteger2 = hugeInteger.GetNumber();

            int indexHugeInteger2 = -1;

            for (int i = 0; i < hugeInteger2.Length; i++)
            {
                if (hugeInteger2[i] != 0)
                {
                    indexHugeInteger2 = i;
                    break;
                }
            }

            int lengthHugeInteger2 = 0;
            if (indexHugeInteger2 >= 0)
            {
                lengthHugeInteger2 = hugeInteger2.Length - indexHugeInteger2;
            }
            //----------------------------------------------


            if (lengthHugeInteger1 > lengthHugeInteger2)
            {
                if (Sign == '+')
                {
                    return 1;
                }
                else if (Sign == '-')
                {
                    return -1;
                }

            }
            else if (lengthHugeInteger1 < lengthHugeInteger2)
            {
                if (Sign == '+')
                {
                    return -1;
                }
                else if (Sign == '-')
                {
                    return +1;
                }

            }
            else if (indexHugeInteger1 >= 0)
            {
                //if Length Equal :
                for (int i = indexHugeInteger1; i < hugeInteger1.Length; i++)
                {

                    if (hugeInteger1[i] > hugeInteger2[i])
                    {
                        return 1;
                    }
                    else if (hugeInteger1[i] < hugeInteger2[i])
                    {
                        return -1;
                    }

                }

            }

            return 0;


        }
        public override string ToString()
        {
            string result = string.Join("", NumArray);
            return string.Format("Number : {0}", result);

        }


    }
}
