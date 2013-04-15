namespace WindowsFormsApplication1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalPortListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.futureUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportTheDevelopersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lisWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aevvsWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem1,
            this.supportTheDevelopersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(435, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.helpToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wikiToolStripMenuItem,
            this.generalPortListToolStripMenuItem,
            this.changelogToolStripMenuItem,
            this.supportLogToolStripMenuItem,
            this.futureUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // wikiToolStripMenuItem
            // 
            this.wikiToolStripMenuItem.Name = "wikiToolStripMenuItem";
            this.wikiToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.wikiToolStripMenuItem.Text = "Wiki";
            // 
            // generalPortListToolStripMenuItem
            // 
            this.generalPortListToolStripMenuItem.Name = "generalPortListToolStripMenuItem";
            this.generalPortListToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.generalPortListToolStripMenuItem.Text = "General Port List";
            // 
            // changelogToolStripMenuItem
            // 
            this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            this.changelogToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.changelogToolStripMenuItem.Text = "Changelog";
            // 
            // supportLogToolStripMenuItem
            // 
            this.supportLogToolStripMenuItem.Name = "supportLogToolStripMenuItem";
            this.supportLogToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.supportLogToolStripMenuItem.Text = "Support Log";
            // 
            // futureUpdatesToolStripMenuItem
            // 
            this.futureUpdatesToolStripMenuItem.Name = "futureUpdatesToolStripMenuItem";
            this.futureUpdatesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.futureUpdatesToolStripMenuItem.Text = "Future Updates";
            // 
            // supportTheDevelopersToolStripMenuItem
            // 
            this.supportTheDevelopersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lisWebsiteToolStripMenuItem,
            this.aevvsWebsiteToolStripMenuItem});
            this.supportTheDevelopersToolStripMenuItem.Name = "supportTheDevelopersToolStripMenuItem";
            this.supportTheDevelopersToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.supportTheDevelopersToolStripMenuItem.Text = "Support The Developers";
            // 
            // lisWebsiteToolStripMenuItem
            // 
            this.lisWebsiteToolStripMenuItem.Name = "lisWebsiteToolStripMenuItem";
            this.lisWebsiteToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.lisWebsiteToolStripMenuItem.Text = "li\'s Website";
            // 
            // aevvsWebsiteToolStripMenuItem
            // 
            this.aevvsWebsiteToolStripMenuItem.Name = "aevvsWebsiteToolStripMenuItem";
            this.aevvsWebsiteToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.aevvsWebsiteToolStripMenuItem.Text = "Aevv\'s Website";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 405);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "t";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalPortListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem futureUpdatesToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem supportTheDevelopersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lisWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aevvsWebsiteToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}

