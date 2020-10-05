namespace Adatbevitel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1_Rendszám = new System.Windows.Forms.Label();
            this.textBox1_Rendszám = new System.Windows.Forms.TextBox();
            this.label2_Teljesitmeny = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4_Tipus = new System.Windows.Forms.Label();
            this.label5_Gyartmany = new System.Windows.Forms.Label();
            this.textBox2_Gyártmány = new System.Windows.Forms.TextBox();
            this.listBox_Autok = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1_Típus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_Rendszám
            // 
            this.label1_Rendszám.AutoSize = true;
            this.label1_Rendszám.Location = new System.Drawing.Point(14, 16);
            this.label1_Rendszám.Name = "label1_Rendszám";
            this.label1_Rendszám.Size = new System.Drawing.Size(60, 13);
            this.label1_Rendszám.TabIndex = 0;
            this.label1_Rendszám.Text = "Rendszám:";
            // 
            // textBox1_Rendszám
            // 
            this.textBox1_Rendszám.Location = new System.Drawing.Point(101, 16);
            this.textBox1_Rendszám.Name = "textBox1_Rendszám";
            this.textBox1_Rendszám.Size = new System.Drawing.Size(142, 20);
            this.textBox1_Rendszám.TabIndex = 1;
            // 
            // label2_Teljesitmeny
            // 
            this.label2_Teljesitmeny.AutoSize = true;
            this.label2_Teljesitmeny.Location = new System.Drawing.Point(14, 79);
            this.label2_Teljesitmeny.Name = "label2_Teljesitmeny";
            this.label2_Teljesitmeny.Size = new System.Drawing.Size(68, 13);
            this.label2_Teljesitmeny.TabIndex = 2;
            this.label2_Teljesitmeny.Text = "Teljesitmény:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(101, 79);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(142, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "lóerő";
            // 
            // label4_Tipus
            // 
            this.label4_Tipus.AutoSize = true;
            this.label4_Tipus.Location = new System.Drawing.Point(21, 150);
            this.label4_Tipus.Name = "label4_Tipus";
            this.label4_Tipus.Size = new System.Drawing.Size(38, 13);
            this.label4_Tipus.TabIndex = 5;
            this.label4_Tipus.Text = "Típus:";
            // 
            // label5_Gyartmany
            // 
            this.label5_Gyartmany.AutoSize = true;
            this.label5_Gyartmany.Location = new System.Drawing.Point(21, 197);
            this.label5_Gyartmany.Name = "label5_Gyartmany";
            this.label5_Gyartmany.Size = new System.Drawing.Size(60, 13);
            this.label5_Gyartmany.TabIndex = 7;
            this.label5_Gyartmany.Text = "Gyártmány:";
            // 
            // textBox2_Gyártmány
            // 
            this.textBox2_Gyártmány.Location = new System.Drawing.Point(101, 190);
            this.textBox2_Gyártmány.Name = "textBox2_Gyártmány";
            this.textBox2_Gyártmány.Size = new System.Drawing.Size(142, 20);
            this.textBox2_Gyártmány.TabIndex = 8;
            // 
            // listBox_Autok
            // 
            this.listBox_Autok.FormattingEnabled = true;
            this.listBox_Autok.Location = new System.Drawing.Point(460, 31);
            this.listBox_Autok.Name = "listBox_Autok";
            this.listBox_Autok.Size = new System.Drawing.Size(219, 238);
            this.listBox_Autok.TabIndex = 9;
            this.listBox_Autok.SelectedIndexChanged += new System.EventHandler(this.ListBox_Autok_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "Rögzít";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBox1_Típus
            // 
            this.comboBox1_Típus.FormattingEnabled = true;
            this.comboBox1_Típus.Items.AddRange(new object[] {
            "Suzuki",
            "BMW",
            "Opel",
            "Audi"});
            this.comboBox1_Típus.Location = new System.Drawing.Point(101, 142);
            this.comboBox1_Típus.Name = "comboBox1_Típus";
            this.comboBox1_Típus.Size = new System.Drawing.Size(142, 21);
            this.comboBox1_Típus.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1_Típus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox_Autok);
            this.Controls.Add(this.textBox2_Gyártmány);
            this.Controls.Add(this.label5_Gyartmany);
            this.Controls.Add(this.label4_Tipus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2_Teljesitmeny);
            this.Controls.Add(this.textBox1_Rendszám);
            this.Controls.Add(this.label1_Rendszám);
            this.Name = "Form1";
            this.Text = "Gepjarmu_nyilvantartas";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_Rendszám;
        private System.Windows.Forms.TextBox textBox1_Rendszám;
        private System.Windows.Forms.Label label2_Teljesitmeny;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4_Tipus;
        private System.Windows.Forms.Label label5_Gyartmany;
        private System.Windows.Forms.TextBox textBox2_Gyártmány;
        private System.Windows.Forms.ListBox listBox_Autok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1_Típus;
    }
}

