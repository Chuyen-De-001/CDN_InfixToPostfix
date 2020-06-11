using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDN
{
    class Functions
    {
        static char taoToanTu(Random rand)
        {
            string listOperator = "+-*/";
            return listOperator[rand.Next(0, 4)];
        }

        static List<Entity.bracket> taoNgoac(Random rand, int lenght, int maxlenghtNgoac)
        {
            List<Entity.bracket> lst = new List<Entity.bracket>();
            int lenghtBanket = rand.Next(0, maxlenghtNgoac);// radom so ngoăc có trong da thức.
            for (int i = 0; i < lenghtBanket; i++)
            {
                int vstart = rand.Next(0, lenght - 2);
                int vend = rand.Next(2, lenght);
                if (vend - vstart > 0)
                {
                    lst.Add(new Entity.bracket(vstart, vend));
                }
            }
            return lst;

        }

        static List<int> taoLuythua(Random rand, int LenghtDathuc, int maxLenghtLuythua)
        {
            List<int> lst = new List<int>();
            int LenghtExponential = rand.Next(0, maxLenghtLuythua); // phải nhỏ hơn LenghtOperand;
            for (int i = 0; i < LenghtExponential; i++)
            {
                int vTri = rand.Next(0, LenghtDathuc);
                if (lst.Any(item => item == vTri) == false)
                {
                    lst.Add(vTri);
                }
            }
            return lst;
        }


        public string taoDathuc(int maxLenghtDathuc, int maxlenghtNgoac, int maxLenghtLuythua)
        {
            Random rand = new Random();
            string dathu = "";
            string listOperand = "abcdefghimnopqrstuvwxyz";
            int IndexOperand = 0;
            int LenghtDathuc = rand.Next(2, maxLenghtDathuc); //radom độ dài đa thức.
            if(LenghtDathuc == 2)
            {
                dathu += "a";
                dathu += taoToanTu(rand);
                dathu += "b";
            }
            else
            {
                List<int> lstExponential = taoLuythua(rand, LenghtDathuc, maxLenghtLuythua);
                List<Entity.bracket> lst = taoNgoac(rand, LenghtDathuc, maxlenghtNgoac);
                for (int i = 0; i < LenghtDathuc; i++)
                {
                    foreach (Entity.bracket item in lst)
                    {
                        if (item.vStart == i) { dathu += "("; }
                    }
                    /*                    if(IndexOperand < 23)
                                        {
                                            dathu += listOperand[IndexOperand];
                                            IndexOperand++;
                                        }
                                        else
                                        {
                                            IndexOperand = 0;
                                            dathu += listOperand[IndexOperand];
                                            IndexOperand++;
                                        }*/
                    dathu += listOperand[i % 23];
                    if (lstExponential.Any(item => item == i)) { dathu += "^" + rand.Next(2, 10); }
                    foreach (Entity.bracket item in lst)
                    {
                        if (item.vEnd == i) { dathu += ")"; }
                    }
                    if (i != LenghtDathuc - 1)
                    {
                        dathu += taoToanTu(rand);
                    }
                }
            }

            return dathu;
        }

    }
}
