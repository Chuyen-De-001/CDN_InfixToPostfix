using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDN
{
    class IOFile
    {
        public bool ghiFileSetting(String str)
        {
            String dirPath = "../../Setting.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(dirPath))
                {
                    sw.WriteLine(str);
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }

/*        public bool ghiFileSetting(List<>)
        {
            String dirPath = "../../Setting.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(dirPath))
                {
                    sw.WriteLine(str);
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }*/

        public String docFileSetting()
        {
            String dirPath = "../../Setting.txt";
           if (System.IO.File.Exists(dirPath))
            {
                using (StreamReader sr = new StreamReader(dirPath))
                {
                    string line = "";
                    line = sr.ReadLine();
                    return line;
                }
            }
            else
            {
                File.CreateText(dirPath);
                Debug.Write("chưa có file. Đã tạo file");
                
            }
            return "";
        }
    }
}
