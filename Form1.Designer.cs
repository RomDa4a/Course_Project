namespace Course_Project_2
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			pictureBox1 = new PictureBox();
			lblQuestion = new Label();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			buttonStart = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.QUIZ;
			pictureBox1.Location = new Point(12, 74);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(871, 367);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// lblQuestion
			// 
			lblQuestion.Font = new Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblQuestion.Location = new Point(12, 18);
			lblQuestion.Name = "lblQuestion";
			lblQuestion.Size = new Size(871, 43);
			lblQuestion.TabIndex = 1;
			lblQuestion.Text = "Question";
			lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			button1.Font = new Font("Gadugi", 9F);
			button1.Location = new Point(37, 458);
			button1.Name = "button1";
			button1.Size = new Size(250, 50);
			button1.TabIndex = 2;
			button1.Tag = "1";
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += answerCheckingEvent;
			// 
			// button2
			// 
			button2.Font = new Font("Gadugi", 9F);
			button2.Location = new Point(633, 458);
			button2.Name = "button2";
			button2.Size = new Size(250, 50);
			button2.TabIndex = 2;
			button2.Tag = "2";
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			button2.Click += answerCheckingEvent;
			// 
			// button3
			// 
			button3.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			button3.Location = new Point(37, 532);
			button3.Name = "button3";
			button3.Size = new Size(250, 50);
			button3.TabIndex = 2;
			button3.Tag = "3";
			button3.Text = "button3";
			button3.UseVisualStyleBackColor = true;
			button3.Click += answerCheckingEvent;
			// 
			// button4
			// 
			button4.Font = new Font("Gadugi", 9F);
			button4.Location = new Point(633, 532);
			button4.Name = "button4";
			button4.Size = new Size(250, 50);
			button4.TabIndex = 2;
			button4.Tag = "4";
			button4.Text = "button4";
			button4.UseVisualStyleBackColor = true;
			button4.Click += answerCheckingEvent;
			// 
			// buttonStart
			// 
			buttonStart.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonStart.Location = new Point(745, 557);
			buttonStart.Name = "buttonStart";
			buttonStart.Size = new Size(138, 57);
			buttonStart.TabIndex = 3;
			buttonStart.Text = "Start Quiz";
			buttonStart.UseVisualStyleBackColor = true;
			buttonStart.Click += buttonStart_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(895, 626);
			Controls.Add(buttonStart);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(lblQuestion);
			Controls.Add(pictureBox1);
			Name = "Form1";
			Text = "Quiz Application";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pictureBox1;
		private Label lblQuestion;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button buttonStart;
	}
}
