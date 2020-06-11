using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDN
{
    class ExprHelper
    {
        public string FormatExpression(string expression)
        {
            string result = "";
            foreach(char item in expression) {
                result += item + " ";
            }
            return result;
        }
        public bool IsHangTu(string exp)
        {
            String Listtoanhang = "abcdefghimnopqrstuvwxyz1234567890";
            if(Listtoanhang.IndexOf(exp) >= 0)
            {
                return true;
            }
            return false;
        }
        public bool IsToanTu(string exp)
        {
            String ListToanTu = "+-*/^";
            if (ListToanTu.IndexOf(exp) >= 0)
            {
                return true;
            }
            return false;
        }

    }
}
