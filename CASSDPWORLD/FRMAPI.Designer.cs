namespace CASSDPWORLD
{
    partial class FRMAPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMAPI));
            this.label1 = new System.Windows.Forms.Label();
            this.PictLogo = new System.Windows.Forms.PictureBox();
            this.PicClose = new System.Windows.Forms.PictureBox();
            this.BtngetToken = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRegPlace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttruckNo = new System.Windows.Forms.TextBox();
            this.txtterminalID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtEITRUCKNO = new System.Windows.Forms.TextBox();
            this.TxtEILaneID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtEIRregPlace = new System.Windows.Forms.TextBox();
            this.BtnGetEIRLocation = new System.Windows.Forms.Button();
            this.TxtEITokenNo = new System.Windows.Forms.TextBox();
            this.TxtEICotainerNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtEIPortCode = new System.Windows.Forms.TextBox();
            this.TxtResponse = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "WELCOME TO TERMINAL 1";
            // 
            // PictLogo
            // 
            this.PictLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictLogo.Image")));
            this.PictLogo.InitialImage = null;
            this.PictLogo.Location = new System.Drawing.Point(323, 12);
            this.PictLogo.Name = "PictLogo";
            this.PictLogo.Size = new System.Drawing.Size(309, 102);
            this.PictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictLogo.TabIndex = 30;
            this.PictLogo.TabStop = false;
            // 
            // PicClose
            // 
            this.PicClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicClose.Image = ((System.Drawing.Image)(resources.GetObject("PicClose.Image")));
            this.PicClose.Location = new System.Drawing.Point(991, 2);
            this.PicClose.Name = "PicClose";
            this.PicClose.Size = new System.Drawing.Size(34, 26);
            this.PicClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicClose.TabIndex = 32;
            this.PicClose.TabStop = false;
            this.PicClose.Click += new System.EventHandler(this.PicClose_Click);
            // 
            // BtngetToken
            // 
            this.BtngetToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtngetToken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtngetToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtngetToken.ForeColor = System.Drawing.Color.White;
            this.BtngetToken.Location = new System.Drawing.Point(723, 52);
            this.BtngetToken.Name = "BtngetToken";
            this.BtngetToken.Size = new System.Drawing.Size(254, 31);
            this.BtngetToken.TabIndex = 33;
            this.BtngetToken.Text = "Retrieve Token";
            this.BtngetToken.UseVisualStyleBackColor = false;
            this.BtngetToken.Click += new System.EventHandler(this.BtngetToken_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtterminalID);
            this.groupBox1.Controls.Add(this.txttruckNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRegPlace);
            this.groupBox1.Controls.Add(this.BtngetToken);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(996, 122);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GET TOKEN";
            // 
            // txtRegPlace
            // 
            this.txtRegPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegPlace.Location = new System.Drawing.Point(6, 62);
            this.txtRegPlace.Name = "txtRegPlace";
            this.txtRegPlace.Size = new System.Drawing.Size(151, 21);
            this.txtRegPlace.TabIndex = 34;
            this.txtRegPlace.Text = "DXB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "REG PLACE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "TRUCK NO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "TERMINAL ID";
            // 
            // txttruckNo
            // 
            this.txttruckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttruckNo.Location = new System.Drawing.Point(196, 61);
            this.txttruckNo.Name = "txttruckNo";
            this.txttruckNo.Size = new System.Drawing.Size(151, 21);
            this.txttruckNo.TabIndex = 38;
            this.txttruckNo.Text = "355";
            // 
            // txtterminalID
            // 
            this.txtterminalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtterminalID.Location = new System.Drawing.Point(391, 62);
            this.txtterminalID.Name = "txtterminalID";
            this.txtterminalID.Size = new System.Drawing.Size(151, 21);
            this.txtterminalID.TabIndex = 39;
            this.txtterminalID.Text = "T1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtEITokenNo);
            this.groupBox2.Controls.Add(this.TxtEICotainerNo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TxtEIPortCode);
            this.groupBox2.Controls.Add(this.TxtEITRUCKNO);
            this.groupBox2.Controls.Add(this.TxtEILaneID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtEIRregPlace);
            this.groupBox2.Controls.Add(this.BtnGetEIRLocation);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 360);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(996, 173);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GET EIR LOCATION DETAILS";
            // 
            // TxtEITRUCKNO
            // 
            this.TxtEITRUCKNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEITRUCKNO.Location = new System.Drawing.Point(391, 62);
            this.TxtEITRUCKNO.Name = "TxtEITRUCKNO";
            this.TxtEITRUCKNO.Size = new System.Drawing.Size(151, 21);
            this.TxtEITRUCKNO.TabIndex = 39;
            this.TxtEITRUCKNO.Text = "355";
            // 
            // TxtEILaneID
            // 
            this.TxtEILaneID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEILaneID.Location = new System.Drawing.Point(196, 61);
            this.TxtEILaneID.Name = "TxtEILaneID";
            this.TxtEILaneID.Size = new System.Drawing.Size(151, 21);
            this.TxtEILaneID.TabIndex = 38;
            this.TxtEILaneID.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(430, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "TRUCK NO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(240, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "LANE ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "REG PLACE";
            // 
            // TxtEIRregPlace
            // 
            this.TxtEIRregPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEIRregPlace.Location = new System.Drawing.Point(6, 62);
            this.TxtEIRregPlace.Name = "TxtEIRregPlace";
            this.TxtEIRregPlace.Size = new System.Drawing.Size(151, 21);
            this.TxtEIRregPlace.TabIndex = 34;
            this.TxtEIRregPlace.Text = "DXB";
            // 
            // BtnGetEIRLocation
            // 
            this.BtnGetEIRLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnGetEIRLocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGetEIRLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGetEIRLocation.ForeColor = System.Drawing.Color.White;
            this.BtnGetEIRLocation.Location = new System.Drawing.Point(723, 52);
            this.BtnGetEIRLocation.Name = "BtnGetEIRLocation";
            this.BtnGetEIRLocation.Size = new System.Drawing.Size(254, 31);
            this.BtnGetEIRLocation.TabIndex = 33;
            this.BtnGetEIRLocation.Text = "GET EIR LOCATION DETAILS";
            this.BtnGetEIRLocation.UseVisualStyleBackColor = false;
            this.BtnGetEIRLocation.Click += new System.EventHandler(this.BtnGetEIRLocation_Click);
            // 
            // TxtEITokenNo
            // 
            this.TxtEITokenNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEITokenNo.Location = new System.Drawing.Point(391, 125);
            this.TxtEITokenNo.Name = "TxtEITokenNo";
            this.TxtEITokenNo.Size = new System.Drawing.Size(151, 21);
            this.TxtEITokenNo.TabIndex = 45;
            this.TxtEITokenNo.Text = "545446464";
            // 
            // TxtEICotainerNo
            // 
            this.TxtEICotainerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEICotainerNo.Location = new System.Drawing.Point(196, 124);
            this.TxtEICotainerNo.Name = "TxtEICotainerNo";
            this.TxtEICotainerNo.Size = new System.Drawing.Size(151, 21);
            this.TxtEICotainerNo.TabIndex = 44;
            this.TxtEICotainerNo.Text = "124";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(430, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 43;
            this.label8.Text = "TOKEN NO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(240, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "CONTAINER NO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 41;
            this.label10.Text = "PORT CODE";
            // 
            // TxtEIPortCode
            // 
            this.TxtEIPortCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEIPortCode.Location = new System.Drawing.Point(6, 125);
            this.TxtEIPortCode.Name = "TxtEIPortCode";
            this.TxtEIPortCode.Size = new System.Drawing.Size(151, 21);
            this.TxtEIPortCode.TabIndex = 40;
            this.TxtEIPortCode.Text = "100";
            // 
            // TxtResponse
            // 
            this.TxtResponse.Location = new System.Drawing.Point(22, 539);
            this.TxtResponse.Multiline = true;
            this.TxtResponse.Name = "TxtResponse";
            this.TxtResponse.Size = new System.Drawing.Size(996, 176);
            this.TxtResponse.TabIndex = 36;
            // 
            // FRMAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 727);
            this.Controls.Add(this.TxtResponse);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PicClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMAPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMAPI";
            ((System.ComponentModel.ISupportInitialize)(this.PictLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PictLogo;
        private System.Windows.Forms.PictureBox PicClose;
        private System.Windows.Forms.Button BtngetToken;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegPlace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtterminalID;
        private System.Windows.Forms.TextBox txttruckNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtEITRUCKNO;
        private System.Windows.Forms.TextBox TxtEILaneID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtEIRregPlace;
        private System.Windows.Forms.Button BtnGetEIRLocation;
        private System.Windows.Forms.TextBox TxtEITokenNo;
        private System.Windows.Forms.TextBox TxtEICotainerNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtEIPortCode;
        private System.Windows.Forms.TextBox TxtResponse;
    }
}