namespace Proiect_ISS
{
    partial class Form2
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
            this.welcomelabel = new System.Windows.Forms.Label();
            this.newBtn = new System.Windows.Forms.Button();
            this.chooseBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomelabel
            // 
            this.welcomelabel.AutoSize = true;
            this.welcomelabel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcomelabel.Location = new System.Drawing.Point(260, 52);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(318, 37);
            this.welcomelabel.TabIndex = 5;
            this.welcomelabel.Text = "Conference Management";
            // 
            // newBtn
            // 
            this.newBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newBtn.Location = new System.Drawing.Point(293, 130);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(220, 75);
            this.newBtn.TabIndex = 1;
            this.newBtn.Text = "Create Conference";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // chooseBtn
            // 
            this.chooseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chooseBtn.Location = new System.Drawing.Point(293, 238);
            this.chooseBtn.Name = "chooseBtn";
            this.chooseBtn.Size = new System.Drawing.Size(220, 75);
            this.chooseBtn.TabIndex = 2;
            this.chooseBtn.Text = "Choose Conference";
            this.chooseBtn.UseVisualStyleBackColor = true;
            this.chooseBtn.Click += new System.EventHandler(this.chooseBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitBtn.Location = new System.Drawing.Point(333, 351);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(124, 41);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.chooseBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.welcomelabel);
            this.Name = "Form2";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomelabel;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button chooseBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}