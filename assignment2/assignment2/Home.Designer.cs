namespace assignment2
{
    partial class Home
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.infoSave = new System.Windows.Forms.Button();
            this.ordercomboBox = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactynoTextBox = new System.Windows.Forms.TextBox();
            this.customernameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.infoTextBox = new System.Windows.Forms.RichTextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.contactnolabel = new System.Windows.Forms.Label();
            this.addresslabel = new System.Windows.Forms.Label();
            this.orderlabel = new System.Windows.Forms.Label();
            this.quantitylabel = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.infoSave);
            this.groupBox1.Controls.Add(this.ordercomboBox);
            this.groupBox1.Controls.Add(this.quantityTextBox);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(this.contactynoTextBox);
            this.groupBox1.Controls.Add(this.customernameTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 372);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // infoSave
            // 
            this.infoSave.Location = new System.Drawing.Point(141, 331);
            this.infoSave.Name = "infoSave";
            this.infoSave.Size = new System.Drawing.Size(75, 23);
            this.infoSave.TabIndex = 10;
            this.infoSave.Text = "Save";
            this.infoSave.UseVisualStyleBackColor = true;
            this.infoSave.Click += new System.EventHandler(this.infoSave_Click);
            // 
            // ordercomboBox
            // 
            this.ordercomboBox.FormattingEnabled = true;
            this.ordercomboBox.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Regular"});
            this.ordercomboBox.Location = new System.Drawing.Point(141, 226);
            this.ordercomboBox.Name = "ordercomboBox";
            this.ordercomboBox.Size = new System.Drawing.Size(100, 21);
            this.ordercomboBox.TabIndex = 2;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(141, 278);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 9;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(141, 160);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 7;
            // 
            // contactynoTextBox
            // 
            this.contactynoTextBox.Location = new System.Drawing.Point(141, 93);
            this.contactynoTextBox.Name = "contactynoTextBox";
            this.contactynoTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactynoTextBox.TabIndex = 6;
            // 
            // customernameTextBox
            // 
            this.customernameTextBox.Location = new System.Drawing.Point(141, 35);
            this.customernameTextBox.Name = "customernameTextBox";
            this.customernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.customernameTextBox.TabIndex = 1;
            
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(340, 12);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(262, 372);
            this.infoTextBox.TabIndex = 1;
            this.infoTextBox.Text = "";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(387, 40);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 13);
            this.nameLabel.TabIndex = 2;
            // 
            // contactnolabel
            // 
            this.contactnolabel.AutoSize = true;
            this.contactnolabel.Location = new System.Drawing.Point(387, 73);
            this.contactnolabel.Name = "contactnolabel";
            this.contactnolabel.Size = new System.Drawing.Size(0, 13);
            this.contactnolabel.TabIndex = 3;
            // 
            // addresslabel
            // 
            this.addresslabel.AutoSize = true;
            this.addresslabel.Location = new System.Drawing.Point(387, 99);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(0, 13);
            this.addresslabel.TabIndex = 4;
            // 
            // orderlabel
            // 
            this.orderlabel.AutoSize = true;
            this.orderlabel.Location = new System.Drawing.Point(387, 138);
            this.orderlabel.Name = "orderlabel";
            this.orderlabel.Size = new System.Drawing.Size(0, 13);
            this.orderlabel.TabIndex = 5;
            // 
            // quantitylabel
            // 
            this.quantitylabel.AutoSize = true;
            this.quantitylabel.Location = new System.Drawing.Point(387, 196);
            this.quantitylabel.Name = "quantitylabel";
            this.quantitylabel.Size = new System.Drawing.Size(0, 13);
            this.quantitylabel.TabIndex = 6;
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Location = new System.Drawing.Point(390, 307);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(0, 13);
            this.pricelabel.TabIndex = 7;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(this.quantitylabel);
            this.Controls.Add(this.orderlabel);
            this.Controls.Add(this.addresslabel);
            this.Controls.Add(this.contactnolabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.infoTextBox);
            this.Name = "Home";
            this.Text = "Coffee Shop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox contactynoTextBox;
        private System.Windows.Forms.TextBox customernameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox infoTextBox;
        private System.Windows.Forms.ComboBox ordercomboBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button infoSave;
        private System.Windows.Forms.Label contactnolabel;
        private System.Windows.Forms.Label addresslabel;
        private System.Windows.Forms.Label orderlabel;
        private System.Windows.Forms.Label quantitylabel;
        private System.Windows.Forms.Label pricelabel;
    }
}

