namespace ALPHA_GYM
{
    partial class GererC
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            radioBtnMale = new RadioButton();
            radioBtnFemale = new RadioButton();
            label4 = new Label();
            majbtn = new Button();
            ajoutbtn = new Button();
            supbtn = new Button();
            dataGridView1 = new DataGridView();
            nomtxt = new TextBox();
            numtxt = new TextBox();
            pretxt = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 44);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 163);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Num tel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 104);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Prenom";
            // 
            // radioBtnMale
            // 
            radioBtnMale.AutoSize = true;
            radioBtnMale.Location = new Point(116, 229);
            radioBtnMale.Name = "radioBtnMale";
            radioBtnMale.Size = new Size(84, 24);
            radioBtnMale.TabIndex = 3;
            radioBtnMale.TabStop = true;
            radioBtnMale.Text = "Homme";
            radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // radioBtnFemale
            // 
            radioBtnFemale.AutoSize = true;
            radioBtnFemale.Location = new Point(116, 269);
            radioBtnFemale.Name = "radioBtnFemale";
            radioBtnFemale.Size = new Size(79, 24);
            radioBtnFemale.TabIndex = 6;
            radioBtnFemale.TabStop = true;
            radioBtnFemale.Text = "Femme";
            radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 231);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 7;
            label4.Text = "Sexe";
            // 
            // majbtn
            // 
            majbtn.Location = new Point(282, 190);
            majbtn.Name = "majbtn";
            majbtn.Size = new Size(94, 29);
            majbtn.TabIndex = 9;
            majbtn.Text = "Mise A Jour";
            majbtn.UseVisualStyleBackColor = true;
            majbtn.Click += majbtn_Click;
            // 
            // ajoutbtn
            // 
            ajoutbtn.Location = new Point(282, 98);
            ajoutbtn.Name = "ajoutbtn";
            ajoutbtn.Size = new Size(94, 29);
            ajoutbtn.TabIndex = 10;
            ajoutbtn.Text = "Ajouter";
            ajoutbtn.UseVisualStyleBackColor = true;
            ajoutbtn.Click += ajoutbtn_Click;
            // 
            // supbtn
            // 
            supbtn.Location = new Point(282, 284);
            supbtn.Name = "supbtn";
            supbtn.Size = new Size(94, 29);
            supbtn.TabIndex = 12;
            supbtn.Text = "Supprimer";
            supbtn.UseVisualStyleBackColor = true;
            supbtn.Click += supbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(429, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(359, 415);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
          //  dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nomtxt
            // 
            nomtxt.Location = new Point(123, 48);
            nomtxt.Name = "nomtxt";
            nomtxt.Size = new Size(125, 27);
            nomtxt.TabIndex = 14;
            // 
            // numtxt
            // 
            numtxt.Location = new Point(123, 160);
            numtxt.Name = "numtxt";
            numtxt.Size = new Size(125, 27);
            numtxt.TabIndex = 15;
            // 
            // pretxt
            // 
            pretxt.Location = new Point(123, 104);
            pretxt.Name = "pretxt";
            pretxt.Size = new Size(125, 27);
            pretxt.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(116, 346);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 323);
            label5.Name = "label5";
            label5.Size = new Size(157, 20);
            label5.TabIndex = 18;
            label5.Text = "Methode De Paiement";
            // 
            // GererC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(pretxt);
            Controls.Add(numtxt);
            Controls.Add(nomtxt);
            Controls.Add(dataGridView1);
            Controls.Add(supbtn);
            Controls.Add(ajoutbtn);
            Controls.Add(majbtn);
            Controls.Add(label4);
            Controls.Add(radioBtnFemale);
            Controls.Add(radioBtnMale);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GererC";
            Text = "GererC";
            Load += GererC_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton radioBtnMale;
        private RadioButton radioBtnFemale;
        private Label label4;
        private Button majbtn;
        private Button ajoutbtn;
        private Button supbtn;
        private DataGridView dataGridView1;
        private TextBox nomtxt;
        private TextBox numtxt;
        private TextBox pretxt;
        private ComboBox comboBox1;
        private Label label5;
    }
}