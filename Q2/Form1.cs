using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void CheckButton_Click(object sender, EventArgs e)
		{
			string input = dateTimeTextBox.Text;
			DateTime dateTime = DateTime.Today;
			DateTime inputDateTime = Convert.ToDateTime(input);
			if (inputDateTime < dateTime)
			{
				outputLabel.Text = inputDateTime.ToString("yyyy/MM/dd");

			}
			else
			{
				outputLabel.Text = "您輸入的日期大於今天";
			}
		}
	}
}
