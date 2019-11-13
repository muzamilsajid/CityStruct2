namespace CityStruct
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
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCities = new System.Windows.Forms.ListBox();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.cmdChangeCityName = new System.Windows.Forms.Button();
            this.txtChangeCityName = new System.Windows.Forms.TextBox();
            this.listBoxCityDetails = new System.Windows.Forms.ListBox();
            this.btnIncPop = new System.Windows.Forms.Button();
            this.listBoxPersonDetails = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.listBoxPersons = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cmbCities = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(16, 28);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(129, 20);
            this.txtCityName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "City Name:";
            // 
            // listBoxCities
            // 
            this.listBoxCities.FormattingEnabled = true;
            this.listBoxCities.Location = new System.Drawing.Point(16, 55);
            this.listBoxCities.Name = "listBoxCities";
            this.listBoxCities.Size = new System.Drawing.Size(129, 212);
            this.listBoxCities.TabIndex = 2;
            this.listBoxCities.SelectedIndexChanged += new System.EventHandler(this.listBoxCities_SelectedIndexChanged);
            // 
            // btnAddCity
            // 
            this.btnAddCity.Location = new System.Drawing.Point(151, 26);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(75, 23);
            this.btnAddCity.TabIndex = 3;
            this.btnAddCity.Text = "Add City";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // cmdChangeCityName
            // 
            this.cmdChangeCityName.Location = new System.Drawing.Point(151, 80);
            this.cmdChangeCityName.Name = "cmdChangeCityName";
            this.cmdChangeCityName.Size = new System.Drawing.Size(107, 23);
            this.cmdChangeCityName.TabIndex = 4;
            this.cmdChangeCityName.Text = "Change City Name";
            this.cmdChangeCityName.UseVisualStyleBackColor = true;
            this.cmdChangeCityName.Click += new System.EventHandler(this.cmdChangeCityName_Click);
            // 
            // txtChangeCityName
            // 
            this.txtChangeCityName.Location = new System.Drawing.Point(151, 55);
            this.txtChangeCityName.Name = "txtChangeCityName";
            this.txtChangeCityName.Size = new System.Drawing.Size(129, 20);
            this.txtChangeCityName.TabIndex = 5;
            // 
            // listBoxCityDetails
            // 
            this.listBoxCityDetails.FormattingEnabled = true;
            this.listBoxCityDetails.Location = new System.Drawing.Point(295, 55);
            this.listBoxCityDetails.Name = "listBoxCityDetails";
            this.listBoxCityDetails.Size = new System.Drawing.Size(240, 212);
            this.listBoxCityDetails.TabIndex = 6;
            // 
            // btnIncPop
            // 
            this.btnIncPop.Location = new System.Drawing.Point(232, 25);
            this.btnIncPop.Name = "btnIncPop";
            this.btnIncPop.Size = new System.Drawing.Size(87, 23);
            this.btnIncPop.TabIndex = 7;
            this.btnIncPop.Text = "Increase Pop";
            this.btnIncPop.UseVisualStyleBackColor = true;
            this.btnIncPop.Click += new System.EventHandler(this.btnIncPop_Click);
            // 
            // listBoxPersonDetails
            // 
            this.listBoxPersonDetails.FormattingEnabled = true;
            this.listBoxPersonDetails.Location = new System.Drawing.Point(830, 55);
            this.listBoxPersonDetails.Name = "listBoxPersonDetails";
            this.listBoxPersonDetails.Size = new System.Drawing.Size(240, 212);
            this.listBoxPersonDetails.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(686, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(686, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Change City Name";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(825, 26);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(75, 23);
            this.btnAddPerson.TabIndex = 11;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // listBoxPersons
            // 
            this.listBoxPersons.FormattingEnabled = true;
            this.listBoxPersons.Location = new System.Drawing.Point(551, 55);
            this.listBoxPersons.Name = "listBoxPersons";
            this.listBoxPersons.Size = new System.Drawing.Size(129, 212);
            this.listBoxPersons.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Person First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(551, 28);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(129, 20);
            this.txtFirstName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Person Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(686, 29);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(129, 20);
            this.txtLastName.TabIndex = 16;
            // 
            // cmbCities
            // 
            this.cmbCities.FormattingEnabled = true;
            this.cmbCities.Location = new System.Drawing.Point(687, 53);
            this.cmbCities.Name = "cmbCities";
            this.cmbCities.Size = new System.Drawing.Size(121, 21);
            this.cmbCities.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 479);
            this.Controls.Add(this.cmbCities);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.listBoxPersonDetails);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.listBoxPersons);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnIncPop);
            this.Controls.Add(this.listBoxCityDetails);
            this.Controls.Add(this.txtChangeCityName);
            this.Controls.Add(this.cmdChangeCityName);
            this.Controls.Add(this.btnAddCity);
            this.Controls.Add(this.listBoxCities);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCityName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCities;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.Button cmdChangeCityName;
        private System.Windows.Forms.TextBox txtChangeCityName;
        private System.Windows.Forms.ListBox listBoxCityDetails;
        private System.Windows.Forms.Button btnIncPop;
        private System.Windows.Forms.ListBox listBoxPersonDetails;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.ListBox listBoxPersons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cmbCities;
    }
}

