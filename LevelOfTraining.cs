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
    public partial class LevelOfTraining : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-RJ7CEM4L\\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public LevelOfTraining()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select * from LevelOfTraining", con);
            this.levelOfTrainingTableAdapter.Fill(this.gymDataSet.LevelOfTraining);

        }

        private void LevelOfTraining_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet.LevelOfTraining' table. You can move, or remove it, as needed.
            this.levelOfTrainingTableAdapter.Fill(this.gymDataSet.LevelOfTraining);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder sda;
            sda = new SqlCommandBuilder(da);
            da.Update(gymDataSet.LevelOfTraining);
            MessageBox.Show("Passed Succesfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
