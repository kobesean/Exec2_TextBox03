using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void calcButton_Click(object sender, EventArgs e)
		{
			string peopleinput = peopleTextBox.Text;
			string carinput = carTextBox.Text;
			int carfee = 200;
			int peoplefee = 60;
			int people = Convert.ToInt32(peopleinput);
			int car = Convert.ToInt32(carinput);

			if (people * peoplefee > car * carfee)
			{
				outputLable.Text = ($"以車數來計算比較便宜,價錢為{car * carfee}");
			}
			if (people * peoplefee < car * carfee)
			{
				outputLable.Text = ($"以人數來計算比較便宜,價錢為{people * peoplefee}");
			}
			if (people * peoplefee == car * carfee)
			{
				outputLable.Text = ($"以人數或車數來計算都一樣,價錢為{people * peoplefee}");
			}
		}
	}
}
