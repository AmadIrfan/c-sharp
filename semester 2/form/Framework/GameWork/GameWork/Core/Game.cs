using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GameWork.Core
{
    public class Game
    {
        private List<GameObject> gameObject;
        private int gravity;
        public event EventHandler OnAddingGsmeObject;
        public Game(int gravity)
        {
            gameObject = new List<GameObject>();
            this.gravity = gravity;
        }
        public void AddGameObject( Image img, int top, int left)
        {
            GameObject go = new GameObject(img,top,left);
            gameObject.Add(go);
            OnAddingGsmeObject?.Invoke(go.Pb,EventArgs.Empty);
        }
        public void update()
        {
        foreach(GameObject go in gameObject)
            {
                go.update(gravity);
            }
        }
    }
}
