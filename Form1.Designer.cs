namespace Zolotarev_2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.languagePictureBox = new System.Windows.Forms.PictureBox();
            this.termInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.springRadioButton = new System.Windows.Forms.RadioButton();
            this.termLabel = new System.Windows.Forms.Label();
            this.fallRadioButton = new System.Windows.Forms.RadioButton();
            this.studentInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.outStateRadioButton = new System.Windows.Forms.RadioButton();
            this.inStateRadioButton = new System.Windows.Forms.RadioButton();
            this.residenceStatusLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.courseOrderInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.frenchPrice = new System.Windows.Forms.Label();
            this.germanPrice = new System.Windows.Forms.Label();
            this.russianPrice = new System.Windows.Forms.Label();
            this.italianPrice = new System.Windows.Forms.Label();
            this.spanishPrice = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalCoursesOutput = new System.Windows.Forms.Label();
            this.numberofCoursesLabel = new System.Windows.Forms.Label();
            this.spanishCheckBox = new System.Windows.Forms.CheckBox();
            this.russianCheckBox = new System.Windows.Forms.CheckBox();
            this.italianCheckBox = new System.Windows.Forms.CheckBox();
            this.germanCheckBox = new System.Windows.Forms.CheckBox();
            this.availableCoursesLabel = new System.Windows.Forms.Label();
            this.frenchCheckBox = new System.Windows.Forms.CheckBox();
            this.paymentGroupBox = new System.Windows.Forms.GroupBox();
            this.expirationTextBox = new System.Windows.Forms.MaskedTextBox();
            this.expirationDateLabel = new System.Windows.Forms.Label();
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.paymentMethodLabel = new System.Windows.Forms.Label();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.visaRadioButton = new System.Windows.Forms.RadioButton();
            this.mastercardRadioButton = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.clearToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exitToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.languagePictureBox)).BeginInit();
            this.termInformationGroupBox.SuspendLayout();
            this.studentInformationGroupBox.SuspendLayout();
            this.courseOrderInformationGroupBox.SuspendLayout();
            this.paymentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // languagePictureBox
            // 
            this.languagePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("languagePictureBox.Image")));
            this.languagePictureBox.Location = new System.Drawing.Point(300, 12);
            this.languagePictureBox.Name = "languagePictureBox";
            this.languagePictureBox.Size = new System.Drawing.Size(147, 132);
            this.languagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.languagePictureBox.TabIndex = 0;
            this.languagePictureBox.TabStop = false;
            // 
            // termInformationGroupBox
            // 
            this.termInformationGroupBox.Controls.Add(this.yearLabel);
            this.termInformationGroupBox.Controls.Add(this.yearComboBox);
            this.termInformationGroupBox.Controls.Add(this.springRadioButton);
            this.termInformationGroupBox.Controls.Add(this.termLabel);
            this.termInformationGroupBox.Controls.Add(this.fallRadioButton);
            this.termInformationGroupBox.Location = new System.Drawing.Point(12, 150);
            this.termInformationGroupBox.Name = "termInformationGroupBox";
            this.termInformationGroupBox.Size = new System.Drawing.Size(676, 114);
            this.termInformationGroupBox.TabIndex = 1;
            this.termInformationGroupBox.TabStop = false;
            this.termInformationGroupBox.Text = "Term Information";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(405, 33);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(47, 20);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Year:";
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.yearComboBox.Location = new System.Drawing.Point(409, 68);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(109, 28);
            this.yearComboBox.TabIndex = 1;
            // 
            // springRadioButton
            // 
            this.springRadioButton.AutoSize = true;
            this.springRadioButton.Location = new System.Drawing.Point(192, 68);
            this.springRadioButton.Name = "springRadioButton";
            this.springRadioButton.Size = new System.Drawing.Size(80, 24);
            this.springRadioButton.TabIndex = 0;
            this.springRadioButton.Text = "Spring";
            this.springRadioButton.UseVisualStyleBackColor = true;
            // 
            // termLabel
            // 
            this.termLabel.AutoSize = true;
            this.termLabel.Location = new System.Drawing.Point(100, 33);
            this.termLabel.Name = "termLabel";
            this.termLabel.Size = new System.Drawing.Size(49, 20);
            this.termLabel.TabIndex = 1;
            this.termLabel.Text = "Term:";
            // 
            // fallRadioButton
            // 
            this.fallRadioButton.AutoSize = true;
            this.fallRadioButton.Checked = true;
            this.fallRadioButton.Location = new System.Drawing.Point(104, 68);
            this.fallRadioButton.Name = "fallRadioButton";
            this.fallRadioButton.Size = new System.Drawing.Size(59, 24);
            this.fallRadioButton.TabIndex = 0;
            this.fallRadioButton.TabStop = true;
            this.fallRadioButton.Text = "Fall";
            this.fallRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentInformationGroupBox
            // 
            this.studentInformationGroupBox.Controls.Add(this.idTextBox);
            this.studentInformationGroupBox.Controls.Add(this.emailTextBox);
            this.studentInformationGroupBox.Controls.Add(this.lastNameTextBox);
            this.studentInformationGroupBox.Controls.Add(this.firstNameTextBox);
            this.studentInformationGroupBox.Controls.Add(this.outStateRadioButton);
            this.studentInformationGroupBox.Controls.Add(this.inStateRadioButton);
            this.studentInformationGroupBox.Controls.Add(this.residenceStatusLabel);
            this.studentInformationGroupBox.Controls.Add(this.emailLabel);
            this.studentInformationGroupBox.Controls.Add(this.lastNameLabel);
            this.studentInformationGroupBox.Controls.Add(this.firstNameLabel);
            this.studentInformationGroupBox.Controls.Add(this.idLabel);
            this.studentInformationGroupBox.Location = new System.Drawing.Point(12, 270);
            this.studentInformationGroupBox.Name = "studentInformationGroupBox";
            this.studentInformationGroupBox.Size = new System.Drawing.Size(676, 136);
            this.studentInformationGroupBox.TabIndex = 2;
            this.studentInformationGroupBox.TabStop = false;
            this.studentInformationGroupBox.Text = "Student Information";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(22, 75);
            this.idTextBox.Mask = "000-00-0000";
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 26);
            this.idTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(398, 75);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(122, 26);
            this.emailTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(274, 75);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(103, 26);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(150, 75);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(103, 26);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // outStateRadioButton
            // 
            this.outStateRadioButton.AutoSize = true;
            this.outStateRadioButton.Location = new System.Drawing.Point(528, 91);
            this.outStateRadioButton.Name = "outStateRadioButton";
            this.outStateRadioButton.Size = new System.Drawing.Size(126, 24);
            this.outStateRadioButton.TabIndex = 0;
            this.outStateRadioButton.Text = "Out-Of-State";
            this.outStateRadioButton.UseVisualStyleBackColor = true;
            this.outStateRadioButton.CheckedChanged += new System.EventHandler(this.outStateRadioButton_CheckedChanged);
            // 
            // inStateRadioButton
            // 
            this.inStateRadioButton.AutoSize = true;
            this.inStateRadioButton.Checked = true;
            this.inStateRadioButton.Location = new System.Drawing.Point(528, 61);
            this.inStateRadioButton.Name = "inStateRadioButton";
            this.inStateRadioButton.Size = new System.Drawing.Size(92, 24);
            this.inStateRadioButton.TabIndex = 0;
            this.inStateRadioButton.TabStop = true;
            this.inStateRadioButton.Text = "In-State";
            this.inStateRadioButton.UseVisualStyleBackColor = true;
            this.inStateRadioButton.CheckedChanged += new System.EventHandler(this.inStateRadioButton_CheckedChanged);
            // 
            // residenceStatusLabel
            // 
            this.residenceStatusLabel.AutoSize = true;
            this.residenceStatusLabel.Location = new System.Drawing.Point(524, 38);
            this.residenceStatusLabel.Name = "residenceStatusLabel";
            this.residenceStatusLabel.Size = new System.Drawing.Size(128, 20);
            this.residenceStatusLabel.TabIndex = 4;
            this.residenceStatusLabel.Text = "Resident Status:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(394, 38);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(115, 20);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email Address:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(270, 38);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(90, 20);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(146, 38);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(90, 20);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(18, 38);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(91, 20);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Student ID:";
            // 
            // courseOrderInformationGroupBox
            // 
            this.courseOrderInformationGroupBox.Controls.Add(this.frenchPrice);
            this.courseOrderInformationGroupBox.Controls.Add(this.germanPrice);
            this.courseOrderInformationGroupBox.Controls.Add(this.russianPrice);
            this.courseOrderInformationGroupBox.Controls.Add(this.italianPrice);
            this.courseOrderInformationGroupBox.Controls.Add(this.spanishPrice);
            this.courseOrderInformationGroupBox.Controls.Add(this.costLabel);
            this.courseOrderInformationGroupBox.Controls.Add(this.totalCostLabel);
            this.courseOrderInformationGroupBox.Controls.Add(this.totalCoursesOutput);
            this.courseOrderInformationGroupBox.Controls.Add(this.numberofCoursesLabel);
            this.courseOrderInformationGroupBox.Controls.Add(this.spanishCheckBox);
            this.courseOrderInformationGroupBox.Controls.Add(this.russianCheckBox);
            this.courseOrderInformationGroupBox.Controls.Add(this.italianCheckBox);
            this.courseOrderInformationGroupBox.Controls.Add(this.germanCheckBox);
            this.courseOrderInformationGroupBox.Controls.Add(this.availableCoursesLabel);
            this.courseOrderInformationGroupBox.Controls.Add(this.frenchCheckBox);
            this.courseOrderInformationGroupBox.Location = new System.Drawing.Point(12, 412);
            this.courseOrderInformationGroupBox.Name = "courseOrderInformationGroupBox";
            this.courseOrderInformationGroupBox.Size = new System.Drawing.Size(676, 126);
            this.courseOrderInformationGroupBox.TabIndex = 3;
            this.courseOrderInformationGroupBox.TabStop = false;
            this.courseOrderInformationGroupBox.Text = "Course Order Information";
            // 
            // frenchPrice
            // 
            this.frenchPrice.AutoSize = true;
            this.frenchPrice.Location = new System.Drawing.Point(196, 61);
            this.frenchPrice.Name = "frenchPrice";
            this.frenchPrice.Size = new System.Drawing.Size(0, 20);
            this.frenchPrice.TabIndex = 14;
            // 
            // germanPrice
            // 
            this.germanPrice.Location = new System.Drawing.Point(196, 25);
            this.germanPrice.Name = "germanPrice";
            this.germanPrice.Size = new System.Drawing.Size(65, 24);
            this.germanPrice.TabIndex = 13;
            // 
            // russianPrice
            // 
            this.russianPrice.AutoSize = true;
            this.russianPrice.Location = new System.Drawing.Point(425, 92);
            this.russianPrice.Name = "russianPrice";
            this.russianPrice.Size = new System.Drawing.Size(0, 20);
            this.russianPrice.TabIndex = 12;
            // 
            // italianPrice
            // 
            this.italianPrice.AutoSize = true;
            this.italianPrice.Location = new System.Drawing.Point(425, 62);
            this.italianPrice.Name = "italianPrice";
            this.italianPrice.Size = new System.Drawing.Size(0, 20);
            this.italianPrice.TabIndex = 11;
            // 
            // spanishPrice
            // 
            this.spanishPrice.AutoSize = true;
            this.spanishPrice.Location = new System.Drawing.Point(425, 26);
            this.spanishPrice.Name = "spanishPrice";
            this.spanishPrice.Size = new System.Drawing.Size(0, 20);
            this.spanishPrice.TabIndex = 10;
            // 
            // costLabel
            // 
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costLabel.Location = new System.Drawing.Point(104, 74);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(71, 28);
            this.costLabel.TabIndex = 9;
            this.costLabel.Text = "$0.00";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(6, 74);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(87, 20);
            this.totalCostLabel.TabIndex = 8;
            this.totalCostLabel.Text = "Total Price:";
            // 
            // totalCoursesOutput
            // 
            this.totalCoursesOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCoursesOutput.Location = new System.Drawing.Point(216, 97);
            this.totalCoursesOutput.Name = "totalCoursesOutput";
            this.totalCoursesOutput.Size = new System.Drawing.Size(20, 26);
            this.totalCoursesOutput.TabIndex = 7;
            this.totalCoursesOutput.Text = "0";
            // 
            // numberofCoursesLabel
            // 
            this.numberofCoursesLabel.AutoSize = true;
            this.numberofCoursesLabel.Location = new System.Drawing.Point(6, 103);
            this.numberofCoursesLabel.Name = "numberofCoursesLabel";
            this.numberofCoursesLabel.Size = new System.Drawing.Size(209, 20);
            this.numberofCoursesLabel.TabIndex = 6;
            this.numberofCoursesLabel.Text = "Number of Course Selected:";
            // 
            // spanishCheckBox
            // 
            this.spanishCheckBox.AutoSize = true;
            this.spanishCheckBox.Location = new System.Drawing.Point(489, 25);
            this.spanishCheckBox.Name = "spanishCheckBox";
            this.spanishCheckBox.Size = new System.Drawing.Size(168, 24);
            this.spanishCheckBox.TabIndex = 5;
            this.spanishCheckBox.TabStop = false;
            this.spanishCheckBox.Text = "Beginning Spanish";
            this.spanishCheckBox.UseVisualStyleBackColor = true;
            this.spanishCheckBox.CheckedChanged += new System.EventHandler(this.spanishCheckBox_CheckedChanged);
            // 
            // russianCheckBox
            // 
            this.russianCheckBox.AutoSize = true;
            this.russianCheckBox.Location = new System.Drawing.Point(489, 88);
            this.russianCheckBox.Name = "russianCheckBox";
            this.russianCheckBox.Size = new System.Drawing.Size(168, 24);
            this.russianCheckBox.TabIndex = 4;
            this.russianCheckBox.TabStop = false;
            this.russianCheckBox.Text = "Beginning Russian";
            this.russianCheckBox.UseVisualStyleBackColor = true;
            this.russianCheckBox.CheckedChanged += new System.EventHandler(this.russianCheckBox_CheckedChanged);
            // 
            // italianCheckBox
            // 
            this.italianCheckBox.AutoSize = true;
            this.italianCheckBox.Location = new System.Drawing.Point(489, 55);
            this.italianCheckBox.Name = "italianCheckBox";
            this.italianCheckBox.Size = new System.Drawing.Size(153, 24);
            this.italianCheckBox.TabIndex = 3;
            this.italianCheckBox.TabStop = false;
            this.italianCheckBox.Text = "Beginning Italian";
            this.italianCheckBox.UseVisualStyleBackColor = true;
            this.italianCheckBox.CheckedChanged += new System.EventHandler(this.italianCheckBox_CheckedChanged);
            // 
            // germanCheckBox
            // 
            this.germanCheckBox.AutoSize = true;
            this.germanCheckBox.Location = new System.Drawing.Point(267, 25);
            this.germanCheckBox.Name = "germanCheckBox";
            this.germanCheckBox.Size = new System.Drawing.Size(168, 24);
            this.germanCheckBox.TabIndex = 2;
            this.germanCheckBox.TabStop = false;
            this.germanCheckBox.Text = "Beginning German";
            this.germanCheckBox.UseVisualStyleBackColor = true;
            this.germanCheckBox.CheckedChanged += new System.EventHandler(this.germanCheckBox_CheckedChanged);
            // 
            // availableCoursesLabel
            // 
            this.availableCoursesLabel.AutoSize = true;
            this.availableCoursesLabel.Location = new System.Drawing.Point(6, 22);
            this.availableCoursesLabel.Name = "availableCoursesLabel";
            this.availableCoursesLabel.Size = new System.Drawing.Size(139, 20);
            this.availableCoursesLabel.TabIndex = 1;
            this.availableCoursesLabel.Text = "Available Courses:";
            // 
            // frenchCheckBox
            // 
            this.frenchCheckBox.AutoSize = true;
            this.frenchCheckBox.Location = new System.Drawing.Point(267, 60);
            this.frenchCheckBox.Name = "frenchCheckBox";
            this.frenchCheckBox.Size = new System.Drawing.Size(160, 24);
            this.frenchCheckBox.TabIndex = 0;
            this.frenchCheckBox.TabStop = false;
            this.frenchCheckBox.Text = "Beginning French";
            this.frenchCheckBox.UseVisualStyleBackColor = true;
            this.frenchCheckBox.CheckedChanged += new System.EventHandler(this.frenchCheckBox_CheckedChanged);
            // 
            // paymentGroupBox
            // 
            this.paymentGroupBox.Controls.Add(this.expirationTextBox);
            this.paymentGroupBox.Controls.Add(this.expirationDateLabel);
            this.paymentGroupBox.Controls.Add(this.cardNumberTextBox);
            this.paymentGroupBox.Controls.Add(this.paymentMethodLabel);
            this.paymentGroupBox.Controls.Add(this.cardNumberLabel);
            this.paymentGroupBox.Controls.Add(this.visaRadioButton);
            this.paymentGroupBox.Controls.Add(this.mastercardRadioButton);
            this.paymentGroupBox.Location = new System.Drawing.Point(12, 544);
            this.paymentGroupBox.Name = "paymentGroupBox";
            this.paymentGroupBox.Size = new System.Drawing.Size(676, 114);
            this.paymentGroupBox.TabIndex = 4;
            this.paymentGroupBox.TabStop = false;
            this.paymentGroupBox.Text = "Payment Information";
            // 
            // expirationTextBox
            // 
            this.expirationTextBox.Location = new System.Drawing.Point(434, 67);
            this.expirationTextBox.Mask = "00/00/0000";
            this.expirationTextBox.Name = "expirationTextBox";
            this.expirationTextBox.Size = new System.Drawing.Size(100, 26);
            this.expirationTextBox.TabIndex = 7;
            this.expirationTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // expirationDateLabel
            // 
            this.expirationDateLabel.AutoSize = true;
            this.expirationDateLabel.Location = new System.Drawing.Point(430, 34);
            this.expirationDateLabel.Name = "expirationDateLabel";
            this.expirationDateLabel.Size = new System.Drawing.Size(160, 20);
            this.expirationDateLabel.TabIndex = 5;
            this.expirationDateLabel.Text = "Card Expiration Date:";
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.Location = new System.Drawing.Point(208, 67);
            this.cardNumberTextBox.MaxLength = 16;
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(149, 26);
            this.cardNumberTextBox.TabIndex = 6;
            // 
            // paymentMethodLabel
            // 
            this.paymentMethodLabel.AutoSize = true;
            this.paymentMethodLabel.Location = new System.Drawing.Point(15, 34);
            this.paymentMethodLabel.Name = "paymentMethodLabel";
            this.paymentMethodLabel.Size = new System.Drawing.Size(133, 20);
            this.paymentMethodLabel.TabIndex = 3;
            this.paymentMethodLabel.Text = "Payment Method:";
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.Location = new System.Drawing.Point(204, 34);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(153, 20);
            this.cardNumberLabel.TabIndex = 2;
            this.cardNumberLabel.Text = "Credit Card Number:";
            // 
            // visaRadioButton
            // 
            this.visaRadioButton.AutoSize = true;
            this.visaRadioButton.Location = new System.Drawing.Point(19, 84);
            this.visaRadioButton.Name = "visaRadioButton";
            this.visaRadioButton.Size = new System.Drawing.Size(65, 24);
            this.visaRadioButton.TabIndex = 0;
            this.visaRadioButton.Text = "Visa";
            this.visaRadioButton.UseVisualStyleBackColor = true;
            // 
            // mastercardRadioButton
            // 
            this.mastercardRadioButton.AutoSize = true;
            this.mastercardRadioButton.Checked = true;
            this.mastercardRadioButton.Location = new System.Drawing.Point(19, 57);
            this.mastercardRadioButton.Name = "mastercardRadioButton";
            this.mastercardRadioButton.Size = new System.Drawing.Size(117, 24);
            this.mastercardRadioButton.TabIndex = 0;
            this.mastercardRadioButton.TabStop = true;
            this.mastercardRadioButton.Text = "MasterCard";
            this.mastercardRadioButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(104, 664);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(104, 36);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "&Save";
            this.saveToolTip.SetToolTip(this.saveButton, "Click here to finalize payment");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(300, 664);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(104, 36);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "&Clear";
            this.clearToolTip.SetToolTip(this.clearButton, "Click here to clear information");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(501, 664);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(104, 36);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "&Exit";
            this.exitToolTip.SetToolTip(this.exitButton, "Click here to exit program");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 699);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.paymentGroupBox);
            this.Controls.Add(this.courseOrderInformationGroupBox);
            this.Controls.Add(this.studentInformationGroupBox);
            this.Controls.Add(this.termInformationGroupBox);
            this.Controls.Add(this.languagePictureBox);
            this.Name = "Form1";
            this.Text = "Language Arts Institute (LAI)";
            ((System.ComponentModel.ISupportInitialize)(this.languagePictureBox)).EndInit();
            this.termInformationGroupBox.ResumeLayout(false);
            this.termInformationGroupBox.PerformLayout();
            this.studentInformationGroupBox.ResumeLayout(false);
            this.studentInformationGroupBox.PerformLayout();
            this.courseOrderInformationGroupBox.ResumeLayout(false);
            this.courseOrderInformationGroupBox.PerformLayout();
            this.paymentGroupBox.ResumeLayout(false);
            this.paymentGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox languagePictureBox;
        private System.Windows.Forms.GroupBox termInformationGroupBox;
        private System.Windows.Forms.Label termLabel;
        private System.Windows.Forms.RadioButton fallRadioButton;
        private System.Windows.Forms.RadioButton springRadioButton;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.GroupBox studentInformationGroupBox;
        private System.Windows.Forms.RadioButton outStateRadioButton;
        private System.Windows.Forms.RadioButton inStateRadioButton;
        private System.Windows.Forms.Label residenceStatusLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.GroupBox courseOrderInformationGroupBox;
        private System.Windows.Forms.CheckBox spanishCheckBox;
        private System.Windows.Forms.CheckBox russianCheckBox;
        private System.Windows.Forms.CheckBox italianCheckBox;
        private System.Windows.Forms.CheckBox germanCheckBox;
        private System.Windows.Forms.Label availableCoursesLabel;
        private System.Windows.Forms.CheckBox frenchCheckBox;
        private System.Windows.Forms.GroupBox paymentGroupBox;
        private System.Windows.Forms.RadioButton visaRadioButton;
        private System.Windows.Forms.RadioButton mastercardRadioButton;
        private System.Windows.Forms.Label paymentMethodLabel;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.Label expirationDateLabel;
        private System.Windows.Forms.TextBox cardNumberTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolTip saveToolTip;
        private System.Windows.Forms.ToolTip clearToolTip;
        private System.Windows.Forms.ToolTip exitToolTip;
        private System.Windows.Forms.MaskedTextBox idTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label totalCoursesOutput;
        private System.Windows.Forms.Label numberofCoursesLabel;
        private System.Windows.Forms.Label frenchPrice;
        private System.Windows.Forms.Label germanPrice;
        private System.Windows.Forms.Label russianPrice;
        private System.Windows.Forms.Label italianPrice;
        private System.Windows.Forms.Label spanishPrice;
        private System.Windows.Forms.MaskedTextBox expirationTextBox;
    }
}

