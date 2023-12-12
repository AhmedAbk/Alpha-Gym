namespace ALPHA_GYM
{
    partial class espaceadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(espaceadmin));
            menuStrip1 = new MenuStrip();
            gererClientToolStripMenuItem = new ToolStripMenuItem();
            gererStaffToolStripMenuItem = new ToolStripMenuItem();
            gererEquipementToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gererClientToolStripMenuItem, gererStaffToolStripMenuItem, gererEquipementToolStripMenuItem, logoutToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gererClientToolStripMenuItem
            // 
            gererClientToolStripMenuItem.Name = "gererClientToolStripMenuItem";
            gererClientToolStripMenuItem.Size = new Size(101, 24);
            gererClientToolStripMenuItem.Text = "Gerer Client";
            gererClientToolStripMenuItem.Click += gererClientToolStripMenuItem_Click;
            // 
            // gererStaffToolStripMenuItem
            // 
            gererStaffToolStripMenuItem.Name = "gererStaffToolStripMenuItem";
            gererStaffToolStripMenuItem.Size = new Size(94, 24);
            gererStaffToolStripMenuItem.Text = "Gerer Staff";
            gererStaffToolStripMenuItem.Click += gererStaffToolStripMenuItem_Click;
            // 
            // gererEquipementToolStripMenuItem
            // 
            gererEquipementToolStripMenuItem.Name = "gererEquipementToolStripMenuItem";
            gererEquipementToolStripMenuItem.Size = new Size(143, 24);
            gererEquipementToolStripMenuItem.Text = "Gerer Equipement";
            gererEquipementToolStripMenuItem.Click += gererEquipementToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(70, 24);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // espaceadmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "espaceadmin";
            Text = "espaceadmin";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gererClientToolStripMenuItem;
        private ToolStripMenuItem gererStaffToolStripMenuItem;
        private ToolStripMenuItem gererEquipementToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}