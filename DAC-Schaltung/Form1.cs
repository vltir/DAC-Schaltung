using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DAC_Schaltung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Close();
		}
   
        private void infoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			MessageBox.Show("Programmierer: ******* ******* \nDatum: **.**.****", "Info");
		}

        private void textbox_R0_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Uref_textBox__TextChanged(object sender, EventArgs e)
        {

        }
    }

}
