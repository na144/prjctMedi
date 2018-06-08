namespace MediPrjct
{
    partial class FrmStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStart));
            this.lblName = new System.Windows.Forms.Label();
            this.lblTimeStampFrmStart = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDonations = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRegNewDonation = new System.Windows.Forms.Button();
            this.btnRegNewDonar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(41, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Namn";
            // 
            // lblTimeStampFrmStart
            // 
            this.lblTimeStampFrmStart.AutoSize = true;
            this.lblTimeStampFrmStart.Location = new System.Drawing.Point(41, 57);
            this.lblTimeStampFrmStart.Name = "lblTimeStampFrmStart";
            this.lblTimeStampFrmStart.Size = new System.Drawing.Size(77, 17);
            this.lblTimeStampFrmStart.TabIndex = 19;
            this.lblTimeStampFrmStart.Text = "Timestamp";
            this.lblTimeStampFrmStart.Click += new System.EventHandler(this.lblTimeStamp_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnLogOut.FlatAppearance.BorderSize = 3;
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(585, 452);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(200, 44);
            this.btnLogOut.TabIndex = 18;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDonations
            // 
            this.btnDonations.BackColor = System.Drawing.Color.White;
            this.btnDonations.Location = new System.Drawing.Point(230, 339);
            this.btnDonations.Name = "btnDonations";
            this.btnDonations.Size = new System.Drawing.Size(200, 44);
            this.btnDonations.TabIndex = 17;
            this.btnDonations.Text = "Donation list";
            this.btnDonations.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(230, 282);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 44);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnRegNewDonation
            // 
            this.btnRegNewDonation.BackColor = System.Drawing.Color.White;
            this.btnRegNewDonation.Location = new System.Drawing.Point(229, 223);
            this.btnRegNewDonation.Name = "btnRegNewDonation";
            this.btnRegNewDonation.Size = new System.Drawing.Size(200, 44);
            this.btnRegNewDonation.TabIndex = 15;
            this.btnRegNewDonation.Text = "Register new donation";
            this.btnRegNewDonation.UseVisualStyleBackColor = false;
            this.btnRegNewDonation.Click += new System.EventHandler(this.btnRegNewDonation_Click);
            // 
            // btnRegNewDonar
            // 
            this.btnRegNewDonar.BackColor = System.Drawing.Color.White;
            this.btnRegNewDonar.Location = new System.Drawing.Point(230, 161);
            this.btnRegNewDonar.Name = "btnRegNewDonar";
            this.btnRegNewDonar.Size = new System.Drawing.Size(200, 44);
            this.btnRegNewDonar.TabIndex = 14;
            this.btnRegNewDonar.Text = "Register new donar";
            this.btnRegNewDonar.UseVisualStyleBackColor = false;
            this.btnRegNewDonar.Click += new System.EventHandler(this.btnRegNewDonar_Click);
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(826, 516);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTimeStampFrmStart);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnDonations);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRegNewDonation);
            this.Controls.Add(this.btnRegNewDonar);
            this.Name = "FrmStart";
            this.Text = "FrmStart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTimeStampFrmStart;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnDonations;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRegNewDonation;
        private System.Windows.Forms.Button btnRegNewDonar;
    }
}