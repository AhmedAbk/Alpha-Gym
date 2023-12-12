namespace ALPHA_GYM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            loginbtn = new Button();
            label1 = new Label();
            pw = new TextBox();
            username = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 310);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(loginbtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pw);
            groupBox1.Controls.Add(username);
            groupBox1.Location = new Point(383, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(399, 310);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sign In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 145);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // loginbtn
            // 
            loginbtn.Location = new Point(6, 227);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(371, 38);
            loginbtn.TabIndex = 4;
            loginbtn.Text = "login";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 44);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // pw
            // 
            pw.ForeColor = SystemColors.Highlight;
            pw.Location = new Point(140, 142);
            pw.Name = "pw";
            pw.Size = new Size(237, 27);
            pw.TabIndex = 3;
            pw.UseSystemPasswordChar = true;
            // 
            // username
            // 
            username.ForeColor = SystemColors.Highlight;
            username.Location = new Point(140, 41);
            username.Name = "username";
            username.Size = new Size(237, 27);
            username.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label2;
        private Button loginbtn;
        private Label label1;
        private TextBox pw;
        private TextBox username;
    }
}