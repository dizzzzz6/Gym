namespace Project
{
    partial class TrainingSchedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gymDataSet = new Project.GymDataSet();
            this.trainingScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainingScheduleTableAdapter = new Project.GymDataSetTableAdapters.TrainingScheduleTableAdapter();
            this.scheduleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exerciseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repetitionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthOfTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingScheduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scheduleIDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.levelCodeDataGridViewTextBoxColumn,
            this.exerciseNameDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.repetitionDataGridViewTextBoxColumn,
            this.lengthOfTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.trainingScheduleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 284);
            this.dataGridView1.TabIndex = 0;
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainingScheduleBindingSource
            // 
            this.trainingScheduleBindingSource.DataMember = "TrainingSchedule";
            this.trainingScheduleBindingSource.DataSource = this.gymDataSet;
            // 
            // trainingScheduleTableAdapter
            // 
            this.trainingScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // scheduleIDDataGridViewTextBoxColumn
            // 
            this.scheduleIDDataGridViewTextBoxColumn.DataPropertyName = "ScheduleID";
            this.scheduleIDDataGridViewTextBoxColumn.HeaderText = "ScheduleID";
            this.scheduleIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.scheduleIDDataGridViewTextBoxColumn.Name = "scheduleIDDataGridViewTextBoxColumn";
            this.scheduleIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // levelCodeDataGridViewTextBoxColumn
            // 
            this.levelCodeDataGridViewTextBoxColumn.DataPropertyName = "LevelCode";
            this.levelCodeDataGridViewTextBoxColumn.HeaderText = "LevelCode";
            this.levelCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.levelCodeDataGridViewTextBoxColumn.Name = "levelCodeDataGridViewTextBoxColumn";
            this.levelCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // exerciseNameDataGridViewTextBoxColumn
            // 
            this.exerciseNameDataGridViewTextBoxColumn.DataPropertyName = "ExerciseName";
            this.exerciseNameDataGridViewTextBoxColumn.HeaderText = "ExerciseName";
            this.exerciseNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.exerciseNameDataGridViewTextBoxColumn.Name = "exerciseNameDataGridViewTextBoxColumn";
            this.exerciseNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // repetitionDataGridViewTextBoxColumn
            // 
            this.repetitionDataGridViewTextBoxColumn.DataPropertyName = "Repetition";
            this.repetitionDataGridViewTextBoxColumn.HeaderText = "Repetition";
            this.repetitionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.repetitionDataGridViewTextBoxColumn.Name = "repetitionDataGridViewTextBoxColumn";
            this.repetitionDataGridViewTextBoxColumn.Width = 125;
            // 
            // lengthOfTimeDataGridViewTextBoxColumn
            // 
            this.lengthOfTimeDataGridViewTextBoxColumn.DataPropertyName = "LengthOfTime";
            this.lengthOfTimeDataGridViewTextBoxColumn.HeaderText = "LengthOfTime";
            this.lengthOfTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lengthOfTimeDataGridViewTextBoxColumn.Name = "lengthOfTimeDataGridViewTextBoxColumn";
            this.lengthOfTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrainingSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TrainingSchedule";
            this.Text = "TrainingSchedule";
            this.Load += new System.EventHandler(this.TrainingSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingScheduleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource trainingScheduleBindingSource;
        private GymDataSetTableAdapters.TrainingScheduleTableAdapter trainingScheduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exerciseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repetitionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthOfTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}