﻿
namespace Siren
{
    partial class ManagePeriods
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.createPeriod = new System.Windows.Forms.Button();
            this.Home_btn = new System.Windows.Forms.Button();
            this.Periods_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Periods_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkViolet;
            this.panel1.Location = new System.Drawing.Point(-10, -43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 137);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(410, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create Periods";
            // 
            // createPeriod
            // 
            this.createPeriod.BackColor = System.Drawing.Color.Blue;
            this.createPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createPeriod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createPeriod.Location = new System.Drawing.Point(288, 209);
            this.createPeriod.Name = "createPeriod";
            this.createPeriod.Size = new System.Drawing.Size(119, 35);
            this.createPeriod.TabIndex = 2;
            this.createPeriod.Text = "New Period";
            this.createPeriod.UseVisualStyleBackColor = false;
            // 
            // Home_btn
            // 
            this.Home_btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Home_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Home_btn.Location = new System.Drawing.Point(415, 209);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(75, 35);
            this.Home_btn.TabIndex = 3;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = false;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // Periods_dataGridView
            // 
            this.Periods_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Periods_dataGridView.Location = new System.Drawing.Point(205, 264);
            this.Periods_dataGridView.Name = "Periods_dataGridView";
            this.Periods_dataGridView.RowHeadersWidth = 62;
            this.Periods_dataGridView.RowTemplate.Height = 28;
            this.Periods_dataGridView.Size = new System.Drawing.Size(548, 150);
            this.Periods_dataGridView.TabIndex = 4;
            this.Periods_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Periods_dataGridView_CellContentClick);
            // 
            // ManagePeriods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.Periods_dataGridView);
            this.Controls.Add(this.Home_btn);
            this.Controls.Add(this.createPeriod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ManagePeriods";
            this.ShowIcon = false;
            this.Text = "CreatePeriods";
            ((System.ComponentModel.ISupportInitialize)(this.Periods_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createPeriod;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.DataGridView Periods_dataGridView;
    }
}