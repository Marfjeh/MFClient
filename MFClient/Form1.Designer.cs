namespace MFClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.browserPanel = new System.Windows.Forms.Panel();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dEBUGMENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDevToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugmenu = new System.Windows.Forms.MenuStrip();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.browserPanel.SuspendLayout();
            this.loadingPanel.SuspendLayout();
            this.debugmenu.SuspendLayout();
            this.toolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // browserPanel
            // 
            this.browserPanel.Controls.Add(this.loadingPanel);
            this.browserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserPanel.Location = new System.Drawing.Point(0, 34);
            this.browserPanel.Name = "browserPanel";
            this.browserPanel.Size = new System.Drawing.Size(1015, 539);
            this.browserPanel.TabIndex = 0;
            // 
            // loadingPanel
            // 
            this.loadingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadingPanel.Controls.Add(this.label1);
            this.loadingPanel.Location = new System.Drawing.Point(12, 6);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(124, 32);
            this.loadingPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loading...";
            this.label1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDoubleClick);
            // 
            // dEBUGMENUToolStripMenuItem
            // 
            this.dEBUGMENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDevToolsToolStripMenuItem,
            this.reloadPageToolStripMenuItem});
            this.dEBUGMENUToolStripMenuItem.Name = "dEBUGMENUToolStripMenuItem";
            this.dEBUGMENUToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.dEBUGMENUToolStripMenuItem.Text = "DEBUG-MENU";
            // 
            // openDevToolsToolStripMenuItem
            // 
            this.openDevToolsToolStripMenuItem.Name = "openDevToolsToolStripMenuItem";
            this.openDevToolsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openDevToolsToolStripMenuItem.Text = "Open Dev tools";
            this.openDevToolsToolStripMenuItem.Click += new System.EventHandler(this.openDevToolsToolStripMenuItem_Click);
            // 
            // reloadPageToolStripMenuItem
            // 
            this.reloadPageToolStripMenuItem.Name = "reloadPageToolStripMenuItem";
            this.reloadPageToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.reloadPageToolStripMenuItem.Text = "Reload page";
            this.reloadPageToolStripMenuItem.Click += new System.EventHandler(this.reloadPageToolStripMenuItem_Click);
            // 
            // debugmenu
            // 
            this.debugmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dEBUGMENUToolStripMenuItem});
            this.debugmenu.Location = new System.Drawing.Point(0, 0);
            this.debugmenu.Name = "debugmenu";
            this.debugmenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.debugmenu.Size = new System.Drawing.Size(707, 24);
            this.debugmenu.TabIndex = 1;
            this.debugmenu.Text = "menuStrip1";
            this.debugmenu.Visible = false;
            // 
            // toolPanel
            // 
            this.toolPanel.Controls.Add(this.button5);
            this.toolPanel.Controls.Add(this.textBox1);
            this.toolPanel.Controls.Add(this.button4);
            this.toolPanel.Controls.Add(this.button3);
            this.toolPanel.Controls.Add(this.button2);
            this.toolPanel.Controls.Add(this.button1);
            this.toolPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolPanel.Location = new System.Drawing.Point(0, 0);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(1015, 34);
            this.toolPanel.TabIndex = 0;
            this.toolPanel.Visible = false;
            this.toolPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.toolPanel_Paint);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(970, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 34);
            this.button5.TabIndex = 5;
            this.button5.Text = ">>";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(142, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(822, 22);
            this.textBox1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(102, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "H";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(68, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "R";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(34, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 573);
            this.Controls.Add(this.browserPanel);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.debugmenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.debugmenu;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Jade Hotel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.browserPanel.ResumeLayout(false);
            this.loadingPanel.ResumeLayout(false);
            this.loadingPanel.PerformLayout();
            this.debugmenu.ResumeLayout(false);
            this.debugmenu.PerformLayout();
            this.toolPanel.ResumeLayout(false);
            this.toolPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel browserPanel;
        private System.Windows.Forms.ToolStripMenuItem dEBUGMENUToolStripMenuItem;
        private System.Windows.Forms.MenuStrip debugmenu;
        private System.Windows.Forms.ToolStripMenuItem openDevToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadPageToolStripMenuItem;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.Label label1;
    }
}

