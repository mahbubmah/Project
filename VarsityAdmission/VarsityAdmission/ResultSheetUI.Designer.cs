﻿namespace VarsityAdmission
{
    partial class ResultSheetUI
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Reg No");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("student name");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Course  title");
            this.findCEUiTutton = new System.Windows.Forms.Button();
            this.emailREUiTextBox = new System.Windows.Forms.TextBox();
            this.nameREUiTextBox = new System.Windows.Forms.TextBox();
            this.regNoREUiTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.showScoreTextBox = new System.Windows.Forms.TextBox();
            this.showGradeTextBox = new System.Windows.Forms.TextBox();
            this.resultListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // findCEUiTutton
            // 
            this.findCEUiTutton.Location = new System.Drawing.Point(242, 36);
            this.findCEUiTutton.Name = "findCEUiTutton";
            this.findCEUiTutton.Size = new System.Drawing.Size(75, 23);
            this.findCEUiTutton.TabIndex = 26;
            this.findCEUiTutton.Text = "FIND";
            this.findCEUiTutton.UseVisualStyleBackColor = true;
            this.findCEUiTutton.Click += new System.EventHandler(this.findCEUiTutton_Click);
            // 
            // emailREUiTextBox
            // 
            this.emailREUiTextBox.Location = new System.Drawing.Point(115, 91);
            this.emailREUiTextBox.Name = "emailREUiTextBox";
            this.emailREUiTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailREUiTextBox.TabIndex = 25;
            // 
            // nameREUiTextBox
            // 
            this.nameREUiTextBox.Location = new System.Drawing.Point(115, 65);
            this.nameREUiTextBox.Name = "nameREUiTextBox";
            this.nameREUiTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameREUiTextBox.TabIndex = 24;
            // 
            // regNoREUiTextBox
            // 
            this.regNoREUiTextBox.Location = new System.Drawing.Point(115, 39);
            this.regNoREUiTextBox.Name = "regNoREUiTextBox";
            this.regNoREUiTextBox.Size = new System.Drawing.Size(121, 20);
            this.regNoREUiTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Reg NO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Result";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Grade Letter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Average Score%";
            // 
            // showScoreTextBox
            // 
            this.showScoreTextBox.Location = new System.Drawing.Point(465, 43);
            this.showScoreTextBox.Name = "showScoreTextBox";
            this.showScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.showScoreTextBox.TabIndex = 31;
            // 
            // showGradeTextBox
            // 
            this.showGradeTextBox.Location = new System.Drawing.Point(465, 72);
            this.showGradeTextBox.Name = "showGradeTextBox";
            this.showGradeTextBox.Size = new System.Drawing.Size(100, 20);
            this.showGradeTextBox.TabIndex = 32;
            // 
            // resultListView
            // 
            this.resultListView.GridLines = true;
            this.resultListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.resultListView.Location = new System.Drawing.Point(115, 128);
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(450, 115);
            this.resultListView.TabIndex = 33;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            // 
            // ResultSheetUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 288);
            this.Controls.Add(this.resultListView);
            this.Controls.Add(this.showGradeTextBox);
            this.Controls.Add(this.showScoreTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.findCEUiTutton);
            this.Controls.Add(this.emailREUiTextBox);
            this.Controls.Add(this.nameREUiTextBox);
            this.Controls.Add(this.regNoREUiTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ResultSheetUI";
            this.Text = "ResultSheetUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findCEUiTutton;
        private System.Windows.Forms.TextBox emailREUiTextBox;
        private System.Windows.Forms.TextBox nameREUiTextBox;
        private System.Windows.Forms.TextBox regNoREUiTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox showScoreTextBox;
        private System.Windows.Forms.TextBox showGradeTextBox;
        private System.Windows.Forms.ListView resultListView;
    }
}