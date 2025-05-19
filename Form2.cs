using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing.Drawing2D;

namespace Course_Project_2
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
			ApplyDarkTheme();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text;
			string password = txtPassword.Text;

			string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QuizDB;Integrated Security=True"; ;

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				MessageBox.Show("Loading...");

				string query = "SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@username", username);
				cmd.Parameters.AddWithValue("@password", password);

				int count = (int)cmd.ExecuteScalar();

				if (count > 0)
				{
					MessageBox.Show("Successful login!");
					Form1 mainForm = new Form1();
					mainForm.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Login Failed.");
				}
			}
		}

		private void ApplyDarkTheme()
		{
			this.BackColor = Color.FromArgb(30, 30, 30);
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;

			lblTitle.ForeColor = Color.White;
			label1.ForeColor = Color.White;
			label2.ForeColor = Color.White;

			txtUsername.BackColor = Color.FromArgb(45, 45, 48);
			txtUsername.ForeColor = Color.White;
			txtUsername.BorderStyle = BorderStyle.FixedSingle;

			txtPassword.BackColor = Color.FromArgb(45, 45, 48);
			txtPassword.ForeColor = Color.White;
			txtPassword.BorderStyle = BorderStyle.FixedSingle;
			txtPassword.UseSystemPasswordChar = true;

			btnLogin.FlatStyle = FlatStyle.Flat;
			btnLogin.FlatAppearance.BorderSize = 0;
			btnLogin.BackColor = Color.FromArgb(70, 70, 75);
			btnLogin.ForeColor = Color.White;
			btnLogin.Font = new Font("Gadugi", 10, FontStyle.Bold);
			btnLogin.Region = new Region(CreateRoundedRect(btnLogin.ClientRectangle, 10));
		}

		private GraphicsPath CreateRoundedRect(Rectangle rect, int radius)
		{
			GraphicsPath path = new GraphicsPath();
			int diameter = radius * 2;

			path.StartFigure();
			path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
			path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
			path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
			path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
			path.CloseFigure();
			return path;
		}

	}
}