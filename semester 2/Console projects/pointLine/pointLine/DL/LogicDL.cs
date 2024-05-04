using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using pointLine.BL;
using pointLine.UI;

namespace pointLine.DL
{
    class LogicDL
    {
        public static Line option1()
        {
            Line MyLine;
            ConsoleOutput.Header();
            Point start = PointUI.getFromConsole("Starting");
            Point end = PointUI.getFromConsole("Ending");
            MyLine = new Line(start, end);
            return MyLine;
        }

        public static Line option2(Line MyLine)
        {
            ConsoleOutput.Header();
            Point start = PointUI.getFromConsole("Updated Starting");
            MyLine.First.setX(start.x);
            MyLine.First.setY(start.y);
            return MyLine;
        }

        public static Line option3(Line MyLine)
        {
            ConsoleOutput.Header();
            Point end = PointUI.getFromConsole("Updated Ending");
            MyLine.Last.setX(end.x);
            MyLine.Last.setY(end.y);
            return MyLine;
        }

        public static void option4(Line MyLine)
        {
            ConsoleOutput.Header();
            PointUI.displayPoint(MyLine.First);
        }

        public static void option5(Line MyLine)
        {
            ConsoleOutput.Header();
            PointUI.displayPoint(MyLine.Last);
        }

        public static void option6(Line MyLine)
        {
            ConsoleOutput.Header();
            LineUI.DisplayLength(MyLine);
        }

        public static void option7(Line MyLine)
        {
            ConsoleOutput.Header();
            LineUI.GetGradient(MyLine);
        }

        public static void option8(Line MyLine)
        {
            ConsoleOutput.Header();
            PointUI.DistanceFromZero("starting", MyLine.First);
        }

        public static void option9(Line MyLine)
        {
            ConsoleOutput.Header();
            PointUI.DistanceFromZero("ending", MyLine.Last);
        }

        public static void storeDataIntoFile(Line MyLine, string path)
        {
            StreamWriter file = new StreamWriter(path);
            if (File.Exists(path))
            {
                file.WriteLine(MyLine.First + "," + MyLine.Last);
            }
            file.Flush();
            file.Close();
        }

        public static Line LoadDataFromFile(Line MyLine, string path)
        {
            StreamReader file = new StreamReader(path);
            if (File.Exists(path))
            {
                string record = file.ReadLine();
                string[] splitted_Record = record.Split(',');
                MyLine.First.x = int.Parse(splitted_Record[0]);
            }
            file.Close();
            return MyLine;
        }
    }
}
