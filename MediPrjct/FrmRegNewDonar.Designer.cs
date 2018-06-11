namespace MediPrjct
{
    partial class FrmRegNewDonar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegNewDonar));
            this.lblName = new System.Windows.Forms.Label();
            this.lblTimeStampFrmRegNewDonar = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.cboBloodGroup = new System.Windows.Forms.ComboBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 69;
            this.lblName.Text = "Namn";
            // 
            // lblTimeStampFrmRegNewDonar
            // 
            this.lblTimeStampFrmRegNewDonar.AutoSize = true;
            this.lblTimeStampFrmRegNewDonar.Location = new System.Drawing.Point(28, 67);
            this.lblTimeStampFrmRegNewDonar.Name = "lblTimeStampFrmRegNewDonar";
            this.lblTimeStampFrmRegNewDonar.Size = new System.Drawing.Size(77, 17);
            this.lblTimeStampFrmRegNewDonar.TabIndex = 68;
            this.lblTimeStampFrmRegNewDonar.Text = "Timestamp";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(590, 582);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 44);
            this.btnSave.TabIndex = 67;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 3;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(806, 582);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 44);
            this.btnCancel.TabIndex = 66;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(96, 435);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(69, 21);
            this.lblGender.TabIndex = 65;
            this.lblGender.Text = "Gender";
            // 
            // cboBloodGroup
            // 
            this.cboBloodGroup.FormattingEnabled = true;
            this.cboBloodGroup.Items.AddRange(new object[] {
            "0+",
            "0-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.cboBloodGroup.Location = new System.Drawing.Point(709, 362);
            this.cboBloodGroup.Name = "cboBloodGroup";
            this.cboBloodGroup.Size = new System.Drawing.Size(242, 24);
            this.cboBloodGroup.TabIndex = 62;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthDate.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.ForeColor = System.Drawing.Color.White;
            this.lblBirthDate.Location = new System.Drawing.Point(96, 245);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(92, 21);
            this.lblBirthDate.TabIndex = 61;
            this.lblBirthDate.Text = "Birth date";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(96, 304);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(75, 21);
            this.lblAddress.TabIndex = 60;
            this.lblAddress.Text = "Address";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(96, 365);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 21);
            this.lblCity.TabIndex = 59;
            this.lblCity.Text = "City";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(530, 183);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(93, 21);
            this.lblLastName.TabIndex = 58;
            this.lblLastName.Text = "Last name";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Location = new System.Drawing.Point(530, 245);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(125, 21);
            this.lblPhoneNumber.TabIndex = 57;
            this.lblPhoneNumber.Text = "Phone number";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.BackColor = System.Drawing.Color.Transparent;
            this.lblPostCode.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostCode.ForeColor = System.Drawing.Color.White;
            this.lblPostCode.Location = new System.Drawing.Point(530, 304);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(86, 21);
            this.lblPostCode.TabIndex = 56;
            this.lblPostCode.Text = "Post code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(530, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 55;
            this.label1.Text = "Blood group";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(96, 184);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(97, 21);
            this.lblFirstName.TabIndex = 54;
            this.lblFirstName.Text = "First name";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(240, 246);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(242, 22);
            this.txtBirthDate.TabIndex = 53;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(240, 305);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(242, 22);
            this.txtAddress.TabIndex = 52;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(240, 366);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(242, 22);
            this.txtCity.TabIndex = 51;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(709, 184);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(242, 22);
            this.txtLastName.TabIndex = 50;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(709, 246);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(242, 22);
            this.txtPhoneNo.TabIndex = 49;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(709, 305);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(242, 22);
            this.txtPostCode.TabIndex = 48;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(240, 184);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(242, 22);
            this.txtFirstName.TabIndex = 47;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(240, 432);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(242, 24);
            this.cboGender.TabIndex = 70;
            // 
            // FrmRegNewDonar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1035, 657);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTimeStampFrmRegNewDonar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cboBloodGroup);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.txtPostCode);
            this.Controls.Add(this.txtFirstName);
            this.Name = "FrmRegNewDonar";
            this.Text = "FrmRegNewDonar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTimeStampFrmRegNewDonar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cboBloodGroup;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox cboGender;
    }
}