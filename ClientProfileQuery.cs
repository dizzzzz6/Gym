using System;
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
    public partial class ClientProfileQuery : Form
    {
        public ClientProfileQuery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-RJ7CEM4L\\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from Client_Profile", con);
            da.Fill(gymDataSet.Client_Profile);
            dataGridView1.DataSource = gymDataSet.Client_Profile;



        }

        private void ClientProfileQuery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet.Client_Profile' table. You can move, or remove it, as needed.
            this.client_ProfileTableAdapter.Fill(this.gymDataSet.Client_Profile);

        }

        private void searchNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.client_ProfileTableAdapter.SearchName(this.gymDataSet.Client_Profile, client_NameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void searchGenderToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.client_ProfileTableAdapter.SearchGender(this.gymDataSet.Client_Profile, genderToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
