namespace Project
{
    partial class ClientProfileQuery
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
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSet = new Project.GymDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.client_ProfileTableAdapter = new Project.GymDataSetTableAdapters.Client_ProfileTableAdapter();
            this.searchNameToolStrip = new System.Windows.Forms.ToolStrip();
            this.client_NameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.client_NameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.gymDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchGenderToolStrip = new System.Windows.Forms.ToolStrip();
            this.genderToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.genderToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchGenderToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            this.searchNameToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSetBindingSource)).BeginInit();
            this.searchGenderToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.payementDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientProfileBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(60, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            this.birthdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "Startdate";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "Startdate";
            this.startdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            this.startdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // payementDataGridViewTextBoxColumn
            // 
            this.payementDataGridViewTextBoxColumn.DataPropertyName = "Payement";
            this.payementDataGridViewTextBoxColumn.HeaderText = "Payement";
            this.payementDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payementDataGridViewTextBoxColumn.Name = "payementDataGridViewTextBoxColumn";
            this.payementDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientProfileBindingSource
            // 
            this.clientProfileBindingSource.DataMember = "Client_Profile";
            this.clientProfileBindingSource.DataSource = this.gymDataSet;
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 66);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // client_ProfileTableAdapter
            // 
            this.client_ProfileTableAdapter.ClearBeforeFill = true;
            // 
            // searchNameToolStrip
            // 
            this.searchNameToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.searchNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.client_NameToolStripLabel,
            this.client_NameToolStripTextBox,
            this.searchNameToolStripButton});
            this.searchNameToolStrip.Location = new System.Drawing.Point(0, 0);
            this.searchNameToolStrip.Name = "searchNameToolStrip";
            this.searchNameToolStrip.Size = new System.Drawing.Size(800, 27);
            this.searchNameToolStrip.TabIndex = 4;
            this.searchNameToolStrip.Text = "searchNameToolStrip";
            // 
            // client_NameToolStripLabel
            // 
            this.client_NameToolStripLabel.Name = "client_NameToolStripLabel";
            this.client_NameToolStripLabel.Size = new System.Drawing.Size(96, 24);
            this.client_NameToolStripLabel.Text = "Client_Name:";
            // 
            // client_NameToolStripTextBox
            // 
            this.client_NameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.client_NameToolStripTextBox.Name = "client_NameToolStripTextBox";
            this.client_NameToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // searchNameToolStripButton
            // 
            this.searchNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchNameToolStripButton.Name = "searchNameToolStripButton";
            this.searchNameToolStripButton.Size = new System.Drawing.Size(97, 24);
            this.searchNameToolStripButton.Text = "SearchName";
            this.searchNameToolStripButton.Click += new System.EventHandler(this.searchNameToolStripButton_Click);
            // 
            // gymDataSetBindingSource
            // 
            this.gymDataSetBindingSource.DataSource = this.gymDataSet;
            this.gymDataSetBindingSource.Position = 0;
            // 
            // searchGenderToolStrip
            // 
            this.searchGenderToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.searchGenderToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genderToolStripLabel,
            this.genderToolStripTextBox,
            this.searchGenderToolStripButton});
            this.searchGenderToolStrip.Location = new System.Drawing.Point(0, 27);
            this.searchGenderToolStrip.Name = "searchGenderToolStrip";
            this.searchGenderToolStrip.Size = new System.Drawing.Size(800, 27);
            this.searchGenderToolStrip.TabIndex = 5;
            this.searchGenderToolStrip.Text = "searchGenderToolStrip";
            // 
            // genderToolStripLabel
            // 
            this.genderToolStripLabel.Name = "genderToolStripLabel";
            this.genderToolStripLabel.Size = new System.Drawing.Size(60, 24);
            this.genderToolStripLabel.Text = "Gender:";
            // 
            // genderToolStripTextBox
            // 
            this.genderToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.genderToolStripTextBox.Name = "genderToolStripTextBox";
            this.genderToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // searchGenderToolStripButton
            // 
            this.searchGenderToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchGenderToolStripButton.Name = "searchGenderToolStripButton";
            this.searchGenderToolStripButton.Size = new System.Drawing.Size(105, 24);
            this.searchGenderToolStripButton.Text = "SearchGender";
            this.searchGenderToolStripButton.Click += new System.EventHandler(this.searchGenderToolStripButton_Click);
            // 
            // ClientProfileQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchGenderToolStrip);
            this.Controls.Add(this.searchNameToolStrip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClientProfileQuery";
            this.Text = "ClientProfileQuery";
            this.Load += new System.EventHandler(this.ClientProfileQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            this.searchNameToolStrip.ResumeLayout(false);
            this.searchNameToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSetBindingSource)).EndInit();
            this.searchGenderToolStrip.ResumeLayout(false);
            this.searchGenderToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource gymDataSetBindingSource;
        private GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource clientProfileBindingSource;
        private GymDataSetTableAdapters.Client_ProfileTableAdapter client_ProfileTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payementDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip searchNameToolStrip;
        private System.Windows.Forms.ToolStripLabel client_NameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox client_NameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchNameToolStripButton;
        private System.Windows.Forms.ToolStrip searchGenderToolStrip;
        private System.Windows.Forms.ToolStripLabel genderToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox genderToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchGenderToolStripButton;
    }
}