namespace EMS
{
    partial class User
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
            this.btnGet = new System.Windows.Forms.Button();
            this.btnPut = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtresponse = new System.Windows.Forms.RichTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSingleUser = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.pnlpost = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.lbluserid = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.getbyName = new System.Windows.Forms.Button();
            this.txtbyname = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.Label();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.pnlpost.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(27, 54);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(143, 71);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "GetAllUser";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnPut
            // 
            this.btnPut.Location = new System.Drawing.Point(629, 128);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(154, 60);
            this.btnPut.TabIndex = 1;
            this.btnPut.Text = "PUT";
            this.btnPut.UseVisualStyleBackColor = true;
            this.btnPut.Click += new System.EventHandler(this.btnPut_Click);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(629, 10);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(154, 63);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(487, 68);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(132, 45);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtresponse
            // 
            this.txtresponse.Location = new System.Drawing.Point(2, 415);
            this.txtresponse.Name = "txtresponse";
            this.txtresponse.Size = new System.Drawing.Size(1556, 298);
            this.txtresponse.TabIndex = 4;
            this.txtresponse.Text = "";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(4, 50);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(48, 20);
            this.lblemail.TabIndex = 6;
            this.lblemail.Text = "Email";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(3, 86);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(63, 20);
            this.lblgender.TabIndex = 7;
            this.lblgender.Text = "Gender";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(6, 124);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(56, 20);
            this.lblstatus.TabIndex = 8;
            this.lblstatus.Text = "Status";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(371, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 26);
            this.txtEmail.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(371, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 26);
            this.txtName.TabIndex = 12;
            // 
            // btnSingleUser
            // 
            this.btnSingleUser.Location = new System.Drawing.Point(487, 16);
            this.btnSingleUser.Name = "btnSingleUser";
            this.btnSingleUser.Size = new System.Drawing.Size(132, 46);
            this.btnSingleUser.TabIndex = 13;
            this.btnSingleUser.Text = "GET";
            this.btnSingleUser.UseVisualStyleBackColor = true;
            this.btnSingleUser.Click += new System.EventHandler(this.btnSingleUser_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(99, 55);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(262, 26);
            this.txtid.TabIndex = 14;
            // 
            // pnlpost
            // 
            this.pnlpost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlpost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlpost.Controls.Add(this.txtgender);
            this.pnlpost.Controls.Add(this.txtstatus);
            this.pnlpost.Controls.Add(this.panel3);
            this.pnlpost.Controls.Add(this.txtuserid);
            this.pnlpost.Controls.Add(this.lbluserid);
            this.pnlpost.Controls.Add(this.lblName);
            this.pnlpost.Controls.Add(this.lblemail);
            this.pnlpost.Controls.Add(this.lblgender);
            this.pnlpost.Controls.Add(this.btnPut);
            this.pnlpost.Controls.Add(this.btnPost);
            this.pnlpost.Controls.Add(this.txtEmail);
            this.pnlpost.Controls.Add(this.txtName);
            this.pnlpost.Controls.Add(this.lblstatus);
            this.pnlpost.ForeColor = System.Drawing.SystemColors.Highlight;
            this.pnlpost.Location = new System.Drawing.Point(80, 24);
            this.pnlpost.Name = "pnlpost";
            this.pnlpost.Size = new System.Drawing.Size(1363, 209);
            this.pnlpost.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnGet);
            this.panel3.Location = new System.Drawing.Point(956, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 178);
            this.panel3.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Search User List";
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(371, 162);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(214, 26);
            this.txtuserid.TabIndex = 18;
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.Location = new System.Drawing.Point(6, 165);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(23, 20);
            this.lbluserid.TabIndex = 17;
            this.lbluserid.Text = "Id";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblid);
            this.panel2.Controls.Add(this.txtid);
            this.panel2.Controls.Add(this.btnSingleUser);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(80, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 126);
            this.panel2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "SearchBy Id ";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(13, 55);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(66, 20);
            this.lblid.TabIndex = 15;
            this.lblid.Text = "Enter Id";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.getbyName);
            this.panel1.Controls.Add(this.txtbyname);
            this.panel1.Controls.Add(this.txtSearchName);
            this.panel1.Location = new System.Drawing.Point(761, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 126);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "SearchBy Name";
            // 
            // getbyName
            // 
            this.getbyName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.getbyName.Location = new System.Drawing.Point(418, 49);
            this.getbyName.Name = "getbyName";
            this.getbyName.Size = new System.Drawing.Size(110, 32);
            this.getbyName.TabIndex = 17;
            this.getbyName.Text = "GET";
            this.getbyName.UseVisualStyleBackColor = true;
            this.getbyName.Click += new System.EventHandler(this.getbyName_Click);
            // 
            // txtbyname
            // 
            this.txtbyname.Location = new System.Drawing.Point(136, 49);
            this.txtbyname.Name = "txtbyname";
            this.txtbyname.Size = new System.Drawing.Size(262, 26);
            this.txtbyname.TabIndex = 1;
            // 
            // txtSearchName
            // 
            this.txtSearchName.AutoSize = true;
            this.txtSearchName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtSearchName.Location = new System.Drawing.Point(30, 55);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(94, 20);
            this.txtSearchName.TabIndex = 0;
            this.txtSearchName.Text = "Enter Name";
            // 
            // txtgender
            // 
            this.txtgender.Location = new System.Drawing.Point(371, 88);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(214, 26);
            this.txtgender.TabIndex = 18;
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(371, 128);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(214, 26);
            this.txtstatus.TabIndex = 19;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1649, 890);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlpost);
            this.Controls.Add(this.txtresponse);
            this.Name = "User";
            this.Text = "User";
            this.pnlpost.ResumeLayout(false);
            this.pnlpost.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnPut;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.RichTextBox txtresponse;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSingleUser;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Panel pnlpost;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.Label lbluserid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbyname;
        private System.Windows.Forms.Label txtSearchName;
        private System.Windows.Forms.Button getbyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.TextBox txtstatus;
    }
}