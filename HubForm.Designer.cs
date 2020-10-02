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
            this.truckMarketButton.Click += new System.EventHandler(this.FormButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(39, 77);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(144, 23);
            this.orderButton.TabIndex = 0;
            this.orderButton.Text = "Оформить заказ";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.FormButton_Click);
            // 
            // HubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.truckMarketButton);
            this.Name = "HubForm";
            this.Text = "HubForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button truckMarketButton;
        private System.Windows.Forms.Button orderButton;
    }
}