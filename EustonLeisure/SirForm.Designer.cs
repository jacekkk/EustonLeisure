﻿namespace EustonLeisure
{
    partial class SirForm
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
            this.tbIncidents = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbIncidents
            // 
            this.tbIncidents.BackColor = System.Drawing.Color.White;
            this.tbIncidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIncidents.ForeColor = System.Drawing.Color.Black;
            this.tbIncidents.Location = new System.Drawing.Point(13, 13);
            this.tbIncidents.Multiline = true;
            this.tbIncidents.Name = "tbIncidents";
            this.tbIncidents.ReadOnly = true;
            this.tbIncidents.Size = new System.Drawing.Size(357, 295);
            this.tbIncidents.TabIndex = 1;
            // 
            // SirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 320);
            this.Controls.Add(this.tbIncidents);
            this.Name = "SirForm";
            this.Text = "SirForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIncidents;
    }
}