namespace ALPHA_GYM
{
    partial class GererE
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
            nometxt = new TextBox();
            dataGridView1 = new DataGridView();
            supbtn = new Button();
            ajoutbtn = new Button();
            majbtn = new Button();
            label1 = new Label();
            destxt = new TextBox();
            label3 = new Label();
            poidtxt = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // nometxt
            // 
            nometxt.Location = new Point(29, 50);
            nometxt.Name = "nometxt";
            nometxt.Size = new Size(125, 27);
            nometxt.TabIndex = 31;
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
            // supbtn
            // 
            supbtn.Location = new Point(273, 317);
            supbtn.Name = "supbtn";
            supbtn.Size = new Size(94, 29);
            supbtn.TabIndex = 29;
            supbtn.Text = "Supprimer";
            supbtn.UseVisualStyleBackColor = true;
            supbtn.Click += supbtn_Click;
            // 
            // ajoutbtn
            // 
            ajoutbtn.Location = new Point(273, 104);
            ajoutbtn.Name = "ajoutbtn";
            ajoutbtn.Size = new Size(94, 29);
            ajoutbtn.TabIndex = 27;
            ajoutbtn.Text = "Ajouter";
            ajoutbtn.UseVisualStyleBackColor = true;
            ajoutbtn.Click += ajoutbtn_Click;
            // 
            // majbtn
            // 
            majbtn.Location = new Point(273, 212);
            majbtn.Name = "majbtn";
            majbtn.Size = new Size(94, 29);
            majbtn.TabIndex = 26;
            majbtn.Text = "Mise A Jour";
            majbtn.UseVisualStyleBackColor = true;
            majbtn.Click += majbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 18);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 17;
            label1.Text = "Nom de equipemnt";
            // 
            // destxt
            // 
            destxt.Location = new Point(29, 130);
            destxt.Name = "destxt";
            destxt.Size = new Size(125, 27);
            destxt.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 95);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 19;
            label3.Text = "Description";
            // 
            // poidtxt
            // 
            poidtxt.Location = new Point(29, 202);
            poidtxt.Name = "poidtxt";
            poidtxt.Size = new Size(125, 27);
            poidtxt.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 170);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 35;
            label2.Text = "Poids";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(29, 277);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 244);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 37;
            label4.Text = "Muscle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 326);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 39;
            label5.Text = "type";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(29, 359);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(125, 28);
            comboBox2.TabIndex = 38;
            // 
            // GererE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(poidtxt);
            Controls.Add(destxt);
            Controls.Add(nometxt);
            Controls.Add(dataGridView1);
            Controls.Add(supbtn);
            Controls.Add(ajoutbtn);
            Controls.Add(majbtn);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "GererE";
            Text = "GererE";
            Load += GererE_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nometxt;
        private DataGridView dataGridView1;
        private Button supbtn;
        private Button ajoutbtn;
        private Button majbtn;
        private Label label1;
        private TextBox destxt;
        private Label label3;
        private TextBox poidtxt;
        private Label label2;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private ComboBox comboBox2;
    }
}