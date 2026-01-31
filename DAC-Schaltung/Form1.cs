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
        
        // Falls du die Checkboxen im Designer an dieses Event gebunden hast:
        private void CheckBox_CheckStateChanged(object sender, EventArgs e)
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
            
            // Ausgabe der Stromstärke (Formatierung laut Beispiel U.4 auf Seite U8)
            // Falls du noch kein Label dafür hast, kannst du es auch in label2 mit anzeigen
            string stromAnzeige = "IRef = " + iRef.ToString("F2") + " mA";

            // 3. Widerstände der Stufen berechnen und anzeigen
            // R1=2*R0, R2=4*R0, R3=8*R0, R4=16*R0
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

            // 6. Finale Werteausgabe im großen Label
            // Anzeige von IRef und uA kombiniert (entspricht Screenshots auf U8)
            label2.Text = stromAnzeige + "\n" + "uA = " + uA.ToString("F3") + " V";
        }
    }

}
