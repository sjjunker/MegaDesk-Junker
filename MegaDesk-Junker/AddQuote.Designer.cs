namespace MegaDesk_Junker
{
    partial class AddQuote
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
            this.deskLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.drawersLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.depthInput = new System.Windows.Forms.TextBox();
            this.orderInfoLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.rushOrderLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.rushOrderInput = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.drawerInput = new System.Windows.Forms.ComboBox();
            this.materialInput = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // deskLabel
            // 
            this.deskLabel.AutoSize = true;
            this.deskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskLabel.Location = new System.Drawing.Point(13, 13);
            this.deskLabel.Name = "deskLabel";
            this.deskLabel.Size = new System.Drawing.Size(203, 26);
            this.deskLabel.TabIndex = 0;
            this.deskLabel.Text = "Desk Specifications";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(18, 52);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(50, 20);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "Width";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(18, 83);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(53, 20);
            this.depthLabel.TabIndex = 3;
            this.depthLabel.Text = "Depth";
            // 
            // drawersLabel
            // 
            this.drawersLabel.AutoSize = true;
            this.drawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersLabel.Location = new System.Drawing.Point(18, 117);
            this.drawersLabel.Name = "drawersLabel";
            this.drawersLabel.Size = new System.Drawing.Size(120, 20);
            this.drawersLabel.TabIndex = 5;
            this.drawersLabel.Text = "Drawer Number";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel.Location = new System.Drawing.Point(18, 151);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(65, 20);
            this.materialLabel.TabIndex = 7;
            this.materialLabel.Text = "Material";
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(176, 54);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(121, 20);
            this.widthInput.TabIndex = 2;
            this.widthInput.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateWidth);
            // 
            // depthInput
            // 
            this.depthInput.Location = new System.Drawing.Point(176, 85);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(121, 20);
            this.depthInput.TabIndex = 4;
            this.depthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDepth);
            // 
            // orderInfoLabel
            // 
            this.orderInfoLabel.AutoSize = true;
            this.orderInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderInfoLabel.Location = new System.Drawing.Point(13, 219);
            this.orderInfoLabel.Name = "orderInfoLabel";
            this.orderInfoLabel.Size = new System.Drawing.Size(182, 26);
            this.orderInfoLabel.TabIndex = 9;
            this.orderInfoLabel.Text = "Order Information";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(18, 260);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(124, 20);
            this.customerLabel.TabIndex = 10;
            this.customerLabel.Text = "Customer Name";
            // 
            // rushOrderLabel
            // 
            this.rushOrderLabel.AutoSize = true;
            this.rushOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushOrderLabel.Location = new System.Drawing.Point(18, 293);
            this.rushOrderLabel.Name = "rushOrderLabel";
            this.rushOrderLabel.Size = new System.Drawing.Size(91, 20);
            this.rushOrderLabel.TabIndex = 12;
            this.rushOrderLabel.Text = "Rush Order";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(176, 262);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(121, 20);
            this.nameInput.TabIndex = 11;
            // 
            // rushOrderInput
            // 
            this.rushOrderInput.FormattingEnabled = true;
            this.rushOrderInput.Items.AddRange(new object[] {
            "None",
            "Three",
            "Five",
            "Seven"});
            this.rushOrderInput.Location = new System.Drawing.Point(176, 292);
            this.rushOrderInput.Name = "rushOrderInput";
            this.rushOrderInput.Size = new System.Drawing.Size(121, 21);
            this.rushOrderInput.TabIndex = 13;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(18, 342);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 35);
            this.submitButton.TabIndex = 14;
            this.submitButton.Text = "Order Now!";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.ValidateForm);
            // 
            // drawerInput
            // 
            this.drawerInput.FormattingEnabled = true;
            this.drawerInput.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.drawerInput.Location = new System.Drawing.Point(176, 119);
            this.drawerInput.Name = "drawerInput";
            this.drawerInput.Size = new System.Drawing.Size(121, 21);
            this.drawerInput.TabIndex = 6;
            // 
            // materialInput
            // 
            this.materialInput.FormattingEnabled = true;
            this.materialInput.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Rosewood",
            "Pine",
            "Veneer"});
            this.materialInput.Location = new System.Drawing.Point(176, 153);
            this.materialInput.Name = "materialInput";
            this.materialInput.Size = new System.Drawing.Size(121, 21);
            this.materialInput.TabIndex = 15;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 396);
            this.Controls.Add(this.materialInput);
            this.Controls.Add(this.drawerInput);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.rushOrderInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.rushOrderLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.orderInfoLabel);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.drawersLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.deskLabel);
            this.Name = "AddQuote";
            this.Text = "Add New Quote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deskLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label drawersLabel;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.TextBox depthInput;
        private System.Windows.Forms.Label orderInfoLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label rushOrderLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.ComboBox rushOrderInput;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox drawerInput;
        private System.Windows.Forms.ComboBox materialInput;
    }
}