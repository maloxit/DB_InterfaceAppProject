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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sellTruckButton = new System.Windows.Forms.Button();
            this.sellTruckGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.addOfferButton = new System.Windows.Forms.Button();
            this.buyTruckGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.citesListBox = new System.Windows.Forms.ListBox();
            this.buyTruckButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellTruckGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyTruckGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.sellTruckButton);
            this.splitContainer1.Panel1.Controls.Add(this.sellTruckGridView);
            this.splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2MinSize = 150;
            this.splitContainer1.Size = new System.Drawing.Size(975, 621);
            this.splitContainer1.SplitterDistance = 331;
            this.splitContainer1.SplitterIncrement = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.MidnightBlue;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(973, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "Продажа";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Доступные для продажи грузовики";
            // 
            // sellTruckButton
            // 
            this.sellTruckButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sellTruckButton.Location = new System.Drawing.Point(895, 303);
            this.sellTruckButton.Name = "sellTruckButton";
            this.sellTruckButton.Size = new System.Drawing.Size(75, 23);
            this.sellTruckButton.TabIndex = 2;
            this.sellTruckButton.Text = "Продать";
            this.sellTruckButton.UseVisualStyleBackColor = true;
            // 
            // sellTruckGridView
            // 
            this.sellTruckGridView.AllowUserToAddRows = false;
            this.sellTruckGridView.AllowUserToDeleteRows = false;
            this.sellTruckGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellTruckGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellTruckGridView.Location = new System.Drawing.Point(3, 64);
            this.sellTruckGridView.MultiSelect = false;
            this.sellTruckGridView.Name = "sellTruckGridView";
            this.sellTruckGridView.ReadOnly = true;
            this.sellTruckGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sellTruckGridView.Size = new System.Drawing.Size(967, 233);
            this.sellTruckGridView.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.MidnightBlue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(973, 48);
            this.label5.TabIndex = 4;
            this.label5.Text = "Покупка";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(-1, 51);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.addOfferButton);
            this.splitContainer2.Panel1.Controls.Add(this.buyTruckGridView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.citesListBox);
            this.splitContainer2.Panel2.Controls.Add(this.buyTruckButton);
            this.splitContainer2.Size = new System.Drawing.Size(975, 234);
            this.splitContainer2.SplitterDistance = 763;
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
            this.addOfferButton.Location = new System.Drawing.Point(612, 208);
            this.addOfferButton.Name = "addOfferButton";
            this.addOfferButton.Size = new System.Drawing.Size(148, 23);
            this.addOfferButton.TabIndex = 2;
            this.addOfferButton.Text = "Добавить предложение";
            this.addOfferButton.UseVisualStyleBackColor = true;
            // 
            // buyTruckGridView
            // 
            this.buyTruckGridView.AllowUserToAddRows = false;
            this.buyTruckGridView.AllowUserToDeleteRows = false;
            this.buyTruckGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buyTruckGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buyTruckGridView.Location = new System.Drawing.Point(4, 16);
            this.buyTruckGridView.MultiSelect = false;
            this.buyTruckGridView.Name = "buyTruckGridView";
            this.buyTruckGridView.ReadOnly = true;
            this.buyTruckGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buyTruckGridView.Size = new System.Drawing.Size(756, 186);
            this.buyTruckGridView.TabIndex = 0;
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
            // citesListBox
            // 
            this.citesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.citesListBox.FormattingEnabled = true;
            this.citesListBox.Location = new System.Drawing.Point(2, 16);
            this.citesListBox.Name = "citesListBox";
            this.citesListBox.Size = new System.Drawing.Size(202, 186);
            this.citesListBox.TabIndex = 4;
            // 
            // buyTruckButton
            // 
            this.buyTruckButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buyTruckButton.Location = new System.Drawing.Point(130, 208);
            this.buyTruckButton.Name = "buyTruckButton";
            this.buyTruckButton.Size = new System.Drawing.Size(75, 23);
            this.buyTruckButton.TabIndex = 2;
            this.buyTruckButton.Text = "Купить";
            this.buyTruckButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backButton.BackColor = System.Drawing.Color.LightCoral;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.DarkRed;
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(62, 42);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "<< Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitContainer3.Panel2.Controls.Add(this.backButton);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer3.Size = new System.Drawing.Size(975, 673);
            this.splitContainer3.SplitterDistance = 621;
            this.splitContainer3.TabIndex = 1;
            // 
            // TruckMarketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 673);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 545);
            this.Name = "TruckMarketForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Торговая площадка грузовиков";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TruckMarketForm_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sellTruckGridView)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buyTruckGridView)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView sellTruckGridView;
        private System.Windows.Forms.Button sellTruckButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addOfferButton;
        private System.Windows.Forms.Button buyTruckButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView buyTruckGridView;
        private System.Windows.Forms.ListBox citesListBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SplitContainer splitContainer3;
    }
}