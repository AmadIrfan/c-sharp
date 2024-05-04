using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_Line.PointLine.BL;
using Point_Line.PointLine.UI;
using System.IO;

namespace Point_Line.PointLine.DL
{
    class Logic
    {
        public static Line option1()
        {
            Line MyLine;
            Output.Header();
            Point start = PointUI.getFromConsole("Starting");
            Point end = PointUI.getFromConsole("Ending");
            MyLine = new Line(start, end);
            return MyLine;
        }

        public static Line option2(Line MyLine)
        {
            Output.Header();
            Point start = PointUI.getFromConsole("Updated Starting");
            MyLine.First.setX(start.x);
            MyLine.First.setY(start.y);
            return MyLine;
        }

        public static Line option3(Line MyLine)
        {
            Output.Header();
            Point end = PointUI.getFromConsole("Updated Ending");
            MyLine.Last.setX(end.x);
            MyLine.Last.setY(end.y);
            return MyLine;
        }

        public static void option4(Line MyLine)
        {
            Output.Header();
            PointUI.displayPoint(MyLine.First);
        }

        public static void option5(Line MyLine)
        {
            Output.Header();
            PointUI.displayPoint(MyLine.Last);
        }

        public static void option6(Line MyLine)
        {
            Output.Header();
            LineUI.DisplayLength(MyLine);
        }

        public static void option7(Line MyLine)
        {
            Output.Header();
            LineUI.GetGradient(MyLine);
        }

        public static void option8(Line MyLine)
        {
            Output.Header();
            PointUI.DistanceFromZero("starting", MyLine.First);
        }

        public static void option9(Line MyLine)
        {
            Output.Header();
            PointUI.DistanceFromZero("ending", MyLine.Last);
        }

        public static void storeDataIntoFile (Line MyLine,string path)
        {
            StreamWriter f1 = new StreamWriter(path);
            if(File.Exists(path))
            {
                f1.WriteLine(MyLine.First + "," + MyLine.Last);
            }
            f1.Flush();
            f1.Close();
        }

        public static Line LoadDataFromFile(Line MyLine,string path)
        {
            StreamReader f1 = new StreamReader(path);
            if(File.Exists(path))
            {
                string record = f1.ReadLine();
                string[] splitted_Record = record.Split(',');
                MyLine.First.x =int.Parse(splitted_Record[0]);
            }
            f1.Close();
            return MyLine;
        }
    }
}
