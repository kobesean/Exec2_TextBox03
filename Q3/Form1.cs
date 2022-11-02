using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void checkButton_Click(object sender, EventArgs e)
		{
			string input = dateTimeTextBox.Text;
			DateTime dateTime = DateTime.Today;
			DateTime inputDateTime = Convert.ToDateTime(input);
			int year = dateTime.Year - inputDateTime.Year;
			if (inputDateTime > dateTime)
			{
				outputLabel.Text = ("您輸入的日期大於今天");
				return;
			}
			if (year > 13)
			{
				outputLabel.Text = ($"您的年紀為{year}大於13");
			}
			else
			{
				outputLabel.Text = ($"您的年紀為{year}小於13");
			}
		}
	}
}
