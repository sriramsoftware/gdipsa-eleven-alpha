﻿namespace ElevenAlpha
{
    partial class BookingsManager
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
            this.BookingManagerDataGrid = new System.Windows.Forms.DataGridView();
            this.MemberIdLabel = new System.Windows.Forms.Label();
            this.MemberIdTextBox = new System.Windows.Forms.TextBox();
            this.ShowMemberLookupButton = new System.Windows.Forms.Button();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.BookingDateLabel = new System.Windows.Forms.Label();
            this.BookingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FacilityTypeLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BookButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookingManagerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BookingManagerDataGrid
            // 
            this.BookingManagerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookingManagerDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookingManagerDataGrid.Location = new System.Drawing.Point(100, 150);
            this.BookingManagerDataGrid.Name = "BookingManagerDataGrid";
            this.BookingManagerDataGrid.RowTemplate.Height = 40;
            this.BookingManagerDataGrid.Size = new System.Drawing.Size(1078, 493);
            this.BookingManagerDataGrid.TabIndex = 0;
            // 
            // MemberIdLabel
            // 
            this.MemberIdLabel.AutoSize = true;
            this.MemberIdLabel.Location = new System.Drawing.Point(94, 39);
            this.MemberIdLabel.Name = "MemberIdLabel";
            this.MemberIdLabel.Size = new System.Drawing.Size(152, 32);
            this.MemberIdLabel.TabIndex = 1;
            this.MemberIdLabel.Text = "Member ID";
            // 
            // MemberIdTextBox
            // 
            this.MemberIdTextBox.Location = new System.Drawing.Point(296, 36);
            this.MemberIdTextBox.Name = "MemberIdTextBox";
            this.MemberIdTextBox.Size = new System.Drawing.Size(158, 38);
            this.MemberIdTextBox.TabIndex = 2;
            // 
            // ShowMemberLookupButton
            // 
            this.ShowMemberLookupButton.Location = new System.Drawing.Point(461, 36);
            this.ShowMemberLookupButton.Name = "ShowMemberLookupButton";
            this.ShowMemberLookupButton.Size = new System.Drawing.Size(49, 38);
            this.ShowMemberLookupButton.TabIndex = 3;
            this.ShowMemberLookupButton.Text = "...";
            this.ShowMemberLookupButton.UseVisualStyleBackColor = true;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FirstNameTextBox.Location = new System.Drawing.Point(516, 36);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.ReadOnly = true;
            this.FirstNameTextBox.Size = new System.Drawing.Size(254, 38);
            this.FirstNameTextBox.TabIndex = 4;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(776, 37);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.ReadOnly = true;
            this.LastNameTextBox.Size = new System.Drawing.Size(254, 38);
            this.LastNameTextBox.TabIndex = 5;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // BookingDateLabel
            // 
            this.BookingDateLabel.AutoSize = true;
            this.BookingDateLabel.Location = new System.Drawing.Point(94, 87);
            this.BookingDateLabel.Name = "BookingDateLabel";
            this.BookingDateLabel.Size = new System.Drawing.Size(186, 32);
            this.BookingDateLabel.TabIndex = 6;
            this.BookingDateLabel.Text = "Booking Date";
            // 
            // BookingDateTimePicker
            // 
            this.BookingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BookingDateTimePicker.Location = new System.Drawing.Point(296, 81);
            this.BookingDateTimePicker.Name = "BookingDateTimePicker";
            this.BookingDateTimePicker.Size = new System.Drawing.Size(214, 38);
            this.BookingDateTimePicker.TabIndex = 7;
            // 
            // FacilityTypeLabel
            // 
            this.FacilityTypeLabel.AutoSize = true;
            this.FacilityTypeLabel.Location = new System.Drawing.Point(665, 84);
            this.FacilityTypeLabel.Name = "FacilityTypeLabel";
            this.FacilityTypeLabel.Size = new System.Drawing.Size(168, 32);
            this.FacilityTypeLabel.TabIndex = 8;
            this.FacilityTypeLabel.Text = "FacilityType";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(839, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 39);
            this.comboBox1.TabIndex = 9;
            // 
            // BookButton
            // 
            this.BookButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BookButton.Location = new System.Drawing.Point(500, 692);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(128, 47);
            this.BookButton.TabIndex = 10;
            this.BookButton.Text = "Book";
            this.BookButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CloseButton.Location = new System.Drawing.Point(634, 692);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(128, 47);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // BookingsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 793);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.BookButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.FacilityTypeLabel);
            this.Controls.Add(this.BookingDateTimePicker);
            this.Controls.Add(this.BookingDateLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.ShowMemberLookupButton);
            this.Controls.Add(this.MemberIdTextBox);
            this.Controls.Add(this.MemberIdLabel);
            this.Controls.Add(this.BookingManagerDataGrid);
            this.Name = "BookingsManager";
            this.Padding = new System.Windows.Forms.Padding(100, 150, 100, 150);
            this.Text = "BookingsManager";
            ((System.ComponentModel.ISupportInitialize)(this.BookingManagerDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BookingManagerDataGrid;
        private System.Windows.Forms.Label MemberIdLabel;
        private System.Windows.Forms.TextBox MemberIdTextBox;
        private System.Windows.Forms.Button ShowMemberLookupButton;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label BookingDateLabel;
        private System.Windows.Forms.DateTimePicker BookingDateTimePicker;
        private System.Windows.Forms.Label FacilityTypeLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.Button CloseButton;
    }
}