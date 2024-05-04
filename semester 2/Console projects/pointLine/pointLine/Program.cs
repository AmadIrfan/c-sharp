using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointLine.BL;
using pointLine.UI;
using pointLine.DL;

namespace pointLine
{
    class Program
    {
       static Line MyLine;
        static void Main(string[] args)
        {
        string path = "pointLine.txt";
            int option = 0;
            while (option<10)
            {
                ConsoleOutput.Header();
                option =ConsoleOutput.Menu();
                if(option==1){
                    MyLine = (LogicDL.option1());
                    LogicDL.storeDataIntoFile(MyLine, path);
                    Console.ReadKey();
                }
                if(option==2){
                    MyLine = (LogicDL.option2(MyLine));
                    LogicDL.storeDataIntoFile(MyLine, path);
                    Console.ReadKey();
                }
                if(option==3)
                {
                    MyLine = (LogicDL.option3(MyLine));
                    LogicDL.storeDataIntoFile(MyLine, path);
                    Console.ReadKey();
                }
                if(option==4){
                    LogicDL.option4(MyLine);
                    Console.ReadKey();
                }
                if(option==5)
                {
                    LogicDL.option5(MyLine);
                    Console.ReadKey();
                }
                if (option==6){
                    LogicDL.option6(MyLine);
                    Console.ReadKey();
                }
                if(option==7){
                    LogicDL.option7(MyLine);
                    Console.ReadKey();
                }
                if(option==8){
                    LogicDL.option8(MyLine);
                    Console.ReadKey();
                }
                if (option == 9) {
                    LogicDL.option9(MyLine);
                    Console.ReadKey();
                }
                  if (option == 10)
                {   
                  break;
                }
            }
        }
    }
}
