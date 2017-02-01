namespace TicketSystem
{
    partial class TicketSystem
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
            this.lstBoxEvents = new System.Windows.Forms.ListBox();
            this.lstSelectCategory = new System.Windows.Forms.ListBox();
            this.txtSearchPerformer = new System.Windows.Forms.TextBox();
            this.txtSearchVenue = new System.Windows.Forms.TextBox();
            this.dtSearchDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearchCategory = new System.Windows.Forms.Button();
            this.btnSearchPerformer = new System.Windows.Forms.Button();
            this.btnSearchVenue = new System.Windows.Forms.Button();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEventDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxEvents
            // 
            this.lstBoxEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxEvents.FormattingEnabled = true;
            this.lstBoxEvents.ItemHeight = 31;
            this.lstBoxEvents.Location = new System.Drawing.Point(153, 162);
            this.lstBoxEvents.Name = "lstBoxEvents";
            this.lstBoxEvents.Size = new System.Drawing.Size(764, 996);
            this.lstBoxEvents.TabIndex = 0;
            // 
            // lstSelectCategory
            // 
            this.lstSelectCategory.AllowDrop = true;
            this.lstSelectCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSelectCategory.FormattingEnabled = true;
            this.lstSelectCategory.ItemHeight = 31;
            this.lstSelectCategory.Location = new System.Drawing.Point(1093, 142);
            this.lstSelectCategory.Name = "lstSelectCategory";
            this.lstSelectCategory.Size = new System.Drawing.Size(383, 221);
            this.lstSelectCategory.TabIndex = 1;
            // 
            // txtSearchPerformer
            // 
            this.txtSearchPerformer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPerformer.Location = new System.Drawing.Point(1093, 434);
            this.txtSearchPerformer.Name = "txtSearchPerformer";
            this.txtSearchPerformer.Size = new System.Drawing.Size(383, 38);
            this.txtSearchPerformer.TabIndex = 2;
            this.txtSearchPerformer.Text = "Search by performer";
            // 
            // txtSearchVenue
            // 
            this.txtSearchVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchVenue.Location = new System.Drawing.Point(1093, 546);
            this.txtSearchVenue.Name = "txtSearchVenue";
            this.txtSearchVenue.Size = new System.Drawing.Size(383, 38);
            this.txtSearchVenue.TabIndex = 3;
            this.txtSearchVenue.Text = "Search by venue";
            // 
            // dtSearchDate
            // 
            this.dtSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSearchDate.Location = new System.Drawing.Point(1093, 629);
            this.dtSearchDate.Name = "dtSearchDate";
            this.dtSearchDate.Size = new System.Drawing.Size(383, 38);
            this.dtSearchDate.TabIndex = 4;
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearchCategory.Location = new System.Drawing.Point(1543, 142);
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Size = new System.Drawing.Size(171, 44);
            this.btnSearchCategory.TabIndex = 5;
            this.btnSearchCategory.Text = "Search";
            this.btnSearchCategory.UseVisualStyleBackColor = false;
            // 
            // btnSearchPerformer
            // 
            this.btnSearchPerformer.Location = new System.Drawing.Point(1543, 427);
            this.btnSearchPerformer.Name = "btnSearchPerformer";
            this.btnSearchPerformer.Size = new System.Drawing.Size(171, 44);
            this.btnSearchPerformer.TabIndex = 6;
            this.btnSearchPerformer.Text = "Search";
            this.btnSearchPerformer.UseVisualStyleBackColor = true;
            // 
            // btnSearchVenue
            // 
            this.btnSearchVenue.Location = new System.Drawing.Point(1543, 533);
            this.btnSearchVenue.Name = "btnSearchVenue";
            this.btnSearchVenue.Size = new System.Drawing.Size(171, 44);
            this.btnSearchVenue.TabIndex = 7;
            this.btnSearchVenue.Text = "Search";
            this.btnSearchVenue.UseVisualStyleBackColor = true;
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Location = new System.Drawing.Point(1543, 629);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(171, 44);
            this.btnSearchDate.TabIndex = 8;
            this.btnSearchDate.Text = "Search";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 25.125F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(291, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 77);
            this.label1.TabIndex = 9;
            this.label1.Text = "Event Search";
            // 
            // btnEventDetails
            // 
            this.btnEventDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventDetails.Location = new System.Drawing.Point(1093, 742);
            this.btnEventDetails.Name = "btnEventDetails";
            this.btnEventDetails.Size = new System.Drawing.Size(623, 79);
            this.btnEventDetails.TabIndex = 10;
            this.btnEventDetails.Text = "Event Details";
            this.btnEventDetails.UseVisualStyleBackColor = true;
            // 
            // TicketSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1868, 1314);
            this.Controls.Add(this.btnEventDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchDate);
            this.Controls.Add(this.btnSearchVenue);
            this.Controls.Add(this.btnSearchPerformer);
            this.Controls.Add(this.btnSearchCategory);
            this.Controls.Add(this.dtSearchDate);
            this.Controls.Add(this.txtSearchVenue);
            this.Controls.Add(this.txtSearchPerformer);
            this.Controls.Add(this.lstSelectCategory);
            this.Controls.Add(this.lstBoxEvents);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TicketSystem";
            this.Text = "TicketSystem";
            this.Load += new System.EventHandler(this.TicketSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxEvents;
        private System.Windows.Forms.ListBox lstSelectCategory;
        private System.Windows.Forms.TextBox txtSearchPerformer;
        private System.Windows.Forms.TextBox txtSearchVenue;
        private System.Windows.Forms.DateTimePicker dtSearchDate;
        private System.Windows.Forms.Button btnSearchCategory;
        private System.Windows.Forms.Button btnSearchPerformer;
        private System.Windows.Forms.Button btnSearchVenue;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEventDetails;
    }
}

