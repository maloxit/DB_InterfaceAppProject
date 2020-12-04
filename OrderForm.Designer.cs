namespace GabdushevDB_InterfaceAppProject
{
    partial class OrderForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.cargoParamsGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.unloadCityComboBox = new System.Windows.Forms.ComboBox();
            this.loadCityComboBox = new System.Windows.Forms.ComboBox();
            this.cargoTypeComboBox = new System.Windows.Forms.ComboBox();
            this.cargoWeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cargoParamsButton = new System.Windows.Forms.Button();
            this.truckDataGridView = new System.Windows.Forms.DataGridView();
            this.truckSelectGroupBox = new System.Windows.Forms.GroupBox();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.deliveryCostLabel = new System.Windows.Forms.Label();
            this.cargoTransPriceLabel = new System.Windows.Forms.Label();
            this.deliveryDateLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.finishButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.globalsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.emptyDistPercentLabel = new System.Windows.Forms.Label();
            this.cargoParamsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargoWeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckDataGridView)).BeginInit();
            this.truckSelectGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.Location = new System.Drawing.Point(12, 263);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Назад";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // cargoParamsGroupBox
            // 
            this.cargoParamsGroupBox.Controls.Add(this.label4);
            this.cargoParamsGroupBox.Controls.Add(this.label3);
            this.cargoParamsGroupBox.Controls.Add(this.label2);
            this.cargoParamsGroupBox.Controls.Add(this.label1);
            this.cargoParamsGroupBox.Controls.Add(this.unloadCityComboBox);
            this.cargoParamsGroupBox.Controls.Add(this.loadCityComboBox);
            this.cargoParamsGroupBox.Controls.Add(this.cargoTypeComboBox);
            this.cargoParamsGroupBox.Controls.Add(this.cargoWeightNumericUpDown);
            this.cargoParamsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.cargoParamsGroupBox.Name = "cargoParamsGroupBox";
            this.cargoParamsGroupBox.Size = new System.Drawing.Size(148, 202);
            this.cargoParamsGroupBox.TabIndex = 1;
            this.cargoParamsGroupBox.TabStop = false;
            this.cargoParamsGroupBox.Text = "Параметры груза";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Город разгрузки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Город загрузки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вес груза";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тип груза";
            // 
            // unloadCityComboBox
            // 
            this.unloadCityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unloadCityComboBox.FormattingEnabled = true;
            this.unloadCityComboBox.Location = new System.Drawing.Point(6, 159);
            this.unloadCityComboBox.Name = "unloadCityComboBox";
            this.unloadCityComboBox.Size = new System.Drawing.Size(121, 21);
            this.unloadCityComboBox.TabIndex = 1;
            // 
            // loadCityComboBox
            // 
            this.loadCityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loadCityComboBox.FormattingEnabled = true;
            this.loadCityComboBox.Location = new System.Drawing.Point(6, 114);
            this.loadCityComboBox.Name = "loadCityComboBox";
            this.loadCityComboBox.Size = new System.Drawing.Size(121, 21);
            this.loadCityComboBox.TabIndex = 1;
            // 
            // cargoTypeComboBox
            // 
            this.cargoTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cargoTypeComboBox.FormattingEnabled = true;
            this.cargoTypeComboBox.Location = new System.Drawing.Point(6, 35);
            this.cargoTypeComboBox.Name = "cargoTypeComboBox";
            this.cargoTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.cargoTypeComboBox.TabIndex = 1;
            // 
            // cargoWeightNumericUpDown
            // 
            this.cargoWeightNumericUpDown.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.cargoWeightNumericUpDown.Location = new System.Drawing.Point(6, 75);
            this.cargoWeightNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cargoWeightNumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.cargoWeightNumericUpDown.Name = "cargoWeightNumericUpDown";
            this.cargoWeightNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.cargoWeightNumericUpDown.TabIndex = 0;
            this.cargoWeightNumericUpDown.ThousandsSeparator = true;
            this.cargoWeightNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // cargoParamsButton
            // 
            this.cargoParamsButton.Location = new System.Drawing.Point(41, 220);
            this.cargoParamsButton.Name = "cargoParamsButton";
            this.cargoParamsButton.Size = new System.Drawing.Size(75, 23);
            this.cargoParamsButton.TabIndex = 6;
            this.cargoParamsButton.Text = "Далее";
            this.cargoParamsButton.UseVisualStyleBackColor = true;
            this.cargoParamsButton.Click += new System.EventHandler(this.CargoParamsButton_Click);
            // 
            // truckDataGridView
            // 
            this.truckDataGridView.AllowUserToAddRows = false;
            this.truckDataGridView.AllowUserToDeleteRows = false;
            this.truckDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.truckDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.truckDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.truckDataGridView.Location = new System.Drawing.Point(6, 19);
            this.truckDataGridView.MultiSelect = false;
            this.truckDataGridView.Name = "truckDataGridView";
            this.truckDataGridView.ReadOnly = true;
            this.truckDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.truckDataGridView.Size = new System.Drawing.Size(488, 206);
            this.truckDataGridView.TabIndex = 2;
            this.truckDataGridView.SelectionChanged += new System.EventHandler(this.truckDataGridView_SelectionChanged);
            // 
            // truckSelectGroupBox
            // 
            this.truckSelectGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.truckSelectGroupBox.Controls.Add(this.incomeLabel);
            this.truckSelectGroupBox.Controls.Add(this.emptyDistPercentLabel);
            this.truckSelectGroupBox.Controls.Add(this.deliveryCostLabel);
            this.truckSelectGroupBox.Controls.Add(this.cargoTransPriceLabel);
            this.truckSelectGroupBox.Controls.Add(this.deliveryDateLabel);
            this.truckSelectGroupBox.Controls.Add(this.label8);
            this.truckSelectGroupBox.Controls.Add(this.label9);
            this.truckSelectGroupBox.Controls.Add(this.label7);
            this.truckSelectGroupBox.Controls.Add(this.label6);
            this.truckSelectGroupBox.Controls.Add(this.label5);
            this.truckSelectGroupBox.Controls.Add(this.truckDataGridView);
            this.truckSelectGroupBox.Enabled = false;
            this.truckSelectGroupBox.Location = new System.Drawing.Point(166, 12);
            this.truckSelectGroupBox.Name = "truckSelectGroupBox";
            this.truckSelectGroupBox.Size = new System.Drawing.Size(706, 231);
            this.truckSelectGroupBox.TabIndex = 3;
            this.truckSelectGroupBox.TabStop = false;
            this.truckSelectGroupBox.Text = "Выбор грузовика";
            // 
            // incomeLabel
            // 
            this.incomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.incomeLabel.Location = new System.Drawing.Point(619, 208);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(81, 14);
            this.incomeLabel.TabIndex = 7;
            this.incomeLabel.Text = "NONE";
            this.incomeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // deliveryCostLabel
            // 
            this.deliveryCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryCostLabel.Location = new System.Drawing.Point(619, 117);
            this.deliveryCostLabel.Name = "deliveryCostLabel";
            this.deliveryCostLabel.Size = new System.Drawing.Size(81, 14);
            this.deliveryCostLabel.TabIndex = 7;
            this.deliveryCostLabel.Text = "NONE";
            this.deliveryCostLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cargoTransPriceLabel
            // 
            this.cargoTransPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cargoTransPriceLabel.Location = new System.Drawing.Point(619, 77);
            this.cargoTransPriceLabel.Name = "cargoTransPriceLabel";
            this.cargoTransPriceLabel.Size = new System.Drawing.Size(81, 14);
            this.cargoTransPriceLabel.TabIndex = 7;
            this.cargoTransPriceLabel.Text = "NONE";
            this.cargoTransPriceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // deliveryDateLabel
            // 
            this.deliveryDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryDateLabel.Location = new System.Drawing.Point(619, 38);
            this.deliveryDateLabel.Name = "deliveryDateLabel";
            this.deliveryDateLabel.Size = new System.Drawing.Size(81, 14);
            this.deliveryDateLabel.TabIndex = 7;
            this.deliveryDateLabel.Text = "NONE";
            this.deliveryDateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(500, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Прибыль";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Расходы на доставку";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Цена доставки";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Дата доставки";
            // 
            // finishButton
            // 
            this.finishButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.finishButton.Location = new System.Drawing.Point(797, 263);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 4;
            this.finishButton.Text = "Оформить";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.globalsLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 289);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // globalsLabel
            // 
            this.globalsLabel.Name = "globalsLabel";
            this.globalsLabel.Size = new System.Drawing.Size(205, 17);
            this.globalsLabel.Text = "Бюджет: 0; Текущая дата: 01.01.1999;";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Location = new System.Drawing.Point(500, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 29);
            this.label9.TabIndex = 5;
            this.label9.Text = "Процент порожнего пробега";
            // 
            // emptyDistPercentLabel
            // 
            this.emptyDistPercentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emptyDistPercentLabel.Location = new System.Drawing.Point(619, 162);
            this.emptyDistPercentLabel.Name = "emptyDistPercentLabel";
            this.emptyDistPercentLabel.Size = new System.Drawing.Size(81, 14);
            this.emptyDistPercentLabel.TabIndex = 7;
            this.emptyDistPercentLabel.Text = "NONE";
            this.emptyDistPercentLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 311);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cargoParamsButton);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.truckSelectGroupBox);
            this.Controls.Add(this.cargoParamsGroupBox);
            this.Controls.Add(this.cancelButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 350);
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.Text = "OrderForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.cargoParamsGroupBox.ResumeLayout(false);
            this.cargoParamsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargoWeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckDataGridView)).EndInit();
            this.truckSelectGroupBox.ResumeLayout(false);
            this.truckSelectGroupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox cargoParamsGroupBox;
        private System.Windows.Forms.ComboBox unloadCityComboBox;
        private System.Windows.Forms.ComboBox loadCityComboBox;
        private System.Windows.Forms.ComboBox cargoTypeComboBox;
        private System.Windows.Forms.NumericUpDown cargoWeightNumericUpDown;
        private System.Windows.Forms.Button cargoParamsButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView truckDataGridView;
        private System.Windows.Forms.GroupBox truckSelectGroupBox;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.Label deliveryCostLabel;
        private System.Windows.Forms.Label cargoTransPriceLabel;
        private System.Windows.Forms.Label deliveryDateLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel globalsLabel;
        private System.Windows.Forms.Label emptyDistPercentLabel;
        private System.Windows.Forms.Label label9;
    }
}