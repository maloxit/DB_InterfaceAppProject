namespace GabdushevDB_InterfaceAppProject
{
    partial class TruckMarketAddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.cargoFormComboBox = new System.Windows.Forms.ComboBox();
            this.liftCapacityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.downtimeCostNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.transportationCostNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.emptyTranspCostNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.backButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.liftCapacityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downtimeCostNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportationCostNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyTranspCostNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Модель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Форма перевозимых грузов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Грузоподъемность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Стоимость дня простоя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Стоимость дня перевозки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Стоимость дня переезда порожняком";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelTextBox.Location = new System.Drawing.Point(182, 24);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(265, 20);
            this.modelTextBox.TabIndex = 7;
            // 
            // cargoFormComboBox
            // 
            this.cargoFormComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cargoFormComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cargoFormComboBox.Location = new System.Drawing.Point(277, 63);
            this.cargoFormComboBox.Name = "cargoFormComboBox";
            this.cargoFormComboBox.Size = new System.Drawing.Size(170, 21);
            this.cargoFormComboBox.TabIndex = 8;
            // 
            // liftCapacityNumericUpDown
            // 
            this.liftCapacityNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.liftCapacityNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.liftCapacityNumericUpDown.Location = new System.Drawing.Point(327, 104);
            this.liftCapacityNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.liftCapacityNumericUpDown.Name = "liftCapacityNumericUpDown";
            this.liftCapacityNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.liftCapacityNumericUpDown.TabIndex = 9;
            this.liftCapacityNumericUpDown.ThousandsSeparator = true;
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.priceNumericUpDown.Location = new System.Drawing.Point(327, 143);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.priceNumericUpDown.TabIndex = 10;
            this.priceNumericUpDown.ThousandsSeparator = true;
            // 
            // downtimeCostNumericUpDown
            // 
            this.downtimeCostNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.downtimeCostNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.downtimeCostNumericUpDown.Location = new System.Drawing.Point(327, 182);
            this.downtimeCostNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.downtimeCostNumericUpDown.Name = "downtimeCostNumericUpDown";
            this.downtimeCostNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.downtimeCostNumericUpDown.TabIndex = 10;
            this.downtimeCostNumericUpDown.ThousandsSeparator = true;
            // 
            // transportationCostNumericUpDown
            // 
            this.transportationCostNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transportationCostNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.transportationCostNumericUpDown.Location = new System.Drawing.Point(327, 221);
            this.transportationCostNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.transportationCostNumericUpDown.Name = "transportationCostNumericUpDown";
            this.transportationCostNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.transportationCostNumericUpDown.TabIndex = 10;
            this.transportationCostNumericUpDown.ThousandsSeparator = true;
            // 
            // emptyTranspCostNumericUpDown
            // 
            this.emptyTranspCostNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emptyTranspCostNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.emptyTranspCostNumericUpDown.Location = new System.Drawing.Point(327, 260);
            this.emptyTranspCostNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.emptyTranspCostNumericUpDown.Name = "emptyTranspCostNumericUpDown";
            this.emptyTranspCostNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.emptyTranspCostNumericUpDown.TabIndex = 10;
            this.emptyTranspCostNumericUpDown.ThousandsSeparator = true;
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backButton.Location = new System.Drawing.Point(12, 328);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(127, 36);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Отмена";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(320, 328);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(127, 36);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TruckMarketAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 376);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.emptyTranspCostNumericUpDown);
            this.Controls.Add(this.transportationCostNumericUpDown);
            this.Controls.Add(this.downtimeCostNumericUpDown);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.liftCapacityNumericUpDown);
            this.Controls.Add(this.cargoFormComboBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(380, 380);
            this.Name = "TruckMarketAddForm";
            this.ShowIcon = false;
            this.Text = "Добавление предложения на торговую площадку грузовиков";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TruckMarketAddForm_FormClosing);
            this.Load += new System.EventHandler(this.TruckMarketAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liftCapacityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downtimeCostNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportationCostNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptyTranspCostNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.ComboBox cargoFormComboBox;
        private System.Windows.Forms.NumericUpDown liftCapacityNumericUpDown;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.NumericUpDown downtimeCostNumericUpDown;
        private System.Windows.Forms.NumericUpDown transportationCostNumericUpDown;
        private System.Windows.Forms.NumericUpDown emptyTranspCostNumericUpDown;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addButton;
    }
}