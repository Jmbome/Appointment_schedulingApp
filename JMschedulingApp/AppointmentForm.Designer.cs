
namespace JMschedulingApp
{
    partial class AppointmentForm
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
            this.AppointmentdataGridView = new System.Windows.Forms.DataGridView();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AppointmentLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeReportHeaderlabel = new System.Windows.Forms.Label();
            this.ConsultantReportlabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AllAppointmentsradioButton = new System.Windows.Forms.RadioButton();
            this.MonthlyradioButton = new System.Windows.Forms.RadioButton();
            this.WeeklyAppointmentsradioButton = new System.Windows.Forms.RadioButton();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UserIDcomboBox = new System.Windows.Forms.ComboBox();
            this.CustomerIDcomboBox = new System.Windows.Forms.ComboBox();
            this.AppointmentIdLabel = new System.Windows.Forms.Label();
            this.AppointmentIDtextBox = new System.Windows.Forms.TextBox();
            this.TypeReportcomboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TypeReportlabel = new System.Windows.Forms.Label();
            this.TypeReportCountlabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.UserReportlabel = new System.Windows.Forms.Label();
            this.UserReportCountlabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.CustomerReportlabel = new System.Windows.Forms.Label();
            this.CustomerReportCountlabel = new System.Windows.Forms.Label();
            this.ConsultantReportcomboBox = new System.Windows.Forms.ComboBox();
            this.CustomerReportcomboBox = new System.Windows.Forms.ComboBox();
            this.ConsultantReportGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentdataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultantReportGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentdataGridView
            // 
            this.AppointmentdataGridView.AllowDrop = true;
            this.AppointmentdataGridView.AllowUserToAddRows = false;
            this.AppointmentdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentdataGridView.Location = new System.Drawing.Point(391, 78);
            this.AppointmentdataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.AppointmentdataGridView.Name = "AppointmentdataGridView";
            this.AppointmentdataGridView.ReadOnly = true;
            this.AppointmentdataGridView.RowHeadersVisible = false;
            this.AppointmentdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentdataGridView.Size = new System.Drawing.Size(554, 214);
            this.AppointmentdataGridView.TabIndex = 0;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(134, 322);
            this.TypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(183, 23);
            this.TypeComboBox.TabIndex = 2;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.IndianRed;
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Deletebutton.Location = new System.Drawing.Point(726, 309);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(4);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(88, 36);
            this.Deletebutton.TabIndex = 3;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.Location = new System.Drawing.Point(617, 309);
            this.Updatebutton.Margin = new System.Windows.Forms.Padding(4);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(88, 36);
            this.Updatebutton.TabIndex = 3;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.Location = new System.Drawing.Point(511, 309);
            this.Exitbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(88, 36);
            this.Exitbutton.TabIndex = 3;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer ID:";
            // 
            // AppointmentLabel
            // 
            this.AppointmentLabel.AutoSize = true;
            this.AppointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentLabel.Location = new System.Drawing.Point(106, 34);
            this.AppointmentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AppointmentLabel.Name = "AppointmentLabel";
            this.AppointmentLabel.Size = new System.Drawing.Size(194, 26);
            this.AppointmentLabel.TabIndex = 4;
            this.AppointmentLabel.Text = "Appointment Table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "User ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 327);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 381);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 436);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "End:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(-500, 617);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(30, 21);
            this.textBox5.TabIndex = 5;
            // 
            // Savebutton
            // 
            this.Savebutton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebutton.Location = new System.Drawing.Point(134, 473);
            this.Savebutton.Margin = new System.Windows.Forms.Padding(4);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(183, 38);
            this.Savebutton.TabIndex = 3;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = false;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Set/Update Appointments:";
            // 
            // TypeReportHeaderlabel
            // 
            this.TypeReportHeaderlabel.AutoSize = true;
            this.TypeReportHeaderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeReportHeaderlabel.Location = new System.Drawing.Point(1035, 112);
            this.TypeReportHeaderlabel.Name = "TypeReportHeaderlabel";
            this.TypeReportHeaderlabel.Size = new System.Drawing.Size(87, 18);
            this.TypeReportHeaderlabel.TabIndex = 6;
            this.TypeReportHeaderlabel.Text = "Type report:";
            // 
            // ConsultantReportlabel
            // 
            this.ConsultantReportlabel.AutoSize = true;
            this.ConsultantReportlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultantReportlabel.Location = new System.Drawing.Point(429, 362);
            this.ConsultantReportlabel.Name = "ConsultantReportlabel";
            this.ConsultantReportlabel.Size = new System.Drawing.Size(126, 18);
            this.ConsultantReportlabel.TabIndex = 6;
            this.ConsultantReportlabel.Text = "Consultant report:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1017, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Customer report:";
            // 
            // AllAppointmentsradioButton
            // 
            this.AllAppointmentsradioButton.AutoSize = true;
            this.AllAppointmentsradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllAppointmentsradioButton.Location = new System.Drawing.Point(415, 51);
            this.AllAppointmentsradioButton.Name = "AllAppointmentsradioButton";
            this.AllAppointmentsradioButton.Size = new System.Drawing.Size(130, 21);
            this.AllAppointmentsradioButton.TabIndex = 7;
            this.AllAppointmentsradioButton.TabStop = true;
            this.AllAppointmentsradioButton.Text = "All appointments";
            this.AllAppointmentsradioButton.UseVisualStyleBackColor = true;
            this.AllAppointmentsradioButton.CheckedChanged += new System.EventHandler(this.AllAppointmentsradioButton_CheckedChanged);
            // 
            // MonthlyradioButton
            // 
            this.MonthlyradioButton.AutoSize = true;
            this.MonthlyradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlyradioButton.Location = new System.Drawing.Point(566, 51);
            this.MonthlyradioButton.Name = "MonthlyradioButton";
            this.MonthlyradioButton.Size = new System.Drawing.Size(147, 21);
            this.MonthlyradioButton.TabIndex = 7;
            this.MonthlyradioButton.TabStop = true;
            this.MonthlyradioButton.Text = "Current month apts";
            this.MonthlyradioButton.UseVisualStyleBackColor = true;
            this.MonthlyradioButton.CheckedChanged += new System.EventHandler(this.MonthlyradioButton_CheckedChanged);
            // 
            // WeeklyAppointmentsradioButton
            // 
            this.WeeklyAppointmentsradioButton.AutoSize = true;
            this.WeeklyAppointmentsradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeeklyAppointmentsradioButton.Location = new System.Drawing.Point(750, 51);
            this.WeeklyAppointmentsradioButton.Name = "WeeklyAppointmentsradioButton";
            this.WeeklyAppointmentsradioButton.Size = new System.Drawing.Size(140, 21);
            this.WeeklyAppointmentsradioButton.TabIndex = 7;
            this.WeeklyAppointmentsradioButton.TabStop = true;
            this.WeeklyAppointmentsradioButton.Text = "Current week apts";
            this.WeeklyAppointmentsradioButton.UseVisualStyleBackColor = true;
            this.WeeklyAppointmentsradioButton.CheckedChanged += new System.EventHandler(this.WeeklyAppointmentsradioButton_CheckedChanged);
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.CustomFormat = "  MM / dd / yyyy    HH:mm tt";
            this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDateTimePicker.Location = new System.Drawing.Point(134, 381);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(183, 21);
            this.StartDateTimePicker.TabIndex = 8;
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.CustomFormat = "  MM / dd / yyyy    HH:mm tt";
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDateTimePicker.Location = new System.Drawing.Point(134, 434);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(183, 21);
            this.EndDateTimePicker.TabIndex = 8;
            // 
            // UserIDcomboBox
            // 
            this.UserIDcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserIDcomboBox.FormattingEnabled = true;
            this.UserIDcomboBox.Location = new System.Drawing.Point(134, 269);
            this.UserIDcomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserIDcomboBox.Name = "UserIDcomboBox";
            this.UserIDcomboBox.Size = new System.Drawing.Size(183, 23);
            this.UserIDcomboBox.TabIndex = 2;
            this.UserIDcomboBox.SelectedIndexChanged += new System.EventHandler(this.UserIDcomboBox_SelectedIndexChanged);
            // 
            // CustomerIDcomboBox
            // 
            this.CustomerIDcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerIDcomboBox.FormattingEnabled = true;
            this.CustomerIDcomboBox.Location = new System.Drawing.Point(134, 206);
            this.CustomerIDcomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerIDcomboBox.Name = "CustomerIDcomboBox";
            this.CustomerIDcomboBox.Size = new System.Drawing.Size(183, 23);
            this.CustomerIDcomboBox.TabIndex = 2;
            this.CustomerIDcomboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerIDcomboBox_SelectedIndexChanged);
            // 
            // AppointmentIdLabel
            // 
            this.AppointmentIdLabel.AutoSize = true;
            this.AppointmentIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentIdLabel.Location = new System.Drawing.Point(5, 160);
            this.AppointmentIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AppointmentIdLabel.Name = "AppointmentIdLabel";
            this.AppointmentIdLabel.Size = new System.Drawing.Size(121, 20);
            this.AppointmentIdLabel.TabIndex = 4;
            this.AppointmentIdLabel.Text = "AppointmentID:";
            // 
            // AppointmentIDtextBox
            // 
            this.AppointmentIDtextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.AppointmentIDtextBox.Enabled = false;
            this.AppointmentIDtextBox.Location = new System.Drawing.Point(134, 160);
            this.AppointmentIDtextBox.Name = "AppointmentIDtextBox";
            this.AppointmentIDtextBox.ReadOnly = true;
            this.AppointmentIDtextBox.Size = new System.Drawing.Size(183, 21);
            this.AppointmentIDtextBox.TabIndex = 9;
            // 
            // TypeReportcomboBox
            // 
            this.TypeReportcomboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.TypeReportcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeReportcomboBox.FormattingEnabled = true;
            this.TypeReportcomboBox.Location = new System.Drawing.Point(986, 154);
            this.TypeReportcomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.TypeReportcomboBox.Name = "TypeReportcomboBox";
            this.TypeReportcomboBox.Size = new System.Drawing.Size(183, 23);
            this.TypeReportcomboBox.TabIndex = 2;
            this.TypeReportcomboBox.SelectedIndexChanged += new System.EventHandler(this.TypeReportcomboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(992, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "select month:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Type:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(89, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "Apt.Count:";
            // 
            // TypeReportlabel
            // 
            this.TypeReportlabel.AutoSize = true;
            this.TypeReportlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeReportlabel.Location = new System.Drawing.Point(18, 51);
            this.TypeReportlabel.Name = "TypeReportlabel";
            this.TypeReportlabel.Size = new System.Drawing.Size(44, 18);
            this.TypeReportlabel.TabIndex = 6;
            this.TypeReportlabel.Text = "None";
            // 
            // TypeReportCountlabel
            // 
            this.TypeReportCountlabel.AutoSize = true;
            this.TypeReportCountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeReportCountlabel.Location = new System.Drawing.Point(120, 52);
            this.TypeReportCountlabel.Name = "TypeReportCountlabel";
            this.TypeReportCountlabel.Size = new System.Drawing.Size(16, 18);
            this.TypeReportCountlabel.TabIndex = 6;
            this.TypeReportCountlabel.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TypeReportlabel);
            this.groupBox1.Controls.Add(this.TypeReportCountlabel);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(986, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 179);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Location = new System.Drawing.Point(0, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(183, 179);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 18);
            this.label14.TabIndex = 6;
            this.label14.Text = "Type:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(105, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 18);
            this.label15.TabIndex = 6;
            this.label15.Text = "Count:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(18, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 18);
            this.label19.TabIndex = 6;
            this.label19.Text = "None";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(120, 52);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 18);
            this.label20.TabIndex = 6;
            this.label20.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(397, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 18);
            this.label11.TabIndex = 6;
            this.label11.Text = "select user Id:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.UserReportlabel);
            this.groupBox2.Controls.Add(this.UserReportCountlabel);
            this.groupBox2.Location = new System.Drawing.Point(617, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 46);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 18);
            this.label12.TabIndex = 6;
            this.label12.Text = "User:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(86, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 18);
            this.label13.TabIndex = 6;
            this.label13.Text = "Apt.Count:";
            // 
            // UserReportlabel
            // 
            this.UserReportlabel.AutoSize = true;
            this.UserReportlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserReportlabel.Location = new System.Drawing.Point(22, 18);
            this.UserReportlabel.Name = "UserReportlabel";
            this.UserReportlabel.Size = new System.Drawing.Size(16, 18);
            this.UserReportlabel.TabIndex = 6;
            this.UserReportlabel.Text = "0";
            // 
            // UserReportCountlabel
            // 
            this.UserReportCountlabel.AutoSize = true;
            this.UserReportCountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserReportCountlabel.Location = new System.Drawing.Point(118, 18);
            this.UserReportCountlabel.Name = "UserReportCountlabel";
            this.UserReportCountlabel.Size = new System.Drawing.Size(16, 18);
            this.UserReportCountlabel.TabIndex = 6;
            this.UserReportCountlabel.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(992, 402);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 18);
            this.label16.TabIndex = 6;
            this.label16.Text = "select customer Id:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.CustomerReportlabel);
            this.groupBox3.Controls.Add(this.CustomerReportCountlabel);
            this.groupBox3.Location = new System.Drawing.Point(986, 453);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 171);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(16, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 18);
            this.label17.TabIndex = 6;
            this.label17.Text = "Customer:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(100, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 18);
            this.label18.TabIndex = 6;
            this.label18.Text = "Apt.Count:";
            // 
            // CustomerReportlabel
            // 
            this.CustomerReportlabel.AutoSize = true;
            this.CustomerReportlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerReportlabel.Location = new System.Drawing.Point(16, 18);
            this.CustomerReportlabel.Name = "CustomerReportlabel";
            this.CustomerReportlabel.Size = new System.Drawing.Size(44, 18);
            this.CustomerReportlabel.TabIndex = 6;
            this.CustomerReportlabel.Text = "None";
            // 
            // CustomerReportCountlabel
            // 
            this.CustomerReportCountlabel.AutoSize = true;
            this.CustomerReportCountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerReportCountlabel.Location = new System.Drawing.Point(123, 18);
            this.CustomerReportCountlabel.Name = "CustomerReportCountlabel";
            this.CustomerReportCountlabel.Size = new System.Drawing.Size(16, 18);
            this.CustomerReportCountlabel.TabIndex = 6;
            this.CustomerReportCountlabel.Text = "0";
            // 
            // ConsultantReportcomboBox
            // 
            this.ConsultantReportcomboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.ConsultantReportcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConsultantReportcomboBox.FormattingEnabled = true;
            this.ConsultantReportcomboBox.Location = new System.Drawing.Point(391, 404);
            this.ConsultantReportcomboBox.Name = "ConsultantReportcomboBox";
            this.ConsultantReportcomboBox.Size = new System.Drawing.Size(183, 23);
            this.ConsultantReportcomboBox.TabIndex = 11;
            this.ConsultantReportcomboBox.SelectedIndexChanged += new System.EventHandler(this.ConsultantReportcomboBox_SelectedIndexChanged);
            // 
            // CustomerReportcomboBox
            // 
            this.CustomerReportcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerReportcomboBox.FormattingEnabled = true;
            this.CustomerReportcomboBox.Location = new System.Drawing.Point(986, 424);
            this.CustomerReportcomboBox.Name = "CustomerReportcomboBox";
            this.CustomerReportcomboBox.Size = new System.Drawing.Size(183, 23);
            this.CustomerReportcomboBox.TabIndex = 12;
            this.CustomerReportcomboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerReportcomboBox_SelectedIndexChanged);
            // 
            // ConsultantReportGridView
            // 
            this.ConsultantReportGridView.AllowUserToAddRows = false;
            this.ConsultantReportGridView.AllowUserToDeleteRows = false;
            this.ConsultantReportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultantReportGridView.Location = new System.Drawing.Point(391, 436);
            this.ConsultantReportGridView.Name = "ConsultantReportGridView";
            this.ConsultantReportGridView.ReadOnly = true;
            this.ConsultantReportGridView.RowHeadersVisible = false;
            this.ConsultantReportGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConsultantReportGridView.Size = new System.Drawing.Size(554, 222);
            this.ConsultantReportGridView.TabIndex = 13;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1186, 689);
            this.Controls.Add(this.ConsultantReportGridView);
            this.Controls.Add(this.CustomerReportcomboBox);
            this.Controls.Add(this.ConsultantReportcomboBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AppointmentIDtextBox);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.StartDateTimePicker);
            this.Controls.Add(this.WeeklyAppointmentsradioButton);
            this.Controls.Add(this.MonthlyradioButton);
            this.Controls.Add(this.AllAppointmentsradioButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ConsultantReportlabel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TypeReportHeaderlabel);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AppointmentIdLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AppointmentLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.CustomerIDcomboBox);
            this.Controls.Add(this.UserIDcomboBox);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.TypeReportcomboBox);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.AppointmentdataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AppointmentForm";
            this.Text = "AppointmentForm";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentdataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultantReportGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AppointmentLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TypeReportHeaderlabel;
        private System.Windows.Forms.Label ConsultantReportlabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton AllAppointmentsradioButton;
        private System.Windows.Forms.RadioButton MonthlyradioButton;
        private System.Windows.Forms.RadioButton WeeklyAppointmentsradioButton;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.ComboBox UserIDcomboBox;
        private System.Windows.Forms.ComboBox CustomerIDcomboBox;
        private System.Windows.Forms.Label AppointmentIdLabel;
        private System.Windows.Forms.TextBox AppointmentIDtextBox;
        private System.Windows.Forms.ComboBox TypeReportcomboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label TypeReportlabel;
        private System.Windows.Forms.Label TypeReportCountlabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label UserReportlabel;
        private System.Windows.Forms.Label UserReportCountlabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label CustomerReportlabel;
        private System.Windows.Forms.Label CustomerReportCountlabel;
        private System.Windows.Forms.ComboBox ConsultantReportcomboBox;
        private System.Windows.Forms.ComboBox CustomerReportcomboBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.DataGridView AppointmentdataGridView;
        private System.Windows.Forms.DataGridView ConsultantReportGridView;
    }
}