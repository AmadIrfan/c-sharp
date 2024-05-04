using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pro.BL;
using pro.DL;
using System.IO;

namespace pro.DL
{
    class customerDL
    {
        public static List<customer> customerlistforroom = new List<customer>();
        public static List<customer> customerlistforproduct = new List<customer>();

        public static void addcustomersintolist(customer c)
        {
            customerlistforroom.Add(c);
        }
       public static void storecustomerdataintofile(string path,customer c) 
        {
             StreamWriter f = new StreamWriter(path, true);
            string roomnames = "";
            for (int x = 0; x < customerlistforroom.Count ; x++)
            {
                f.WriteLine(customerlistforroom[x].name + "," + customerlistforroom[x].idcardnumber);
            }
            roomnames = roomnames + DL.roomDL.bookedroomlist[DL.roomDL.bookedroomlist.Count - 1].roomname;
            f.Flush();
            f.Close();
             String path1="bookedRoom.txt";
             StreamWriter f1 = new StreamWriter(path1, true);
             for(int x = 0; x < customerlistforroom.Count ; x++)
             {
                for(int z=0; z < customerlistforroom[x].bookedroomlist.Count; z++)
                {
        Console.WriteLine(customerlistforroom[x].bookedroomlist[z].cnic);
                    f1.WriteLine(customerlistforroom[x].bookedroomlist[z].cnic + "," + customerlistforroom[x].bookedroomlist[z].roomname + "," + customerlistforroom[x].bookedroomlist[z].numberofdays);
                }
             }
             f1.Flush();
             f1.Close();
       }

        public static void searchfordeleteincustomerlist(customer c)
        {
            for (int i = 0; i < customerlistforroom.Count; i++)
            {
                if (c.name == customerlistforroom[i].name)
                {
                    customerlistforroom.RemoveAt(i);
                }
            }
        }

        public static void forstoringalllistatonceintolist(string path,customer c)
        {
            StreamWriter f = new StreamWriter(path);
            string roomnames = "";
            for (int x = 0; x < DL.roomDL.bookedroomlist.Count - 1; x++)
            {
                roomnames = roomnames + DL.roomDL.bookedroomlist[x].roomname + ";";
            }
            roomnames = roomnames + DL.roomDL.bookedroomlist[DL.roomDL.bookedroomlist.Count - 1].roomname;
            f.WriteLine(c.name + "," + c.idcardnumber + "," + roomnames);
            f.Flush();
            f.Close();
        }
        public static bool readFromFileroom(string path)
        {
     /*       string record;
           
            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);

                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string idcardnumber = splittedRecord[1];
        //            string[] splittedRecordForRoomdata = splittedRecord[2].Split(';');
                   
                    List<room> bookedroomlist = new List<room>();
                    
                    for (int x = 0; x < splittedRecordForRoomdata.Length; x++)
                    {
                        room r = roomDL.isRoomExists(splittedRecordForRoomdata[x]);
                        
                 // Console.WriteLine(name + idcardnumber);  
                        if (r != null)
                        {
                            
                            if (!(bookedroomlist.Contains(r)))
                                bookedroomlist.Add(r);
                        }
                    }
                    foreach(room r in bookedroomlist)
                    {
                        Console.WriteLine(r.roomname+"  "+r.numberofdays);
                    }
                    customer c = new customer(name, idcardnumber,bookedroomlist);
                    customerlistforroom.Add(c);
                }
                f.Close();
                return true;
            }
            else
                return false;
 */
     return true;
        }
        public static void storeorderedproductsinformation(string path, customer c)
        {
            StreamWriter f = new StreamWriter(path, true);
            string productnames = "";
            for (int x = 0; x < DL.productDL.orderedlist.Count - 1; x++)
            {
                productnames = productnames +DL.productDL.orderedlist[x].productname + ";";
            }
            productnames =productnames + DL.productDL.orderedlist[DL.productDL.orderedlist.Count - 1].productname;
            f.WriteLine(c.name + "," + c.idcardnumber + "," +productnames);
            f.Flush();
            f.Close();
        }
        public static bool readFromFileproduct(string path)
        {
          /*  string record;
            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);

                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string idcardnumber = splittedRecord[1];
                    string[] splittedRecordForProductdata = splittedRecord[2].Split(';');
                    List<product> orderedlist = new List<product>();
                    for (int x = 0; x < splittedRecordForProductdata.Length; x++)
                    {
                        product p = productDL.isProductExists(splittedRecordForProductdata[x]);
                        if (p != null)
                        {
                            if (!(orderedlist.Contains(p)))
                                orderedlist.Add(p);
                        }
                    }
                    customer c = new customer(name, idcardnumber, orderedlist);
                    customerlistforproduct.Add(c);
                }
                f.Close();
                return true;
            }
            else
                return false;
*/
return true;
        }

    }
}
