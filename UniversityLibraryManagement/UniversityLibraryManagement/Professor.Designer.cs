namespace UniversityLibraryManagement
{
    partial class Professor
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
            this.Search = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lANGUAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMOFPAGESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVAILABLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTHORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_Management_SystemDataSet = new UniversityLibraryManagement.Library_Management_SystemDataSet();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BookName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iD2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDVANCEBORROWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bOOKTableAdapter = new UniversityLibraryManagement.Library_Management_SystemDataSetTableAdapters.BOOKTableAdapter();
            this.aDVANCE_BORROWTableAdapter = new UniversityLibraryManagement.Library_Management_SystemDataSetTableAdapters.ADVANCE_BORROWTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.Search.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_Management_SystemDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDVANCEBORROWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Controls.Add(this.tabPage1);
            this.Search.Controls.Add(this.tabPage2);
            this.Search.Location = new System.Drawing.Point(17, 16);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.SelectedIndex = 0;
            this.Search.Size = new System.Drawing.Size(963, 351);
            this.Search.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.BookName);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(955, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBNDataGridViewTextBoxColumn,
            this.pUBIDDataGridViewTextBoxColumn,
            this.cATIDDataGridViewTextBoxColumn,
            this.tITLEDataGridViewTextBoxColumn,
            this.lANGUAGEDataGridViewTextBoxColumn,
            this.nUMOFPAGESDataGridViewTextBoxColumn,
            this.yEARDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn,
            this.aVAILABLEDataGridViewTextBoxColumn,
            this.aUTHORDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bOOKBindingSource;
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(31, 79);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(663, 224);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            // 
            // pUBIDDataGridViewTextBoxColumn
            // 
            this.pUBIDDataGridViewTextBoxColumn.DataPropertyName = "PUB_ID";
            this.pUBIDDataGridViewTextBoxColumn.HeaderText = "PUB_ID";
            this.pUBIDDataGridViewTextBoxColumn.Name = "pUBIDDataGridViewTextBoxColumn";
            // 
            // cATIDDataGridViewTextBoxColumn
            // 
            this.cATIDDataGridViewTextBoxColumn.DataPropertyName = "CAT_ID";
            this.cATIDDataGridViewTextBoxColumn.HeaderText = "CAT_ID";
            this.cATIDDataGridViewTextBoxColumn.Name = "cATIDDataGridViewTextBoxColumn";
            // 
            // tITLEDataGridViewTextBoxColumn
            // 
            this.tITLEDataGridViewTextBoxColumn.DataPropertyName = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.HeaderText = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.Name = "tITLEDataGridViewTextBoxColumn";
            // 
            // lANGUAGEDataGridViewTextBoxColumn
            // 
            this.lANGUAGEDataGridViewTextBoxColumn.DataPropertyName = "LANGUAGE";
            this.lANGUAGEDataGridViewTextBoxColumn.HeaderText = "LANGUAGE";
            this.lANGUAGEDataGridViewTextBoxColumn.Name = "lANGUAGEDataGridViewTextBoxColumn";
            // 
            // nUMOFPAGESDataGridViewTextBoxColumn
            // 
            this.nUMOFPAGESDataGridViewTextBoxColumn.DataPropertyName = "NUM_OF_PAGES";
            this.nUMOFPAGESDataGridViewTextBoxColumn.HeaderText = "NUM_OF_PAGES";
            this.nUMOFPAGESDataGridViewTextBoxColumn.Name = "nUMOFPAGESDataGridViewTextBoxColumn";
            // 
            // yEARDataGridViewTextBoxColumn
            // 
            this.yEARDataGridViewTextBoxColumn.DataPropertyName = "YEAR";
            this.yEARDataGridViewTextBoxColumn.HeaderText = "YEAR";
            this.yEARDataGridViewTextBoxColumn.Name = "yEARDataGridViewTextBoxColumn";
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            // 
            // aVAILABLEDataGridViewTextBoxColumn
            // 
            this.aVAILABLEDataGridViewTextBoxColumn.DataPropertyName = "AVAILABLE";
            this.aVAILABLEDataGridViewTextBoxColumn.HeaderText = "AVAILABLE";
            this.aVAILABLEDataGridViewTextBoxColumn.Name = "aVAILABLEDataGridViewTextBoxColumn";
            // 
            // aUTHORDataGridViewTextBoxColumn
            // 
            this.aUTHORDataGridViewTextBoxColumn.DataPropertyName = "AUTHOR";
            this.aUTHORDataGridViewTextBoxColumn.HeaderText = "AUTHOR";
            this.aUTHORDataGridViewTextBoxColumn.Name = "aUTHORDataGridViewTextBoxColumn";
            // 
            // bOOKBindingSource
            // 
            this.bOOKBindingSource.DataMember = "BOOK";
            this.bOOKBindingSource.DataSource = this.library_Management_SystemDataSet;
            // 
            // library_Management_SystemDataSet
            // 
            this.library_Management_SystemDataSet.DataSetName = "Library_Management_SystemDataSet";
            this.library_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(161, 29);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 22);
            this.textBox3.TabIndex = 1;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // BookName
            // 
            this.BookName.AutoSize = true;
            this.BookName.Location = new System.Drawing.Point(28, 32);
            this.BookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(77, 17);
            this.BookName.TabIndex = 0;
            this.BookName.Text = "BookName";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(955, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Borrow";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(578, 254);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 12;
            this.button4.Text = "Reload";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iD2DataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.aDVANCEBORROWBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(481, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(325, 215);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iD2DataGridViewTextBoxColumn
            // 
            this.iD2DataGridViewTextBoxColumn.DataPropertyName = "ID2";
            this.iD2DataGridViewTextBoxColumn.HeaderText = "ID2";
            this.iD2DataGridViewTextBoxColumn.Name = "iD2DataGridViewTextBoxColumn";
            // 
            // iSBNDataGridViewTextBoxColumn1
            // 
            this.iSBNDataGridViewTextBoxColumn1.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn1.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn1.Name = "iSBNDataGridViewTextBoxColumn1";
            // 
            // aDVANCEBORROWBindingSource
            // 
            this.aDVANCEBORROWBindingSource.DataMember = "ADVANCE_BORROW";
            this.aDVANCEBORROWBindingSource.DataSource = this.library_Management_SystemDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 133);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Borrow";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(243, 68);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "ISBN";
            // 
            // bOOKTableAdapter
            // 
            this.bOOKTableAdapter.ClearBeforeFill = true;
            // 
            // aDVANCE_BORROWTableAdapter
            // 
            this.aDVANCE_BORROWTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(21, 388);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 38);
            this.button5.TabIndex = 2;
            this.button5.Text = "Log Out";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 438);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Search);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.Search.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_Management_SystemDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDVANCEBORROWBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Search;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label BookName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private Library_Management_SystemDataSet library_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource bOOKBindingSource;
        private Library_Management_SystemDataSetTableAdapters.BOOKTableAdapter bOOKTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lANGUAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMOFPAGESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVAILABLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTHORDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aDVANCEBORROWBindingSource;
        private Library_Management_SystemDataSetTableAdapters.ADVANCE_BORROWTableAdapter aDVANCE_BORROWTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iD2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button5;
    }
}