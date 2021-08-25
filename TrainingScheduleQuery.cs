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
    public partial class TrainingScheduleQuery : Form
    {
        public TrainingScheduleQuery()
        {
            InitializeComponent();
        }

        private void TrainingScheduleQuery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet.TrainingSchedule' table. You can move, or remove it, as needed.
            this.trainingScheduleTableAdapter.Fill(this.gymDataSet.TrainingSchedule);

        }

        private void levelCodeSearchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.trainingScheduleTableAdapter.LevelCodeSearch(this.gymDataSet.TrainingSchedule, levelCodeToolStripTextBox.Text);
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
                this.trainingScheduleTableAdapter.ExerciseNameSearch(this.gymDataSet.TrainingSchedule, exerciseNameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-RJ7CEM4L\\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from TrainingSchedule", con);
            da.Fill(gymDataSet.TrainingSchedule);
            dataGridView1.DataSource = gymDataSet.TrainingSchedule;
        }
    }
}
