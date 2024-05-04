using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plane.Ships.BL;
using System.IO;
namespace ship.DL
{
    class shipDL
    {
        public static List<ships> ship_water = new List<ships>();
        public static void addShip(ships temp)
        {
            ship_water.Add(temp);
        }
      public  static int ship_index_checker(string number)
      {
            int index = 0;
            for (int i = 0; i < shipDL.ship_water.Count; i++)
            {
                if (number == shipDL.ship_water[i].Number)
                {
                    index = i;
                }
            }
            return index;
      }
        public static void ShipDataToFile()
        {
            string path = "shipData.txt";
            StreamWriter file = new StreamWriter(path,false);
            foreach(ships i in ship_water)
            {
                file.WriteLine(i.Number+","+i.Latitude_Degree + "," + i.Latitude_Minute + "," + i.Latitude_Direction + "," + i.Longitude_Degree + "," + i.Longitude_Minute + "," + i.Longitude_Direction);
            }
            file.Flush();
            file.Close();
        }
        public static void ShipDataFromFile()
        {
            string path = "shipData.txt";
            StreamReader file = new StreamReader(path);
                string record;
            if (File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string number = splittedRecord[0];
                    string Degree = splittedRecord[1];
                    string Minute = splittedRecord[2];
                    char Direction = char.Parse(splittedRecord[3]);
                    string Degree1 = splittedRecord[4];
                    string Minute1 = splittedRecord[5];
                    char Direction1 = char.Parse(splittedRecord[6]);
                    ships s = new ships(number, Degree, Minute, Direction, Degree1, Minute1, Direction1);
                    addShip(s);
                }
            }
                file.Close();

        }

    }
}
