namespace UniversityLibraryManagement
{
    partial class Form4
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
            this.PROFFESSORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PROFFESSORTableAdapter = new UniversityLibraryManagement.Library_Management_SystemDataSetTableAdapters.PROFFESSORTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Library_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROFFESSORBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PROFFESSORBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UniversityLibraryManagement.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(707, 379);
            this.reportViewer1.TabIndex = 0;
            // 
            // Library_Management_SystemDataSet
            // 
            this.Library_Management_SystemDataSet.DataSetName = "Library_Management_SystemDataSet";
            this.Library_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PROFFESSORBindingSource
            // 
            this.PROFFESSORBindingSource.DataMember = "PROFFESSOR";
            this.PROFFESSORBindingSource.DataSource = this.Library_Management_SystemDataSet;
            // 
            // PROFFESSORTableAdapter
            // 
            this.PROFFESSORTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 381);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Library_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROFFESSORBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PROFFESSORBindingSource;
        private Library_Management_SystemDataSet Library_Management_SystemDataSet;
        private Library_Management_SystemDataSetTableAdapters.PROFFESSORTableAdapter PROFFESSORTableAdapter;
    }
}