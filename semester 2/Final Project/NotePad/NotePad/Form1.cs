using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter ="Text File(.txt)|*.txt";
            saveFileDialog.Title = "Save File...";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
               StreamWriter file= new StreamWriter(saveFileDialog.FileName);
               file.Write(richtxtbox.Text);
            file.Close();
            }
               
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Txet File (.txt)|*.txt";
            openFileDialog.Title = "Open File ...";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
            StreamReader file = new StreamReader(openFileDialog.FileName);
            richtxtbox.Text = file.ReadToEnd();
            file.Close ();

            }
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richtxtbox.Clear();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf=new SaveFileDialog();
            svf.Title = "Save File...";
            svf.Filter = "Text Fie(.txt)|*.txt";
            if(svf.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file=new StreamWriter(svf.FileName);
                file.Write(richtxtbox.Text);
                file.Close();
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            richtxtbox.Clear();
           
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Txt file(.txt)|*.txt";
            open.Title = "Open file...";
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = new StreamReader(open.FileName);
                richtxtbox.Text = file.ReadToEnd();
                file.Close();
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            richtxtbox.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            richtxtbox.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            richtxtbox.Paste();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richtxtbox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richtxtbox.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richtxtbox.Cut();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richtxtbox.Undo();  
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richtxtbox.Redo();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (toolStripComboBox1.Text != "")
                {
                    string Fontname = toolStripComboBoxFont.Text.ToString();
                    Font font = new Font(Fontname, float.Parse(toolStripComboBox1.Text));
                    richtxtbox.SelectionFont = font;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void toolStripComboBoxFont_SelectedIndexChanged_1(object sender, EventArgs e)
        {
                string Fontname= toolStripComboBoxFont.Text.ToString();
                Font font = new Font(Fontname,float.Parse(toolStripComboBox1.Text));
                 richtxtbox.SelectionFont = font;
        }

        private void richtxtbox_TextChanged(object sender, EventArgs e)
        {
            label2.Text = richtxtbox.Text.Length.ToString();
            label4.Text=richtxtbox.Lines.Count().ToString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abutForm about=new abutForm();
           about.ShowDialog();

        }
    }
}
