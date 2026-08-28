namespace ConsoleApp1
{
    static class ExecutionMethodHelper
    {
        public static void MyWhere(this List<int> list, Func<int, bool> filter)
        {

            foreach (var i in list)
            {
                if (filter(i))
                {
                    Console.WriteLine(i);
                }
            }

        }
        public static void MyTake(this List<int> list, int count)
        {
            int condition = 0;
            foreach (var i in list)
            {
                if (condition < count)
                {
                    Console.WriteLine(i);
                }
                condition++;
            }

        }

        public static void MySkip(this List<int> list, int count)
        {
            int condition = 0;
            foreach (var i in list)
            {
                if (condition >= count)
                {
                    Console.WriteLine(i);
                }
                condition++;
            }
        }

        public static void MyTakeWhile(this List<int> list, Func<int, bool> filter)
        {
            foreach (var i in list)
            {
                if (filter(i))
                {
                    Console.WriteLine(i);
                }
                else break;
            }
        }
        public static void MySkipWhile(this List<int>list, Func<int, bool> filter)
        { 
            bool flag = true;
            foreach (var i in list)
            {
                if (flag && filter(i))
                {
                    continue;
                }
                flag = false;
                Console.WriteLine(i);
            }


        }

        public static void MyFirst(this List<int> list) {
            if (list.Count > 0)
            {

                Console.WriteLine(list[0]);
                return;
                
            }
            else throw new Exception();
        }
        public static void MyLast(this List<int> list)
        {
            if (list.Count > 0)
            {
                int cnt = list.Count - 1;

                Console.WriteLine(list[cnt]);
                return;

            }
            else throw new Exception();
        }

        public static void MyMax(this List<int> list)
        {
            if (list.Count == 0) throw new Exception();
            int temp = list[0];
            foreach(var i in list)
            {
                if(i > temp)
                {
                    temp = i;
                }
            }
            Console.WriteLine(temp);
        }

        public static void MyMin(this List<int> list)
        {
            int temp = 0;
            foreach (var i in list)
            {
                if (i < temp)
                {
                    temp = i;
                }
            }
            Console.WriteLine(temp);
        }

        public static void MySum(this List<int> list)
        {
            int temp = 0;
            foreach (var i in list)
            {
                temp += i;
            }
            Console.WriteLine(temp);
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                List<int> list = new List<int> { 1,2,3,66,4,5,6,7,-3,9,10};
                //list.MyWhere(e=>e>5);
                //list.MyTake(5);
                //list.MySkip(5);
                //list.MyTakeWhile(e=>e>5);
                //list.MySkipWhile(e=>e>5);
                //list.MyLast();
                //list.MyFirst();
                //list.MyMax();
                //list.MyMin();
                list.MySum();

            }
        }
    }
}
