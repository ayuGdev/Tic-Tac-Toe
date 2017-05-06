using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		bool t = true;
		int t_count = 0;
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void Btns_Click(object sender, EventArgs e)
		{
			Button b = (Button)sender;
			if (t)
				b.Text = "X";
			else
				b.Text = "O";
			t = !t;
			b.Enabled = false;
			t_count++;
			checkwinner();
		}
		private void checkwinner()
		{
			bool i = false;
			if ((a1.Text==a2.Text)&&(a2.Text==a3.Text)&&(!a1.Enabled))
			{
				i = true;
			}
			else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
			{
				i = true;
			}
			else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
			{
				i = true;
			}
			else if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
			{
				i = true;
			}
			else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
			{
				i = true;
			}
			else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
			{
				i = true;
			}
			else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
			{
				i = true;
			}
			else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && (!a3.Enabled))
			{
				i = true;
			}
			if (i)
			{
				string s;
				if (t)
				{
					int a = Convert.ToInt32(O.Text);
					a++;
					O.Text = a.ToString();
					s = player2.Text;
					enabledbuttons();
				}
				else
				{
					int a = Convert.ToInt32(X.Text);
					a++;
					X.Text = a.ToString();
					s = player1.Text;
					enabledbuttons();
				}
				MessageBox.Show(s + " WIN !! ");
				t_count = 0;
			}
			if (t_count == 9)
			{
				MessageBox.Show(" Draw !! ");
				t_count = 0;
				enabledbuttons();
				int a = Convert.ToInt32(d.Text);
				a++;
				d.Text = a.ToString();
			}
		}
		private void enabledbuttons()
		{
			foreach (Control c in Controls) 
			{
				try
				{
					Button b = (Button)c;
					b.Enabled = true;
					b.Text = "";
				}
				catch { }

			}
			
		}

		private void c1_mouseEntre(object sender, EventArgs e)
		{
			Button b = (Button)sender;
			if ((t) && (b.Enabled))
				b.Text = "X";
			if ((t == false) && (b.Enabled))
				b.Text = "O";
		}

		private void c1_mouseLeave(object sender, EventArgs e)
		{
			Button b = (Button)sender;
			if (b.Enabled)
				b.Text = "";

		}

		private void X_Click(object sender, EventArgs e)
		{

		}
	}
}
