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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // truckMarketButton
            // 
            this.truckMarketButton.Location = new System.Drawing.Point(22, 48);
            this.truckMarketButton.Name = "truckMarketButton";
            this.truckMarketButton.Size = new System.Drawing.Size(202, 48);
            this.truckMarketButton.TabIndex = 0;
            this.truckMarketButton.Text = "Торговля грузовиками";
            this.truckMarketButton.UseVisualStyleBackColor = true;
            this.truckMarketButton.Click += new System.EventHandler(this.TruckMarketButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(22, 102);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(202, 48);
            this.orderButton.TabIndex = 0;
            this.orderButton.Text = "Оформить заказ";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.globalsLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 398);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(481, 22);
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
            this.menuStrip1.Size = new System.Drawing.Size(481, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // globalsActionsToolStripMenuItem
            // 
            this.globalsActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.globalsReloadToolStripMenuItem,
            this.globalsChangeDateToolStripMenuItem,
            this.testToolStripMenuItem});
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отчет \"Популярные грузы\"";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "Отчет \"Коэффициент бесполезного пробега грузовиков\"";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(263, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "Отчет \"Коэффициент простоя грузовиков\"";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(263, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "Отчет \"Активность городов по суммарному весу отправленного груза\"";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(263, 264);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(202, 48);
            this.button5.TabIndex = 3;
            this.button5.Text = "Отчет \"Активность городов по суммарному весу принятого груза\"";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(22, 156);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(202, 48);
            this.button6.TabIndex = 0;
            this.button6.Text = "Обзор грузовиков";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(145, 318);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(202, 48);
            this.button7.TabIndex = 0;
            this.button7.Text = "Закрыть все окна";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(22, 210);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(202, 48);
            this.button8.TabIndex = 0;
            this.button8.Text = "Обзор заказов";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(22, 264);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(202, 48);
            this.button9.TabIndex = 0;
            this.button9.Text = "Финансовый отчет";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testToolStripMenuItem.Text = "Тест";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // HubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(481, 420);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.truckMarketButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    }
}