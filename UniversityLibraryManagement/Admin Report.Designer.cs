namespace UniversityLibraryManagement
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Library_Management_SystemDataSet = new UniversityLibraryManagement.Library_Management_SystemDataSet();
            this.ADMINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ADMINTableAdapter = new UniversityLibraryManagement.Library_Management_SystemDataSetTableAdapters.ADMINTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Library_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ADMINBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ADMINBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UniversityLibraryManagement.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(712, 380);
            this.reportViewer1.TabIndex = 0;
            // 
            // Library_Management_SystemDataSet
            // 
            this.Library_Management_SystemDataSet.DataSetName = "Library_Management_SystemDataSet";
            this.Library_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ADMINBindingSource
            // 
            this.ADMINBindingSource.DataMember = "ADMIN";
            this.ADMINBindingSource.DataSource = this.Library_Management_SystemDataSet;
            // 
            // ADMINTableAdapter
            // 
            this.ADMINTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 381);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Library_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ADMINBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ADMINBindingSource;
        private Library_Management_SystemDataSet Library_Management_SystemDataSet;
        private Library_Management_SystemDataSetTableAdapters.ADMINTableAdapter ADMINTableAdapter;
    }
}