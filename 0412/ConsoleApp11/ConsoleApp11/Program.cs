using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp11
{
       public interface Stack
    {
        Boolean isEmpty();
        void Push(char item);
        char Pop();
        void Delete();
        char Peek();
    }

    public class StackNode
    {
        public char data;
        public StackNode link;
    }

    public class LinkedStack : Stack
    {
        private StackNode top;

        public Boolean isEmpty()
        {
            return (top == null);
        }

        public void Push(char item)
        {
            StackNode newNode = new StackNode();
            newNode.data = item;
            newNode.link = top;
            top = newNode;
            //
        }

        public char Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Deleting fail! Linked Stack is empty!!");
                return (char)0;
            }
            else
            {
                char item = top.data;
                top = top.link;
                return item;
            }
        }

        public void Delete()
        {
            if (isEmpty())
            {
                Console.WriteLine("Deleting fail! Linked Stack is empty!!");
            }
            else
            {
                top = top.link;
            }
        }

        public char Peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Deleting fail! Linked Stack is empty!!");
                return (char)0;
            }
            else
                return top.data;
        }

        public char printStack()
        {
            if (isEmpty())
            {
                Console.WriteLine("Deleting fail! Linked Stack is empty!!");
                return (char) 0;
            }
            else
                return top.data;
        }

    }

    public class OptExp
    {
        private String exp;
        private int expSize;
        private char testCh, openPair;

        public Boolean testPair(String exp)
        {
            this.exp = exp;
            LinkedStack S = new LinkedStack();
            expSize = this.exp.Length;
            for (int i = 0; i < expSize; i++)
            {
                testCh = this.exp[i];
                switch (testCh)
                {
                    case '(':
                    case '{':
                    case '[':
                        S.Push(testCh);
                        break;
                    case ')':
                    case '}':
                    case ']':
                        if (S.isEmpty())
                            return false;
                        else
                        {
                            openPair = S.Pop();
                            if ((openPair == '(' && testCh != ')') || (openPair == '{' && testCh != '}')
                                    || (openPair == '[' && testCh != ']'))
                                return false;
                            else
                                break;
                        }
                }
            }

            if (S.isEmpty())
                return true;
            else
                return false;
        }
    }



        internal class Program
        {
            static void Main(string[] args)
            {
                OptExp opt = new OptExp();
                String exp = "(3*5)-6/2)";

               Console.WriteLine(exp);

                if (opt.testPair(exp))
                    Console.WriteLine("괄호 맞음!!");

                 else
                    Console.WriteLine("괄호 틀림!!");
            }
        }
}
