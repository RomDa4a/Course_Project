namespace Course_Project_2
{
	partial class Form2
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
			label1 = new Label();
			label2 = new Label();
			txtUsername = new TextBox();
			txtPassword = new TextBox();
			btnLogin = new Button();
			lblTitle = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(9, 84);
			label1.Name = "label1";
			label1.Size = new Size(80, 19);
			label1.TabIndex = 0;
			label1.Text = "Username";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Gadugi", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(9, 147);
			label2.Name = "label2";
			label2.Size = new Size(76, 19);
			label2.TabIndex = 1;
			label2.Text = "Password";
			// 
			// txtUsername
			// 
			txtUsername.BackColor = Color.FromArgb(30, 30, 30);
			txtUsername.BorderStyle = BorderStyle.None;
			txtUsername.Font = new Font("Gadugi", 12F);
			txtUsername.ForeColor = Color.White;
			txtUsername.Location = new Point(12, 106);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(508, 22);
			txtUsername.TabIndex = 2;
			// 
			// txtPassword
			// 
			txtPassword.BackColor = Color.FromArgb(30, 30, 30);
			txtPassword.BorderStyle = BorderStyle.None;
			txtPassword.Font = new Font("Gadugi", 12F);
			txtPassword.ForeColor = Color.White;
			txtPassword.Location = new Point(9, 169);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(511, 22);
			txtPassword.TabIndex = 2;
			txtPassword.UseSystemPasswordChar = true;
			// 
			// btnLogin
			// 
			btnLogin.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnLogin.Location = new Point(411, 264);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(109, 29);
			btnLogin.TabIndex = 3;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTitle.Location = new Point(207, 9);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(135, 25);
			lblTitle.TabIndex = 4;
			lblTitle.Text = "QUIZ LOGIN";
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(532, 305);
			Controls.Add(lblTitle);
			Controls.Add(btnLogin);
			Controls.Add(txtPassword);
			Controls.Add(txtUsername);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form2";
			Text = "Login";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtUsername;
		private TextBox txtPassword;
		private Button btnLogin;
		private Label lblTitle;
	}
}