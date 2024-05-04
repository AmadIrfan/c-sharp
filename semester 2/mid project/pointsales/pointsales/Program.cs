using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointsales.UI;
using pointsales.DL;
using pointsales.BL;

namespace pointsales
{
    class Program
    {
        static void Main(string[] args)
        {
           MuserDL.UserDatafromFile();
           ProductDL.ProductDataFromFile();
           CustomerDL.CustomerDataFromFile();
              Console.WriteLine("Data loaded");
                int option=0;
            while (option < 3)
            {
                menu.clearScreen();
                menu.LoginSinup();
                option = menu.consoleManu();
                if (option == 1)
                {
                    string role;
                    Muser temp;
                    temp = MuserUI.login();
                    role = MuserDL.CheckUser(temp);
                    Console.WriteLine(role);
                    menu.clearScreen();
                    if ( role == "admin") {
                              int ad_option =0;
                        do { 
                             ad_option= menu.adminManu();
                            if (ad_option == 1) {
                                Product temp1;
                                temp1 = ProductUI.NewProduct();
                                ProductDL.addProduct(temp1);
                            }
                            if (ad_option == 2) {
                                ProductUI.AllProduct(); 
                            }
                            if (ad_option == 3) 
                            {
                                ProductUI.highest_price();
                            }
                            if (ad_option == 4) {
                                ProductUI.totalTex();
                            }
                            if (ad_option == 5)
                            {
                                ProductUI.PrintAllOrdersProduct();
                            }
                            if (ad_option == 6) 
                            {
                                break;
                            }
                           }
                        while (ad_option==1|| ad_option == 2|| ad_option == 3|| ad_option == 4 || ad_option == 5 || ad_option == 6);
                        }
                    if (role == "user") {
                        int user_option = 0;
                        do
                        {
                            user_option= menu.custManu();
                            if(user_option == 1) {
                                ProductUI.AllProduct();
                            }
                            if(user_option == 2) 
                            {
                                Customer temp2;
                                bool status;
                                temp2=CustomerUI.BuyProduct();
                               status= CustomerDL.AddOrder(temp2);
                               CustomerUI.IsOrderd(status);
                            }
                            if(user_option == 3)
                            {
                               ProductUI.PrintAllOrdersProduct();
                               ProductUI.Printinvoice();
                            }
                            if(user_option == 4) { 
                                break;
                            }
                            ProductDL.ProductDataToFile();
                            CustomerDL.CustomerDataToFile();
                        }
                        while (user_option==1|| user_option == 2|| user_option == 3);
                    }
                }
                if (option == 2) 
                {
                    menu.Singin();
                    Muser temp2;
                    temp2 = MuserUI.signup();
                    MuserDL.AddUser(temp2);
                    menu.clearScreen();
                }
                 if(option == 3)
                 {
                    menu.clearScreen();
                    break;
                 }
                MuserDL.UserDataToFile();
            }
        }
    }
}  