﻿namespace SARMS
{
    partial class LecturerForm
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
            this.lstUnits = new System.Windows.Forms.ListBox();
            this.lststuinuni = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstUnits
            // 
            this.lstUnits.FormattingEnabled = true;
            this.lstUnits.Location = new System.Drawing.Point(13, 13);
            this.lstUnits.Name = "lstUnits";
            this.lstUnits.Size = new System.Drawing.Size(120, 95);
            this.lstUnits.TabIndex = 0;
            this.lstUnits.SelectedIndexChanged += new System.EventHandler(this.lstUnits_SelectedIndexChanged);
            // 
            // lststuinuni
            // 
            this.lststuinuni.FormattingEnabled = true;
            this.lststuinuni.Location = new System.Drawing.Point(13, 115);
            this.lststuinuni.Name = "lststuinuni";
            this.lststuinuni.Size = new System.Drawing.Size(120, 95);
            this.lststuinuni.TabIndex = 1;
            // 
            // LecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lststuinuni);
            this.Controls.Add(this.lstUnits);
            this.Name = "LecturerForm";
            this.Text = "LecturerForm";
            this.Load += new System.EventHandler(this.LecturerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstUnits;
        private System.Windows.Forms.ListBox lststuinuni;
    }
}