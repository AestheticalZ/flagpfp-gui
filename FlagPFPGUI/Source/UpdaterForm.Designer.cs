﻿namespace FlagPFPGUI
{
	partial class UpdaterForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdaterForm));
			this.systemBitmap = new System.Windows.Forms.PictureBox();
			this.headerLabel = new System.Windows.Forms.Label();
			this.noButton = new System.Windows.Forms.Button();
			this.yesButton = new System.Windows.Forms.Button();
			this.downloadProgress = new System.Windows.Forms.ProgressBar();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.changelogBox = new System.Windows.Forms.TextBox();
			this.statusLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.systemBitmap)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// systemBitmap
			// 
			this.systemBitmap.Location = new System.Drawing.Point(12, 12);
			this.systemBitmap.Name = "systemBitmap";
			this.systemBitmap.Size = new System.Drawing.Size(32, 32);
			this.systemBitmap.TabIndex = 0;
			this.systemBitmap.TabStop = false;
			// 
			// headerLabel
			// 
			this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerLabel.Location = new System.Drawing.Point(50, 12);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(336, 32);
			this.headerLabel.TabIndex = 1;
			this.headerLabel.Text = "Version (version) of FlagPFP-GUI is available.\r\nWould you like to download and in" +
    "stall it?";
			this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// noButton
			// 
			this.noButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.noButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.noButton.Location = new System.Drawing.Point(311, 251);
			this.noButton.Name = "noButton";
			this.noButton.Size = new System.Drawing.Size(75, 23);
			this.noButton.TabIndex = 2;
			this.noButton.Text = "No";
			this.noButton.UseVisualStyleBackColor = true;
			this.noButton.Click += new System.EventHandler(this.noButton_Click);
			// 
			// yesButton
			// 
			this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.yesButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.yesButton.Location = new System.Drawing.Point(230, 251);
			this.yesButton.Name = "yesButton";
			this.yesButton.Size = new System.Drawing.Size(75, 23);
			this.yesButton.TabIndex = 3;
			this.yesButton.Text = "Yes";
			this.yesButton.UseVisualStyleBackColor = true;
			this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
			// 
			// downloadProgress
			// 
			this.downloadProgress.Location = new System.Drawing.Point(12, 202);
			this.downloadProgress.MarqueeAnimationSpeed = 0;
			this.downloadProgress.Name = "downloadProgress";
			this.downloadProgress.Size = new System.Drawing.Size(374, 23);
			this.downloadProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.downloadProgress.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.changelogBox);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 50);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(374, 146);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Changelog";
			// 
			// changelogBox
			// 
			this.changelogBox.Location = new System.Drawing.Point(6, 19);
			this.changelogBox.Multiline = true;
			this.changelogBox.Name = "changelogBox";
			this.changelogBox.ReadOnly = true;
			this.changelogBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.changelogBox.Size = new System.Drawing.Size(362, 121);
			this.changelogBox.TabIndex = 0;
			// 
			// statusLabel
			// 
			this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusLabel.Location = new System.Drawing.Point(9, 228);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(377, 20);
			this.statusLabel.TabIndex = 7;
			this.statusLabel.Text = "Status: Idle";
			this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// UpdaterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 286);
			this.Controls.Add(this.statusLabel);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.downloadProgress);
			this.Controls.Add(this.yesButton);
			this.Controls.Add(this.noButton);
			this.Controls.Add(this.headerLabel);
			this.Controls.Add(this.systemBitmap);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UpdaterForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FlagPFP GUI Update Checker";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.systemBitmap)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox systemBitmap;
		private System.Windows.Forms.Label headerLabel;
		private System.Windows.Forms.Button noButton;
		private System.Windows.Forms.Button yesButton;
		private System.Windows.Forms.ProgressBar downloadProgress;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox changelogBox;
		private System.Windows.Forms.Label statusLabel;
	}
}

