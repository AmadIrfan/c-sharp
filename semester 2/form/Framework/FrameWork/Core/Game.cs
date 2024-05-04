using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using FrameWork.Movement;
using FrameWork.Fire;

namespace FrameWork.Core
{
    public class Game
    {
        int livecounter=100; 
        private int ScoreCounter;
        private List<GameObject> gameObject;
        private List<fire> playerFire;
        private int gravity;
        public player P1 { get => p1; set => p1 = value; }
       private player p1;
        Finalpoint key;
        public event EventHandler OnAddingGsmeObject;
        public Game(int gravity){
            this.gravity = gravity;
            playerFire= new List<fire>();
            gameObject = new List<GameObject>();
        }
        public void AddGameObject(Image img, int top, int left, Imovement movement)
        {
             GameObject go = new GameObject(img, top, left,movement);
            gameObject.Add(go);
            OnAddingGsmeObject?.Invoke(go.Pb, EventArgs.Empty);
        }
        //fire
        public void addBullets(Image img ,int top,int left,int speed )
        {
            fire fir = new fire(img ,top ,left,speed);
           playerFire.Add(fir);
            OnAddingGsmeObject?.Invoke(fir.PictureBox,EventArgs.Empty);
        }
        public  player NewPlayer(Image img,int Top,int Left,Imovement imovement )
        {
            P1 = new player(img,Top,Left,imovement);  
            OnAddingGsmeObject?.Invoke(P1.Pb, EventArgs.Empty);
            return P1;
        }
        public void finalpoint(Image img, int Top, int Left)
        {
            key = new Finalpoint(img,Top,Left);  
            OnAddingGsmeObject?.Invoke(key.Key, EventArgs.Empty);
        }
        public bool ReachedFinelPoint()
        {
            if (p1.Pb.Bounds.IntersectsWith(key.Key.Bounds))
            {
                return true;
            }
            return false;
        }
        public void KeyPressed(Keys KeyCode)
        {
            
            Keyboard keyboard = (Keyboard)P1.Movement;
            keyboard.keyPressedByuser(KeyCode);
        }
        public void objmove()
        {
            foreach (GameObject go in gameObject)
            {
                go.update();
            }
            P1.Pb.Location = P1.Movement.move(P1.Pb.Location);
            p1.gravity();
        }
        public int collision()
        {
            foreach (GameObject go in gameObject)
            {
                if (go.Pb.Bounds.IntersectsWith(p1.Pb.Bounds))
                {
                    livecounter -= 25;
                    takeAction(go);
                    break;
                }
            }
            return livecounter;
        }
        //collision detection for bullets
        public int checkCollisionWithBullets()
        {
            foreach (fire f in playerFire)
            {
                foreach (GameObject go in gameObject)
                {
                    if (f.PictureBox.Bounds.IntersectsWith(go.Pb.Bounds))
                    {
                        takeAction(f, go);
                        return ScoreCounter;
                        
                    }
                }
            }
            return ScoreCounter;
        }
        private void takeAction(GameObject go)
        {

                go.Pb.Hide();
                gameObject.Remove(go);
        } private void takeAction(fire f,GameObject go)
        {

            ScoreCounter++;
            go.Pb.Hide();
            gameObject.Remove(go);
            f.PictureBox.Hide();
            playerFire.Remove(f);
        }

        public void fireBullet()
        {
            if (playerFire.Any())
            {

                foreach (fire g in playerFire)
                {
                    g.Updatefire();
                }
            }
        }
    }
}
