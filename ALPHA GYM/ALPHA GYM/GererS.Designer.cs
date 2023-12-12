namespace ALPHA_GYM
{
    partial class GererS
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
            prestxt = new TextBox();
            numstxt = new TextBox();
            nomstxt = new TextBox();
            dataGridView1 = new DataGridView();
            supsbtn = new Button();
            ajoutsbtn = new Button();
            majsbtn = new Button();
            label4 = new Label();
            radiosBtnFemale = new RadioButton();
            radiosBtnMale = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ansstxt = new TextBox();
            anstxt = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // prestxt
            // 
            prestxt.Location = new Point(134, 110);
            prestxt.Name = "prestxt";
            prestxt.Size = new Size(125, 27);
            prestxt.TabIndex = 33;
            // 
            // numstxt
            // 
            numstxt.Location = new Point(134, 166);
            numstxt.Name = "numstxt";
            numstxt.Size = new Size(125, 27);
            numstxt.TabIndex = 32;
            // 
            // nomstxt
            // 
            nomstxt.Location = new Point(134, 47);
            nomstxt.Name = "nomstxt";
            nomstxt.Size = new Size(125, 27);
            nomstxt.TabIndex = 31;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(420, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(359, 415);
            dataGridView1.TabIndex = 30;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // supsbtn
            // 
            supsbtn.Location = new Point(288, 248);
            supsbtn.Name = "supsbtn";
            supsbtn.Size = new Size(94, 29);
            supsbtn.TabIndex = 29;
            supsbtn.Text = "Supprimer";
            supsbtn.UseVisualStyleBackColor = true;
            supsbtn.Click += supsbtn_Click;
            // 
            // ajoutsbtn
            // 
            ajoutsbtn.Location = new Point(288, 76);
            ajoutsbtn.Name = "ajoutsbtn";
            ajoutsbtn.Size = new Size(94, 29);
            ajoutsbtn.TabIndex = 27;
            ajoutsbtn.Text = "Ajouter";
            ajoutsbtn.UseVisualStyleBackColor = true;
            ajoutsbtn.Click += ajoutsbtn_Click;
            // 
            // majsbtn
            // 
            majsbtn.Location = new Point(288, 163);
            majsbtn.Name = "majsbtn";
            majsbtn.Size = new Size(94, 29);
            majsbtn.TabIndex = 26;
            majsbtn.Text = "Mise A Jour";
            majsbtn.UseVisualStyleBackColor = true;
            majsbtn.Click += majsbtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 294);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 24;
            label4.Text = "Sexe";
            // 
            // radiosBtnFemale
            // 
            radiosBtnFemale.AutoSize = true;
            radiosBtnFemale.Location = new Point(134, 332);
            radiosBtnFemale.Name = "radiosBtnFemale";
            radiosBtnFemale.Size = new Size(79, 24);
            radiosBtnFemale.TabIndex = 23;
            radiosBtnFemale.TabStop = true;
            radiosBtnFemale.Text = "Femme";
            radiosBtnFemale.UseVisualStyleBackColor = true;
            // 
            // radiosBtnMale
            // 
            radiosBtnMale.AutoSize = true;
            radiosBtnMale.Location = new Point(134, 292);
            radiosBtnMale.Name = "radiosBtnMale";
            radiosBtnMale.Size = new Size(84, 24);
            radiosBtnMale.TabIndex = 20;
            radiosBtnMale.TabStop = true;
            radiosBtnMale.Text = "Homme";
            radiosBtnMale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 110);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 19;
            label3.Text = "Prenom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 169);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 18;
            label2.Text = "Num tel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 50);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 17;
            label1.Text = "Nom";
            // 
            // ansstxt
            // 
            ansstxt.Location = new Point(134, 229);
            ansstxt.Name = "ansstxt";
            ansstxt.Size = new Size(125, 27);
            ansstxt.TabIndex = 35;
            // 
            // anstxt
            // 
            anstxt.AutoSize = true;
            anstxt.Location = new Point(12, 232);
            anstxt.Name = "anstxt";
            anstxt.Size = new Size(107, 20);
            anstxt.TabIndex = 34;
            anstxt.Text = "ans experience";
            // 
            // GererS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ansstxt);
            Controls.Add(anstxt);
            Controls.Add(prestxt);
            Controls.Add(numstxt);
            Controls.Add(nomstxt);
            Controls.Add(dataGridView1);
            Controls.Add(supsbtn);
            Controls.Add(ajoutsbtn);
            Controls.Add(majsbtn);
            Controls.Add(label4);
            Controls.Add(radiosBtnFemale);
            Controls.Add(radiosBtnMale);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GererS";
            Text = "GererS";
            Load += GererS_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox prestxt;
        private TextBox numstxt;
        private TextBox nomstxt;
        private DataGridView dataGridView1;
        private Button supsbtn;
        private Button ajoutsbtn;
        private Button majsbtn;
        private Label label4;
        private RadioButton radiosBtnFemale;
        private RadioButton radiosBtnMale;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox ansstxt;
        private Label anstxt;
    }
}