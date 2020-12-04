namespace GabdushevDB_InterfaceAppProject
{
    partial class ChangeGlobalDate
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
            this.canselButton = new System.Windows.Forms.Button();
            this.newDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.applyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // canselButton
            // 
            this.canselButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.canselButton.Location = new System.Drawing.Point(18, 192);
            this.canselButton.Name = "canselButton";
            this.canselButton.Size = new System.Drawing.Size(75, 23);
            this.canselButton.TabIndex = 0;
            this.canselButton.Text = "Отмена";
            this.canselButton.UseVisualStyleBackColor = true;
            this.canselButton.Click += new System.EventHandler(this.CanselButton_Click);
            // 
            // newDateCalendar
            // 
            this.newDateCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newDateCalendar.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.newDateCalendar.Location = new System.Drawing.Point(18, 18);
            this.newDateCalendar.MaxSelectionCount = 1;
            this.newDateCalendar.Name = "newDateCalendar";
            this.newDateCalendar.TabIndex = 1;
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Location = new System.Drawing.Point(277, 192);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 0;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // ChangeGlobalDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 231);
            this.Controls.Add(this.newDateCalendar);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.canselButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChangeGlobalDate";
            this.Text = "ChangeGlobalDate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangeGlobalDate_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button canselButton;
        private System.Windows.Forms.MonthCalendar newDateCalendar;
        private System.Windows.Forms.Button applyButton;
    }
}