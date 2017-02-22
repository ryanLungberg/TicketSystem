namespace TicketSystem
{
    partial class FrmCreateCategory
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
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmitCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.AccessibleName = "txtCategoryName";
            this.txtCategoryName.Location = new System.Drawing.Point(364, 255);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(806, 31);
            this.txtCategoryName.TabIndex = 0;
            // 
            // txtCategoryInfo
            // 
            this.txtCategoryInfo.Location = new System.Drawing.Point(364, 371);
            this.txtCategoryInfo.Multiline = true;
            this.txtCategoryInfo.Name = "txtCategoryInfo";
            this.txtCategoryInfo.Size = new System.Drawing.Size(806, 497);
            this.txtCategoryInfo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(583, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1227, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1227, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category Information";
            // 
            // btnSubmitCategory
            // 
            this.btnSubmitCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitCategory.Location = new System.Drawing.Point(1233, 536);
            this.btnSubmitCategory.Name = "btnSubmitCategory";
            this.btnSubmitCategory.Size = new System.Drawing.Size(252, 116);
            this.btnSubmitCategory.TabIndex = 5;
            this.btnSubmitCategory.Text = "Submit";
            this.btnSubmitCategory.UseVisualStyleBackColor = true;
            this.btnSubmitCategory.Click += new System.EventHandler(this.btnSubmitCategory_Click);
            // 
            // FrmCreateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1868, 1062);
            this.ControlBox = false;
            this.Controls.Add(this.btnSubmitCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategoryInfo);
            this.Controls.Add(this.txtCategoryName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCreateCategory";
            this.Text = "Create a Category";
            this.Load += new System.EventHandler(this.FrmCreateCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmitCategory;
    }
}