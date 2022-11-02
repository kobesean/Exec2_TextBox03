using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void checkbutton_Click(object sender, EventArgs e)
		{
			//判斷資料型別
			string input = inputTextBox.Text;
			//轉成int
			bool inputint = int.TryParse(input, out int result);
			//判斷是否在1~99
			if (inputint == true && result > 0)
			{
				outputLabel.Text = $"您輸入的數字為 {input}";

			}
			else
			{
				MessageBox.Show("請輸入1~99");
			}
		}
	}
}
