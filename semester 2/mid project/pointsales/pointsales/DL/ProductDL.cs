using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointsales.BL;
using pointsales.UI;
using System.IO;

namespace pointsales.DL
{
    class ProductDL
    {
        public static List<Product> products = new List<Product>();
        public static void addProduct(Product temp)
        {
            products.Add(temp);
        }
        public static int HeigestPrice()
        {
            int max = 0;
            int index = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].price > max)
                {
                    max = products[i].price;
                    index = i;
                }
            }
            return index;
        }
        public static int CalculateTax()
        {
            int tax, sum = 0;
            foreach (Product i in products)
            {
                if (i.type == "fruit")
                {
                    tax = ((i.price * 5 / 100) * i.quantity);
                    sum = sum + tax;
                }
                if (i.type == "Grocery")
                {
                    tax = ((i.price * 10 / 100) * i.quantity);
                    sum = sum + tax;
                }
                else
                {
                    tax = ((i.price * 15 / 100) * i.quantity);
                    sum = sum + tax;
                }
            }
            return sum;
        }
        public static int calculateTax(string type, int price, int quantity)
        {
            int sum = 0, tax = 0;
            if (type == "fruit")
            {
                tax = ((price * 5 / 100) * quantity);
                sum = sum + tax;
            }
            if (type == "Grocery")
            {
                tax = ((price * 10 / 100) * quantity);
                sum = sum + tax;
            }
            else
            {
                tax = ((price * 15 / 100) * quantity);
                sum = sum + tax;
            }
            return sum;
        }

        public static void ProductDataToFile()
        {
            string path = "product.txt";
            StreamWriter file = new StreamWriter(path, false);
            foreach (Product i in products)
            {
                file.WriteLine(i.name + "," + i.type + "," + i.price + "," + i.quantity);
            }
            file.Flush();
            file.Close();
        }
        public static void ProductDataFromFile()
        {
            string path = "product.txt";
            StreamReader file = new StreamReader(path);
            if (File.Exists(path))
            {
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string type = splittedRecord[1];
                    int price =int.Parse(splittedRecord[2]);
                    int Quantity =int.Parse(splittedRecord[3]);
                    //int subjectFees = int.Parse(splittedRecord[3]);
                    Product p = new Product(name, type,price,Quantity);
                    addProduct(p);
                }
            }
                file.Close();
        } 
    }
}
