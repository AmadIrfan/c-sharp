using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pro.BL;
using System.IO;

namespace pro.DL
{
    class roomDL
    {
        public static long totalbillpaid2;
        public static string roomsinfomation = "rooms information.txt";
        public static List<room> bookedroomlist = new List<room>();
        public static List<room> roomlist = new List<room>();
        public static void storebookedroomdataintolist(room r)
        {
            bookedroomlist.Add(r);
        }
        public static void viewrooms()
        {
            for (int i = 0; i < roomlist.Count; i++)
            {
                Console.WriteLine(roomlist[i].roomname + "               " + roomlist[i].roomprice);
            }
        }
        public static void searchforchangingroomname()
        {
            int idx = 0;
            string roomname;
            bool check = false;
            while (true)
            {
                Console.WriteLine("Enter the name of the room of which you want to change the price: ");
                roomname = Console.ReadLine();
                room r = new room(roomname);
                for (int i = 0; i < 7; i++)
                {
                    if (r.roomname == roomlist[i].roomname)
                    {
                        idx = i;
                        check = true;
                        break;
                    }
                }
                if (check)
                {
                    Console.WriteLine("Enter the new price of the room: ");
                    roomlist[idx].roomprice = Console.ReadLine();

                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice! Try again..........");
                }
            }
            storeintofile(roomsinfomation);

        }
        public static void storeintofile(string path)
        {
            StreamWriter f = new StreamWriter(path);
            for (int i = 0; i < roomlist.Count; i++)
            {
                f.WriteLine(roomlist[i].roomname + "," + roomlist[i].roomprice);
            }
            f.Flush();
            f.Close();
        }
        public static bool readFromFile(string path)
        {
            string record;
            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string roomname = splittedRecord[0];
                    string roomprice = splittedRecord[1];
                    room r = new room(roomname, roomprice);
                    roomlist.Add(r);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static room isRoomExists(string splittedRecordForRoomdata)
        {
            foreach (room r in roomlist)
            {
                if (r.roomname == splittedRecordForRoomdata)
                {
                    return r;
                }


            }
            return null;

        }
        // function for hotel room booing
        public static void hotelbook(long totalbillpaid)
        {
            int idx = 0, a;
            bool flag = false;
            while (true)
            {
                room r = new room();
                r = UI.roomUI.ron();
                for (int i = 0; i < 7; i++)
                {
                    if (r.roomname == roomlist[i].roomname)
                    {
                        idx = i;
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
                else
                {
                    UI.roomUI.write();
                    continue;
                }
            }
            room rr = new room();
            rr = UI.roomUI.day();
            a = int.Parse(roomlist[idx].roomprice);
            totalbillpaid = a * rr.numberofdays;
            totalbillpaid2 = totalbillpaid;
            UI.roomUI.total(totalbillpaid);
        }

    }

}