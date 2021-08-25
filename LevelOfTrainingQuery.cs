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
    public partial class LevelOfTrainingQuery : Form
    {
        public LevelOfTrainingQuery()
        {
            InitializeComponent();
        }

        private void LevelOfTrainingQuery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet.LevelOfTraining' table. You can move, or remove it, as needed.
            this.levelOfTrainingTableAdapter.Fill(this.gymDataSet.LevelOfTraining);

        }

        private void levelDescriptionSearchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.levelOfTrainingTableAdapter.LevelDescriptionSearch(this.gymDataSet.LevelOfTraining, levelDescriptionToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void exerciseNameSearchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.levelOfTrainingTableAdapter.ExerciseNameSearch(this.gymDataSet.LevelOfTraining, exerciseNameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-RJ7CEM4L\\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from LevelOfTraining", con);
            da.Fill(gymDataSet.LevelOfTraining);
            dataGridView1.DataSource = gymDataSet.LevelOfTraining;
        }
    }
}
