using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Project_2
{
	public partial class Form1 : Form
	{

		// Quiz variables

		int correctQuestion;
		int questionNumber = 1;
		int score;
		int percentage;
		int totalQuestions;




		public Form1()
		{
			InitializeComponent();

			ApplyDarkTheme();
			ShowStartScreen();
			
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void answerCheckingEvent(object sender, EventArgs e)
		{
			var senderObject = (Button)sender;
			int buttonTag = Convert.ToInt32(senderObject.Tag);
			if (buttonTag == correctQuestion)
			{
				score++;
			}
			if (questionNumber == totalQuestions)
			{
				percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
				MessageBox.Show(
					"Quiz Ended!" + Environment.NewLine +
					"You have answered " + score + " questions correctly." + Environment.NewLine +
					"Your total percentage is " + percentage + "%" + Environment.NewLine +
					"Click OK to play again"
					);
				score = 0;
				questionNumber = 0;
				askQuestion(questionNumber);
			}
			questionNumber++;
			askQuestion(questionNumber);

		}

		private void askQuestion(int qnum)
		{
			switch (qnum)
			{
				case 1:
					pictureBox1.Image = Properties.Resources.DataStructuresAlgorithms;
					lblQuestion.Text = "What is the time complexity of searching for an element in a balanced binary search tree (BST)?";
					button1.Text = "O(log n)";
					button2.Text = "O(n)";
					button3.Text = "O(1)";
					button4.Text = "O(n log n)";
					correctQuestion = 1;
					break;
				case 2:
					pictureBox1.Image = Properties.Resources.algorithm;
					lblQuestion.Text = "Which of the following sorting algorithms is NOT comparison-based?";
					button1.Text = "Merge Sort";
					button2.Text = "Quick Sort";
					button3.Text = "Heap Sort";
					button4.Text = "Counting Sort";
					correctQuestion = 4;
					break;
				case 3:
					pictureBox1.Image = Properties.Resources.OOP;
					lblQuestion.Text = "Which concept of OOP is being used when a subclass provides a specific implementation of a method already defined in its superclass?";
					button1.Text = "Encapsulation";
					button2.Text = "Inheritance";
					button3.Text = "Abstraction";
					button4.Text = "Polymorphism";
					correctQuestion = 4;
					break;
				case 4:
					pictureBox1.Image = Properties.Resources.Databases;
					lblQuestion.Text = "In relational databases, what does SQL stand for?";
					button1.Text = "Structured Query Language";
					button2.Text = "Sequential Query Logic";
					button3.Text = "Simple Query Language";
					button4.Text = "Structured Question Language";
					correctQuestion = 1;
					break;
				case 5:
					pictureBox1.Image = Properties.Resources.OS;
					lblQuestion.Text = "Which of the following is NOT a function of an operating system?";
					button1.Text = "File management";
					button2.Text = "Memory management";
					button3.Text = "Compiling code";
					button4.Text = "Process scheduling";
					correctQuestion = 3;
					break;
				case 6:
					pictureBox1.Image = Properties.Resources.PROG;
					lblQuestion.Text = "What is the output of the expression 5 / 2 in most modern programming languages when both operands are integers?";
					button1.Text = "2.5";
					button2.Text = "2";
					button3.Text = "3";
					button4.Text = "Error";
					correctQuestion = 2;
					break;
				case 7:
					pictureBox1.Image = Properties.Resources.SOFT_ENG;
					lblQuestion.Text = "In the software development life cycle (SDLC), which phase comes immediately after requirements analysis?";
					button1.Text = "Testing";
					button2.Text = "Design";
					button3.Text = "Implementation";
					button4.Text = "Deployment";
					correctQuestion = 2;
					break;
				case 8:
					pictureBox1.Image = Properties.Resources.COMP_ARC;
					lblQuestion.Text = "What type of memory is typically used to store the BIOS of a computer?";
					button1.Text = "RAM";
					button2.Text = "Cache";
					button3.Text = "ROM";
					button4.Text = "Register";
					correctQuestion = 3;
					break;
				case 9:
					pictureBox1.Image = Properties.Resources.NETWORKING;
					lblQuestion.Text = "Which protocol is used to send emails?";
					button1.Text = "FTP";
					button2.Text = "HTTP";
					button3.Text = "SMTP";
					button4.Text = "SNMP";
					correctQuestion = 3;
					break;
				case 10:
					pictureBox1.Image = Properties.Resources.cybersecurity;
					lblQuestion.Text = "What does the term “phishing” refer to in cybersecurity?";
					button1.Text = "Cracking encryption";
					button2.Text = "Unauthorized access to hardware";
					button3.Text = "Fraudulent attempts to obtain sensitive information";
					button4.Text = "Scanning networks for open ports";
					correctQuestion = 3;
					break;
			}

		}

		private void ShowStartScreen()
		{
			pictureBox1.Image = Properties.Resources.QUIZ;

			lblQuestion.Text = "Are you ready for Quiz?";

			button1.Visible = false;
			button2.Visible = false;
			button3.Visible = false;
			button4.Visible = false;

			buttonStart.Visible = true;
		}

		private void StartQuiz()
		{
			questionNumber = 1;
			score = 0;

			button1.Visible = true;
			button2.Visible = true;
			button3.Visible = true;
			button4.Visible = true;

			buttonStart.Visible = false;

			totalQuestions = 10;
			askQuestion(questionNumber);
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			StartQuiz();
		}

		private void ApplyDarkTheme()
		{
			RoundPictureBox(pictureBox1, 30);

			this.BackColor = Color.FromArgb(30, 30, 30); 
			lblQuestion.ForeColor = Color.White;

			foreach (Control ctrl in this.Controls)
			{
				if (ctrl is Button btn)
				{
					btn.FlatStyle = FlatStyle.Flat;
					btn.FlatAppearance.BorderSize = 0;
					btn.BackColor = Color.FromArgb(45, 45, 48);
					btn.ForeColor = Color.White;
					btn.Font = new Font("Gadugi", 10, FontStyle.Bold);
					btn.Region = new Region(CreateRoundedRect(btn.ClientRectangle, 10));
				}
			}
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
		private void RoundPictureBox(PictureBox pb, int radius)
		{
			Rectangle rect = pb.ClientRectangle;
			GraphicsPath path = new GraphicsPath();
			int diameter = radius * 2;

			path.StartFigure();
			path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
			path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
			path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
			path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
			path.CloseFigure();

			pb.Region = new Region(path);
		}


	}

}
