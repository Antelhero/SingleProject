﻿namespace TrainMuseum
{
    partial class BoardInsUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardInsUpForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnPictureUpload3 = new System.Windows.Forms.Button();
            this.btnPictureUpload2 = new System.Windows.Forms.Button();
            this.txtPictureLink3 = new System.Windows.Forms.TextBox();
            this.txtPictureLink2 = new System.Windows.Forms.TextBox();
            this.txtPictureLink1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cbxBoardType = new System.Windows.Forms.ComboBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPictureUpload1 = new System.Windows.Forms.Button();
            this.btnPictureUpload5 = new System.Windows.Forms.Button();
            this.txtPictureLink5 = new System.Windows.Forms.TextBox();
            this.txtPictureLink4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPictureUpload4 = new System.Windows.Forms.Button();
            this.lblWriter = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(361, 576);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 29);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpload.Location = new System.Drawing.Point(154, 576);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(86, 29);
            this.btnUpload.TabIndex = 45;
            this.btnUpload.Text = "업로드";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnPictureUpload3
            // 
            this.btnPictureUpload3.Location = new System.Drawing.Point(306, 416);
            this.btnPictureUpload3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPictureUpload3.Name = "btnPictureUpload3";
            this.btnPictureUpload3.Size = new System.Drawing.Size(86, 29);
            this.btnPictureUpload3.TabIndex = 44;
            this.btnPictureUpload3.Text = "사진찾기";
            this.btnPictureUpload3.UseVisualStyleBackColor = true;
            this.btnPictureUpload3.Click += new System.EventHandler(this.btnPictureUpload3_Click);
            // 
            // btnPictureUpload2
            // 
            this.btnPictureUpload2.Location = new System.Drawing.Point(307, 382);
            this.btnPictureUpload2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPictureUpload2.Name = "btnPictureUpload2";
            this.btnPictureUpload2.Size = new System.Drawing.Size(86, 29);
            this.btnPictureUpload2.TabIndex = 43;
            this.btnPictureUpload2.Text = "사진찾기";
            this.btnPictureUpload2.UseVisualStyleBackColor = true;
            this.btnPictureUpload2.Click += new System.EventHandler(this.btnPictureUpload2_Click);
            // 
            // txtPictureLink3
            // 
            this.txtPictureLink3.Enabled = false;
            this.txtPictureLink3.Location = new System.Drawing.Point(93, 419);
            this.txtPictureLink3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPictureLink3.Name = "txtPictureLink3";
            this.txtPictureLink3.Size = new System.Drawing.Size(206, 25);
            this.txtPictureLink3.TabIndex = 42;
            // 
            // txtPictureLink2
            // 
            this.txtPictureLink2.Enabled = false;
            this.txtPictureLink2.Location = new System.Drawing.Point(93, 385);
            this.txtPictureLink2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPictureLink2.Name = "txtPictureLink2";
            this.txtPictureLink2.Size = new System.Drawing.Size(206, 25);
            this.txtPictureLink2.TabIndex = 41;
            // 
            // txtPictureLink1
            // 
            this.txtPictureLink1.Enabled = false;
            this.txtPictureLink1.Location = new System.Drawing.Point(93, 351);
            this.txtPictureLink1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPictureLink1.Name = "txtPictureLink1";
            this.txtPictureLink1.Size = new System.Drawing.Size(206, 25);
            this.txtPictureLink1.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "사진 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 38;
            this.label8.Text = "사진 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "사진 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "게시판 종류";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(93, 12);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(214, 25);
            this.txtTitle.TabIndex = 33;
            // 
            // cbxBoardType
            // 
            this.cbxBoardType.FormattingEnabled = true;
            this.cbxBoardType.Location = new System.Drawing.Point(93, 522);
            this.cbxBoardType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxBoardType.Name = "cbxBoardType";
            this.cbxBoardType.Size = new System.Drawing.Size(138, 23);
            this.cbxBoardType.TabIndex = 32;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(93, 55);
            this.txtContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(533, 278);
            this.txtContent.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "글 내용";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "글 제목";
            // 
            // btnPictureUpload1
            // 
            this.btnPictureUpload1.Location = new System.Drawing.Point(306, 349);
            this.btnPictureUpload1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPictureUpload1.Name = "btnPictureUpload1";
            this.btnPictureUpload1.Size = new System.Drawing.Size(86, 29);
            this.btnPictureUpload1.TabIndex = 24;
            this.btnPictureUpload1.Text = "사진찾기";
            this.btnPictureUpload1.UseVisualStyleBackColor = true;
            this.btnPictureUpload1.Click += new System.EventHandler(this.btnPictureUpload1_Click);
            // 
            // btnPictureUpload5
            // 
            this.btnPictureUpload5.Location = new System.Drawing.Point(307, 484);
            this.btnPictureUpload5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPictureUpload5.Name = "btnPictureUpload5";
            this.btnPictureUpload5.Size = new System.Drawing.Size(86, 29);
            this.btnPictureUpload5.TabIndex = 54;
            this.btnPictureUpload5.Text = "사진찾기";
            this.btnPictureUpload5.UseVisualStyleBackColor = true;
            this.btnPictureUpload5.Click += new System.EventHandler(this.btnPictureUpload5_Click);
            // 
            // txtPictureLink5
            // 
            this.txtPictureLink5.Enabled = false;
            this.txtPictureLink5.Location = new System.Drawing.Point(93, 486);
            this.txtPictureLink5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPictureLink5.Name = "txtPictureLink5";
            this.txtPictureLink5.Size = new System.Drawing.Size(206, 25);
            this.txtPictureLink5.TabIndex = 52;
            // 
            // txtPictureLink4
            // 
            this.txtPictureLink4.Enabled = false;
            this.txtPictureLink4.Location = new System.Drawing.Point(93, 452);
            this.txtPictureLink4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPictureLink4.Name = "txtPictureLink4";
            this.txtPictureLink4.Size = new System.Drawing.Size(206, 25);
            this.txtPictureLink4.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 49;
            this.label4.Text = "사진 5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 48;
            this.label5.Text = "사진 4";
            // 
            // btnPictureUpload4
            // 
            this.btnPictureUpload4.Location = new System.Drawing.Point(306, 450);
            this.btnPictureUpload4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPictureUpload4.Name = "btnPictureUpload4";
            this.btnPictureUpload4.Size = new System.Drawing.Size(86, 29);
            this.btnPictureUpload4.TabIndex = 47;
            this.btnPictureUpload4.Text = "사진찾기";
            this.btnPictureUpload4.UseVisualStyleBackColor = true;
            this.btnPictureUpload4.Click += new System.EventHandler(this.btnPictureUpload4_Click);
            // 
            // lblWriter
            // 
            this.lblWriter.AutoSize = true;
            this.lblWriter.Location = new System.Drawing.Point(431, 18);
            this.lblWriter.Name = "lblWriter";
            this.lblWriter.Size = new System.Drawing.Size(70, 15);
            this.lblWriter.TabIndex = 56;
            this.lblWriter.Text = "작성자 ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(358, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 55;
            this.label10.Text = "작성자 : ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BoardInsUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 628);
            this.Controls.Add(this.lblWriter);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnPictureUpload5);
            this.Controls.Add(this.txtPictureLink5);
            this.Controls.Add(this.txtPictureLink4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPictureUpload4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnPictureUpload3);
            this.Controls.Add(this.btnPictureUpload2);
            this.Controls.Add(this.txtPictureLink3);
            this.Controls.Add(this.txtPictureLink2);
            this.Controls.Add(this.txtPictureLink1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.cbxBoardType);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPictureUpload1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BoardInsUpForm";
            this.Text = "게시판 글 올리기";
            this.Load += new System.EventHandler(this.BoardInsUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnPictureUpload3;
        private System.Windows.Forms.Button btnPictureUpload2;
        private System.Windows.Forms.TextBox txtPictureLink3;
        private System.Windows.Forms.TextBox txtPictureLink2;
        private System.Windows.Forms.TextBox txtPictureLink1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cbxBoardType;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPictureUpload1;
        private System.Windows.Forms.Button btnPictureUpload5;
        private System.Windows.Forms.TextBox txtPictureLink5;
        private System.Windows.Forms.TextBox txtPictureLink4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPictureUpload4;
        private System.Windows.Forms.Label lblWriter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}