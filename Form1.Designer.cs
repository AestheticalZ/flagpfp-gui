﻿
namespace FlagPFPGUI
{
    partial class MainForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.outputBrowseButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fsizeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.insizeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.marginBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flagCombo = new System.Windows.Forms.ComboBox();
            this.inputBrowseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.previewPicture = new System.Windows.Forms.PictureBox();
            this.aboutButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.aboutButton);
            this.groupBox2.Controls.Add(this.quitButton);
            this.groupBox2.Controls.Add(this.generateButton);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.outputBrowseButton);
            this.groupBox2.Controls.Add(this.outputBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.fsizeBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.insizeBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.marginBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.flagCombo);
            this.groupBox2.Controls.Add(this.inputBrowseButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.inputBox);
            this.groupBox2.Location = new System.Drawing.Point(318, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 300);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(6, 271);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 15;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(349, 271);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 14;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Output";
            // 
            // outputBrowseButton
            // 
            this.outputBrowseButton.Location = new System.Drawing.Point(349, 148);
            this.outputBrowseButton.Name = "outputBrowseButton";
            this.outputBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.outputBrowseButton.TabIndex = 12;
            this.outputBrowseButton.Text = "Browse";
            this.outputBrowseButton.UseVisualStyleBackColor = true;
            this.outputBrowseButton.Click += new System.EventHandler(this.outputBrowseButton_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(66, 150);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(277, 20);
            this.outputBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Full Size";
            // 
            // fsizeBox
            // 
            this.fsizeBox.Location = new System.Drawing.Point(66, 124);
            this.fsizeBox.Name = "fsizeBox";
            this.fsizeBox.Size = new System.Drawing.Size(358, 20);
            this.fsizeBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Inner Size";
            // 
            // insizeBox
            // 
            this.insizeBox.Location = new System.Drawing.Point(66, 98);
            this.insizeBox.Name = "insizeBox";
            this.insizeBox.Size = new System.Drawing.Size(358, 20);
            this.insizeBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Margin";
            // 
            // marginBox
            // 
            this.marginBox.Location = new System.Drawing.Point(66, 72);
            this.marginBox.Name = "marginBox";
            this.marginBox.Size = new System.Drawing.Size(358, 20);
            this.marginBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Flag";
            // 
            // flagCombo
            // 
            this.flagCombo.FormattingEnabled = true;
            this.flagCombo.Location = new System.Drawing.Point(66, 45);
            this.flagCombo.Name = "flagCombo";
            this.flagCombo.Size = new System.Drawing.Size(358, 21);
            this.flagCombo.TabIndex = 3;
            // 
            // inputBrowseButton
            // 
            this.inputBrowseButton.Location = new System.Drawing.Point(349, 17);
            this.inputBrowseButton.Name = "inputBrowseButton";
            this.inputBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.inputBrowseButton.TabIndex = 2;
            this.inputBrowseButton.Text = "Browse";
            this.inputBrowseButton.UseVisualStyleBackColor = true;
            this.inputBrowseButton.Click += new System.EventHandler(this.inputBrowseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(66, 19);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(277, 20);
            this.inputBox.TabIndex = 0;
            // 
            // previewPicture
            // 
            this.previewPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previewPicture.Location = new System.Drawing.Point(12, 12);
            this.previewPicture.Name = "previewPicture";
            this.previewPicture.Size = new System.Drawing.Size(300, 300);
            this.previewPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previewPicture.TabIndex = 2;
            this.previewPicture.TabStop = false;
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(87, 271);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 23);
            this.aboutButton.TabIndex = 16;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 326);
            this.Controls.Add(this.previewPicture);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "FlagPFP GUI";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox flagCombo;
        private System.Windows.Forms.Button inputBrowseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.PictureBox previewPicture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox insizeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox marginBox;
        private System.Windows.Forms.Button outputBrowseButton;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fsizeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button aboutButton;
    }
}
