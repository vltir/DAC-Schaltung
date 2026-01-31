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
            BerechneDac();
        }

        private void Uref_textBox__TextChanged(object sender, EventArgs e)
        {
            BerechneDac();
        }
        
        // Diese Methode berechnet alles neu
        private void BerechneDac()
        {
            // 1. Validierung und Farbumschaltung
            bool uRefOk = double.TryParse(textBox_URef_.Text, out double uRef);
            bool rRefOk = double.TryParse(textBox_RRef.Text, out double rRef);
            bool r0Ok = double.TryParse(textbox_R0.Text, out double r0);

            // Hintergrundfarben setzen
            textBox_URef_.BackColor = uRefOk ? Color.LightGreen : Color.IndianRed;
            textBox_RRef.BackColor = rRefOk ? Color.LightGreen : Color.IndianRed;
            textbox_R0.BackColor = r0Ok ? Color.LightGreen : Color.IndianRed;

            // Wenn eine Eingabe fehlt, Berechnung abbrechen
            if (!uRefOk || !rRefOk || !r0Ok) return;

            // 2. Referenzstrom berechnen
            // Einheiten: V / kOhm = mA
            double iRef = uRef / rRef;

            // 3. Widerstände der Stufen berechnen und in Labels anzeigen
            double r1 = 2 * r0;
            double r2 = 4 * r0;
            double r3 = 8 * r0;
            double r4 = 16 * r0;

            label_R1.Text = r1.ToString("F1") + " kΩ";
            label_R2.Text = r2.ToString("F1") + " kΩ";
            label_R3.Text = r3.ToString("F1") + " kΩ";
            label_R4.Text = r4.ToString("F1") + " kΩ";

            // 4. Gesamtwiderstand der offenen Schalter berechnen
            // Laut Skript: S=true bedeutet Schalter OFFEN -> Widerstand zählt!
            double rGesamt = 0;
            if (checkBox_S0.Checked) rGesamt += r0;
            if (checkBox_S1.Checked) rGesamt += r1;
            if (checkBox_S2.Checked) rGesamt += r2;
            if (checkBox_S3.Checked) rGesamt += r3;
            if (checkBox_S4.Checked) rGesamt += r4;

            // 5. Ausgangsspannung uA berechnen
            double uA = rGesamt * iRef;

            // 6. Ausgabe im Label mit 3 Nachkommastellen
            label2.Text = "uA = " + uA.ToString("F3") + " V";
        }
    }

}
