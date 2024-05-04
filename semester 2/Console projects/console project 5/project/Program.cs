using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using project.MataData.BL;

namespace project
{
	class Program
	{
		//public string uname;
		//public string password;
		//public string username;
		//public string userpass;
		//public static int number = 0;
		static void Main(string[] args)
		{
			List<admin_data> Admindetail = new List<admin_data>();
			List<cars_data> carsdetail = new List<cars_data>();
			List<user_data> userdetail = new List<user_data>();
			int input = 0;
			while (input < 5)
			{
				input = main_manu();
				if (input == 1)
				{
					int user_input = 0;
					while (user_input < 3)
					{
						counter();
						user_input = user_manu();
						if (user_input == 1)
						{
							int existing_user_input = 0;
							while (existing_user_input < 3)
							{
								existing_user_input = existing_user_manu();
								if (existing_user_input == 1)
								{
									counter();
									Console.WriteLine("Srno\tcar_brand_name\tcar_color\tcar_model\tcar_plate_number\tcar_status\tcar_rpd\tcar_conditions");
									for (int x = 0; x < carsdetail.Count; x++)
									{
										Console.WriteLine(x + "\t" + carsdetail[x].cars_brand_name + "\t\t" + carsdetail[x].car_colour + "\t\t" + carsdetail[x].car_model + "\t\t" + carsdetail[x].car_number_plate + "\t\t" + carsdetail[x].car_status + "\t\t" + carsdetail[x].car_rpd + "\t\t" + carsdetail[x].car_condition);
										
									}
								}
								if (existing_user_input == 2)
								{
									counter();
									Console.WriteLine("Srno\tcar_brand_name\tcar_color\tcar_model\tcar_plate_number\tcar_status\tcar_rpd\tcar_conditions");
									for (int x = 0; x < carsdetail.Count; x++)
									{
										Console.WriteLine(x + "\t" + carsdetail[x].cars_brand_name + "\t\t" + carsdetail[x].car_colour + "\t\t" + carsdetail[x].car_model + "\t\t" + carsdetail[x].car_number_plate + "\t\t" + carsdetail[x].car_status + "\t\t" + carsdetail[x].car_rpd + "\t\t" + carsdetail[x].car_condition);
									}
									Console.WriteLine("\tAre You Sure to Delete a Car ");
									Console.WriteLine("\tPress (Y/N)key to Coninue... ");
									char select = char.Parse(Console.ReadLine());
									if (select == 'Y')
									{
										Console.WriteLine("Enter Sr No of Car You Wants to Book ");
										int srno = int.Parse(Console.ReadLine());
										int num1 = srno + 1;
										Console.WriteLine("Srno\tcar_brand_name\tcar_color\tcar_model\tcar_plate_number\tcar_status\tcar_rpd\tcar_conditions\n\n\n");
									
											Console.WriteLine(srno + "\t" + carsdetail[srno].cars_brand_name + "\t\t" + carsdetail[srno].car_colour + "\t\t" + carsdetail[srno].car_model + "\t\t" + carsdetail[srno].car_number_plate + "\t\t" + carsdetail[srno].car_status + "\t\t" + carsdetail[srno].car_rpd + "\t\t" + carsdetail[srno].car_condition);								
										Console.WriteLine("You Booked a Car ");
										Console.WriteLine(srno + "\t" + carsdetail[srno].cars_brand_name + "\t\t" + carsdetail[srno].car_colour + "\t\t" + carsdetail[srno].car_model + "\t\t" + carsdetail[srno].car_number_plate + "\t\t" + carsdetail[srno].car_status + "\t\t" + carsdetail[srno].car_rpd + "\t\t" + carsdetail[srno].car_condition);								
										
										counter();
									}
									if (select == 'N')
									{

										counter();
									}
								}
								if (existing_user_input == 3)
								{
									Console.ReadKey();
								}
								//if (existing_user_input == 4) 
								//{
								//}
							}
						}
						if (user_input == 2)
						{
							newperson();
							counter();
						}
						if (user_input == 3)
						{
							counter();
						}
					}
				}
				if (input == 2)
				{
					int admin_input = 0, num = 0;
					while (admin_input < 8)
					{
						counter();
						admin_input = admin_manu();
						if (admin_input == 1)
						{
							Admindetail.Add( add_admin());
							counter();
						}
						if (admin_input == 2)
						{
						//	carsdetail.Add(All_cars());
						}
						if (admin_input == 3)
						{
							int srno;
							counter();
							manu_top1();
							Console.WriteLine("Srno\tcar_brand_name\tcar_color\tcar_model\tcar_plate_number\tcar_status\tcar_rpd\tcar_conditions");
							for (int x = 0; x < carsdetail.Count; x++)
							{
								Console.WriteLine((x+1) + "\t" + carsdetail[x].cars_brand_name + "\t\t" + carsdetail[x].car_colour + "\t\t" + carsdetail[x].car_model + "\t\t" + carsdetail[x].car_number_plate + "\t\t" + carsdetail[x].car_status + "\t\t" + carsdetail[x].car_rpd + "\t\t" + carsdetail[x].car_condition);
							}
							Console.WriteLine("\tAre You Sure to Delete a Car ");
							Console.WriteLine("\tPress (Y/N)key to Coninue... ");
							char select = char.Parse(Console.ReadLine());
							if (select == 'Y')
							{
								Console.WriteLine("Enter Sr No of Car You Wants to Delete ");
								srno = int.Parse(Console.ReadLine());
								carsdetail.RemoveAt(srno);
								counter();
							}
							if (select == 'N')
							{

								counter();
							}
						}
						if (admin_input == 4)
						{
							int srno;
							counter();
							manu_top1();
							Console.WriteLine("Srno\tcar_brand_name\tcar_color\tcar_model\tcar_plate_number\tcar_status\tcar_rpd\tcar_conditions");
							for (int x = 0; x < carsdetail.Count; x++)
							{
								Console.WriteLine(x + "\t" + carsdetail[x].cars_brand_name + "\t\t" + carsdetail[x].car_colour + "\t\t" + carsdetail[x].car_model + "\t\t" + carsdetail[x].car_number_plate + "\t\t" + carsdetail[x].car_status + "\t\t" + carsdetail[x].car_rpd + "\t\t" + carsdetail[x].car_condition);
							}
							Console.WriteLine("\tAre You Sure to update a Car ");
							Console.WriteLine("\tPress (Y/N)key to Coninue... ");
							char select = char.Parse(Console.ReadLine());
							if (select == 'Y')
							{
								Console.WriteLine("Enter Sr No of Car You Wants to update ");
								srno = int.Parse(Console.ReadLine());
								//update
								for (int x = 0; x < carsdetail.Count; x++)
								{
									Console.WriteLine(x + "\t" + carsdetail[x].cars_brand_name + "\t\t" + carsdetail[x].car_colour + "\t\t" + carsdetail[x].car_model + "\t\t" + carsdetail[x].car_number_plate + "\t\t" + carsdetail[x].car_status + "\t\t" + carsdetail[x].car_rpd + "\t\t" + carsdetail[x].car_condition);
								}
								counter();
							}
							if (select == 'N')
							{
								counter();
							}
						}
						if (admin_input == 5)
						{
							manu_top1();
							Console.WriteLine("Main menu >Admin >Show all admins");
							lines();
							Console.WriteLine("NO\tID\tFisrt\tLast\tUser\tCity\tmale");
							for (int x = 0; x < num; x++)
							{
									Console.WriteLine(x + "\t\t"+Admindetail[x].first_name + "\t\t"+ Admindetail[x].last_name + "\t\t"+ Admindetail[x].user_name + "\t\t" + Admindetail[x].city + "\t\t"+ Admindetail[x].gender + "\t\t" + Admindetail[x].adress + "\t\t");
							}
							counter();
						}
						if (admin_input == 6)
						{
							Console.WriteLine("Srno\tcar_brand_name\tcar_color\tcar_model\tcar_plate_number\tcar_status\tcar_rpd\tcar_conditions");
							for (int x = 0; x < carsdetail.Count; x++)
							{
								Console.WriteLine(x + "\t" + carsdetail[x].cars_brand_name + "\t\t" + carsdetail[x].car_colour + "\t\t" + carsdetail[x].car_model + "\t\t" + carsdetail[x].car_number_plate + "\t\t" + carsdetail[x].car_status + "\t\t" + carsdetail[x].car_rpd + "\t\t" + carsdetail[x].car_condition);
							}
							counter();
						}
						if (admin_input == 7)
						{
							counter();

						}if (admin_input == 8)
						{
							counter();
						}
					}
				}
				if (input == 3)
				{
					counter();
					tearms();
				}
				if (input == 4)
				{
					counter();
					break;
				}
			}
		}
		static int main_manu()
		{
			manu_top1();
			int input;
			Console.WriteLine("\n\n\n");
			Console.WriteLine("\t\tMain Manu > \n");
			lines();
			Console.WriteLine("\n\n");
			Console.WriteLine("\t\t(1) : Users Modules ");
			Console.WriteLine("\t\t(2) : Admin modules ");
			Console.WriteLine("\t\t(3) : Terms & Conditions ");
			Console.WriteLine("\t\t(4) : Exit \n\n");
			Console.Write("\tINPUT :  ");
			input = int.Parse(Console.ReadLine());
			return input;
		}
		static int admin_manu()
		{
			int admin_input;
			manu_top1();
			Console.WriteLine("\t\tMain Manu > Admin");
			lines();
			Console.WriteLine("\t\t(1) : ADD Admin");
			Console.WriteLine("\t\t(2) : Add Cars");
			Console.WriteLine("\t\t(3) : Delete Cars");
			Console.WriteLine("\t\t(4) : Update Cars");
			Console.WriteLine("\t\t(5) : Show Users & Admin");
			Console.WriteLine("\t\t(6) : Show All Cars");
			Console.WriteLine("\t\t(7) : Announcements");
			Console.WriteLine("\t\t(8) : Generate Reports");
			Console.WriteLine("\t\t(9) : Log Out");
			Console.Write("\t\tINPUT : ");
			admin_input = int.Parse(Console.ReadLine());
			return admin_input;
		}
		// function for user menu
		static int user_manu()
		{
			int user_input;
			manu_top1();
			Console.WriteLine("\t\t Main Manu > user");
			lines();
			Console.WriteLine("\t\tMain Manu > User");
			Console.WriteLine("\t\t(1) : Existing");
			Console.WriteLine("\t\t(2) : Create New Account");
			Console.WriteLine("\t\t(3) : Main Manu");
			Console.Write("\tINPUT : ");
			user_input = int.Parse(Console.ReadLine());
			return user_input;
		}
		static int existing_user_manu()
		{
			int existing_user_input;
			manu_top1();
			Console.WriteLine("Main Manu > User * \n");
			lines();
			Console.WriteLine("\t\t Dashbord :--- ");
			Console.WriteLine("\t\t\\n\n");
			Console.WriteLine("\t\t(1). Show all availbile cars ");
			Console.WriteLine("\t\t(2). Book a car ");
			Console.WriteLine("\t\t(3). Privious record ");
			Console.WriteLine("\t\t(4). Announcements");
			Console.WriteLine("\t\t(5). Log out ");
			Console.WriteLine("\n");
			Console.WriteLine("\t\t    Enter your choise continue.... ");
			existing_user_input = int.Parse(Console.ReadLine());
			return existing_user_input;
		}
		static void counter()
		{
			Console.WriteLine("\tPress any Key tp continue...");
			Console.ReadKey();
			Console.Clear();
		}
		static void tearms()
		{
			manu_top1();
			Console.Write("\n\n\n");
			Console.WriteLine("\tMain Manu > Terms & Condition ");
			lines();
			Console.Write("\n\n");
			Console.Write("\tRental Terms and Conditions ");
			Console.Write("\tTHESE TERMS AND CONDITIONS CONTAIN A BINDING ARBITRATION CLAUSE AND CLASS ACTION WAIVER THAT IMPACT YOUR RIGHTS ABOUT HOW TO RESOLVE DISPUTES. PLEASE READ THIS PROVISION CAREFULLY.\n");
			Console.Write("\t 1. The Rental Agreement. These Rental Terms and Conditions, the rental document you receive when you are given access to the car you are renting (the  Rental Contract ) any additional agreement signed by you, any documents or agreements (or links to on-line documents or agreements) sent to you electronically in connection with your rental, the Privacy Notice, and the return receipt or record (the  Rental Receipt ) with computed rental charges together constitute the  Rental Agreement  between yourself and Avis Rent A Car System, LLC, or the independent Avis System Licensee identified on the Rental Contract (“Avis”).\n");
			Console.Write("\t 2. Your Rental. You rent from Avis the car described on the Rental Contract, which rental is solely a transfer of possession, and not of drivership. You agree to the terms in the Rental Agreement provided any such term is not prohibited by the law of a jurisdiction covering this rental, in which case such law controls. “You” and “your” refer to the person who signs this agreement, “we”, “our” and “us” refer to Avis. You also agree that you are not our agent for any purpose; and that you cannot assign delegate  transfer your obligations under the Rental Agreement and any discrete part thereof.\n");
			Console.Write("\t 3. Changes.Any change in the Rental Agreement or our rights must be in writing and signed by an authorized Avis officer.You further agree that we have the unilateral right to change these Terms and Conditions from time to time either upon written notice to you, in paper or electronic form, or upon our posting such changes on the Avis web site.Such changes will apply to rentals that you reserve after such notice has been given, as indicated by the date of such notice, if sent in written form, or the date such changes are posted on the Avis web site, which date will be indicated therein, without any requirement by you to sign the changed Terms and Conditions.Changes to these Terms and Conditions will be posted as they occur on the Avis web site at www.Avis.com and will govern all rentals commencing after posting even if the terms provided at time of reserving the rental car are different.\n");
			Console.Write("\t 4. Meaning of Car.The word car in the Rental Agreement means the vehicle rented to you or its replacement and includes tires,tools,keys,key fobs, equipment, included and optional accessories, plates, documents, and any other products or property provided by Avis with the vehicle and separately rented to you by Avis unless otherwise explicitly specified in the Rental Agreement.\n ");
			counter();
		}
		// function for existing user manu
		static void manu_top1()
		{
			Console.WriteLine("                                                                                        ___                ___                               ");
			Console.WriteLine("                           _______ _______ ___________    __________________  _______  /  /____________ __/  /                               ");
			Console.WriteLine("                          /   ___ /  ____   /  ______/   /  ________/    _  \\/  ___  \\/   __/ /  _____   /  /                              ");
			Console.WriteLine("                         /  /___ /  /___/  /  /         /  /       /     __ /  /  /  /  /____/  /____/  /  /____                             ");
			Console.WriteLine("                         \\______ \\_____^__/__/         /__/        \\_______/  /  /  /\\______/\\______^__/\\______/                       ");
			Console.WriteLine("                                                                                                                                             ");
			Console.WriteLine("                                                                            ___                                                              ");
			Console.WriteLine("                                                __________     ___________ /  /__________________   ____                                     ");
			Console.WriteLine("                                               / ______/ /    / / ________/  ___/   __   /   /___ '  ___\\                                   ");
			Console.WriteLine("                                              ( ____  / /____/ ( ______  /  /__/ /_____ /   /   /   /   /                                    ");
			Console.WriteLine("                                             /_______/\\_______/_________/_____/\\_______/___/   /___/   /                                   ");
			Console.WriteLine("                                                      ______ /                                                                               ");
			Console.WriteLine("                                                     /______/                                                                                ");
			Console.WriteLine("                                                                                                                                             ");
			Console.WriteLine("\n\n\n");
		}
		// function for  lines after logo
		static void lines()
		{
			Console.Write("\t> ");
			for (int i = 0; i < 40; i++)
			{
				Console.Write("-");
			}
			Console.Write("\n\n");
		}
		static admin_data add_admin()
		{
			int count = 0;
			admin_data admin = new admin_data();
			Console.Write(" Main Manu > Admin >Add admin ");
			lines();
			if (count < 5)
			{
				Console.Write("Enter Admin ID ");
				admin.id = int.Parse(Console.ReadLine());
				Console.Write("Enter Admin first Name ");
				admin.first_name = Console.ReadLine();
				Console.Write("Enter Admin last Name ");
				admin.last_name = Console.ReadLine();
				Console.Write("Enter Admin user Name ");
				admin.user_name = Console.ReadLine();
				Console.Write("Enter Admin Password ");
				admin.password = Console.ReadLine();
				Console.Write("Enter admin city ");
				admin.city = Console.ReadLine();
				Console.Write("Enter Admin gender ");
				admin.gender = Console.ReadLine();
				count++;
				string path = "D:\\C#\\project\\project\\admin.txt";
				StreamWriter file = new StreamWriter(path, true);
				file.WriteLine(admin.first_name,admin.last_name,admin.user_name,admin.password,admin.city,admin.gender);
				file.Flush();
				file.Close();
			}
			else
			{
				Console.Write("You Entered 5 admins so you cannot add new admin ");
			}
			return admin;
		}
	/*	static cars_data All_cars()
		{ 
			//fstream file = new fstream();
			int num_cars;
			cars_data cars = new cars_data();
			Console.WriteLine(" Main Manu > Admin >Add cars ");
			Console.WriteLine("Enter the number of cars you want to Enter ");
			num_cars = int.Parse(Console.ReadLine());
			lines();
			for (int c = 0; c < num_cars; c++)
			{
				Console.WriteLine("Enter brand name ");
				cars.cars_brand_name = Console.ReadLine(); ;
				Console.WriteLine("Enter ar colour ");
				cars.car_colour = Console.ReadLine();
				Console.WriteLine("Enter car model ");
				cars.car_model = Console.ReadLine();
				Console.WriteLine("Enter car number plate ");
				cars.car_number_plate = Console.ReadLine();
				Console.WriteLine("Enter rate per days");
				cars.car_rpd =int.Parse(Console.ReadLine());
				Console.WriteLine("Enter Car status ");
				cars.car_status = Console.ReadLine();
				Console.WriteLine("Enter car conditions ");
				cars.car_condition = Console.ReadLine();
				string path = "E:\\C#\\project\\project\\cars.txt";
				StreamWriter file = new StreamWriter(path, true);
				Console.WriteLine(cars.cars_brand_name, cars.car_colour, cars.car_model, cars.car_number_plate, cars.car_rpd, cars.car_status, cars.car_condition);
				file.Flush();
				file.Close();
				return cars;
			}*/
	//	}
		static user_data newperson()
		{
			user_data user = new user_data(); 
			Console.Write("                                Enter your first name: (e.g is Ahmad)");
			user.first_name = Console.ReadLine();
			Console.Write("                                Enter your Last name: (e.g is Ahmad)");
			user.last_name = Console.ReadLine();
			Console.Write("                                Enter User name:(e.g is Amad123) ");
			user.user_name = Console.ReadLine();
			Console.Write("                                Enter password (password consist on atleast 4)");
			user.password = Console.ReadLine();
			Console.Write("                                Enter your  Gender: (male/female)");
			user.gender = Console.ReadLine();
			Console.Write("                                Enter your  city: ");
			user.city = Console.ReadLine();
			Console.Write("                                Enter your Adress: ");
			user.adress = Console.ReadLine();
			string path = "E:\\C#\\project\\project\\user.txt";
			StreamWriter file = new StreamWriter(path, true);
			Console.WriteLine(user.first_name, user.last_name, user.user_name, user.password, user.gender, user.city, user.adress);
			file.Flush();
			file.Close();
			return user;
		}
		static void user_pass_way()
		{

			Console.Write("\n\n");
			Console.Write("\t \t \t Enter your User Name ... ");
			Console.Write("\n\n\n");
			 string uname = Console.ReadLine();
			Console.Write("\t \t \t Enter your pasword ... ");
			Console.Write("\n");
			Console.Write("\n");
			Console.Write("\n");
			string password = Console.ReadLine();
			Console.Write("\n");
			Console.Write("\n");
			user_checker(uname,password);

		}
		static void user_checker(string uname , string password)
		{
			string username, userpass;
			string path = "E:\\C#\\oop 1\\task3\\task3\\user.txt";
			if (File.Exists(path))
			{
				StreamReader filereader = new StreamReader(path);
				string record;
				while ((record = filereader.ReadLine()) != null)
				{
				username = parse(record, 3);
				userpass = parse(record, 4);
					Console.ReadKey();
				if (username == uname && password == userpass)
				{
					break;
				}
				}
			}
		}
		static void admin_pass_way()
		{

			Console.Write("\n");
			Console.Write("\n");
			Console.Write("\t \t \t Enter your User Name ... ");
			Console.Write("\n");
			Console.Write("\n");
			Console.Write("\n");
			string uname = Console.ReadLine();
			Console.Write("\t \t \t Enter your pasword ... ");
			Console.Write("\n");
			Console.Write("\n");
			Console.Write("\n");
			string password = Console.ReadLine();
			Console.Write("\n");
			Console.Write("\n");
			admin_checker(uname,password);
		}
		static void admin_checker(string uname, string password)
		{
			string username, userpass;
			string path = "E:\\C#\\oop 1\\task3\\task3\\Admin.txt";
			if (File.Exists(path))
			{
				StreamReader filereader = new StreamReader(path);
				string record;
				while ((record = filereader.ReadLine()) != null)
				{
					username = parse(record, 4);
					userpass = parse(record, 5);
					Console.ReadKey();
					if (username == uname && password == userpass)
					{
						break;
					}
				}
			}
		}
	static string parse(string row, int column)
	{
			int commansCount = 1;
			string item="";
			int index = 0;
			while (true)
			{
				char ch = row[index];
				if (ch == '\0')
					return item;
				if (ch == ',')
				{
					commansCount++;
				}
				else if (commansCount == column)
				{
					item = item + ch;
				}
				index++;
			}
			return item;
		}
	}
}
