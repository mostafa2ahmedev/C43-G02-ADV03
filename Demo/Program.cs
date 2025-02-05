

namespace Demo
{
    internal class Program
    {

        #region Q1)	Given a Queue, implement a function to reverse the elements of a queue using a stack.

        //public static void ReverseQueueElementsUsingStack( Queue<int> passedQueue)
        //{
        //    Stack<int> stack = new Stack<int>();
        //    int count = passedQueue.Count;

        //    for (int i = 0; i < count; i++)
        //    {

        //        passedQueue.TryDequeue(out int item);
        //        stack.Push(item);

        //    }
        //    count = stack.Count;

        //    for (int i = 0; i < count; i++)
        //    {
        //        stack.TryPop(out int value);
        //        passedQueue.Enqueue(value);

        //    }

        //}


        #endregion

        #region Q2).	Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
        public static bool checkPair(char top,char charactar) {

            if (top == '(' && charactar == ')') return true;
            else if (top == '{' && charactar == '}') return true;
            else if (top == '[' && charactar == ']') return true;
            return false;
        
        
        }
        public static string IsBalanced(string s) {

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {

                    stack.Push(s[i]);

                }
                else if (s[i]==')' || s[i] == '}' || s[i]==']') {

                    if (stack.Count == 0 || !checkPair(stack.Peek(), s[i])) {
                        return "Not Balanced";
                    }
                    stack.Pop();
                }

            }


            return "Balanced";
        }


        #endregion
        static void Main(string[] args)
        {
            #region Q1)	Given a Queue, implement a function to reverse the elements of a queue using a stack.
            //Queue<int> queue = new Queue<int>();

            //for (int i = 0; i < 5; i++)
            //{
            //    queue.Enqueue(i+1);
            //}



            //Console.WriteLine("***********");


            //ReverseQueueElementsUsingStack(queue);

            //int count = queue.Count;

            //for (int i = 0; i < count; i++) 
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            #endregion

            #region Q2).	Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
            Console.WriteLine(IsBalanced("[()]{}"));
            #endregion
        }
    }
}
