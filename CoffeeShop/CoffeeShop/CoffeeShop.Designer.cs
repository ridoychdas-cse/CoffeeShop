namespace CoffeeShop
{
    partial class CoffeeShop
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneNoLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNoTextBox = new System.Windows.Forms.TextBox();
            this.addessRichTextBox = new System.Windows.Forms.RichTextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(64, 41);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name :";
            // 
            // phoneNoLabel
            // 
            this.phoneNoLabel.AutoSize = true;
            this.phoneNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNoLabel.Location = new System.Drawing.Point(35, 77);
            this.phoneNoLabel.Name = "phoneNoLabel";
            this.phoneNoLabel.Size = new System.Drawing.Size(82, 15);
            this.phoneNoLabel.TabIndex = 0;
            this.phoneNoLabel.Text = "Phone No. :";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(47, 118);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(70, 15);
            this.addressLabel.TabIndex = 0;
            this.addressLabel.Text = "Address  :";
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel.Location = new System.Drawing.Point(74, 159);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(43, 15);
            this.itemLabel.TabIndex = 0;
            this.itemLabel.Text = "Item :";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(50, 198);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(67, 15);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "Quantity :";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(123, 40);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(132, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // phoneNoTextBox
            // 
            this.phoneNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNoTextBox.Location = new System.Drawing.Point(123, 72);
            this.phoneNoTextBox.Name = "phoneNoTextBox";
            this.phoneNoTextBox.Size = new System.Drawing.Size(132, 20);
            this.phoneNoTextBox.TabIndex = 2;
            // 
            // addessRichTextBox
            // 
            this.addessRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addessRichTextBox.Location = new System.Drawing.Point(124, 111);
            this.addessRichTextBox.Name = "addessRichTextBox";
            this.addessRichTextBox.Size = new System.Drawing.Size(131, 34);
            this.addessRichTextBox.TabIndex = 3;
            this.addessRichTextBox.Text = "";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(123, 197);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(132, 20);
            this.quantityTextBox.TabIndex = 5;
            // 
            // itemComboBox
            // 
            this.itemComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Items.AddRange(new object[] {
            "",
            "Regular",
            "Hot",
            "Cold",
            "Black"});
            this.itemComboBox.Location = new System.Drawing.Point(124, 159);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(131, 21);
            this.itemComboBox.TabIndex = 4;
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputRichTextBox.Location = new System.Drawing.Point(288, 33);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.Size = new System.Drawing.Size(259, 397);
            this.outputRichTextBox.TabIndex = 4;
            this.outputRichTextBox.Text = "";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(123, 236);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(61, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(194, 236);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(61, 23);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CoffeeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 442);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.addessRichTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.phoneNoTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneNoLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "CoffeeShop";
            this.Text = "Coffee Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneNoLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneNoTextBox;
        private System.Windows.Forms.RichTextBox addessRichTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

