namespace GabdushevDB_InterfaceAppProject
{
    partial class InformationTableForm
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
            this.informationGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.updateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodDropListBox = new System.Windows.Forms.ToolStripComboBox();
            this.pageOnScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowsOnScreenTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.prevPageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageLabelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextPageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.informationGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // informationGridView
            // 
            this.informationGridView.AllowUserToAddRows = false;
            this.informationGridView.AllowUserToDeleteRows = false;
            this.informationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informationGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informationGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.informationGridView.Location = new System.Drawing.Point(0, 27);
            this.informationGridView.Name = "informationGridView";
            this.informationGridView.ReadOnly = true;
            this.informationGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.informationGridView.Size = new System.Drawing.Size(1098, 354);
            this.informationGridView.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateMenuItem,
            this.periodDropListBox,
            this.pageOnScreenToolStripMenuItem,
            this.rowsOnScreenTextBox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1098, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // updateMenuItem
            // 
            this.updateMenuItem.Name = "updateMenuItem";
            this.updateMenuItem.Size = new System.Drawing.Size(73, 23);
            this.updateMenuItem.Text = "Обновить";
            this.updateMenuItem.Click += new System.EventHandler(this.updateMenuItem_Click);
            // 
            // periodDropListBox
            // 
            this.periodDropListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodDropListBox.Items.AddRange(new object[] {
            "Месяц",
            "Квартал",
            "Год",
            "Всё время"});
            this.periodDropListBox.Name = "periodDropListBox";
            this.periodDropListBox.Size = new System.Drawing.Size(121, 23);
            this.periodDropListBox.SelectedIndexChanged += new System.EventHandler(this.PeriodDropListBox_SelectedIndexChanged);
            // 
            // pageOnScreenToolStripMenuItem
            // 
            this.pageOnScreenToolStripMenuItem.Name = "pageOnScreenToolStripMenuItem";
            this.pageOnScreenToolStripMenuItem.Size = new System.Drawing.Size(178, 23);
            this.pageOnScreenToolStripMenuItem.Text = "Кол-во записей на странице:";
            // 
            // rowsOnScreenTextBox
            // 
            this.rowsOnScreenTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rowsOnScreenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rowsOnScreenTextBox.Name = "rowsOnScreenTextBox";
            this.rowsOnScreenTextBox.Size = new System.Drawing.Size(100, 23);
            this.rowsOnScreenTextBox.Leave += new System.EventHandler(this.RowsOnScreenTextBox_Leave);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prevPageMenuItem,
            this.pageLabelMenuItem,
            this.nextPageMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 381);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1098, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // prevPageMenuItem
            // 
            this.prevPageMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.prevPageMenuItem.Name = "prevPageMenuItem";
            this.prevPageMenuItem.Size = new System.Drawing.Size(67, 20);
            this.prevPageMenuItem.Text = "<<Назад";
            this.prevPageMenuItem.Click += new System.EventHandler(this.PrevPageLabel_Click);
            // 
            // pageLabelMenuItem
            // 
            this.pageLabelMenuItem.Name = "pageLabelMenuItem";
            this.pageLabelMenuItem.Size = new System.Drawing.Size(73, 20);
            this.pageLabelMenuItem.Text = "pageLabel";
            this.pageLabelMenuItem.Click += new System.EventHandler(this.pageLabelMenuItem_Click);
            // 
            // nextPageMenuItem
            // 
            this.nextPageMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nextPageMenuItem.Name = "nextPageMenuItem";
            this.nextPageMenuItem.Size = new System.Drawing.Size(74, 20);
            this.nextPageMenuItem.Text = "Вперед>>";
            this.nextPageMenuItem.Click += new System.EventHandler(this.NextPageLabel_Click);
            // 
            // InformationTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 405);
            this.Controls.Add(this.informationGridView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InformationTableForm";
            this.Text = "InformationTableForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InformationTableForm_FormClosing);
            this.Load += new System.EventHandler(this.InformationTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informationGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView informationGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateMenuItem;
        private System.Windows.Forms.ToolStripComboBox periodDropListBox;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem prevPageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextPageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageOnScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageLabelMenuItem;
        private System.Windows.Forms.ToolStripTextBox rowsOnScreenTextBox;
    }
}