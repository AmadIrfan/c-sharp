using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameObject.BL;

namespace GameObject.DL
{
    internal class gameObjectDL
    {
        public static List<gameobjects> objectList = new List<gameobjects>();

        public static void AddObject(gameobjects newObject)
        {
            objectList.Add( newObject );
        }
    }
}
