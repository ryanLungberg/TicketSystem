﻿namespace TicketSystem
{
    partial class FrmParent
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCreateEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCreateCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCreatePerformer = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCreateVenue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.btnMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1974, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 38);
            // 
            // btnMenu
            // 
            this.btnMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEventToolStripMenuItem});
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(90, 38);
            this.btnMenu.Text = "Menu";
            // 
            // createEventToolStripMenuItem
            // 
            this.createEventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCreateEvent,
            this.BtnCreateCategory,
            this.BtnCreatePerformer,
            this.BtnCreateVenue});
            this.createEventToolStripMenuItem.Name = "createEventToolStripMenuItem";
            this.createEventToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.createEventToolStripMenuItem.Text = "Create";
            // 
            // BtnCreateEvent
            // 
            this.BtnCreateEvent.Name = "BtnCreateEvent";
            this.BtnCreateEvent.Size = new System.Drawing.Size(269, 38);
            this.BtnCreateEvent.Text = "Event";
            this.BtnCreateEvent.Click += new System.EventHandler(this.BtnCreateEvent_Click);
            // 
            // BtnCreateCategory
            // 
            this.BtnCreateCategory.Name = "BtnCreateCategory";
            this.BtnCreateCategory.Size = new System.Drawing.Size(269, 38);
            this.BtnCreateCategory.Text = "Category";
            this.BtnCreateCategory.Click += new System.EventHandler(this.BtnCreateCategory_Click);
            // 
            // BtnCreatePerformer
            // 
            this.BtnCreatePerformer.Name = "BtnCreatePerformer";
            this.BtnCreatePerformer.Size = new System.Drawing.Size(269, 38);
            this.BtnCreatePerformer.Text = "Performer";
            this.BtnCreatePerformer.Click += new System.EventHandler(this.BtnCreatePerformer_Click);
            // 
            // BtnCreateVenue
            // 
            this.BtnCreateVenue.Name = "BtnCreateVenue";
            this.BtnCreateVenue.Size = new System.Drawing.Size(269, 38);
            this.BtnCreateVenue.Text = "Venue";
            this.BtnCreateVenue.Click += new System.EventHandler(this.BtnCreateVenue_Click);
            // 
            // FrmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1974, 1329);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(2000, 1400);
            this.MinimumSize = new System.Drawing.Size(2000, 1400);
            this.Name = "FrmParent";
            this.Text = "FrmParent";
            this.Load += new System.EventHandler(this.FrmParent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnMenu;
        private System.Windows.Forms.ToolStripMenuItem createEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtnCreateEvent;
        private System.Windows.Forms.ToolStripMenuItem BtnCreateCategory;
        private System.Windows.Forms.ToolStripMenuItem BtnCreatePerformer;
        private System.Windows.Forms.ToolStripMenuItem BtnCreateVenue;
    }
}