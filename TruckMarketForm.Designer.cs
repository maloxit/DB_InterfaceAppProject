namespace GabdushevDB_InterfaceAppProject
{
    partial class TruckMarketForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sellTruckButton = new System.Windows.Forms.Button();
            this.sellTruckDataGridView = new System.Windows.Forms.DataGridView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.addOfferButton = new System.Windows.Forms.Button();
            this.buyTruckDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.citiesListBox = new System.Windows.Forms.ListBox();
            this.buyTruckButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.globalsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellTruckDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyTruckDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer4);
            this.splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Panel2MinSize = 150;
            this.splitContainer1.Size = new System.Drawing.Size(1123, 550);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.SplitterIncrement = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.label1);
            this.splitContainer4.Panel2.Controls.Add(this.sellTruckButton);
            this.splitContainer4.Panel2.Controls.Add(this.sellTruckDataGridView);
            this.splitContainer4.Size = new System.Drawing.Size(1121, 259);
            this.splitContainer4.SplitterDistance = 40;
            this.splitContainer4.SplitterWidth = 1;
            this.splitContainer4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.MidnightBlue;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1121, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Продажа";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Доступные для продажи грузовики";
            // 
            // sellTruckButton
            // 
            this.sellTruckButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sellTruckButton.Location = new System.Drawing.Point(1043, 195);
            this.sellTruckButton.Name = "sellTruckButton";
            this.sellTruckButton.Size = new System.Drawing.Size(75, 23);
            this.sellTruckButton.TabIndex = 2;
            this.sellTruckButton.Text = "Продать";
            this.sellTruckButton.UseVisualStyleBackColor = true;
            this.sellTruckButton.Click += new System.EventHandler(this.SellTruckButton_Click);
            // 
            // sellTruckDataGridView
            // 
            this.sellTruckDataGridView.AllowUserToAddRows = false;
            this.sellTruckDataGridView.AllowUserToDeleteRows = false;
            this.sellTruckDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellTruckDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellTruckDataGridView.Location = new System.Drawing.Point(6, 16);
            this.sellTruckDataGridView.MultiSelect = false;
            this.sellTruckDataGridView.Name = "sellTruckDataGridView";
            this.sellTruckDataGridView.ReadOnly = true;
            this.sellTruckDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sellTruckDataGridView.Size = new System.Drawing.Size(1112, 173);
            this.sellTruckDataGridView.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer3.Size = new System.Drawing.Size(1121, 283);
            this.splitContainer3.SplitterDistance = 40;
            this.splitContainer3.SplitterWidth = 1;
            this.splitContainer3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.MidnightBlue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1121, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "Покупка";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.addOfferButton);
            this.splitContainer2.Panel1.Controls.Add(this.buyTruckDataGridView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.citiesListBox);
            this.splitContainer2.Panel2.Controls.Add(this.buyTruckButton);
            this.splitContainer2.Size = new System.Drawing.Size(1121, 242);
            this.splitContainer2.SplitterDistance = 909;
            this.splitContainer2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Доступные для покупки грузовики";
            // 
            // addOfferButton
            // 
            this.addOfferButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addOfferButton.Location = new System.Drawing.Point(758, 195);
            this.addOfferButton.Name = "addOfferButton";
            this.addOfferButton.Size = new System.Drawing.Size(148, 23);
            this.addOfferButton.TabIndex = 2;
            this.addOfferButton.Text = "Добавить предложение";
            this.addOfferButton.UseVisualStyleBackColor = true;
            this.addOfferButton.Click += new System.EventHandler(this.AddOfferButton_Click);
            // 
            // buyTruckDataGridView
            // 
            this.buyTruckDataGridView.AllowUserToAddRows = false;
            this.buyTruckDataGridView.AllowUserToDeleteRows = false;
            this.buyTruckDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buyTruckDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buyTruckDataGridView.Location = new System.Drawing.Point(4, 16);
            this.buyTruckDataGridView.MultiSelect = false;
            this.buyTruckDataGridView.Name = "buyTruckDataGridView";
            this.buyTruckDataGridView.ReadOnly = true;
            this.buyTruckDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buyTruckDataGridView.Size = new System.Drawing.Size(902, 173);
            this.buyTruckDataGridView.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Желаемый город доставки";
            // 
            // citiesListBox
            // 
            this.citiesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.citiesListBox.FormattingEnabled = true;
            this.citiesListBox.Location = new System.Drawing.Point(2, 16);
            this.citiesListBox.Name = "citiesListBox";
            this.citiesListBox.Size = new System.Drawing.Size(202, 173);
            this.citiesListBox.TabIndex = 4;
            // 
            // buyTruckButton
            // 
            this.buyTruckButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buyTruckButton.Location = new System.Drawing.Point(130, 195);
            this.buyTruckButton.Name = "buyTruckButton";
            this.buyTruckButton.Size = new System.Drawing.Size(75, 23);
            this.buyTruckButton.TabIndex = 2;
            this.buyTruckButton.Text = "Купить";
            this.buyTruckButton.UseVisualStyleBackColor = true;
            this.buyTruckButton.Click += new System.EventHandler(this.BuyTruckButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.globalsLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1123, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // globalsLabel
            // 
            this.globalsLabel.Name = "globalsLabel";
            this.globalsLabel.Size = new System.Drawing.Size(205, 17);
            this.globalsLabel.Text = "Бюджет: 0; Текущая дата: 01.01.1999;";
            // 
            // TruckMarketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 550);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 545);
            this.Name = "TruckMarketForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Торговая площадка грузовиков";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TruckMarketForm_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sellTruckDataGridView)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buyTruckDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView sellTruckDataGridView;
        private System.Windows.Forms.Button sellTruckButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addOfferButton;
        private System.Windows.Forms.Button buyTruckButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView buyTruckDataGridView;
        private System.Windows.Forms.ListBox citiesListBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel globalsLabel;
    }
}