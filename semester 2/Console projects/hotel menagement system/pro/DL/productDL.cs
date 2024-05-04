using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pro.BL;
using System.IO;

namespace pro.DL
{
    class productDL
    {
        public static List<product> productlist =new List<product>();
        public static List<product> orderedlist = new List<product>();
        public static bool readFromFile(string path)
        {
            string record;
            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string productname = splittedRecord[0];
                    string productprice = splittedRecord[1];
                    product p = new product(productname, productprice);
                    productlist.Add(p);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void userestaurant(int num, int idx)
        {
            bool flag = false;
            for (int i = 0; i < num; i++)
            {
                while (true)
                {
                    product pd = new product();
                    pd = UI.productUI.nam();

                    foreach (product p in productlist)
                    {

                        if (p.productname == pd.productname)
                        {
                            flag = true;
                            orderedlist.Add(p);
                            break;

                        }
                    }
                    if (flag)
                    {
                        flag = false;
                        break;
                    }
                    else
                    {
                        flag = false;
                        Console.WriteLine("INVALID INPUT");
                        continue;
                    }
                }
                idx++;
            }
        }
        public static float paybill(ref float givendiscount, ref float result)
        {

            float total = 0;
            float s = 20.0f;
            float t = 100.0f;
            foreach (product p in productlist)
            {
                foreach (product pr in orderedlist)
                {
                    if (p.productname == pr.productname)
                    {
                        int a = 0;
                        a = int.Parse(p.productprice);
                        result = result + a;
                    }
                }
            }
            total = (result * s) / t;
            givendiscount = result - total;
            return givendiscount;
        }
        public static product isProductExists(string splittedRecordForProductdata)
        {

            foreach (product p in productlist)
            {
                if (p.productname == splittedRecordForProductdata)
                {
                    return p;
                }


            }
            return null;

        }
        public static void storeinfile(string path, product p)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(p.productname + "," + p.productprice);
            f.Flush();
            f.Close();
        }
    }
}
