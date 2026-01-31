namespace DAC_Schaltung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.infoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.checkBox_S0 = new System.Windows.Forms.CheckBox();
			this.checkBox_S1 = new System.Windows.Forms.CheckBox();
			this.checkBox_S2 = new System.Windows.Forms.CheckBox();
			this.checkBox_S4 = new System.Windows.Forms.CheckBox();
			this.checkBox_S3 = new System.Windows.Forms.CheckBox();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.textBox_RRef = new System.Windows.Forms.TextBox();
			this.textbox_R0 = new System.Windows.Forms.TextBox();
			this.label_R4 = new System.Windows.Forms.Label();
			this.label_R3 = new System.Windows.Forms.Label();
			this.label_R2 = new System.Windows.Forms.Label();
			this.label_R1 = new System.Windows.Forms.Label();
			this.textBox_URef_ = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.infoToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1894, 40);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// dateiToolStripMenuItem
			// 
			this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
			this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
			this.dateiToolStripMenuItem.Size = new System.Drawing.Size(90, 40);
			this.dateiToolStripMenuItem.Text = "Datei";
			// 
			// beendenToolStripMenuItem
			// 
			this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
			this.beendenToolStripMenuItem.Size = new System.Drawing.Size(242, 44);
			this.beendenToolStripMenuItem.Text = "Beenden";
			this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
			// 
			// infoToolStripMenuItem
			// 
			this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem1});
			this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
			this.infoToolStripMenuItem.Size = new System.Drawing.Size(84, 40);
			this.infoToolStripMenuItem.Text = "Hilfe";
			// 
			// infoToolStripMenuItem1
			// 
			this.infoToolStripMenuItem1.Name = "infoToolStripMenuItem1";
			this.infoToolStripMenuItem1.Size = new System.Drawing.Size(189, 44);
			this.infoToolStripMenuItem1.Text = "Info";
			this.infoToolStripMenuItem1.Click += new System.EventHandler(this.infoToolStripMenuItem1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::DAC_Schaltung.Properties.Resources.DAC;
			this.pictureBox1.Location = new System.Drawing.Point(205, 90);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1520, 567);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// checkBox_S0
			// 
			this.checkBox_S0.AutoSize = true;
			this.checkBox_S0.Location = new System.Drawing.Point(444, 127);
			this.checkBox_S0.Name = "checkBox_S0";
			this.checkBox_S0.Size = new System.Drawing.Size(28, 27);
			this.checkBox_S0.TabIndex = 2;
			this.checkBox_S0.UseVisualStyleBackColor = true;
			this.checkBox_S0.CheckedChanged += new System.EventHandler(this.textbox_R0_TextChanged);
			// 
			// checkBox_S1
			// 
			this.checkBox_S1.AutoSize = true;
			this.checkBox_S1.Location = new System.Drawing.Point(444, 161);
			this.checkBox_S1.Name = "checkBox_S1";
			this.checkBox_S1.Size = new System.Drawing.Size(28, 27);
			this.checkBox_S1.TabIndex = 3;
			this.checkBox_S1.UseVisualStyleBackColor = true;
			this.checkBox_S1.CheckedChanged += new System.EventHandler(this.textbox_R0_TextChanged);
			// 
			// checkBox_S2
			// 
			this.checkBox_S2.AutoSize = true;
			this.checkBox_S2.Location = new System.Drawing.Point(444, 196);
			this.checkBox_S2.Name = "checkBox_S2";
			this.checkBox_S2.Size = new System.Drawing.Size(28, 27);
			this.checkBox_S2.TabIndex = 4;
			this.checkBox_S2.UseVisualStyleBackColor = true;
			this.checkBox_S2.CheckedChanged += new System.EventHandler(this.textbox_R0_TextChanged);
			// 
			// checkBox_S4
			// 
			this.checkBox_S4.AutoSize = true;
			this.checkBox_S4.Location = new System.Drawing.Point(444, 267);
			this.checkBox_S4.Name = "checkBox_S4";
			this.checkBox_S4.Size = new System.Drawing.Size(28, 27);
			this.checkBox_S4.TabIndex = 5;
			this.checkBox_S4.UseVisualStyleBackColor = true;
			this.checkBox_S4.CheckedChanged += new System.EventHandler(this.textbox_R0_TextChanged);
			// 
			// checkBox_S3
			// 
			this.checkBox_S3.AutoSize = true;
			this.checkBox_S3.Location = new System.Drawing.Point(444, 232);
			this.checkBox_S3.Name = "checkBox_S3";
			this.checkBox_S3.Size = new System.Drawing.Size(28, 27);
			this.checkBox_S3.TabIndex = 6;
			this.checkBox_S3.UseVisualStyleBackColor = true;
			this.checkBox_S3.CheckedChanged += new System.EventHandler(this.textbox_R0_TextChanged);
			// 
			// textBox_RRef
			// 
			this.textBox_RRef.BackColor = System.Drawing.Color.IndianRed;
			this.textBox_RRef.Location = new System.Drawing.Point(405, 459);
			this.textBox_RRef.Name = "textBox_RRef";
			this.textBox_RRef.Size = new System.Drawing.Size(84, 31);
			this.textBox_RRef.TabIndex = 7;
			// 
			// textbox_R0
			// 
			this.textbox_R0.BackColor = System.Drawing.Color.IndianRed;
			this.textbox_R0.Location = new System.Drawing.Point(1442, 369);
			this.textbox_R0.Name = "textbox_R0";
			this.textbox_R0.Size = new System.Drawing.Size(87, 31);
			this.textbox_R0.TabIndex = 9;
			this.textbox_R0.TextChanged += new System.EventHandler(this.textbox_R0_TextChanged);
			// 
			// label_R4
			// 
			this.label_R4.AutoSize = true;
			this.label_R4.Location = new System.Drawing.Point(726, 372);
			this.label_R4.Name = "label_R4";
			this.label_R4.Size = new System.Drawing.Size(70, 25);
			this.label_R4.TabIndex = 10;
			this.label_R4.Text = "label1";
			// 
			// label_R3
			// 
			this.label_R3.AutoSize = true;
			this.label_R3.Location = new System.Drawing.Point(905, 372);
			this.label_R3.Name = "label_R3";
			this.label_R3.Size = new System.Drawing.Size(70, 25);
			this.label_R3.TabIndex = 11;
			this.label_R3.Text = "label2";
			// 
			// label_R2
			// 
			this.label_R2.AutoSize = true;
			this.label_R2.Location = new System.Drawing.Point(1084, 372);
			this.label_R2.Name = "label_R2";
			this.label_R2.Size = new System.Drawing.Size(70, 25);
			this.label_R2.TabIndex = 12;
			this.label_R2.Text = "label3";
			// 
			// label_R1
			// 
			this.label_R1.AutoSize = true;
			this.label_R1.Location = new System.Drawing.Point(1264, 372);
			this.label_R1.Name = "label_R1";
			this.label_R1.Size = new System.Drawing.Size(70, 25);
			this.label_R1.TabIndex = 13;
			this.label_R1.Text = "label4";
			// 
			// textBox_URef_
			// 
			this.textBox_URef_.BackColor = System.Drawing.Color.IndianRed;
			this.textBox_URef_.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.textBox_URef_.Location = new System.Drawing.Point(366, 553);
			this.textBox_URef_.Name = "textBox_URef_";
			this.textBox_URef_.Size = new System.Drawing.Size(87, 31);
			this.textBox_URef_.TabIndex = 14;
			this.textBox_URef_.TextChanged += new System.EventHandler(this.Uref_textBox__TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(205, 680);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(1248, 87);
			this.label2.TabIndex = 15;
			this.label2.Text = resources.GetString("label2.Text");
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1894, 1009);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox_URef_);
			this.Controls.Add(this.label_R1);
			this.Controls.Add(this.label_R2);
			this.Controls.Add(this.label_R3);
			this.Controls.Add(this.label_R4);
			this.Controls.Add(this.textbox_R0);
			this.Controls.Add(this.textBox_RRef);
			this.Controls.Add(this.checkBox_S3);
			this.Controls.Add(this.checkBox_S4);
			this.Controls.Add(this.checkBox_S2);
			this.Controls.Add(this.checkBox_S1);
			this.Controls.Add(this.checkBox_S0);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "DAC-Schaltung";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox_S0;
        private System.Windows.Forms.CheckBox checkBox_S1;
        private System.Windows.Forms.CheckBox checkBox_S2;
        private System.Windows.Forms.CheckBox checkBox_S4;
        private System.Windows.Forms.CheckBox checkBox_S3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textBox_RRef;
        private System.Windows.Forms.TextBox textBox_URef;
        private System.Windows.Forms.TextBox textbox_R0;
        private System.Windows.Forms.Label label_R4;
        private System.Windows.Forms.Label label_R3;
        private System.Windows.Forms.Label label_R2;
        private System.Windows.Forms.Label label_R1;
        private System.Windows.Forms.TextBox textBox_URef_;
        private System.Windows.Forms.Label label2;
    }
}

