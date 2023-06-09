namespace PMPA
{
    partial class Form2
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
            System.Windows.Forms.Label chartNoLabel;
            System.Windows.Forms.Label patientNameLabel;
            System.Windows.Forms.Label iDNumLabel;
            System.Windows.Forms.Label birthdayTypeLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label cellphoneLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label detailAddressLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label accNoLabel;
            System.Windows.Forms.Label chartNoLabel1;
            System.Windows.Forms.Label accDateLabel;
            System.Windows.Forms.Label deptCodeLabel;
            System.Windows.Forms.Label docNoLabel;
            System.Windows.Forms.Label examTypeLabel;
            System.Windows.Forms.Label insuCodeLabel;
            System.Windows.Forms.Label insuSeqLabel;
            System.Windows.Forms.Label reservationYnLabel;
            System.Windows.Forms.Label inOutLabel;
            this.chartNoTextBox = new System.Windows.Forms.TextBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PMPA.DataSet1();
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.iDNumTextBox = new System.Windows.Forms.TextBox();
            this.birthdayTypeTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.cellphoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.detailAddressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radS = new System.Windows.Forms.RadioButton();
            this.radL = new System.Windows.Forms.RadioButton();
            this.radF = new System.Windows.Forms.RadioButton();
            this.radM = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.patientTableAdapter = new PMPA.DataSet1TableAdapters.PatientTableAdapter();
            this.tableAdapterManager = new PMPA.DataSet1TableAdapters.TableAdapterManager();
            this.patientAcceptanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientAcceptanceTableAdapter = new PMPA.DataSet1TableAdapters.PatientAcceptanceTableAdapter();
            this.accNoTextBox = new System.Windows.Forms.TextBox();
            this.chartNoTextBox1 = new System.Windows.Forms.TextBox();
            this.accDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deptCodeTextBox = new System.Windows.Forms.TextBox();
            this.docNoTextBox = new System.Windows.Forms.TextBox();
            this.examTypeTextBox = new System.Windows.Forms.TextBox();
            this.insuCodeTextBox = new System.Windows.Forms.TextBox();
            this.insuSeqTextBox = new System.Windows.Forms.TextBox();
            this.reservationYnTextBox = new System.Windows.Forms.TextBox();
            this.inOutTextBox = new System.Windows.Forms.TextBox();
            chartNoLabel = new System.Windows.Forms.Label();
            patientNameLabel = new System.Windows.Forms.Label();
            iDNumLabel = new System.Windows.Forms.Label();
            birthdayTypeLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            cellphoneLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            detailAddressLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            accNoLabel = new System.Windows.Forms.Label();
            chartNoLabel1 = new System.Windows.Forms.Label();
            accDateLabel = new System.Windows.Forms.Label();
            deptCodeLabel = new System.Windows.Forms.Label();
            docNoLabel = new System.Windows.Forms.Label();
            examTypeLabel = new System.Windows.Forms.Label();
            insuCodeLabel = new System.Windows.Forms.Label();
            insuSeqLabel = new System.Windows.Forms.Label();
            reservationYnLabel = new System.Windows.Forms.Label();
            inOutLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientAcceptanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartNoLabel
            // 
            chartNoLabel.AutoSize = true;
            chartNoLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartNoLabel.Font = new System.Drawing.Font("굴림", 12F);
            chartNoLabel.ForeColor = System.Drawing.SystemColors.Control;
            chartNoLabel.Location = new System.Drawing.Point(32, 114);
            chartNoLabel.Name = "chartNoLabel";
            chartNoLabel.Size = new System.Drawing.Size(76, 16);
            chartNoLabel.TabIndex = 2;
            chartNoLabel.Text = "환자번호:";
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            patientNameLabel.Font = new System.Drawing.Font("굴림", 12F);
            patientNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            patientNameLabel.Location = new System.Drawing.Point(47, 199);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new System.Drawing.Size(60, 16);
            patientNameLabel.TabIndex = 4;
            patientNameLabel.Text = "환자명:";
            // 
            // iDNumLabel
            // 
            iDNumLabel.AutoSize = true;
            iDNumLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            iDNumLabel.Font = new System.Drawing.Font("굴림", 12F);
            iDNumLabel.ForeColor = System.Drawing.SystemColors.Control;
            iDNumLabel.Location = new System.Drawing.Point(374, 203);
            iDNumLabel.Name = "iDNumLabel";
            iDNumLabel.Size = new System.Drawing.Size(108, 16);
            iDNumLabel.TabIndex = 6;
            iDNumLabel.Text = "주민등록번호:";
            // 
            // birthdayTypeLabel
            // 
            birthdayTypeLabel.AutoSize = true;
            birthdayTypeLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            birthdayTypeLabel.Font = new System.Drawing.Font("굴림", 12F);
            birthdayTypeLabel.ForeColor = System.Drawing.SystemColors.Control;
            birthdayTypeLabel.Location = new System.Drawing.Point(32, 251);
            birthdayTypeLabel.Name = "birthdayTypeLabel";
            birthdayTypeLabel.Size = new System.Drawing.Size(76, 16);
            birthdayTypeLabel.TabIndex = 8;
            birthdayTypeLabel.Text = "생일구분:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            birthdayLabel.Font = new System.Drawing.Font("굴림", 12F);
            birthdayLabel.ForeColor = System.Drawing.SystemColors.Control;
            birthdayLabel.Location = new System.Drawing.Point(406, 254);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(76, 16);
            birthdayLabel.TabIndex = 10;
            birthdayLabel.Text = "생년월일:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            genderLabel.Font = new System.Drawing.Font("굴림", 12F);
            genderLabel.ForeColor = System.Drawing.SystemColors.Control;
            genderLabel.Location = new System.Drawing.Point(63, 295);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(44, 16);
            genderLabel.TabIndex = 12;
            genderLabel.Text = "성별:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            telephoneLabel.Font = new System.Drawing.Font("굴림", 12F);
            telephoneLabel.ForeColor = System.Drawing.SystemColors.Control;
            telephoneLabel.Location = new System.Drawing.Point(31, 335);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(76, 16);
            telephoneLabel.TabIndex = 14;
            telephoneLabel.Text = "전화번호:";
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            cellphoneLabel.Font = new System.Drawing.Font("굴림", 12F);
            cellphoneLabel.ForeColor = System.Drawing.SystemColors.Control;
            cellphoneLabel.Location = new System.Drawing.Point(389, 299);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new System.Drawing.Size(92, 16);
            cellphoneLabel.TabIndex = 16;
            cellphoneLabel.Text = "핸드폰번호:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            addressLabel.Font = new System.Drawing.Font("굴림", 12F);
            addressLabel.ForeColor = System.Drawing.SystemColors.Control;
            addressLabel.Location = new System.Drawing.Point(63, 385);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(44, 16);
            addressLabel.TabIndex = 22;
            addressLabel.Text = "주소:";
            // 
            // detailAddressLabel
            // 
            detailAddressLabel.AutoSize = true;
            detailAddressLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            detailAddressLabel.Font = new System.Drawing.Font("굴림", 12F);
            detailAddressLabel.ForeColor = System.Drawing.SystemColors.Control;
            detailAddressLabel.Location = new System.Drawing.Point(402, 355);
            detailAddressLabel.Name = "detailAddressLabel";
            detailAddressLabel.Size = new System.Drawing.Size(76, 16);
            detailAddressLabel.TabIndex = 24;
            detailAddressLabel.Text = "상세주소:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            emailLabel.Font = new System.Drawing.Font("굴림", 12F);
            emailLabel.ForeColor = System.Drawing.SystemColors.Control;
            emailLabel.Location = new System.Drawing.Point(48, 439);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(60, 16);
            emailLabel.TabIndex = 26;
            emailLabel.Text = "이메일:";
            // 
            // accNoLabel
            // 
            accNoLabel.AutoSize = true;
            accNoLabel.Location = new System.Drawing.Point(992, 206);
            accNoLabel.Name = "accNoLabel";
            accNoLabel.Size = new System.Drawing.Size(53, 12);
            accNoLabel.TabIndex = 49;
            accNoLabel.Text = "접수번호";
            // 
            // chartNoLabel1
            // 
            chartNoLabel1.AutoSize = true;
            chartNoLabel1.Location = new System.Drawing.Point(992, 233);
            chartNoLabel1.Name = "chartNoLabel1";
            chartNoLabel1.Size = new System.Drawing.Size(53, 12);
            chartNoLabel1.TabIndex = 51;
            chartNoLabel1.Text = "환자번호";
            // 
            // accDateLabel
            // 
            accDateLabel.AutoSize = true;
            accDateLabel.Location = new System.Drawing.Point(992, 261);
            accDateLabel.Name = "accDateLabel";
            accDateLabel.Size = new System.Drawing.Size(53, 12);
            accDateLabel.TabIndex = 53;
            accDateLabel.Text = "접수일자";
            // 
            // deptCodeLabel
            // 
            deptCodeLabel.AutoSize = true;
            deptCodeLabel.Location = new System.Drawing.Point(992, 287);
            deptCodeLabel.Name = "deptCodeLabel";
            deptCodeLabel.Size = new System.Drawing.Size(65, 12);
            deptCodeLabel.TabIndex = 55;
            deptCodeLabel.Text = "진료과코드";
            // 
            // docNoLabel
            // 
            docNoLabel.AutoSize = true;
            docNoLabel.Location = new System.Drawing.Point(992, 314);
            docNoLabel.Name = "docNoLabel";
            docNoLabel.Size = new System.Drawing.Size(69, 12);
            docNoLabel.TabIndex = 57;
            docNoLabel.Text = "진료의 코드";
            // 
            // examTypeLabel
            // 
            examTypeLabel.AutoSize = true;
            examTypeLabel.Location = new System.Drawing.Point(992, 341);
            examTypeLabel.Name = "examTypeLabel";
            examTypeLabel.Size = new System.Drawing.Size(65, 12);
            examTypeLabel.TabIndex = 59;
            examTypeLabel.Text = "초재진구분";
            // 
            // insuCodeLabel
            // 
            insuCodeLabel.AutoSize = true;
            insuCodeLabel.Location = new System.Drawing.Point(992, 368);
            insuCodeLabel.Name = "insuCodeLabel";
            insuCodeLabel.Size = new System.Drawing.Size(53, 12);
            insuCodeLabel.TabIndex = 61;
            insuCodeLabel.Text = "보험코드";
            // 
            // insuSeqLabel
            // 
            insuSeqLabel.AutoSize = true;
            insuSeqLabel.Location = new System.Drawing.Point(992, 395);
            insuSeqLabel.Name = "insuSeqLabel";
            insuSeqLabel.Size = new System.Drawing.Size(77, 12);
            insuSeqLabel.TabIndex = 63;
            insuSeqLabel.Text = "보험일련번호";
            // 
            // reservationYnLabel
            // 
            reservationYnLabel.AutoSize = true;
            reservationYnLabel.Location = new System.Drawing.Point(992, 424);
            reservationYnLabel.Name = "reservationYnLabel";
            reservationYnLabel.Size = new System.Drawing.Size(53, 12);
            reservationYnLabel.TabIndex = 65;
            reservationYnLabel.Text = "예약방법";
            // 
            // inOutLabel
            // 
            inOutLabel.AutoSize = true;
            inOutLabel.Location = new System.Drawing.Point(992, 455);
            inOutLabel.Name = "inOutLabel";
            inOutLabel.Size = new System.Drawing.Size(87, 12);
            inOutLabel.TabIndex = 69;
            inOutLabel.Text = "입원/외래 구분";
            // 
            // chartNoTextBox
            // 
            this.chartNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "ChartNo", true));
            this.chartNoTextBox.Location = new System.Drawing.Point(130, 114);
            this.chartNoTextBox.Name = "chartNoTextBox";
            this.chartNoTextBox.Size = new System.Drawing.Size(200, 21);
            this.chartNoTextBox.TabIndex = 3;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "PatientName", true));
            this.patientNameTextBox.Location = new System.Drawing.Point(130, 197);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(200, 21);
            this.patientNameTextBox.TabIndex = 5;
            // 
            // iDNumTextBox
            // 
            this.iDNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "IDNum", true));
            this.iDNumTextBox.Location = new System.Drawing.Point(492, 201);
            this.iDNumTextBox.Name = "iDNumTextBox";
            this.iDNumTextBox.Size = new System.Drawing.Size(200, 21);
            this.iDNumTextBox.TabIndex = 7;
            // 
            // birthdayTypeTextBox
            // 
            this.birthdayTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "BirthdayType", true));
            this.birthdayTypeTextBox.Location = new System.Drawing.Point(130, 251);
            this.birthdayTypeTextBox.Name = "birthdayTypeTextBox";
            this.birthdayTypeTextBox.Size = new System.Drawing.Size(200, 21);
            this.birthdayTypeTextBox.TabIndex = 9;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource, "Birthday", true));
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(492, 252);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.birthdayDateTimePicker.TabIndex = 11;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(130, 293);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(200, 21);
            this.genderTextBox.TabIndex = 13;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(130, 330);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(200, 21);
            this.telephoneTextBox.TabIndex = 15;
            // 
            // cellphoneTextBox
            // 
            this.cellphoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Cellphone", true));
            this.cellphoneTextBox.Location = new System.Drawing.Point(492, 300);
            this.cellphoneTextBox.Name = "cellphoneTextBox";
            this.cellphoneTextBox.Size = new System.Drawing.Size(200, 21);
            this.cellphoneTextBox.TabIndex = 17;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(130, 385);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 21);
            this.addressTextBox.TabIndex = 23;
            // 
            // detailAddressTextBox
            // 
            this.detailAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "DetailAddress", true));
            this.detailAddressTextBox.Location = new System.Drawing.Point(492, 354);
            this.detailAddressTextBox.Name = "detailAddressTextBox";
            this.detailAddressTextBox.Size = new System.Drawing.Size(200, 21);
            this.detailAddressTextBox.TabIndex = 25;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(130, 439);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 21);
            this.emailTextBox.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(377, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1365, 44);
            this.panel1.TabIndex = 43;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(945, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 44);
            this.button4.TabIndex = 4;
            this.button4.Text = "신규등록";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1050, 0);
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
            this.button2.Location = new System.Drawing.Point(1155, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(1260, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 44);
            this.button5.TabIndex = 1;
            this.button5.Text = "종료";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "접수관리";
            // 
            // radS
            // 
            this.radS.AutoSize = true;
            this.radS.Location = new System.Drawing.Point(16, 20);
            this.radS.Name = "radS";
            this.radS.Size = new System.Drawing.Size(47, 16);
            this.radS.TabIndex = 44;
            this.radS.Text = "양력";
            this.radS.UseVisualStyleBackColor = true;
            // 
            // radL
            // 
            this.radL.AutoSize = true;
            this.radL.Location = new System.Drawing.Point(123, 19);
            this.radL.Name = "radL";
            this.radL.Size = new System.Drawing.Size(47, 16);
            this.radL.TabIndex = 45;
            this.radL.Text = "음력";
            this.radL.UseVisualStyleBackColor = true;
            // 
            // radF
            // 
            this.radF.AutoSize = true;
            this.radF.Location = new System.Drawing.Point(113, 27);
            this.radF.Name = "radF";
            this.radF.Size = new System.Drawing.Size(47, 16);
            this.radF.TabIndex = 47;
            this.radF.TabStop = true;
            this.radF.Text = "여자";
            this.radF.UseVisualStyleBackColor = true;
            // 
            // radM
            // 
            this.radM.AutoSize = true;
            this.radM.Location = new System.Drawing.Point(6, 28);
            this.radM.Name = "radM";
            this.radM.Size = new System.Drawing.Size(47, 16);
            this.radM.TabIndex = 46;
            this.radM.TabStop = true;
            this.radM.Text = "남자";
            this.radM.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radS);
            this.groupBox1.Controls.Add(this.radL);
            this.groupBox1.Location = new System.Drawing.Point(756, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radM);
            this.groupBox2.Controls.Add(this.radF);
            this.groupBox2.Location = new System.Drawing.Point(756, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CodeDeptTableAdapter = null;
            this.tableAdapterManager.CodeDoctorSignTableAdapter = null;
            this.tableAdapterManager.CodeDoctorTableAdapter = null;
            this.tableAdapterManager.CodeInsuranceSubTableAdapter = null;
            this.tableAdapterManager.CodeInsuranceTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.PatientAcceptanceTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = this.patientTableAdapter;
            this.tableAdapterManager.UpdateOrder = PMPA.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // patientAcceptanceBindingSource
            // 
            this.patientAcceptanceBindingSource.DataMember = "PatientAcceptance";
            this.patientAcceptanceBindingSource.DataSource = this.dataSet1;
            // 
            // patientAcceptanceTableAdapter
            // 
            this.patientAcceptanceTableAdapter.ClearBeforeFill = true;
            // 
            // accNoTextBox
            // 
            this.accNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientAcceptanceBindingSource, "AccNo", true));
            this.accNoTextBox.Location = new System.Drawing.Point(1092, 203);
            this.accNoTextBox.Name = "accNoTextBox";
            this.accNoTextBox.Size = new System.Drawing.Size(200, 21);
            this.accNoTextBox.TabIndex = 50;
            // 
            // chartNoTextBox1
            // 
            this.chartNoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientAcceptanceBindingSource, "ChartNo", true));
            this.chartNoTextBox1.Location = new System.Drawing.Point(1092, 230);
            this.chartNoTextBox1.Name = "chartNoTextBox1";
            this.chartNoTextBox1.Size = new System.Drawing.Size(200, 21);
            this.chartNoTextBox1.TabIndex = 52;
            // 
            // accDateDateTimePicker
            // 
            this.accDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientAcceptanceBindingSource, "AccDate", true));
            this.accDateDateTimePicker.Location = new System.Drawing.Point(1092, 257);
            this.accDateDateTimePicker.Name = "accDateDateTimePicker";
            this.accDateDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.accDateDateTimePicker.TabIndex = 54;
            // 
            // deptCodeTextBox
            // 
            this.deptCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientAcceptanceBindingSource, "DeptCode", true));
            this.deptCodeTextBox.Location = new System.Drawing.Point(1092, 284);
            this.deptCodeTextBox.Name = "deptCodeTextBox";
            this.deptCodeTextBox.Size = new System.Drawing.Size(200, 21);
            this.deptCodeTextBox.TabIndex = 56;
            // 
            // docNoTextBox
            // 
            this.docNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientAcceptanceBindingSource, "DocNo", true));
            this.docNoTextBox.Location = new System.Drawing.Point(1092, 311);
            this.docNoTextBox.Name = "docNoTextBox";
            this.docNoTextBox.Size = new System.Drawing.Size(200, 21);
            this.docNoTextBox.TabIndex = 58;
            // 
            // examTypeTextBox
            // 
            this.examTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientAcceptanceBindingSource, "ExamType", true));
            this.examTypeTextBox.Location = new System.Drawing.Point(1092, 338);
            this.examTypeTextBox.Name = "examTypeTextBox";
            this.examTypeTextBox.Size = new System.Drawing.Size(200, 21);
            this.examTypeTextBox.TabIndex = 60;
            // 
            // insuCodeTextBox
            // 
            this.insuCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientAcceptanceBindingSource, "InsuCode", true));
            this.insuCodeTextBox.Location = new System.Drawing.Point(1092, 365);
            this.insuCodeTextBox.Name = "insuCodeTextBox";
            this.insuCodeTextBox.Size = new System.Drawing.Size(200, 21);
            this.insuCodeTextBox.TabIndex = 62;
            // 
            // insuSeqTextBox
            // 
            this.insuSeqTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientAcceptanceBindingSource, "InsuSeq", true));
            this.insuSeqTextBox.Location = new System.Drawing.Point(1092, 392);
            this.insuSeqTextBox.Name = "insuSeqTextBox";
            this.insuSeqTextBox.Size = new System.Drawing.Size(200, 21);
            this.insuSeqTextBox.TabIndex = 64;
            // 
            // reservationYnTextBox
            // 
            this.reservationYnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientAcceptanceBindingSource, "ReservationYn", true));
            this.reservationYnTextBox.Location = new System.Drawing.Point(1092, 419);
            this.reservationYnTextBox.Name = "reservationYnTextBox";
            this.reservationYnTextBox.Size = new System.Drawing.Size(200, 21);
            this.reservationYnTextBox.TabIndex = 66;
            // 
            // inOutTextBox
            // 
            this.inOutTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientAcceptanceBindingSource, "InOut", true));
            this.inOutTextBox.Location = new System.Drawing.Point(1092, 452);
            this.inOutTextBox.Name = "inOutTextBox";
            this.inOutTextBox.Size = new System.Drawing.Size(200, 21);
            this.inOutTextBox.TabIndex = 70;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 700);
            this.Controls.Add(accNoLabel);
            this.Controls.Add(this.accNoTextBox);
            this.Controls.Add(chartNoLabel1);
            this.Controls.Add(this.chartNoTextBox1);
            this.Controls.Add(accDateLabel);
            this.Controls.Add(this.accDateDateTimePicker);
            this.Controls.Add(deptCodeLabel);
            this.Controls.Add(this.deptCodeTextBox);
            this.Controls.Add(docNoLabel);
            this.Controls.Add(this.docNoTextBox);
            this.Controls.Add(examTypeLabel);
            this.Controls.Add(this.examTypeTextBox);
            this.Controls.Add(insuCodeLabel);
            this.Controls.Add(this.insuCodeTextBox);
            this.Controls.Add(insuSeqLabel);
            this.Controls.Add(this.insuSeqTextBox);
            this.Controls.Add(reservationYnLabel);
            this.Controls.Add(this.reservationYnTextBox);
            this.Controls.Add(inOutLabel);
            this.Controls.Add(this.inOutTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(chartNoLabel);
            this.Controls.Add(this.chartNoTextBox);
            this.Controls.Add(patientNameLabel);
            this.Controls.Add(this.patientNameTextBox);
            this.Controls.Add(iDNumLabel);
            this.Controls.Add(this.iDNumTextBox);
            this.Controls.Add(birthdayTypeLabel);
            this.Controls.Add(this.birthdayTypeTextBox);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(cellphoneLabel);
            this.Controls.Add(this.cellphoneTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(detailAddressLabel);
            this.Controls.Add(this.detailAddressTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientAcceptanceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private DataSet1TableAdapters.PatientTableAdapter patientTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox chartNoTextBox;
        private System.Windows.Forms.TextBox patientNameTextBox;
        private System.Windows.Forms.TextBox iDNumTextBox;
        private System.Windows.Forms.TextBox birthdayTypeTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox cellphoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox detailAddressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radS;
        private System.Windows.Forms.RadioButton radL;
        private System.Windows.Forms.RadioButton radF;
        private System.Windows.Forms.RadioButton radM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource patientAcceptanceBindingSource;
        private DataSet1TableAdapters.PatientAcceptanceTableAdapter patientAcceptanceTableAdapter;
        private System.Windows.Forms.TextBox accNoTextBox;
        private System.Windows.Forms.TextBox chartNoTextBox1;
        private System.Windows.Forms.DateTimePicker accDateDateTimePicker;
        private System.Windows.Forms.TextBox deptCodeTextBox;
        private System.Windows.Forms.TextBox docNoTextBox;
        private System.Windows.Forms.TextBox examTypeTextBox;
        private System.Windows.Forms.TextBox insuCodeTextBox;
        private System.Windows.Forms.TextBox insuSeqTextBox;
        private System.Windows.Forms.TextBox reservationYnTextBox;
        private System.Windows.Forms.TextBox inOutTextBox;
    }
}