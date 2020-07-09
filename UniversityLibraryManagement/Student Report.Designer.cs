namespace UniversityLibraryManagement
{
    partial class Form3
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Library_Management_SystemDataSet = new UniversityLibraryManagement.Library_Management_SystemDataSet();
            this.STUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.STUDENTTableAdapter = new UniversityLibraryManagement.Library_Management_SystemDataSetTableAdapters.STUDENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Library_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STUDENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.STUDENTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UniversityLibraryManagement.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(705, 380);
            this.reportViewer1.TabIndex = 0;
            // 
            // Library_Management_SystemDataSet
            // 
            this.Library_Management_SystemDataSet.DataSetName = "Library_Management_SystemDataSet";
            this.Library_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // STUDENTBindingSource
            // 
            this.STUDENTBindingSource.DataMember = "STUDENT";
            this.STUDENTBindingSource.DataSource = this.Library_Management_SystemDataSet;
            // 
            // STUDENTTableAdapter
            // 
            this.STUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 381);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Library_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STUDENTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource STUDENTBindingSource;
        private Library_Management_SystemDataSet Library_Management_SystemDataSet;
        private Library_Management_SystemDataSetTableAdapters.STUDENTTableAdapter STUDENTTableAdapter;
    }
}