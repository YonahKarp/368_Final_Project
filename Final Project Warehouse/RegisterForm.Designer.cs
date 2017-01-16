namespace Final_Project_Warehouse {
    partial class RegisterForm {
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.userTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backLink = new System.Windows.Forms.LinkLabel();
            this.registerBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.errName = new System.Windows.Forms.Label();
            this.errUser = new System.Windows.Forms.Label();
            this.errPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "name: ";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(97, 42);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 20);
            this.nameTxt.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(97, 93);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(100, 20);
            this.userTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "username";
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(97, 143);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(100, 20);
            this.passTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "password";
            // 
            // backLink
            // 
            this.backLink.AutoSize = true;
            this.backLink.Location = new System.Drawing.Point(28, 187);
            this.backLink.Name = "backLink";
            this.backLink.Size = new System.Drawing.Size(72, 13);
            this.backLink.TabIndex = 7;
            this.backLink.TabStop = true;
            this.backLink.Text = "back to Login";
            this.backLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backLink_LinkClicked);
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(159, 187);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 8;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Register";
            // 
            // errName
            // 
            this.errName.AutoSize = true;
            this.errName.ForeColor = System.Drawing.Color.Red;
            this.errName.Location = new System.Drawing.Point(204, 42);
            this.errName.Name = "errName";
            this.errName.Size = new System.Drawing.Size(11, 13);
            this.errName.TabIndex = 10;
            this.errName.Text = "*";
            this.errName.Visible = false;
            // 
            // errUser
            // 
            this.errUser.AutoSize = true;
            this.errUser.ForeColor = System.Drawing.Color.Red;
            this.errUser.Location = new System.Drawing.Point(204, 97);
            this.errUser.Name = "errUser";
            this.errUser.Size = new System.Drawing.Size(11, 13);
            this.errUser.TabIndex = 11;
            this.errUser.Text = "*";
            this.errUser.Visible = false;
            // 
            // errPass
            // 
            this.errPass.AutoSize = true;
            this.errPass.ForeColor = System.Drawing.Color.Red;
            this.errPass.Location = new System.Drawing.Point(203, 143);
            this.errPass.Name = "errPass";
            this.errPass.Size = new System.Drawing.Size(11, 13);
            this.errPass.TabIndex = 12;
            this.errPass.Text = "*";
            this.errPass.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 236);
            this.Controls.Add(this.errPass);
            this.Controls.Add(this.errUser);
            this.Controls.Add(this.errName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.backLink);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel backLink;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label errName;
        private System.Windows.Forms.Label errUser;
        private System.Windows.Forms.Label errPass;
    }
}