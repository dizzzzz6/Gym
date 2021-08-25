namespace Project
{
    partial class ExerciseQuery
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
            this.exerciseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exerciseDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exerciseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSet = new Project.GymDataSet();
            this.exerciseTableAdapter = new Project.GymDataSetTableAdapters.ExerciseTableAdapter();
            this.descriptionSearchToolStrip = new System.Windows.Forms.ToolStrip();
            this.exerciseDescriptionToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.exerciseDescriptionToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.descriptionSearchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            this.descriptionSearchToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exerciseNameDataGridViewTextBoxColumn,
            this.exerciseDescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.exerciseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(460, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // exerciseNameDataGridViewTextBoxColumn
            // 
            this.exerciseNameDataGridViewTextBoxColumn.DataPropertyName = "ExerciseName";
            this.exerciseNameDataGridViewTextBoxColumn.HeaderText = "ExerciseName";
            this.exerciseNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.exerciseNameDataGridViewTextBoxColumn.Name = "exerciseNameDataGridViewTextBoxColumn";
            this.exerciseNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // exerciseDescriptionDataGridViewTextBoxColumn
            // 
            this.exerciseDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ExerciseDescription";
            this.exerciseDescriptionDataGridViewTextBoxColumn.HeaderText = "ExerciseDescription";
            this.exerciseDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.exerciseDescriptionDataGridViewTextBoxColumn.Name = "exerciseDescriptionDataGridViewTextBoxColumn";
            this.exerciseDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // exerciseBindingSource
            // 
            this.exerciseBindingSource.DataMember = "Exercise";
            this.exerciseBindingSource.DataSource = this.gymDataSet;
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exerciseTableAdapter
            // 
            this.exerciseTableAdapter.ClearBeforeFill = true;
            // 
            // descriptionSearchToolStrip
            // 
            this.descriptionSearchToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.descriptionSearchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exerciseDescriptionToolStripLabel,
            this.exerciseDescriptionToolStripTextBox,
            this.descriptionSearchToolStripButton});
            this.descriptionSearchToolStrip.Location = new System.Drawing.Point(0, 0);
            this.descriptionSearchToolStrip.Name = "descriptionSearchToolStrip";
            this.descriptionSearchToolStrip.Size = new System.Drawing.Size(800, 27);
            this.descriptionSearchToolStrip.TabIndex = 1;
            this.descriptionSearchToolStrip.Text = "descriptionSearchToolStrip";
            // 
            // exerciseDescriptionToolStripLabel
            // 
            this.exerciseDescriptionToolStripLabel.Name = "exerciseDescriptionToolStripLabel";
            this.exerciseDescriptionToolStripLabel.Size = new System.Drawing.Size(141, 24);
            this.exerciseDescriptionToolStripLabel.Text = "ExerciseDescription:";
            // 
            // exerciseDescriptionToolStripTextBox
            // 
            this.exerciseDescriptionToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exerciseDescriptionToolStripTextBox.Name = "exerciseDescriptionToolStripTextBox";
            this.exerciseDescriptionToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // descriptionSearchToolStripButton
            // 
            this.descriptionSearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.descriptionSearchToolStripButton.Name = "descriptionSearchToolStripButton";
            this.descriptionSearchToolStripButton.Size = new System.Drawing.Size(133, 24);
            this.descriptionSearchToolStripButton.Text = "DescriptionSearch";
            this.descriptionSearchToolStripButton.Click += new System.EventHandler(this.descriptionSearchToolStripButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExerciseQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.descriptionSearchToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ExerciseQuery";
            this.Text = "ExerciseQuery";
            this.Load += new System.EventHandler(this.ExerciseQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            this.descriptionSearchToolStrip.ResumeLayout(false);
            this.descriptionSearchToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource exerciseBindingSource;
        private GymDataSetTableAdapters.ExerciseTableAdapter exerciseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn exerciseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exerciseDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip descriptionSearchToolStrip;
        private System.Windows.Forms.ToolStripLabel exerciseDescriptionToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox exerciseDescriptionToolStripTextBox;
        private System.Windows.Forms.ToolStripButton descriptionSearchToolStripButton;
        private System.Windows.Forms.Button button1;
    }
}