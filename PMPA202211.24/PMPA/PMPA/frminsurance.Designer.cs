namespace PMPA
{
    partial class frminsurance
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
            System.Windows.Forms.Label insuCodeLabel;
            System.Windows.Forms.Label insuNameLabel;
            System.Windows.Forms.Label myRateLabel;
            System.Windows.Forms.Label insuCodeLabel1;
            System.Windows.Forms.Label subCodeLabel;
            System.Windows.Forms.Label myRateLabel1;
            this.dataSet1 = new PMPA.DataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.codeInsuranceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeInsuranceTableAdapter = new PMPA.DataSet1TableAdapters.CodeInsuranceTableAdapter();
            this.tableAdapterManager = new PMPA.DataSet1TableAdapters.TableAdapterManager();
            this.codeInsuranceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeInsuranceSubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeInsuranceSubTableAdapter = new PMPA.DataSet1TableAdapters.CodeInsuranceSubTableAdapter();
            this.codeInsuranceSubDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insuCodeTextBox = new System.Windows.Forms.TextBox();
            this.insuNameTextBox = new System.Windows.Forms.TextBox();
            this.myRateTextBox = new System.Windows.Forms.TextBox();
            this.insuCodeTextBox1 = new System.Windows.Forms.TextBox();
            this.subCodeTextBox = new System.Windows.Forms.TextBox();
            this.myRateTextBox1 = new System.Windows.Forms.TextBox();
            insuCodeLabel = new System.Windows.Forms.Label();
            insuNameLabel = new System.Windows.Forms.Label();
            myRateLabel = new System.Windows.Forms.Label();
            insuCodeLabel1 = new System.Windows.Forms.Label();
            subCodeLabel = new System.Windows.Forms.Label();
            myRateLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeInsuranceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeInsuranceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeInsuranceSubBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeInsuranceSubDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 44);
            this.panel1.TabIndex = 8;
            // 
            // button15
            // 
            this.button15.Dock = System.Windows.Forms.DockStyle.Right;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(707, 0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(105, 44);
            this.button15.TabIndex = 4;
            this.button15.Text = "신규등록";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(812, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "저장";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(917, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1022, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "종료";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "보험유형관리";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(348, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 44);
            this.panel2.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(339, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 44);
            this.button4.TabIndex = 4;
            this.button4.Text = "신규등록";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(444, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 44);
            this.button5.TabIndex = 3;
            this.button5.Text = "저장";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(549, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 44);
            this.button6.TabIndex = 2;
            this.button6.Text = "삭제";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Right;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(654, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(105, 44);
            this.button7.TabIndex = 1;
            this.button7.Text = "종료";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "기타보험이용";
            // 
            // codeInsuranceBindingSource
            // 
            this.codeInsuranceBindingSource.DataMember = "CodeInsurance";
            this.codeInsuranceBindingSource.DataSource = this.dataSet1;
            // 
            // codeInsuranceTableAdapter
            // 
            this.codeInsuranceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CodeDeptTableAdapter = null;
            this.tableAdapterManager.CodeDoctorSignTableAdapter = null;
            this.tableAdapterManager.CodeDoctorTableAdapter = null;
            this.tableAdapterManager.CodeInsuranceSubTableAdapter = this.codeInsuranceSubTableAdapter;
            this.tableAdapterManager.CodeInsuranceTableAdapter = this.codeInsuranceTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PMPA.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // codeInsuranceDataGridView
            // 
            this.codeInsuranceDataGridView.AutoGenerateColumns = false;
            this.codeInsuranceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codeInsuranceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.codeInsuranceDataGridView.DataSource = this.codeInsuranceBindingSource;
            this.codeInsuranceDataGridView.Location = new System.Drawing.Point(0, 44);
            this.codeInsuranceDataGridView.Name = "codeInsuranceDataGridView";
            this.codeInsuranceDataGridView.RowTemplate.Height = 23;
            this.codeInsuranceDataGridView.Size = new System.Drawing.Size(342, 543);
            this.codeInsuranceDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InsuCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "InsuCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "InsuName";
            this.dataGridViewTextBoxColumn2.HeaderText = "InsuName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MyRate";
            this.dataGridViewTextBoxColumn3.HeaderText = "MyRate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // codeInsuranceSubBindingSource
            // 
            this.codeInsuranceSubBindingSource.DataMember = "FK_CodeInsuranceSub_CodeInsurance";
            this.codeInsuranceSubBindingSource.DataSource = this.codeInsuranceBindingSource;
            // 
            // codeInsuranceSubTableAdapter
            // 
            this.codeInsuranceSubTableAdapter.ClearBeforeFill = true;
            // 
            // codeInsuranceSubDataGridView
            // 
            this.codeInsuranceSubDataGridView.AutoGenerateColumns = false;
            this.codeInsuranceSubDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codeInsuranceSubDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.codeInsuranceSubDataGridView.DataSource = this.codeInsuranceSubBindingSource;
            this.codeInsuranceSubDataGridView.Location = new System.Drawing.Point(346, 313);
            this.codeInsuranceSubDataGridView.Name = "codeInsuranceSubDataGridView";
            this.codeInsuranceSubDataGridView.RowTemplate.Height = 23;
            this.codeInsuranceSubDataGridView.Size = new System.Drawing.Size(300, 220);
            this.codeInsuranceSubDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "InsuCode";
            this.dataGridViewTextBoxColumn4.HeaderText = "InsuCode";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SubCode";
            this.dataGridViewTextBoxColumn5.HeaderText = "SubCode";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MyRate";
            this.dataGridViewTextBoxColumn6.HeaderText = "MyRate";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // insuCodeLabel
            // 
            insuCodeLabel.AutoSize = true;
            insuCodeLabel.Location = new System.Drawing.Point(361, 71);
            insuCodeLabel.Name = "insuCodeLabel";
            insuCodeLabel.Size = new System.Drawing.Size(67, 12);
            insuCodeLabel.TabIndex = 23;
            insuCodeLabel.Text = "Insu Code:";
            // 
            // insuCodeTextBox
            // 
            this.insuCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.codeInsuranceBindingSource, "InsuCode", true));
            this.insuCodeTextBox.Location = new System.Drawing.Point(438, 68);
            this.insuCodeTextBox.Name = "insuCodeTextBox";
            this.insuCodeTextBox.Size = new System.Drawing.Size(100, 21);
            this.insuCodeTextBox.TabIndex = 24;
            // 
            // insuNameLabel
            // 
            insuNameLabel.AutoSize = true;
            insuNameLabel.Location = new System.Drawing.Point(361, 98);
            insuNameLabel.Name = "insuNameLabel";
            insuNameLabel.Size = new System.Drawing.Size(71, 12);
            insuNameLabel.TabIndex = 25;
            insuNameLabel.Text = "Insu Name:";
            // 
            // insuNameTextBox
            // 
            this.insuNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.codeInsuranceBindingSource, "InsuName", true));
            this.insuNameTextBox.Location = new System.Drawing.Point(438, 95);
            this.insuNameTextBox.Name = "insuNameTextBox";
            this.insuNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.insuNameTextBox.TabIndex = 26;
            // 
            // myRateLabel
            // 
            myRateLabel.AutoSize = true;
            myRateLabel.Location = new System.Drawing.Point(361, 125);
            myRateLabel.Name = "myRateLabel";
            myRateLabel.Size = new System.Drawing.Size(56, 12);
            myRateLabel.TabIndex = 27;
            myRateLabel.Text = "My Rate:";
            // 
            // myRateTextBox
            // 
            this.myRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.codeInsuranceBindingSource, "MyRate", true));
            this.myRateTextBox.Location = new System.Drawing.Point(438, 122);
            this.myRateTextBox.Name = "myRateTextBox";
            this.myRateTextBox.Size = new System.Drawing.Size(100, 21);
            this.myRateTextBox.TabIndex = 28;
            // 
            // insuCodeLabel1
            // 
            insuCodeLabel1.AutoSize = true;
            insuCodeLabel1.Location = new System.Drawing.Point(669, 378);
            insuCodeLabel1.Name = "insuCodeLabel1";
            insuCodeLabel1.Size = new System.Drawing.Size(67, 12);
            insuCodeLabel1.TabIndex = 28;
            insuCodeLabel1.Text = "Insu Code:";
            // 
            // insuCodeTextBox1
            // 
            this.insuCodeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.codeInsuranceSubBindingSource, "InsuCode", true));
            this.insuCodeTextBox1.Location = new System.Drawing.Point(742, 375);
            this.insuCodeTextBox1.Name = "insuCodeTextBox1";
            this.insuCodeTextBox1.Size = new System.Drawing.Size(100, 21);
            this.insuCodeTextBox1.TabIndex = 29;
            // 
            // subCodeLabel
            // 
            subCodeLabel.AutoSize = true;
            subCodeLabel.Location = new System.Drawing.Point(669, 405);
            subCodeLabel.Name = "subCodeLabel";
            subCodeLabel.Size = new System.Drawing.Size(65, 12);
            subCodeLabel.TabIndex = 30;
            subCodeLabel.Text = "Sub Code:";
            // 
            // subCodeTextBox
            // 
            this.subCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.codeInsuranceSubBindingSource, "SubCode", true));
            this.subCodeTextBox.Location = new System.Drawing.Point(742, 402);
            this.subCodeTextBox.Name = "subCodeTextBox";
            this.subCodeTextBox.Size = new System.Drawing.Size(100, 21);
            this.subCodeTextBox.TabIndex = 31;
            // 
            // myRateLabel1
            // 
            myRateLabel1.AutoSize = true;
            myRateLabel1.Location = new System.Drawing.Point(669, 432);
            myRateLabel1.Name = "myRateLabel1";
            myRateLabel1.Size = new System.Drawing.Size(56, 12);
            myRateLabel1.TabIndex = 32;
            myRateLabel1.Text = "My Rate:";
            // 
            // myRateTextBox1
            // 
            this.myRateTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.codeInsuranceSubBindingSource, "MyRate", true));
            this.myRateTextBox1.Location = new System.Drawing.Point(742, 429);
            this.myRateTextBox1.Name = "myRateTextBox1";
            this.myRateTextBox1.Size = new System.Drawing.Size(100, 21);
            this.myRateTextBox1.TabIndex = 33;
            // 
            // frminsurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 607);
            this.Controls.Add(insuCodeLabel1);
            this.Controls.Add(this.insuCodeTextBox1);
            this.Controls.Add(subCodeLabel);
            this.Controls.Add(this.subCodeTextBox);
            this.Controls.Add(myRateLabel1);
            this.Controls.Add(this.myRateTextBox1);
            this.Controls.Add(insuCodeLabel);
            this.Controls.Add(this.insuCodeTextBox);
            this.Controls.Add(insuNameLabel);
            this.Controls.Add(this.insuNameTextBox);
            this.Controls.Add(myRateLabel);
            this.Controls.Add(this.myRateTextBox);
            this.Controls.Add(this.codeInsuranceSubDataGridView);
            this.Controls.Add(this.codeInsuranceDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frminsurance";
            this.Text = "frminsurance";
            this.Load += new System.EventHandler(this.frminsurance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeInsuranceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeInsuranceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeInsuranceSubBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeInsuranceSubDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource codeInsuranceBindingSource;
        private DataSet1TableAdapters.CodeInsuranceTableAdapter codeInsuranceTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DataSet1TableAdapters.CodeInsuranceSubTableAdapter codeInsuranceSubTableAdapter;
        private System.Windows.Forms.DataGridView codeInsuranceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource codeInsuranceSubBindingSource;
        private System.Windows.Forms.DataGridView codeInsuranceSubDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox insuCodeTextBox;
        private System.Windows.Forms.TextBox insuNameTextBox;
        private System.Windows.Forms.TextBox myRateTextBox;
        private System.Windows.Forms.TextBox insuCodeTextBox1;
        private System.Windows.Forms.TextBox subCodeTextBox;
        private System.Windows.Forms.TextBox myRateTextBox1;
    }
}