using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameWork;
using GameWork.Core;

namespace GameWorks
{
    public partial class Dav : Form
    {
        public Game go;
        public Dav()
        {
            InitializeComponent();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            go.update();
        }

        private void Dav_Load(object sender, EventArgs e)
        {
            go = new Game(4);
            this.BackgroundImage=GameWorks.Properties.Resources.Battleground1;
            this.BackgroundImageLayout = ImageLayout.Center; 
            go.AddGameObject(GameWorks.Properties.Resources.Idle__000,20,20);
            go.AddGameObject(GameWorks.Properties.Resources.image,20,20);
            go.OnAddingGsmeObject += new EventHandler(AddIntoControals);
        }

        private void AddIntoControals(object sender, EventArgs e)
        {
         
            this.Controls.Add((PictureBox)sender);
        }
    }
}
