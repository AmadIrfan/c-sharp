using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointofsale.UI;
using pointofsale.DL;
using pointofsale.BL;

namespace pointofsale
{
    class Program
    {
        static void Main(string[] args)
        {
            int option=0;
            while (option < 3)
            {
                manu.clearScreen();
                 manu.LoginSinup();
                option = manu.consoleManu();
                if (option == 1)
                {
                    string role;
                    Muser temp;
                    temp=MuserUI.signup();

                   role=MuserDL.checkUser(temp);
                    Console.WriteLine(role);
                   manu.clearScreen();
                    /*if ( role == "admin") {
                              int ad_option =0;
                        do { 
                             ad_option= manu.adminManu();
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
                            { }
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
                            user_option= manu.custManu();
                            if(user_option == 1) {
                                ProductUI.AllProduct();
                            }
                            if(user_option == 2) 
                            {
                                Customer temp2;
                                temp2=CustomerUI.BuyProduct();
                                CustomerDL.AddOrder(temp2);
                            }
                            if(user_option == 3) { }
                            if(user_option == 4) { 
                                break;
                            }
                        }
                        while (user_option==1|| user_option == 2|| user_option == 3);
                    }*/
                }
                if (option == 2)
                {
                    manu.Singin();
                    Muser temp;
                    temp = MuserUI.signup();
                    MuserDL.AddUser(temp);
                    manu.clearScreen();
                }
                if (option == 3)
                {
                    break;
                }
            }
         
        }
    }
}
