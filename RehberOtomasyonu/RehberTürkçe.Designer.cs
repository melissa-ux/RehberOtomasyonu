namespace RehberOtomasyonu
{
    partial class RehberTürkçe
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.rehberrrTürkçeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rehberrDataSet1 = new RehberOtomasyonu.RehberrDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colİsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyisim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoğum_Tarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMeslek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon_Numarası = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefonn_Numarası = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEv_Adresi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colE_Mail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFotoğraf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rehberrrTürkçeTableAdapter1 = new RehberOtomasyonu.RehberrDataSetTableAdapters.RehberrrTürkçeTableAdapter();
            this.afgf = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rehberrrTürkçeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rehberrDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.rehberrrTürkçeBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 52);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1114, 595);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // rehberrrTürkçeBindingSource
            // 
            this.rehberrrTürkçeBindingSource.DataMember = "RehberrrTürkçe";
            this.rehberrrTürkçeBindingSource.DataSource = this.rehberrDataSet1;
            // 
            // rehberrDataSet1
            // 
            this.rehberrDataSet1.DataSetName = "RehberrDataSet";
            this.rehberrDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colİsim,
            this.colSoyisim,
            this.colDoğum_Tarihi,
            this.colMeslek,
            this.colTelefon_Numarası,
            this.colTelefonn_Numarası,
            this.colEv_Adresi,
            this.colE_Mail,
            this.colFotoğraf});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colİsim
            // 
            this.colİsim.FieldName = "İsim";
            this.colİsim.Name = "colİsim";
            this.colİsim.Visible = true;
            this.colİsim.VisibleIndex = 0;
            // 
            // colSoyisim
            // 
            this.colSoyisim.FieldName = "Soyisim";
            this.colSoyisim.Name = "colSoyisim";
            this.colSoyisim.Visible = true;
            this.colSoyisim.VisibleIndex = 1;
            // 
            // colDoğum_Tarihi
            // 
            this.colDoğum_Tarihi.FieldName = "Doğum_Tarihi";
            this.colDoğum_Tarihi.Name = "colDoğum_Tarihi";
            this.colDoğum_Tarihi.Visible = true;
            this.colDoğum_Tarihi.VisibleIndex = 2;
            // 
            // colMeslek
            // 
            this.colMeslek.FieldName = "Meslek";
            this.colMeslek.Name = "colMeslek";
            this.colMeslek.Visible = true;
            this.colMeslek.VisibleIndex = 3;
            // 
            // colTelefon_Numarası
            // 
            this.colTelefon_Numarası.FieldName = "Telefon_Numarası";
            this.colTelefon_Numarası.Name = "colTelefon_Numarası";
            this.colTelefon_Numarası.Visible = true;
            this.colTelefon_Numarası.VisibleIndex = 4;
            // 
            // colTelefonn_Numarası
            // 
            this.colTelefonn_Numarası.FieldName = "Telefonn_Numarası";
            this.colTelefonn_Numarası.Name = "colTelefonn_Numarası";
            this.colTelefonn_Numarası.Visible = true;
            this.colTelefonn_Numarası.VisibleIndex = 5;
            // 
            // colEv_Adresi
            // 
            this.colEv_Adresi.FieldName = "Ev_Adresi";
            this.colEv_Adresi.Name = "colEv_Adresi";
            this.colEv_Adresi.Visible = true;
            this.colEv_Adresi.VisibleIndex = 6;
            // 
            // colE_Mail
            // 
            this.colE_Mail.FieldName = "E_Mail";
            this.colE_Mail.Name = "colE_Mail";
            this.colE_Mail.Visible = true;
            this.colE_Mail.VisibleIndex = 7;
            // 
            // colFotoğraf
            // 
            this.colFotoğraf.FieldName = "Fotoğraf";
            this.colFotoğraf.Name = "colFotoğraf";
            this.colFotoğraf.Visible = true;
            this.colFotoğraf.VisibleIndex = 8;
            // 
            // rehberrrTürkçeTableAdapter1
            // 
            this.rehberrrTürkçeTableAdapter1.ClearBeforeFill = true;
            // 
            // afgf
            // 
            this.afgf.AutoSize = true;
            this.afgf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.afgf.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.afgf.Location = new System.Drawing.Point(9, 24);
            this.afgf.Name = "afgf";
            this.afgf.Size = new System.Drawing.Size(111, 15);
            this.afgf.TabIndex = 1;
            this.afgf.TabStop = true;
            this.afgf.Text = "Telefon Rehberiniz";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1145, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::RehberOtomasyonu.Properties.Resources.refresh_32x32;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuItem2.Text = "Yenile";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // RehberTürkçe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 659);
            this.Controls.Add(this.afgf);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "RehberTürkçe";
            this.Text = "RehberTürkçe";
            this.Load += new System.EventHandler(this.RehberTürkçe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rehberrrTürkçeBindingSource)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colİsim;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyisim;
        private DevExpress.XtraGrid.Columns.GridColumn colDoğum_Tarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colMeslek;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon_Numarası;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefonn_Numarası;
        private DevExpress.XtraGrid.Columns.GridColumn colEv_Adresi;
        private DevExpress.XtraGrid.Columns.GridColumn colE_Mail;
        private DevExpress.XtraGrid.Columns.GridColumn colFotoğraf;
        private RehberrDataSetTableAdapters.RehberrrTürkçeTableAdapter rehberrrTürkçeTableAdapter1;
        private System.Windows.Forms.LinkLabel afgf;
        private System.Windows.Forms.BindingSource rehberrrTürkçeBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}