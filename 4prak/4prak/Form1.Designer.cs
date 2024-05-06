namespace _4prak
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Tekstas = new TextBox();
            label1 = new Label();
            Parasas = new TextBox();
            Eksponente = new TextBox();
            Modulis = new TextBox();
            P = new TextBox();
            Q = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dasd = new Label();
            Qa = new Label();
            dad = new Label();
            TikrintParasa = new Button();
            SugeneruotiPirminius = new Button();
            SukurtParasa = new Button();
            SuspendLayout();
            // 
            // Tekstas
            // 
            Tekstas.Location = new Point(29, 40);
            Tekstas.Multiline = true;
            Tekstas.Name = "Tekstas";
            Tekstas.Size = new Size(350, 162);
            Tekstas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 17);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 1;
            label1.Text = "Tekstas";
            // 
            // Parasas
            // 
            Parasas.Location = new Point(29, 228);
            Parasas.Name = "Parasas";
            Parasas.Size = new Size(100, 23);
            Parasas.TabIndex = 2;
            // 
            // Eksponente
            // 
            Eksponente.Location = new Point(155, 228);
            Eksponente.Name = "Eksponente";
            Eksponente.Size = new Size(100, 23);
            Eksponente.TabIndex = 3;
            // 
            // Modulis
            // 
            Modulis.Location = new Point(279, 228);
            Modulis.Name = "Modulis";
            Modulis.Size = new Size(100, 23);
            Modulis.TabIndex = 4;
            // 
            // P
            // 
            P.Location = new Point(81, 298);
            P.Name = "P";
            P.Size = new Size(100, 23);
            P.TabIndex = 5;
            // 
            // Q
            // 
            Q.Location = new Point(241, 298);
            Q.Name = "Q";
            Q.Size = new Size(100, 23);
            Q.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 205);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 7;
            label2.Text = "Parasas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(155, 205);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 8;
            label3.Text = "Eksponentė";
            // 
            // dasd
            // 
            dasd.AutoSize = true;
            dasd.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dasd.Location = new Point(279, 205);
            dasd.Name = "dasd";
            dasd.Size = new Size(62, 20);
            dasd.TabIndex = 9;
            dasd.Text = "Modulis";
            // 
            // Qa
            // 
            Qa.AutoSize = true;
            Qa.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Qa.Location = new Point(241, 275);
            Qa.Name = "Qa";
            Qa.Size = new Size(20, 20);
            Qa.TabIndex = 10;
            Qa.Text = "Q";
            // 
            // dad
            // 
            dad.AutoSize = true;
            dad.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dad.Location = new Point(81, 275);
            dad.Name = "dad";
            dad.Size = new Size(17, 20);
            dad.TabIndex = 11;
            dad.Text = "P";
            // 
            // TikrintParasa
            // 
            TikrintParasa.Location = new Point(138, 414);
            TikrintParasa.Name = "TikrintParasa";
            TikrintParasa.Size = new Size(159, 23);
            TikrintParasa.TabIndex = 15;
            TikrintParasa.Text = "Tikrint parasa";
            TikrintParasa.UseVisualStyleBackColor = true;
            TikrintParasa.Click += TikrintParasa_Click;
            // 
            // SugeneruotiPirminius
            // 
            SugeneruotiPirminius.Location = new Point(138, 356);
            SugeneruotiPirminius.Name = "SugeneruotiPirminius";
            SugeneruotiPirminius.Size = new Size(159, 23);
            SugeneruotiPirminius.TabIndex = 16;
            SugeneruotiPirminius.Text = "Sugeneruoti pirminius";
            SugeneruotiPirminius.UseVisualStyleBackColor = true;
            SugeneruotiPirminius.Click += SugeneruotiPirminius_Click;
            // 
            // SukurtParasa
            // 
            SukurtParasa.Location = new Point(138, 385);
            SukurtParasa.Name = "SukurtParasa";
            SukurtParasa.Size = new Size(159, 23);
            SukurtParasa.TabIndex = 17;
            SukurtParasa.Text = "Sukurti ir pat. parasa";
            SukurtParasa.UseVisualStyleBackColor = true;
            SukurtParasa.Click += SukurtParasa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 455);
            Controls.Add(SukurtParasa);
            Controls.Add(SugeneruotiPirminius);
            Controls.Add(TikrintParasa);
            Controls.Add(dad);
            Controls.Add(Qa);
            Controls.Add(dasd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Q);
            Controls.Add(P);
            Controls.Add(Modulis);
            Controls.Add(Eksponente);
            Controls.Add(Parasas);
            Controls.Add(label1);
            Controls.Add(Tekstas);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Tekstas;
        private Label label1;
        private TextBox Parasas;
        private TextBox Eksponente;
        private TextBox Modulis;
        private TextBox P;
        private TextBox Q;
        private Label label2;
        private Label label3;
        private Label dasd;
        private Label Qa;
        private Label dad;
        private Button TikrintParasa;
        private Button SugeneruotiPirminius;
        private Button SukurtParasa;
    }
}
