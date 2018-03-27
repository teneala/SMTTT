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
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void createaccbt_Click(object sender, EventArgs e)
		{
			string username = usernametb.Text;
			string password = passwordtb.Text;
			string firstname = firsttb.Text;
			string lastname = lastnametb.Text;
			string phone = phonenumbertb.Text;
			string address = addresstb.Text;
			string userExist;

			username = usernametb.Text;
			password = passwordtb.Text;

			//connects to database pretty straight forward 
			string connString = "Server=simplemodes.cyqmaqudzup4.us-east-2.rds.amazonaws.com;Port=3306;Database=SimpleModes;password=UsmStudent";
			MySqlConnection conn = new MySqlConnection(connString);

			//creates a string to do mySQL commands and stuff
			MySqlCommand insertUserInfo = conn.CreateCommand();
			MySqlCommand checkIfExist = conn.CreateCommand(); 

			//used to see if the username chosen exists obviously 
			userExist = checkIfExist.CommandText = "Select" + username + " from accounttable where password = " + password;

			if (userExist != null)
			{
				MessageBox.Show("Try to be more original as your username already exist. Normie.");
				createaccbt_Click(sender, e);
			}

			insertUserInfo.CommandText = "Insert into accounttable (username, password, firstname, lastname, phone, address)" + "values(" + username + password + firstname + lastname + phone + address + ")" ;




		}
	}
}
