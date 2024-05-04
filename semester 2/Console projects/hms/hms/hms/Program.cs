using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hms.BL;
using hms.DL;
using hms.UI;

namespace hms
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            string adminOption = "";
                mUserDL.loadData();
                patientDL.loadPatientfromFile();
                doctorDL.loadDoctorfromFile();

            while (option < 5)
            {
                patientDL.sortPatient();
                doctorDL.sortDoctor();
                menuUI.clearScreen();
                menuUI.header();
                menuUI.clearScreen();
                menuUI.hms_header();
                option = UI.menuUI.menu();
                if(option == 1)
                {
                    string w = UI.mUserUI.signIn();
                    UI.menuUI.clearScreen();
                    if (w == "Admin")
                    {
                        while(true)
                        {
                           adminOption = UI.menuUI.Admin_menu();
                            if(adminOption == "1")
                            {
                            //    menuUI.clearScreen();
                                menuUI.header();
                                doctor obj = UI.doctorUI.addDoctors();
                                doctorDL.addDoctorinList(obj);
                                doctorDL.addDoctorinFile();
                                menuUI.clearScreen();
                            }
                            else if(adminOption == "2")
                            {
                               // menuUI.clearScreen();
                                menuUI.header();
                                doctorUI.viewDoctor();
                                menuUI.clearScreen();
                            }
                            else if(adminOption == "3")
                            {
                               // menuUI.clearScreen();
                                menuUI.header();
                                doctorUI.viewDoctor();
                                doctorDL.delete_doctor();
                                // DL.doctorDL.addDoctorinFile();
                                menuUI.clearScreen();
                            }
                            else if(adminOption == "4")
                            {
                               // menuUI.clearScreen();
                                menuUI.header();
                                doctorUI.viewDoctor();
                                doctorDL.update_doctor();
                                menuUI.clearScreen();
                            }
                            else if(adminOption == "5")
                            {
                             //   menuUI.clearScreen();
                                menuUI.header();
                                patientUI.viewPatient();
                                menuUI.clearScreen();
                            }
                            else if(adminOption == "6")
                            {
                           //     menuUI.clearScreen();
                                menuUI.header();
                                patientUI.viewPatient();
                                patientDL.deletePatient();
                                menuUI.clearScreen();
                            }
                            else if(adminOption == "7")
                            {
                                //menuUI.clearScreen();
                                menuUI.header();
                                patientUI.available_test();
                                menuUI.clearScreen();
                            }
                            else if(adminOption == "8")
                            {
                              //  menuUI.clearScreen();
                                menuUI.header();
                                 int index=0;
                                patientDL.viewAppointments(index);
                                menuUI.clearScreen();
                            }
                            else if(adminOption == "9")
                            {
                            //    menuUI.clearScreen();
                                menuUI.header();
                                doctorUI.view_instructions();
                                menuUI.clearScreen();
                            }
                            else if(adminOption == "10")
                            {
                                menuUI.clearScreen();
                                break;
                            }
                                patientDL.addPatientinFile();
                                doctorDL.addDoctorinFile();
                        }
                    }
                    else
                    {
                        menuUI.invalidUser();
                    }
                    menuUI.clearScreen();
                }
                else if(option == 2)
                {
                    string w = UI.mUserUI.signIn();
                    menuUI.clearScreen();
                    if(w == "Doctor")
                    {
                        while(true)
                        {
                            string doctorOption = UI.menuUI.Doctor_menu();
                            if(doctorOption == "1")
                            {
                                // menuUI. clearScreen();
                                 menuUI. header();
                                patient obj =
                                    patientUI. addPatient();
                                patientDL.addPatientinList(obj);
                                patientDL.addPatientinFile();
                                 menuUI. clearScreen();
                            }
                            else if(doctorOption == "2")
                            {
                              //   menuUI. clearScreen();
                                 menuUI. header();
                                 patientUI.viewPatient();
                                 menuUI. clearScreen();
                            }
                            else if(doctorOption == "3")
                            {
                             //   menuUI. clearScreen();
                                 menuUI. header();
                                patientDL.deletePatient();                                
                                 menuUI. clearScreen();
                            }
                            else if(doctorOption == "4")
                            {
                            //     menuUI. clearScreen();
                                 menuUI. header();
                                patientDL.searchPatientbyName();
                                 menuUI. clearScreen();
                            }
                            else if(doctorOption == "5")
                            {
                             //    menuUI. clearScreen();
                                 menuUI. header();
                                 doctorUI. prescription();
                                 menuUI. clearScreen();
                            }
                            else if(doctorOption == "6")
                            {
                           //      menuUI .clearScreen();
                                 menuUI. header();
                                int index = 0;
                                patientDL.viewAppointments(index);
                                 menuUI. clearScreen();
                            }
                            else if(doctorOption == "7")
                            {
                                // menuUI.clearScreen();
                                 menuUI.header();
                                 patientUI.available_test();
                                 menuUI.clearScreen();
                            }
                            else if(doctorOption == "8")
                            {
                              //   menuUI.clearScreen();
                                 menuUI.header();
                                 doctorUI.view_instructions();
                                 menuUI.clearScreen();
                            }
                            else if(doctorOption == "9")
                            {
                                 menuUI.clearScreen();
                                 menuUI.header();
                                break;
                            }
                            else
                            {
                                menuUI.invalidUser();
                            }
                        }
                    }
                    else
                    {
                        menuUI.invalidUser();
                    }
                }
                else if(option == 3)
                {
                    string w =  mUserUI.signIn();
                    UI.menuUI.clearScreen();
                    if (w == "Patient")
                    {
                        while (true)
                        {
                            string patientOption = menuUI.Patient_menu();
                            if (patientOption == "1")
                            {
                            //    menuUI.clearScreen();
                                menuUI.header();
                                patient obj = patientDL.bookAppointments();
                                int pat = 0;
                                patientDL.addAppointmentinList(obj, pat);
                                menuUI.clearScreen();
                            }
                            else if (patientOption == "2")
                            {
                               // menuUI.clearScreen();
                                menuUI.header();
                               int  idx = 0;
                                patientDL.viewAppointments(idx);
                                menuUI.clearScreen();
                            }
                            else if (patientOption == "3")
                            {//                              menuUI.clearScreen();
                                menuUI.header();
                                doctorUI.viewDoctor();
                                menuUI.clearScreen();
                            }
                            else if (patientOption == "4")
                            {
                       //        menuUI.clearScreen();
                               menuUI.header();
                               patientUI.viewRecord();
                               menuUI.clearScreen();
                            }
                            else if (patientOption == "5")
                            {
                     //          menuUI.clearScreen();
                               menuUI.header();
                               doctorUI.prescription();
                               menuUI.clearScreen();
                            }
                            else if (patientOption == "6")
                            {
                               menuUI.clearScreen();
                                break;
                            }
                            else
                            {
                                menuUI.invalidUser();
                            }
                        }
                    }
                    else
                    {
                        menuUI.invalidUser();
                    }
                }
                else if(option == 4)
                {
                   // menuUI.clearScreen();
                    menuUI.header();
                    doctorUI.view_instructions();
                    menuUI.clearScreen();
                }
            }
            Console.ReadKey();
        }
    }
}
