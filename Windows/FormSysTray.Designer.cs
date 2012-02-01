namespace MediaServer
{
    partial class FormSysTray
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
            this.components = new System.ComponentModel.Container();
            this.iNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.iContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openMediaServerConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitMediaServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // iNotifyIcon
            // 
            this.iNotifyIcon.ContextMenuStrip = this.iContextMenuStrip;
            this.iNotifyIcon.Text = "MediaServer";
            this.iNotifyIcon.Visible = true;
            this.iNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIconClick);
            // 
            // iContextMenuStrip
            // 
            this.iContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMediaServerConfigurationToolStripMenuItem,
            this.quitMediaServerToolStripMenuItem});
            this.iContextMenuStrip.Name = "iContextMenuStrip";
            this.iContextMenuStrip.Size = new System.Drawing.Size(258, 48);
            // 
            // openMediaServerConfigurationToolStripMenuItem
            // 
            this.openMediaServerConfigurationToolStripMenuItem.Name = "openMediaServerConfigurationToolStripMenuItem";
            this.openMediaServerConfigurationToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.openMediaServerConfigurationToolStripMenuItem.Text = "Open MediaServer Configuration...";
            this.openMediaServerConfigurationToolStripMenuItem.Click += new System.EventHandler(this.MenuItemOpenMediaServerConfigurationClick);
            // 
            // quitMediaServerToolStripMenuItem
            // 
            this.quitMediaServerToolStripMenuItem.Name = "quitMediaServerToolStripMenuItem";
            this.quitMediaServerToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.quitMediaServerToolStripMenuItem.Text = "Quit MediaServer";
            this.quitMediaServerToolStripMenuItem.Click += new System.EventHandler(this.MenuItemQuitMediaServerClick);
            // 
            // FormSysTray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "FormSysTray";
            this.ShowInTaskbar = false;
            this.Text = "FormSysTray";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.iContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon iNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip iContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openMediaServerConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitMediaServerToolStripMenuItem;

    }
}