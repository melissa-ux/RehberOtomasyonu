namespace RehberOtomasyonu
{
    partial class Rehberİngilizce
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.rehberrDataSet1 = new RehberOtomasyonu.RehberrDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone_Number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhonee_Number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHome_Adress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colE_Mail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rehberrrİngilizceTableAdapter1 = new RehberOtomasyonu.RehberrDataSetTableAdapters.RehberrrİngilizceTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.afgf = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rehberrDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Rehberrrİngilizce";
            this.gridControl1.DataSource = this.rehberrDataSet1;
            this.gridControl1.Location = new System.Drawing.Point(12, 45);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1121, 507);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // rehberrDataSet1
            // 
            this.rehberrDataSet1.DataSetName = "RehberrDataSet";
            this.rehberrDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colSurname,
            this.colBirthday,
            this.colJob,
            this.colPhone_Number,
            this.colPhonee_Number,
            this.colHome_Adress,
            this.colE_Mail,
            this.colPhoto});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colSurname
            // 
            this.colSurname.FieldName = "Surname";
            this.colSurname.Name = "colSurname";
            this.colSurname.Visible = true;
            this.colSurname.VisibleIndex = 1;
            // 
            // colBirthday
            // 
            this.colBirthday.FieldName = "Birthday";
            this.colBirthday.Name = "colBirthday";
            this.colBirthday.Visible = true;
            this.colBirthday.VisibleIndex = 2;
            // 
            // colJob
            // 
            this.colJob.FieldName = "Job";
            this.colJob.Name = "colJob";
            this.colJob.Visible = true;
            this.colJob.VisibleIndex = 3;
            // 
            // colPhone_Number
            // 
            this.colPhone_Number.FieldName = "Phone_Number";
            this.colPhone_Number.Name = "colPhone_Number";
            this.colPhone_Number.Visible = true;
            this.colPhone_Number.VisibleIndex = 4;
            // 
            // colPhonee_Number
            // 
            this.colPhonee_Number.FieldName = "Phonee_Number";
            this.colPhonee_Number.Name = "colPhonee_Number";
            this.colPhonee_Number.Visible = true;
            this.colPhonee_Number.VisibleIndex = 5;
            // 
            // colHome_Adress
            // 
            this.colHome_Adress.FieldName = "Home_Adress";
            this.colHome_Adress.Name = "colHome_Adress";
            this.colHome_Adress.Visible = true;
            this.colHome_Adress.VisibleIndex = 6;
            // 
            // colE_Mail
            // 
            this.colE_Mail.FieldName = "E_Mail";
            this.colE_Mail.Name = "colE_Mail";
            this.colE_Mail.Visible = true;
            this.colE_Mail.VisibleIndex = 7;
            // 
            // colPhoto
            // 
            this.colPhoto.FieldName = "Photo";
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.Visible = true;
            this.colPhoto.VisibleIndex = 8;
            // 
            // rehberrrİngilizceTableAdapter1
            // 
            this.rehberrrİngilizceTableAdapter1.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1145, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::RehberOtomasyonu.Properties.Resources.refresh_32x32;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(74, 20);
            this.toolStripMenuItem1.Text = "Refresh";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // afgf
            // 
            this.afgf.AutoSize = true;
            this.afgf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.afgf.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.afgf.Location = new System.Drawing.Point(12, 27);
            this.afgf.Name = "afgf";
            this.afgf.Size = new System.Drawing.Size(117, 15);
            this.afgf.TabIndex = 2;
            this.afgf.TabStop = true;
            this.afgf.Text = "Telephone Directory";
            // 
            // Rehberİngilizce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 564);
            this.Controls.Add(this.afgf);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Rehberİngilizce";
            this.Text = "Rehberİngilizce";
            this.Load += new System.EventHandler(this.Rehberİngilizce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rehberrDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private RehberrDataSet rehberrDataSet1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthday;
        private DevExpress.XtraGrid.Columns.GridColumn colJob;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone_Number;
        private DevExpress.XtraGrid.Columns.GridColumn colPhonee_Number;
        private DevExpress.XtraGrid.Columns.GridColumn colHome_Adress;
        private DevExpress.XtraGrid.Columns.GridColumn colE_Mail;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoto;
        private RehberrDataSetTableAdapters.RehberrrİngilizceTableAdapter rehberrrİngilizceTableAdapter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.LinkLabel afgf;
    }
}