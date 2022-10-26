using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec_Stars_using_combobox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			layoutCbBox.SelectedIndex = 0;
		}

		private void rowLabel_TextChanged(object sender, EventArgs e)
		{

		}

		private void generateButton_Click(object sender, EventArgs e)
		{
			int rows = 0;

			//取得列數
			try
			{
				rows = GetRows();
			}catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			//取得呈現方式
			string display;
			try
			{
				display = GetDisplay(); 
			}catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}


			//計算星星
			string result;
			try
			{
				result = GetStar(display, rows);
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			resultTextBox.Text = result;

		}

		private string GetStar(string display, int rows)
		{
			switch (display)
			{
				case "靠左直角三角形":
					return GenerateLeftStars(rows);

				case "靠右直角三角形":
					return GenerateRightStars(rows);

				case "等腰直角三角形":
					return GenerateIsoStars(rows);
			}

			throw new Exception("不知道要畫什麼");
		}

		private string GenerateIsoStars(int rows)
		{
			string stars = string.Empty;

			for (int i = 1; i <= rows; i++)
			{
				stars += new string(' ', (rows - i) * 2) + new string('*', 2 * i - 1) + "\r\n";
			}

			return stars;
		}

		private string GenerateRightStars(int rows)
		{
			string stars = string.Empty;

			for (int i = 1; i <= rows; i++)
			{
				//stars += new string('*', i).PadLeft(rows, ' '*2) + "\r\n"; //看起來歪歪的
				stars += new string(' ', (rows - i) * 2) + new string('*', i) + "\r\n";
			}

			return stars;
		}

		private string GenerateLeftStars(int rows)
		{
			string stars = string.Empty;

			for (int i = 1; i <= rows; i++)
			{
				stars += new string('*', i) + "\r\n";
			}

			return stars;
		}

		private int GetRows()
		{
			//取得rowsTextBox中的數字
			string input = rowsTextBox.Text;
			bool isInt = int.TryParse(input, out int rows);

			if (isInt == false)
			{
				throw new Exception("請輸入列數!");
			}

			if (rows < 0)
			{
				throw new Exception("請輸入非負的正整數!");
			}

			return rows;
		}

		private string GetDisplay()
		{
			ComboBox item = this.layoutCbBox;
			object selectedItem = item.SelectedItem;

			return selectedItem != null? selectedItem.ToString() : null;	
		}
	}
}
