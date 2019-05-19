namespace Proiect_ISS.ui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.welcomelabel = new System.Windows.Forms.Label();
            this.newBtn = new System.Windows.Forms.Button();
            this.chooseBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomelabel
            // 
            this.welcomelabel.AutoSize = true;
            this.welcomelabel.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcomelabel.Location = new System.Drawing.Point(391, 18);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(343, 42);
            this.welcomelabel.TabIndex = 5;
            this.welcomelabel.Text = "Conference Management";
            // 
            // newBtn
            // 
            this.newBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.newBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.newBtn.FlatAppearance.BorderSize = 0;
            this.newBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.newBtn.Location = new System.Drawing.Point(12, 12);
            this.newBtn.Margin = new System.Windows.Forms.Padding(0);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(220, 75);
            this.newBtn.TabIndex = 1;
            this.newBtn.Text = "Create Conference";
            this.newBtn.UseVisualStyleBackColor = false;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // chooseBtn
            // 
            this.chooseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.chooseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chooseBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.chooseBtn.Location = new System.Drawing.Point(12, 93);
            this.chooseBtn.Name = "chooseBtn";
            this.chooseBtn.Size = new System.Drawing.Size(220, 75);
            this.chooseBtn.TabIndex = 2;
            this.chooseBtn.Text = "Choose Conference";
            this.chooseBtn.UseVisualStyleBackColor = false;
            this.chooseBtn.Click += new System.EventHandler(this.chooseBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.exitBtn.Location = new System.Drawing.Point(56, 332);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(124, 41);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 88);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Controls.Add(this.chooseBtn);
            this.panel2.Controls.Add(this.newBtn);
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 387);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(239, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(663, 387);
            this.panel3.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(884, 467);
            this.Controls.Add(this.welcomelabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomelabel;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button chooseBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}