using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SMTTT_1
{	public partial class Form2 : Form
	{
		
public Form2()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void loginbt_Click(object sender, EventArgs e)
		{
			string username;
			string password;

			username = usernametb.Text;
			password = passwordtb.Text; 

			//Connects to the database
			string connString = "Server=simplemodes.cyqmaqudzup4.us-east-2.rds.amazonaws.com;Port=3306;Database=SimpleModes;password=UsmStudent"; 
			MySqlConnection conn = new MySqlConnection(connString);
			MySqlCommand command = conn.CreateCommand();

			try
			{
				//checks to see if the username and password appear in the accounttable
				command.CommandText = "Select" + username + " from customer where password = " + password;
			}

			catch
			{
				
				MessageBox.Show("Either wrong password or wrong username, brudda");

			}



		}

		private void createbt_Click(object sender, EventArgs e)
		{
			//Opens the create an account form. I just didn't name the form according to what it does cause I'm lazy whatever
			Form4 f4 = new Form4();
			f4.ShowDialog();
		}
	}
}
