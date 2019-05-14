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
            ((System.ComponentModel.ISupportInitialize)(this.accountsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(222, 44);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(337, 37);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Conference Creation Menu";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(81, 117);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(142, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Conference Name:";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(229, 117);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(436, 20);
            this.nameTB.TabIndex = 2;
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createBtn.Location = new System.Drawing.Point(609, 382);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(105, 40);
            this.createBtn.TabIndex = 3;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // abortBtn
            // 
            this.abortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.abortBtn.Location = new System.Drawing.Point(439, 382);
            this.abortBtn.Name = "abortBtn";
            this.abortBtn.Size = new System.Drawing.Size(87, 40);
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
            this.accountsTable.Location = new System.Drawing.Point(194, 153);
            this.accountsTable.Name = "accountsTable";
            this.accountsTable.Size = new System.Drawing.Size(444, 208);
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
            this.chairButton.Location = new System.Drawing.Point(44, 396);
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
            this.coChairButton.Location = new System.Drawing.Point(242, 396);
            this.coChairButton.Name = "coChairButton";
            this.coChairButton.Size = new System.Drawing.Size(65, 17);
            this.coChairButton.TabIndex = 7;
            this.coChairButton.Text = "Co-Chair";
            this.coChairButton.UseVisualStyleBackColor = true;
            // 
            // ConfCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.coChairButton);
            this.Controls.Add(this.chairButton);
            this.Controls.Add(this.accountsTable);
            this.Controls.Add(this.abortBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "ConfCreationForm";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.accountsTable)).EndInit();
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
    }
}