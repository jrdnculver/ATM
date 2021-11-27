
namespace ATM
{
    partial class primary
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
            this.primaryHeaderLbl = new System.Windows.Forms.Label();
            this.atmTxtBx = new System.Windows.Forms.TextBox();
            this.firstNameTxtBox = new System.Windows.Forms.TextBox();
            this.userStatusLbl = new System.Windows.Forms.Label();
            this.accountBtn = new System.Windows.Forms.Button();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.depositBtn = new System.Windows.Forms.Button();
            this.pinBtn = new System.Windows.Forms.Button();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.newAccountBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // primaryHeaderLbl
            // 
            this.primaryHeaderLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.primaryHeaderLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.primaryHeaderLbl.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primaryHeaderLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.primaryHeaderLbl.Location = new System.Drawing.Point(-3, 24);
            this.primaryHeaderLbl.Name = "primaryHeaderLbl";
            this.primaryHeaderLbl.Size = new System.Drawing.Size(471, 33);
            this.primaryHeaderLbl.TabIndex = 0;
            this.primaryHeaderLbl.Text = "United ATM";
            this.primaryHeaderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // atmTxtBx
            // 
            this.atmTxtBx.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atmTxtBx.Location = new System.Drawing.Point(42, 72);
            this.atmTxtBx.Multiline = true;
            this.atmTxtBx.Name = "atmTxtBx";
            this.atmTxtBx.ReadOnly = true;
            this.atmTxtBx.Size = new System.Drawing.Size(388, 154);
            this.atmTxtBx.TabIndex = 99;
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTxtBox.Location = new System.Drawing.Point(172, 298);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.Size = new System.Drawing.Size(256, 26);
            this.firstNameTxtBox.TabIndex = 1;
            // 
            // userStatusLbl
            // 
            this.userStatusLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userStatusLbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userStatusLbl.ForeColor = System.Drawing.Color.White;
            this.userStatusLbl.Location = new System.Drawing.Point(12, 242);
            this.userStatusLbl.Name = "userStatusLbl";
            this.userStatusLbl.Size = new System.Drawing.Size(433, 42);
            this.userStatusLbl.TabIndex = 2;
            this.userStatusLbl.Text = "Please Enter Your Name";
            this.userStatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountBtn
            // 
            this.accountBtn.BackColor = System.Drawing.Color.White;
            this.accountBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountBtn.Location = new System.Drawing.Point(465, 64);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Size = new System.Drawing.Size(197, 38);
            this.accountBtn.TabIndex = 3;
            this.accountBtn.Text = "Account Summary";
            this.accountBtn.UseVisualStyleBackColor = false;
            this.accountBtn.Click += new System.EventHandler(this.accountBtn_Click);
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.BackColor = System.Drawing.Color.White;
            this.withdrawBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawBtn.Location = new System.Drawing.Point(465, 123);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(197, 38);
            this.withdrawBtn.TabIndex = 4;
            this.withdrawBtn.Text = "Withdraw";
            this.withdrawBtn.UseVisualStyleBackColor = false;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // depositBtn
            // 
            this.depositBtn.BackColor = System.Drawing.Color.White;
            this.depositBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositBtn.Location = new System.Drawing.Point(465, 182);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(197, 38);
            this.depositBtn.TabIndex = 5;
            this.depositBtn.Text = "Deposit";
            this.depositBtn.UseVisualStyleBackColor = false;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // pinBtn
            // 
            this.pinBtn.BackColor = System.Drawing.Color.White;
            this.pinBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinBtn.Location = new System.Drawing.Point(465, 243);
            this.pinBtn.Name = "pinBtn";
            this.pinBtn.Size = new System.Drawing.Size(197, 38);
            this.pinBtn.TabIndex = 6;
            this.pinBtn.Text = "Change Pin";
            this.pinBtn.UseVisualStyleBackColor = false;
            this.pinBtn.Click += new System.EventHandler(this.pinBtn_Click);
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTxtBox.Location = new System.Drawing.Point(172, 351);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(256, 26);
            this.lastNameTxtBox.TabIndex = 2;
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameLbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLbl.ForeColor = System.Drawing.Color.White;
            this.firstNameLbl.Location = new System.Drawing.Point(47, 301);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(107, 20);
            this.firstNameLbl.TabIndex = 2;
            this.firstNameLbl.Text = "First Name:";
            this.firstNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameLbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLbl.ForeColor = System.Drawing.Color.White;
            this.lastNameLbl.Location = new System.Drawing.Point(51, 354);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(103, 20);
            this.lastNameLbl.TabIndex = 2;
            this.lastNameLbl.Text = "Last Name:";
            this.lastNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.White;
            this.clearBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(465, 361);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(197, 38);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.White;
            this.printBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.Location = new System.Drawing.Point(465, 303);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(197, 38);
            this.printBtn.TabIndex = 6;
            this.printBtn.Text = "Print Receipt";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // newAccountBtn
            // 
            this.newAccountBtn.BackColor = System.Drawing.Color.White;
            this.newAccountBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccountBtn.Location = new System.Drawing.Point(465, 10);
            this.newAccountBtn.Name = "newAccountBtn";
            this.newAccountBtn.Size = new System.Drawing.Size(197, 38);
            this.newAccountBtn.TabIndex = 6;
            this.newAccountBtn.Text = "New Account";
            this.newAccountBtn.UseVisualStyleBackColor = false;
            this.newAccountBtn.Click += new System.EventHandler(this.newAccountBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.White;
            this.exitBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(465, 414);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(197, 38);
            this.exitBtn.TabIndex = 100;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // primary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(672, 464);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.newAccountBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.pinBtn);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.accountBtn);
            this.Controls.Add(this.lastNameTxtBox);
            this.Controls.Add(this.firstNameTxtBox);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.userStatusLbl);
            this.Controls.Add(this.atmTxtBx);
            this.Controls.Add(this.primaryHeaderLbl);
            this.Name = "primary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label primaryHeaderLbl;
        public System.Windows.Forms.TextBox atmTxtBx;
        public  System.Windows.Forms.TextBox firstNameTxtBox;
        public System.Windows.Forms.Label userStatusLbl;
        private System.Windows.Forms.Button accountBtn;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.Button pinBtn;
        public System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button newAccountBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

