using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pro.BL;

namespace pro.UI
{
    class productUI
    {
        public static string customerpathforproducts = "customer information for products.txt";
        public static float givendiscount2;
        // function for showing the items
        public static void show()
        {
            for (int i = 0; i < DL.productDL.productlist.Count; i++)
            {
                Console.WriteLine(DL.productDL.productlist[i].productname + "..........................." + DL.productDL.productlist[i].productprice);
            }
        }
        public static int outp(int n)
        {

            Console.WriteLine("So dear customer we have the following things available................");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("How many things you want to order: ");
            n = int.Parse(Console.ReadLine());
            return n;
        }
        public static void opp()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Thanks for your order..............");
        }
        public static product nam()
        {
            string name;
            Console.WriteLine("Please enter the item: ");
            name = Console.ReadLine();
            product p = new product(name);
            return p;
        }
        // function to  use the hotel restaurant online as a customer
        public static void useres()
        {
            customer c = new customer();
            c = UI.customerUI.restaurant();
            int n = 0, num = 0;
            int idx = 0;
            show();
            num = outp(n);
            DL.productDL.userestaurant(num, idx);
            DL.customerDL.storeorderedproductsinformation(customerpathforproducts, c);
            opp();
        }
        // function to take discount on restaurant items as a customer
        public static void takediscount()
        {
            int wanteddiscount;
            Console.WriteLine("How much discount you want: \n");
            Console.WriteLine("Enter the percentage: ");
            wanteddiscount = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n");
            Console.WriteLine("We hope that you will get a discount dear..............");
        }
        public static void pay(float givendiscount, float result)
        {
            DL.productDL.paybill(ref givendiscount, ref result);
            Console.WriteLine("\nSo! Dear customer your total bill was: " + result + "\n");
            Console.WriteLine("And the bill after the discount is: " + givendiscount);
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("                                         CONGRAGULATIONS\n");
            Console.WriteLine("For the new discounted price...........");
            Console.WriteLine("You only have to pay: " + givendiscount);
            givendiscount2 = givendiscount;
        }
        // function to pay the bill for the restaurant items as a customer
        public static void paybillres(float givendiscount, float result)
        {
            pay(givendiscount, result);
        }
        // function to see the things that are sailed
        public static void seepurchases()
        {
            Console.WriteLine("\n\nThe sailed items are the following.................\n");
            for (int i = 0; i < DL.productDL.orderedlist.Count; i++)
            {
                Console.WriteLine(DL.productDL.orderedlist[i].productname);
            }
        }
        // function to calculate the profit and loss
        public static void calculateprofitloss()
        {
            float costprice, saleprice, cong;
            Console.WriteLine("Enter the cost price of the item: ");
            costprice = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the saleprice of the item: ");
            saleprice = float.Parse(Console.ReadLine());
            cong = saleprice - costprice;
            if (saleprice > costprice)
            {
                Console.WriteLine("Your total profit is:" + cong);
                Console.WriteLine("Congragulations");
            }
            else if (costprice > saleprice)
            {
                Console.WriteLine("Your total loss is:" + cong);
                Console.WriteLine("Don't be sad........................");
            }
        }
        // function to see the price you have received after giving the discount to the customer
        public static void pricereceivedafterdisc(float givendiscount)
        {
            Console.WriteLine("The bill you have received after giving the discount is: " + givendiscount);
        }
       

    }
}
