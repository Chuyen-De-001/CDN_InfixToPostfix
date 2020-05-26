using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDN.Entity
{
    class Array
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
        public String InfixToPostfix(string Infix)
        {
            String Listtoanhang = "abcdefghimnopqrstuvwxyz1234567890";
            String ListToanTu = "+-*/^";
            char[] arrStack = new char[50];
            int dem = 0;
            String Postfix = "";
            for (int i = 0; i < Infix.Length; i++)
            {
                if (Listtoanhang.IndexOf(Infix[i]) >= 0)
                {
                    Postfix += Infix[i];
                }
                else if (ListToanTu.IndexOf(Infix[i]) >= 0)
                {
                    if (dem == 0)
                    {
                        arrStack[dem] = Infix[i];
                        dem++;
                    }
                    else
                    {
                        arrStack[dem] = Infix[i];
                        dem++;
                        while (getdoUutien(arrStack[dem - 1]) <= getdoUutien(arrStack[dem - 2]))
                        {
                            Postfix += arrStack[dem - 2];
                            arrStack[dem - 2] = arrStack[dem - 1];
                            arrStack[dem - 1] = '\0';
                            dem--;
                            if (dem == 1) { break; }
                        }
                    }
                }
                else if (Infix[i] == '(')
                {
                    arrStack[dem] = Infix[i];
                    dem++;
                }
                else if (Infix[i] == ')')
                {
                    for (int j = dem - 1; j >= 0; j--)
                    {
                        if (arrStack[j] != '(')
                        {
                            Postfix += arrStack[j];
                            arrStack[j] = '\0';
                            dem--;
                        }
                        else
                        {
                            arrStack[j] = '\0';
                            dem--;
                        }
                    }
                }
                Debug.WriteLine(Postfix);
                if (i == Infix.Length - 1)
                {
                    Debug.Write("dem: " + dem);
                    for (int j = dem - 1; j >= 0; j--)
                    {
                        Postfix += arrStack[j];
                    }
                }
            }


            return Postfix;
        }
    }
}
