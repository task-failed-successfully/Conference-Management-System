namespace Proiect_ISS
{
    partial class ChooseConfForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseConfForm));
            this.label1 = new System.Windows.Forms.Label();
            this.conferenceBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.conferenceList = new System.Windows.Forms.ListBox();
            this.conferenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conferenceDataSet = new Proiect_ISS.ConferenceDataSet();
            this.conferenceTableAdapter = new Proiect_ISS.ConferenceDataSetTableAdapters.ConferenceTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(391, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Conference";
            // 
            // conferenceBtn
            // 
            this.conferenceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.conferenceBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.conferenceBtn.Location = new System.Drawing.Point(12, 12);
            this.conferenceBtn.Name = "conferenceBtn";
            this.conferenceBtn.Size = new System.Drawing.Size(220, 75);
            this.conferenceBtn.TabIndex = 1;
            this.conferenceBtn.Text = "Choose Conference";
            this.conferenceBtn.UseVisualStyleBackColor = true;
            this.conferenceBtn.Click += new System.EventHandler(this.conferenceBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.backBtn.Location = new System.Drawing.Point(56, 332);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(124, 41);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // conferenceList
            // 
            this.conferenceList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.conferenceList.DataSource = this.conferenceBindingSource;
            this.conferenceList.DisplayMember = "name";
            this.conferenceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conferenceList.FormattingEnabled = true;
            this.conferenceList.ItemHeight = 25;
            this.conferenceList.Location = new System.Drawing.Point(17, 12);
            this.conferenceList.Name = "conferenceList";
            this.conferenceList.Size = new System.Drawing.Size(617, 354);
            this.conferenceList.TabIndex = 3;
            // 
            // conferenceBindingSource
            // 
            this.conferenceBindingSource.DataMember = "Conference";
            this.conferenceBindingSource.DataSource = this.conferenceDataSet;
            // 
            // conferenceDataSet
            // 
            this.conferenceDataSet.DataSetName = "ConferenceDataSet";
            this.conferenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conferenceTableAdapter
            // 
            this.conferenceTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.conferenceList);
            this.panel1.Location = new System.Drawing.Point(238, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 387);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.backBtn);
            this.panel2.Controls.Add(this.conferenceBtn);
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
            // ChooseConfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChooseConfForm";
            this.Text = "Choose Conference";
            this.Load += new System.EventHandler(this.ChooseConfForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button conferenceBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ListBox conferenceList;
        private ConferenceDataSet conferenceDataSet;
        private System.Windows.Forms.BindingSource conferenceBindingSource;
        private ConferenceDataSetTableAdapters.ConferenceTableAdapter conferenceTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}