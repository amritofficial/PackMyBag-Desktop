namespace WindowsFormsApplication1
{
    partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.UserName = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.tbUser = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.btnSignin = new Bunifu.Framework.UI.BunifuFlatButton();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(-513, -25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(994, 591);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arty Signature", 120F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label2.Location = new System.Drawing.Point(520, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(414, 227);
			this.label2.TabIndex = 13;
			this.label2.Text = "Pack my Bag";
			// 
			// UserName
			// 
			this.UserName.AutoSize = true;
			this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UserName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.UserName.Location = new System.Drawing.Point(510, 232);
			this.UserName.Name = "UserName";
			this.UserName.Size = new System.Drawing.Size(128, 17);
			this.UserName.TabIndex = 4;
			this.UserName.Text = "U S E R N A M E";
			this.UserName.Click += new System.EventHandler(this.UserName_Click);
			// 
			// tbUser
			// 
			this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbUser.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.tbUser.Location = new System.Drawing.Point(513, 273);
			this.tbUser.MaximumSize = new System.Drawing.Size(400, 40);
			this.tbUser.Multiline = true;
			this.tbUser.Name = "tbUser";
			this.tbUser.Size = new System.Drawing.Size(342, 33);
			this.tbUser.TabIndex = 5;
			this.tbUser.UseSystemPasswordChar = true;
			this.tbUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.LightGray;
			this.panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.panel2.Location = new System.Drawing.Point(513, 304);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(342, 2);
			this.panel2.TabIndex = 6;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label1.Location = new System.Drawing.Point(513, 354);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "P A S S W O R D";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Gainsboro;
			this.panel3.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.panel3.Location = new System.Drawing.Point(516, 423);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(342, 2);
			this.panel3.TabIndex = 8;
			// 
			// tbPassword
			// 
			this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.tbPassword.Location = new System.Drawing.Point(513, 390);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.tbPassword.Size = new System.Drawing.Size(342, 23);
			this.tbPassword.TabIndex = 9;
			this.tbPassword.UseSystemPasswordChar = true;
			// 
			// btnSignin
			// 
			this.btnSignin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(14)))), ((int)(((byte)(99)))));
			this.btnSignin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSignin.BorderRadius = 0;
			this.btnSignin.ButtonText = "S I G N  I N";
			this.btnSignin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSignin.DisabledColor = System.Drawing.Color.Gray;
			this.btnSignin.Iconcolor = System.Drawing.Color.Transparent;
			this.btnSignin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSignin.Iconimage")));
			this.btnSignin.Iconimage_right = null;
			this.btnSignin.Iconimage_right_Selected = null;
			this.btnSignin.Iconimage_Selected = null;
			this.btnSignin.IconMarginLeft = 0;
			this.btnSignin.IconMarginRight = 0;
			this.btnSignin.IconRightVisible = true;
			this.btnSignin.IconRightZoom = 0D;
			this.btnSignin.IconVisible = true;
			this.btnSignin.IconZoom = 90D;
			this.btnSignin.IsTab = false;
			this.btnSignin.Location = new System.Drawing.Point(516, 488);
			this.btnSignin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSignin.Name = "btnSignin";
			this.btnSignin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(14)))), ((int)(((byte)(99)))));
			this.btnSignin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(1)))), ((int)(((byte)(84)))));
			this.btnSignin.OnHoverTextColor = System.Drawing.Color.White;
			this.btnSignin.selected = false;
			this.btnSignin.Size = new System.Drawing.Size(339, 39);
			this.btnSignin.TabIndex = 10;
			this.btnSignin.Text = "S I G N  I N";
			this.btnSignin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnSignin.Textcolor = System.Drawing.Color.White;
			this.btnSignin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.Location = new System.Drawing.Point(571, 87);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(205, 120);
			this.panel4.TabIndex = 11;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(14)))), ((int)(((byte)(99)))));
			this.panel5.Controls.Add(this.btnClose);
			this.panel5.Controls.Add(this.btnMinimize);
			this.panel5.Location = new System.Drawing.Point(481, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(431, 46);
			this.panel5.TabIndex = 12;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(14)))), ((int)(((byte)(99)))));
			this.btnClose.Location = new System.Drawing.Point(361, -10);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(65, 43);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnMinimize
			// 
			this.btnMinimize.BackColor = System.Drawing.Color.White;
			this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(14)))), ((int)(((byte)(99)))));
			this.btnMinimize.Location = new System.Drawing.Point(303, -18);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(57, 52);
			this.btnMinimize.TabIndex = 0;
			this.btnMinimize.Text = "-";
			this.btnMinimize.UseVisualStyleBackColor = false;
			this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(911, 562);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.btnSignin);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.tbUser);
			this.Controls.Add(this.UserName);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel UserName;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox tbPassword;
	}
}

