namespace Final_Project_Warehouse {
    partial class ViewPurchase {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.purchasesList = new System.Windows.Forms.ListBox();
            this.menuDropDown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filterByDropDown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fromTxt = new System.Windows.Forms.MaskedTextBox();
            this.toTxt = new System.Windows.Forms.MaskedTextBox();
            this.filterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Purchases:";
            // 
            // purchasesList
            // 
            this.purchasesList.FormattingEnabled = true;
            this.purchasesList.Location = new System.Drawing.Point(25, 56);
            this.purchasesList.Name = "purchasesList";
            this.purchasesList.Size = new System.Drawing.Size(271, 108);
            this.purchasesList.TabIndex = 1;
            // 
            // menuDropDown
            // 
            this.menuDropDown.FormattingEnabled = true;
            this.menuDropDown.Items.AddRange(new object[] {
            "Purchase Items",
            "Pay Balance",
            "Log Out"});
            this.menuDropDown.Location = new System.Drawing.Point(303, 5);
            this.menuDropDown.Name = "menuDropDown";
            this.menuDropDown.Size = new System.Drawing.Size(24, 21);
            this.menuDropDown.TabIndex = 2;
            this.menuDropDown.DropDown += new System.EventHandler(this.menuDropDown_DropDown);
            this.menuDropDown.SelectedIndexChanged += new System.EventHandler(this.menuDropDown_SelectedIndexChanged);
            this.menuDropDown.DropDownClosed += new System.EventHandler(this.menuDropDown_DropDownClosed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "filter list by";
            // 
            // filterByDropDown
            // 
            this.filterByDropDown.FormattingEnabled = true;
            this.filterByDropDown.Items.AddRange(new object[] {
            "Price",
            "Date"});
            this.filterByDropDown.Location = new System.Drawing.Point(96, 180);
            this.filterByDropDown.Name = "filterByDropDown";
            this.filterByDropDown.Size = new System.Drawing.Size(86, 21);
            this.filterByDropDown.TabIndex = 4;
            this.filterByDropDown.SelectedIndexChanged += new System.EventHandler(this.filterByDropDown_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "from";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "to";
            // 
            // fromTxt
            // 
            this.fromTxt.Location = new System.Drawing.Point(71, 208);
            this.fromTxt.Name = "fromTxt";
            this.fromTxt.Size = new System.Drawing.Size(51, 20);
            this.fromTxt.TabIndex = 7;
            // 
            // toTxt
            // 
            this.toTxt.Location = new System.Drawing.Point(150, 208);
            this.toTxt.Name = "toTxt";
            this.toTxt.Size = new System.Drawing.Size(52, 20);
            this.toTxt.TabIndex = 8;
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(25, 240);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(75, 23);
            this.filterBtn.TabIndex = 9;
            this.filterBtn.Text = "filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // ViewPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 324);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.toTxt);
            this.Controls.Add(this.fromTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filterByDropDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuDropDown);
            this.Controls.Add(this.purchasesList);
            this.Controls.Add(this.label1);
            this.Name = "ViewPurchase";
            this.Text = "ViewPurchases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox purchasesList;
        private System.Windows.Forms.ComboBox menuDropDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox filterByDropDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox fromTxt;
        private System.Windows.Forms.MaskedTextBox toTxt;
        private System.Windows.Forms.Button filterBtn;
    }
}