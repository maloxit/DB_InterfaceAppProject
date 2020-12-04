namespace GabdushevDB_InterfaceAppProject
{
    partial class HubForm
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
            this.truckMarketButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.globalsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.globalsActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalsReloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalsChangeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // truckMarketButton
            // 
            this.truckMarketButton.Location = new System.Drawing.Point(39, 48);
            this.truckMarketButton.Name = "truckMarketButton";
            this.truckMarketButton.Size = new System.Drawing.Size(144, 23);
            this.truckMarketButton.TabIndex = 0;
            this.truckMarketButton.Text = "Торговля грузовиками";
            this.truckMarketButton.UseVisualStyleBackColor = true;
            this.truckMarketButton.Click += new System.EventHandler(this.TruckMarketButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(39, 77);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(144, 23);
            this.orderButton.TabIndex = 0;
            this.orderButton.Text = "Оформить заказ";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.globalsLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 219);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(554, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // globalsLabel
            // 
            this.globalsLabel.Name = "globalsLabel";
            this.globalsLabel.Size = new System.Drawing.Size(205, 17);
            this.globalsLabel.Text = "Бюджет: 0; Текущая дата: 01.01.1999;";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.globalsActionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // globalsActionsToolStripMenuItem
            // 
            this.globalsActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.globalsReloadToolStripMenuItem,
            this.globalsChangeDateToolStripMenuItem});
            this.globalsActionsToolStripMenuItem.Name = "globalsActionsToolStripMenuItem";
            this.globalsActionsToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.globalsActionsToolStripMenuItem.Text = "Глобальные действия";
            // 
            // globalsReloadToolStripMenuItem
            // 
            this.globalsReloadToolStripMenuItem.Name = "globalsReloadToolStripMenuItem";
            this.globalsReloadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.globalsReloadToolStripMenuItem.Text = "Обновить";
            this.globalsReloadToolStripMenuItem.Click += new System.EventHandler(this.GlobalsReloadToolStripMenuItem_Click);
            // 
            // globalsChangeDateToolStripMenuItem
            // 
            this.globalsChangeDateToolStripMenuItem.Name = "globalsChangeDateToolStripMenuItem";
            this.globalsChangeDateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.globalsChangeDateToolStripMenuItem.Text = "Изменить дату";
            this.globalsChangeDateToolStripMenuItem.Click += new System.EventHandler(this.GlobalsChangeDateToolStripMenuItem_Click);
            // 
            // HubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(554, 241);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.truckMarketButton);
            this.Location = new System.Drawing.Point(15, 15);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HubForm";
            this.Load += new System.EventHandler(this.HubForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button truckMarketButton;

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel globalsLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem globalsActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem globalsReloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem globalsChangeDateToolStripMenuItem;
    }
}