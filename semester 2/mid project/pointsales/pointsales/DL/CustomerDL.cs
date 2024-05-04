using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointsales.BL;
using System.IO;
namespace pointsales.DL
{
    class CustomerDL
    {
        public static List<Customer> customer = new List<Customer>();
        public static bool AddOrder(Customer temp)
        {
            for(int x=0;x<ProductDL.products.Count; x++)
            {
                if (temp.name == ProductDL.products[x].name)
                {
                    customer.Add(temp);
                    ProductDL.products[x].quantity = ProductDL.products[x].quantity - temp.Quentity;
                    return true;
                }
            }
            return false;
        }
        public static void CustomerDataToFile() 
        {
            string path = "Customer.txt";
            StreamWriter file = new StreamWriter(path,false);
            foreach(Customer i in customer)
            {
                file.WriteLine(i.name+","+ i.Quentity);
            }
            file.Flush();
            file.Close();
        }
        public static void CustomerDataFromFile()
        {
            string path = "Customer.txt";
            StreamReader file = new StreamReader(path);
            if (File.Exists(path)) {
                string record;
                while ((record = file.ReadLine()) != null) { 
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    int quantity =int.Parse( splittedRecord[1]);
                    Customer c = new Customer(name,quantity);
                    AddOrder(c);
                }
            }
            file.Close();
        } 

    }
}
