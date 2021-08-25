namespace Project
{
    partial class TrainingScheduleQuery
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
            this.scheduleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exerciseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repetitionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthOfTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSet = new Project.GymDataSet();
            this.trainingScheduleTableAdapter = new Project.GymDataSetTableAdapters.TrainingScheduleTableAdapter();
            this.levelCodeSearchToolStrip = new System.Windows.Forms.ToolStrip();
            this.levelCodeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.levelCodeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.levelCodeSearchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.exerciseNameSearchToolStrip = new System.Windows.Forms.ToolStrip();
            this.exerciseNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.exerciseNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.exerciseNameSearchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            this.levelCodeSearchToolStrip.SuspendLayout();
            this.exerciseNameSearchToolStrip.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(540, 310);
            this.dataGridView1.TabIndex = 0;
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
            // trainingScheduleBindingSource
            // 
            this.trainingScheduleBindingSource.DataMember = "TrainingSchedule";
            this.trainingScheduleBindingSource.DataSource = this.gymDataSet;
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainingScheduleTableAdapter
            // 
            this.trainingScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // levelCodeSearchToolStrip
            // 
            this.levelCodeSearchToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.levelCodeSearchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.levelCodeToolStripLabel,
            this.levelCodeToolStripTextBox,
            this.levelCodeSearchToolStripButton});
            this.levelCodeSearchToolStrip.Location = new System.Drawing.Point(0, 0);
            this.levelCodeSearchToolStrip.Name = "levelCodeSearchToolStrip";
            this.levelCodeSearchToolStrip.Size = new System.Drawing.Size(800, 27);
            this.levelCodeSearchToolStrip.TabIndex = 1;
            this.levelCodeSearchToolStrip.Text = "levelCodeSearchToolStrip";
            // 
            // levelCodeToolStripLabel
            // 
            this.levelCodeToolStripLabel.Name = "levelCodeToolStripLabel";
            this.levelCodeToolStripLabel.Size = new System.Drawing.Size(81, 24);
            this.levelCodeToolStripLabel.Text = "LevelCode:";
            // 
            // levelCodeToolStripTextBox
            // 
            this.levelCodeToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.levelCodeToolStripTextBox.Name = "levelCodeToolStripTextBox";
            this.levelCodeToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // levelCodeSearchToolStripButton
            // 
            this.levelCodeSearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.levelCodeSearchToolStripButton.Name = "levelCodeSearchToolStripButton";
            this.levelCodeSearchToolStripButton.Size = new System.Drawing.Size(126, 24);
            this.levelCodeSearchToolStripButton.Text = "LevelCodeSearch";
            this.levelCodeSearchToolStripButton.Click += new System.EventHandler(this.levelCodeSearchToolStripButton_Click);
            // 
            // exerciseNameSearchToolStrip
            // 
            this.exerciseNameSearchToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.exerciseNameSearchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exerciseNameToolStripLabel,
            this.exerciseNameToolStripTextBox,
            this.exerciseNameSearchToolStripButton});
            this.exerciseNameSearchToolStrip.Location = new System.Drawing.Point(0, 27);
            this.exerciseNameSearchToolStrip.Name = "exerciseNameSearchToolStrip";
            this.exerciseNameSearchToolStrip.Size = new System.Drawing.Size(800, 27);
            this.exerciseNameSearchToolStrip.TabIndex = 2;
            this.exerciseNameSearchToolStrip.Text = "exerciseNameSearchToolStrip";
            // 
            // exerciseNameToolStripLabel
            // 
            this.exerciseNameToolStripLabel.Name = "exerciseNameToolStripLabel";
            this.exerciseNameToolStripLabel.Size = new System.Drawing.Size(105, 24);
            this.exerciseNameToolStripLabel.Text = "ExerciseName:";
            // 
            // exerciseNameToolStripTextBox
            // 
            this.exerciseNameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exerciseNameToolStripTextBox.Name = "exerciseNameToolStripTextBox";
            this.exerciseNameToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // exerciseNameSearchToolStripButton
            // 
            this.exerciseNameSearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exerciseNameSearchToolStripButton.Name = "exerciseNameSearchToolStripButton";
            this.exerciseNameSearchToolStripButton.Size = new System.Drawing.Size(150, 24);
            this.exerciseNameSearchToolStripButton.Text = "ExerciseNameSearch";
            this.exerciseNameSearchToolStripButton.Click += new System.EventHandler(this.exerciseNameSearchToolStripButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 70);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrainingScheduleQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exerciseNameSearchToolStrip);
            this.Controls.Add(this.levelCodeSearchToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TrainingScheduleQuery";
            this.Text = "TrainingScheduleQuery";
            this.Load += new System.EventHandler(this.TrainingScheduleQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            this.levelCodeSearchToolStrip.ResumeLayout(false);
            this.levelCodeSearchToolStrip.PerformLayout();
            this.exerciseNameSearchToolStrip.ResumeLayout(false);
            this.exerciseNameSearchToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ToolStrip levelCodeSearchToolStrip;
        private System.Windows.Forms.ToolStripLabel levelCodeToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox levelCodeToolStripTextBox;
        private System.Windows.Forms.ToolStripButton levelCodeSearchToolStripButton;
        private System.Windows.Forms.ToolStrip exerciseNameSearchToolStrip;
        private System.Windows.Forms.ToolStripLabel exerciseNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox exerciseNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton exerciseNameSearchToolStripButton;
        private System.Windows.Forms.Button button1;
    }
}