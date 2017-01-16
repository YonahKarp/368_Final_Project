namespace Final_Project_Warehouse {
    partial class PayBalance {
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
            this.balanceLbl = new System.Windows.Forms.Label();
            this.menuDropDown = new System.Windows.Forms.ComboBox();
            this.paymentTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.payBtn = new System.Windows.Forms.Button();
            this.msgLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Balance:";
            // 
            // balanceLbl
            // 
            this.balanceLbl.AutoSize = true;
            this.balanceLbl.Location = new System.Drawing.Point(112, 26);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(45, 13);
            this.balanceLbl.TabIndex = 1;
            this.balanceLbl.Text = "balance";
            // 
            // menuDropDown
            // 
            this.menuDropDown.FormattingEnabled = true;
            this.menuDropDown.Items.AddRange(new object[] {
            "Purchase Items",
            "View Purchases",
            "Log Out"});
            this.menuDropDown.Location = new System.Drawing.Point(256, 12);
            this.menuDropDown.Name = "menuDropDown";
            this.menuDropDown.Size = new System.Drawing.Size(18, 21);
            this.menuDropDown.TabIndex = 2;
            this.menuDropDown.DropDown += new System.EventHandler(this.menuDropDown_DropDown);
            this.menuDropDown.SelectedIndexChanged += new System.EventHandler(this.menuDropDown_SelectedIndexChanged);
            this.menuDropDown.DropDownClosed += new System.EventHandler(this.menuDropDown_DropDownClosed);
            // 
            // paymentTxt
            // 
            this.paymentTxt.Location = new System.Drawing.Point(65, 52);
            this.paymentTxt.Name = "paymentTxt";
            this.paymentTxt.Size = new System.Drawing.Size(92, 20);
            this.paymentTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Payment";
            // 
            // payBtn
            // 
            this.payBtn.Location = new System.Drawing.Point(25, 78);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(54, 23);
            this.payBtn.TabIndex = 5;
            this.payBtn.Text = "pay";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // msgLbl
            // 
            this.msgLbl.AutoSize = true;
            this.msgLbl.Location = new System.Drawing.Point(42, 111);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(0, 13);
            this.msgLbl.TabIndex = 6;
            // 
            // PayBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 133);
            this.Controls.Add(this.msgLbl);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paymentTxt);
            this.Controls.Add(this.menuDropDown);
            this.Controls.Add(this.balanceLbl);
            this.Controls.Add(this.label1);
            this.Name = "PayBalance";
            this.Text = "PayBalance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.ComboBox menuDropDown;
        private System.Windows.Forms.TextBox paymentTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.Label msgLbl;
    }
}