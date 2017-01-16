namespace Final_Project_Warehouse {
    partial class MainForm {
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dDownWhere = new System.Windows.Forms.ComboBox();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.purchaseLbl = new System.Windows.Forms.Label();
            this.itemsList = new System.Windows.Forms.ListBox();
            this.errorLbl = new System.Windows.Forms.Label();
            this.purchaseBtn = new System.Windows.Forms.Button();
            this.quantTxt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.thankYouLbl = new System.Windows.Forms.Label();
            this.menuDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(43, 93);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(182, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // dDownWhere
            // 
            this.dDownWhere.FormattingEnabled = true;
            this.dDownWhere.Items.AddRange(new object[] {
            "Name",
            "Price Above",
            "Price Below"});
            this.dDownWhere.Location = new System.Drawing.Point(102, 66);
            this.dDownWhere.Name = "dDownWhere";
            this.dDownWhere.Size = new System.Drawing.Size(88, 21);
            this.dDownWhere.TabIndex = 2;
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Location = new System.Drawing.Point(150, 9);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(52, 13);
            this.welcomeLbl.TabIndex = 3;
            this.welcomeLbl.Text = "Welcome";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(58, 119);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // purchaseLbl
            // 
            this.purchaseLbl.AutoSize = true;
            this.purchaseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseLbl.Location = new System.Drawing.Point(119, 26);
            this.purchaseLbl.Name = "purchaseLbl";
            this.purchaseLbl.Size = new System.Drawing.Size(114, 17);
            this.purchaseLbl.TabIndex = 6;
            this.purchaseLbl.Text = "Purchase Goods";
            // 
            // itemsList
            // 
            this.itemsList.FormattingEnabled = true;
            this.itemsList.Location = new System.Drawing.Point(43, 159);
            this.itemsList.Name = "itemsList";
            this.itemsList.Size = new System.Drawing.Size(250, 95);
            this.itemsList.TabIndex = 7;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLbl.Location = new System.Drawing.Point(153, 128);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 13);
            this.errorLbl.TabIndex = 8;
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.Location = new System.Drawing.Point(58, 275);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Size = new System.Drawing.Size(75, 23);
            this.purchaseBtn.TabIndex = 9;
            this.purchaseBtn.Text = "Purchase";
            this.purchaseBtn.UseVisualStyleBackColor = true;
            this.purchaseBtn.Click += new System.EventHandler(this.purchaseBtn_Click);
            // 
            // quantTxt
            // 
            this.quantTxt.Location = new System.Drawing.Point(248, 275);
            this.quantTxt.Mask = "00";
            this.quantTxt.Name = "quantTxt";
            this.quantTxt.Size = new System.Drawing.Size(20, 20);
            this.quantTxt.TabIndex = 10;
            this.quantTxt.Text = " 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quantity";
            // 
            // thankYouLbl
            // 
            this.thankYouLbl.AutoSize = true;
            this.thankYouLbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.thankYouLbl.Location = new System.Drawing.Point(43, 309);
            this.thankYouLbl.Name = "thankYouLbl";
            this.thankYouLbl.Size = new System.Drawing.Size(0, 13);
            this.thankYouLbl.TabIndex = 12;
            // 
            // menuDropDown
            // 
            this.menuDropDown.DropDownWidth = 20;
            this.menuDropDown.FormattingEnabled = true;
            this.menuDropDown.Items.AddRange(new object[] {
            "Pay Balance",
            "View Purchases",
            "Log Out"});
            this.menuDropDown.Location = new System.Drawing.Point(300, 1);
            this.menuDropDown.Name = "menuDropDown";
            this.menuDropDown.Size = new System.Drawing.Size(30, 21);
            this.menuDropDown.TabIndex = 13;
            this.menuDropDown.DropDown += new System.EventHandler(this.menuDropDown_DropDown);
            this.menuDropDown.SelectedIndexChanged += new System.EventHandler(this.menuDropDown_SelectedIndexChanged);
            this.menuDropDown.DropDownClosed += new System.EventHandler(this.menuDropDown_DropDownClosed);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 335);
            this.Controls.Add(this.menuDropDown);
            this.Controls.Add(this.thankYouLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantTxt);
            this.Controls.Add(this.purchaseBtn);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.itemsList);
            this.Controls.Add(this.purchaseLbl);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.dDownWhere);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox dDownWhere;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label purchaseLbl;
        private System.Windows.Forms.ListBox itemsList;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Button purchaseBtn;
        private System.Windows.Forms.MaskedTextBox quantTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label thankYouLbl;
        private System.Windows.Forms.ComboBox menuDropDown;
    }
}