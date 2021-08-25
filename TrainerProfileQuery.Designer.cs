namespace Project
{
    partial class TrainerProfileQuery
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
            this.trainerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainerProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSet = new Project.GymDataSet();
            this.trainerProfileTableAdapter = new Project.GymDataSetTableAdapters.TrainerProfileTableAdapter();
            this.trainerNameSearchToolStrip = new System.Windows.Forms.ToolStrip();
            this.trainerNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.trainerNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.trainerNameSearchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addressSearchToolStrip = new System.Windows.Forms.ToolStrip();
            this.addressToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.addressToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.addressSearchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            this.trainerNameSearchToolStrip.SuspendLayout();
            this.addressSearchToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainerIDDataGridViewTextBoxColumn,
            this.trainerNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.trainerProfileBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(599, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // trainerIDDataGridViewTextBoxColumn
            // 
            this.trainerIDDataGridViewTextBoxColumn.DataPropertyName = "TrainerID";
            this.trainerIDDataGridViewTextBoxColumn.HeaderText = "TrainerID";
            this.trainerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trainerIDDataGridViewTextBoxColumn.Name = "trainerIDDataGridViewTextBoxColumn";
            this.trainerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // trainerNameDataGridViewTextBoxColumn
            // 
            this.trainerNameDataGridViewTextBoxColumn.DataPropertyName = "TrainerName";
            this.trainerNameDataGridViewTextBoxColumn.HeaderText = "TrainerName";
            this.trainerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trainerNameDataGridViewTextBoxColumn.Name = "trainerNameDataGridViewTextBoxColumn";
            this.trainerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // trainerProfileBindingSource
            // 
            this.trainerProfileBindingSource.DataMember = "TrainerProfile";
            this.trainerProfileBindingSource.DataSource = this.gymDataSet;
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainerProfileTableAdapter
            // 
            this.trainerProfileTableAdapter.ClearBeforeFill = true;
            // 
            // trainerNameSearchToolStrip
            // 
            this.trainerNameSearchToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.trainerNameSearchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainerNameToolStripLabel,
            this.trainerNameToolStripTextBox,
            this.trainerNameSearchToolStripButton});
            this.trainerNameSearchToolStrip.Location = new System.Drawing.Point(0, 0);
            this.trainerNameSearchToolStrip.Name = "trainerNameSearchToolStrip";
            this.trainerNameSearchToolStrip.Size = new System.Drawing.Size(808, 27);
            this.trainerNameSearchToolStrip.TabIndex = 1;
            this.trainerNameSearchToolStrip.Text = "trainerNameSearchToolStrip";
            // 
            // trainerNameToolStripLabel
            // 
            this.trainerNameToolStripLabel.Name = "trainerNameToolStripLabel";
            this.trainerNameToolStripLabel.Size = new System.Drawing.Size(97, 24);
            this.trainerNameToolStripLabel.Text = "TrainerName:";
            // 
            // trainerNameToolStripTextBox
            // 
            this.trainerNameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.trainerNameToolStripTextBox.Name = "trainerNameToolStripTextBox";
            this.trainerNameToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // trainerNameSearchToolStripButton
            // 
            this.trainerNameSearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.trainerNameSearchToolStripButton.Name = "trainerNameSearchToolStripButton";
            this.trainerNameSearchToolStripButton.Size = new System.Drawing.Size(142, 24);
            this.trainerNameSearchToolStripButton.Text = "TrainerNameSearch";
            this.trainerNameSearchToolStripButton.Click += new System.EventHandler(this.trainerNameSearchToolStripButton_Click);
            // 
            // addressSearchToolStrip
            // 
            this.addressSearchToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.addressSearchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addressToolStripLabel,
            this.addressToolStripTextBox,
            this.addressSearchToolStripButton});
            this.addressSearchToolStrip.Location = new System.Drawing.Point(0, 27);
            this.addressSearchToolStrip.Name = "addressSearchToolStrip";
            this.addressSearchToolStrip.Size = new System.Drawing.Size(808, 27);
            this.addressSearchToolStrip.TabIndex = 2;
            this.addressSearchToolStrip.Text = "addressSearchToolStrip";
            // 
            // addressToolStripLabel
            // 
            this.addressToolStripLabel.Name = "addressToolStripLabel";
            this.addressToolStripLabel.Size = new System.Drawing.Size(65, 24);
            this.addressToolStripLabel.Text = "Address:";
            // 
            // addressToolStripTextBox
            // 
            this.addressToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addressToolStripTextBox.Name = "addressToolStripTextBox";
            this.addressToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // addressSearchToolStripButton
            // 
            this.addressSearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addressSearchToolStripButton.Name = "addressSearchToolStripButton";
            this.addressSearchToolStripButton.Size = new System.Drawing.Size(110, 24);
            this.addressSearchToolStripButton.Text = "AddressSearch";
            this.addressSearchToolStripButton.Click += new System.EventHandler(this.addressSearchToolStripButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 66);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrainerProfileQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addressSearchToolStrip);
            this.Controls.Add(this.trainerNameSearchToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TrainerProfileQuery";
            this.Text = "TrainerProfileQuery";
            this.Load += new System.EventHandler(this.TrainerProfileQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            this.trainerNameSearchToolStrip.ResumeLayout(false);
            this.trainerNameSearchToolStrip.PerformLayout();
            this.addressSearchToolStrip.ResumeLayout(false);
            this.addressSearchToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource trainerProfileBindingSource;
        private GymDataSetTableAdapters.TrainerProfileTableAdapter trainerProfileTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip trainerNameSearchToolStrip;
        private System.Windows.Forms.ToolStripLabel trainerNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox trainerNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton trainerNameSearchToolStripButton;
        private System.Windows.Forms.ToolStrip addressSearchToolStrip;
        private System.Windows.Forms.ToolStripLabel addressToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox addressToolStripTextBox;
        private System.Windows.Forms.ToolStripButton addressSearchToolStripButton;
        private System.Windows.Forms.Button button1;
    }
}