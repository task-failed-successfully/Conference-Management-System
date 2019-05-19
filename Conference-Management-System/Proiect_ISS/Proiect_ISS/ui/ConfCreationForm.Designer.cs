namespace Proiect_ISS
{
    partial class ConfCreationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfCreationForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.abortBtn = new System.Windows.Forms.Button();
            this.accountsTable = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Affiliation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chairButton = new System.Windows.Forms.RadioButton();
            this.coChairButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(422, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(262, 42);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Create Conference";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(16, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(142, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Conference Name:";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(164, 30);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(444, 20);
            this.nameTB.TabIndex = 2;
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.createBtn.Location = new System.Drawing.Point(12, 15);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(220, 75);
            this.createBtn.TabIndex = 3;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // abortBtn
            // 
            this.abortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.abortBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.abortBtn.Location = new System.Drawing.Point(56, 332);
            this.abortBtn.Name = "abortBtn";
            this.abortBtn.Size = new System.Drawing.Size(124, 41);
            this.abortBtn.TabIndex = 4;
            this.abortBtn.Text = "Abort";
            this.abortBtn.UseVisualStyleBackColor = true;
            this.abortBtn.Click += new System.EventHandler(this.abortBtn_Click);
            // 
            // accountsTable
            // 
            this.accountsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Password,
            this.FullName,
            this.Affiliation,
            this.Email});
            this.accountsTable.Location = new System.Drawing.Point(164, 89);
            this.accountsTable.Name = "accountsTable";
            this.accountsTable.Size = new System.Drawing.Size(444, 271);
            this.accountsTable.TabIndex = 5;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.Visible = false;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            // 
            // Affiliation
            // 
            this.Affiliation.HeaderText = "Affiliation";
            this.Affiliation.Name = "Affiliation";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // chairButton
            // 
            this.chairButton.AutoSize = true;
            this.chairButton.Checked = true;
            this.chairButton.Location = new System.Drawing.Point(20, 89);
            this.chairButton.Name = "chairButton";
            this.chairButton.Size = new System.Drawing.Size(49, 17);
            this.chairButton.TabIndex = 6;
            this.chairButton.TabStop = true;
            this.chairButton.Text = "Chair";
            this.chairButton.UseVisualStyleBackColor = true;
            // 
            // coChairButton
            // 
            this.coChairButton.AutoSize = true;
            this.coChairButton.Location = new System.Drawing.Point(93, 89);
            this.coChairButton.Name = "coChairButton";
            this.coChairButton.Size = new System.Drawing.Size(65, 17);
            this.coChairButton.TabIndex = 7;
            this.coChairButton.Text = "Co-Chair";
            this.coChairButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.chairButton);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.coChairButton);
            this.panel1.Controls.Add(this.accountsTable);
            this.panel1.Controls.Add(this.nameTB);
            this.panel1.Location = new System.Drawing.Point(239, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 387);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.abortBtn);
            this.panel2.Controls.Add(this.createBtn);
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 387);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 88);
            this.panel3.TabIndex = 0;
            // 
            // ConfCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(884, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConfCreationForm";
            this.Text = "Create Conference";
            ((System.ComponentModel.ISupportInitialize)(this.accountsTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button abortBtn;
        private System.Windows.Forms.DataGridView accountsTable;
        private System.Windows.Forms.RadioButton chairButton;
        private System.Windows.Forms.RadioButton coChairButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Affiliation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}