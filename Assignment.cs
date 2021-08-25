﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class Assignment : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-RJ7CEM4L\\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public Assignment()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select * from Assignment", con);
            this.assignmentTableAdapter.Fill(this.gymDataSet.Assignment);

        }

        private void Assignment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet.Assignment' table. You can move, or remove it, as needed.
            this.assignmentTableAdapter.Fill(this.gymDataSet.Assignment);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder sda;
            sda = new SqlCommandBuilder(da);
            da.Update(gymDataSet.Assignment);
            MessageBox.Show("Passed Succesfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
