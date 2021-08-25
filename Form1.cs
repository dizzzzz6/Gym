using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

       

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ClientProfile cl = new ClientProfile();
            cl.Show();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            DietItems dit = new DietItems();
            dit.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TrainerProfile tr = new TrainerProfile();
            tr.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Exercise ex = new Exercise();
            ex.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Diet di = new Diet();
            di.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            LevelOfTraining lot = new LevelOfTraining();
            lot.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            TrainingSchedule ts = new TrainingSchedule();
            ts.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Assignment assi = new Assignment();
            assi.Show();
        }

        private void clientProfileQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientProfileQuery q1 = new ClientProfileQuery();
            q1.Show();
        }

        private void trainerProfileQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainerProfileQuery q2 = new TrainerProfileQuery();
            q2.Show();
        }

        private void exerciseQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExerciseQuery q3 = new ExerciseQuery();
            q3.Show();
        }

        private void dietQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DietQuery q4 = new DietQuery();
            q4.Show();
        }

        private void dietItemsQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DietItemsQuery q5 = new DietItemsQuery();
            q5.Show();
        }

        private void levelOfTrainingQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevelOfTrainingQuery q6 = new LevelOfTrainingQuery();
            q6.Show();
        }

        private void trainingScheduleQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainingScheduleQuery q7 = new TrainingScheduleQuery();
            q7.Show();
        }

        private void assignmentQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignmentQuery q8 = new AssignmentQuery();
            q8.Show();
        }
    }
}
