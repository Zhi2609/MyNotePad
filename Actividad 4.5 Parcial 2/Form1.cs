using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; //Agregamos esta Biblioteca

namespace Actividad_4._5_Parcial_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir Archivo
            Stream stm;
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if((stm = ofd.OpenFile())!=null)
                {
                    string str = ofd.FileName;
                    string ftxt = File.ReadAllText(str);
                    richTextBox1.Text = ftxt;
                }
            }
        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Guardar Archivo
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo de texto(*.txt)|*.txt|Archivo de C#(*.cs)|*.cs";
            sfd.ShowDialog();
            File.WriteAllText(sfd.FileName, richTextBox1.Text);
            MessageBox.Show("Archivo de texto guardado exitosamente");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if(dlg.ShowDialog()== DialogResult.OK)
            {
                string fontName;
                float fontSize;
                fontName = dlg.Font.Name;
                fontSize = dlg.Font.Size;
                richTextBox1.Font = dlg.Font;
            }
        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Red;
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Blue;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Green;
        }

        private void naranjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Orange;
        }

        private void aquaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Aqua;
        }

        private void negroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
        }

        private void amarilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Yellow;
        }

        private void negroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Black;
        }

        private void azulToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Blue;
        }

        private void blancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollada por Cesar Garcia");
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize;
            currentSize = richTextBox1.Font.Size;
            currentSize += 2.0F;
            richTextBox1.Font = new Font(richTextBox1.Font.Name, currentSize, 
                richTextBox1.Font.Style, 
                    richTextBox1.Font.Unit);
        }

        private void zToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize;
            currentSize = richTextBox1.Font.Size;
            currentSize -= 2.0F;
            if(currentSize<=2)
            {
                currentSize = 2;
            }
            else
            {
                richTextBox1.Font = new Font(richTextBox1.Font.Name, currentSize,
                    richTextBox1.Font.Style,
                        richTextBox1.Font.Unit);
            }
        }
    }
}
