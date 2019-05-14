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
            this.label1 = new System.Windows.Forms.Label();
            this.conferenceBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.conferenceList = new System.Windows.Forms.ListBox();
            this.conferenceDataSet = new Proiect_ISS.ConferenceDataSet();
            this.conferenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conferenceTableAdapter = new Proiect_ISS.ConferenceDataSetTableAdapters.ConferenceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(223, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Conference";
            // 
            // conferenceBtn
            // 
            this.conferenceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.conferenceBtn.Location = new System.Drawing.Point(417, 120);
            this.conferenceBtn.Name = "conferenceBtn";
            this.conferenceBtn.Size = new System.Drawing.Size(244, 48);
            this.conferenceBtn.TabIndex = 1;
            this.conferenceBtn.Text = "Choose Conference";
            this.conferenceBtn.UseVisualStyleBackColor = true;
            this.conferenceBtn.Click += new System.EventHandler(this.conferenceBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backBtn.Location = new System.Drawing.Point(417, 336);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(244, 48);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ConferenceList
            // 
            this.conferenceList.DataSource = this.conferenceBindingSource;
            this.conferenceList.DisplayMember = "name";
            this.conferenceList.FormattingEnabled = true;
            this.conferenceList.Location = new System.Drawing.Point(40, 120);
            this.conferenceList.Name = "ConferenceList";
            this.conferenceList.Size = new System.Drawing.Size(248, 264);
            this.conferenceList.TabIndex = 3;
            // 
            // conferenceDataSet
            // 
            this.conferenceDataSet.DataSetName = "ConferenceDataSet";
            this.conferenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conferenceBindingSource
            // 
            this.conferenceBindingSource.DataMember = "Conference";
            this.conferenceBindingSource.DataSource = this.conferenceDataSet;
            // 
            // conferenceTableAdapter
            // 
            this.conferenceTableAdapter.ClearBeforeFill = true;
            // 
            // ChooseConfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.conferenceList);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.conferenceBtn);
            this.Controls.Add(this.label1);
            this.Name = "ChooseConfForm";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.ChooseConfForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.conferenceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource)).EndInit();
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
    }
}