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
    public partial class ClientProfile : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-HVOK79UL\\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public ClientProfile()
        {
           
            
            InitializeComponent();
            da = new SqlDataAdapter("select * from Client_Profile", con);
            this.client_ProfileTableAdapter.Fill(this.gymDataSet.Client_Profile);
            
        }

        private void ClientProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet.Client_Profile' table. You can move, or remove it, as needed.
            this.client_ProfileTableAdapter.Fill(this.gymDataSet.Client_Profile);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder sda;
            sda = new SqlCommandBuilder(da);
            da.Update(gymDataSet.Client_Profile);
            MessageBox.Show("Passed Succesfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
