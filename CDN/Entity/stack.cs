using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDN.Entity
{
    class stack
    {
        public int getdoUutien(char toantu)
        {
            int douutien = -1;
            switch (toantu)
            {
                case '+':
                    {
                        douutien = 1;
                        break;
                    }
                case '-':
                    {
                        douutien = 1;
                        break;
                    }
                case '*':
                    {
                        douutien = 2;
                        break;
                    }
                case '/':
                    {
                        douutien = 2;
                        break;
                    }
                case '^':
                    {
                        douutien = 3;
                        break;
                    }
            }
            return douutien;
        }
        public string InfixToPostfix(string infix)
        {
            String postfix = "";
            String Listtoanhang = "abcdefghimnopqrstuvwxyz1234567890";
            String ListToanTu = "+-*/^";
            Stack<char> stack = new Stack<char>();
            foreach (char item in infix)
            {
                if (Listtoanhang.IndexOf(item) >= 0)
                {
                    postfix += item;
                }
                else if (ListToanTu.IndexOf(item) >= 0)
                {

                    if (stack.Count == 0)
                    {
                        stack.Push(item);
                    }
                    else
                    {
                        if (getdoUutien(stack.Peek()) < getdoUutien(item) || stack.Peek() == '(')
                        {
                            stack.Push(item);
                        }
                        else
                        {
                            while (getdoUutien(stack.Peek()) >= getdoUutien(item))
                            {
                                if (stack.Count == 1)
                                {
                                    postfix += stack.Pop();
                                    stack.Push(item);
                                    break;
                                }
                                else
                                {
                                    postfix += stack.Pop();
                                    if (getdoUutien(stack.Peek()) < getdoUutien(item))
                                    {
                                        stack.Push(item);
                                        break;
                                    }
                                }

                            }
                        }


                    }
                }
                else if (item == '(')
                {
                    stack.Push(item);
                }
                else if (item == ')')
                {
                    while (stack.Peek() != '(')
                    {
                        postfix += stack.Pop();

                    }
                    stack.Pop();
                }

            }
            while (stack.Count > 0)
            {
                 if (stack.Peek() != '(')
                 {
                    postfix += stack.Pop();
                }
                else { stack.Pop(); }
                
 
            }


            return postfix;

        }
    }
}
