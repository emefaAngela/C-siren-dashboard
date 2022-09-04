
namespace Siren
{
    partial class CreatePeriod
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.home_btn = new System.Windows.Forms.Button();
            this.saveperiod_btn = new System.Windows.Forms.Button();
            this.input_periodTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_periodName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 89);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.home_btn);
            this.panel2.Controls.Add(this.saveperiod_btn);
            this.panel2.Controls.Add(this.input_periodTime);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.input_periodName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(222, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 262);
            this.panel2.TabIndex = 1;
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.home_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.home_btn.Location = new System.Drawing.Point(176, 217);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(125, 33);
            this.home_btn.TabIndex = 7;
            this.home_btn.Text = "Back to Home";
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // saveperiod_btn
            // 
            this.saveperiod_btn.BackColor = System.Drawing.Color.Blue;
            this.saveperiod_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveperiod_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveperiod_btn.Location = new System.Drawing.Point(37, 217);
            this.saveperiod_btn.Name = "saveperiod_btn";
            this.saveperiod_btn.Size = new System.Drawing.Size(125, 33);
            this.saveperiod_btn.TabIndex = 6;
            this.saveperiod_btn.Text = "Save Period";
            this.saveperiod_btn.UseVisualStyleBackColor = false;
            this.saveperiod_btn.Click += new System.EventHandler(this.saveperiod_btn_Click);
            // 
            // input_periodTime
            // 
            this.input_periodTime.Location = new System.Drawing.Point(37, 172);
            this.input_periodTime.Name = "input_periodTime";
            this.input_periodTime.Size = new System.Drawing.Size(264, 26);
            this.input_periodTime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Period Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Period Name";
            // 
            // input_periodName
            // 
            this.input_periodName.Location = new System.Drawing.Point(37, 95);
            this.input_periodName.Name = "input_periodName";
            this.input_periodName.Size = new System.Drawing.Size(264, 26);
            this.input_periodName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(102, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Periods";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreatePeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreatePeriod";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button saveperiod_btn;
        private System.Windows.Forms.DateTimePicker input_periodTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_periodName;
        private System.Windows.Forms.Label label1;
    }
}

