namespace UniversityLibraryManagement
{
    partial class Student
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sTUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTARTDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bORROWEDBYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bOOKTableAdapter = new UniversityLibraryManagement.Library_Management_SystemDataSetTableAdapters.BOOKTableAdapter();
            this.bORROWED_BYTableAdapter = new UniversityLibraryManagement.Library_Management_SystemDataSetTableAdapters.BORROWED_BYTableAdapter();
            this.Home = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_Management_SystemDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bORROWEDBYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1176, 477);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackgroundImage = global::UniversityLibraryManagement.Properties.Resources.milky_way_2695569_960_720;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1168, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(866, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 50);
            this.button1.TabIndex = 28;
            this.button1.Text = "Books By Publishers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.bOOKBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(53, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 347);
            this.dataGridView1.TabIndex = 27;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(192, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 22);
            this.textBox2.TabIndex = 25;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightYellow;
            this.label2.Location = new System.Drawing.Point(50, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Book Name";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::UniversityLibraryManagement.Properties.Resources.milky_way_2695569_960_720;
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1168, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Borrow";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(578, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 41);
            this.button3.TabIndex = 11;
            this.button3.Text = "Update Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTUIDDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn1,
            this.sTARTDATEDataGridViewTextBoxColumn,
            this.eNDDATEDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bORROWEDBYBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(377, 11);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(577, 364);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // sTUIDDataGridViewTextBoxColumn
            // 
            this.sTUIDDataGridViewTextBoxColumn.DataPropertyName = "STU_ID";
            this.sTUIDDataGridViewTextBoxColumn.HeaderText = "STU_ID";
            this.sTUIDDataGridViewTextBoxColumn.Name = "sTUIDDataGridViewTextBoxColumn";
            // 
            // iSBNDataGridViewTextBoxColumn1
            // 
            this.iSBNDataGridViewTextBoxColumn1.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn1.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn1.Name = "iSBNDataGridViewTextBoxColumn1";
            // 
            // sTARTDATEDataGridViewTextBoxColumn
            // 
            this.sTARTDATEDataGridViewTextBoxColumn.DataPropertyName = "START_DATE";
            this.sTARTDATEDataGridViewTextBoxColumn.HeaderText = "START_DATE";
            this.sTARTDATEDataGridViewTextBoxColumn.Name = "sTARTDATEDataGridViewTextBoxColumn";
            // 
            // eNDDATEDataGridViewTextBoxColumn
            // 
            this.eNDDATEDataGridViewTextBoxColumn.DataPropertyName = "END_DATE";
            this.eNDDATEDataGridViewTextBoxColumn.HeaderText = "END_DATE";
            this.eNDDATEDataGridViewTextBoxColumn.Name = "eNDDATEDataGridViewTextBoxColumn";
            // 
            // bORROWEDBYBindingSource
            // 
            this.bORROWEDBYBindingSource.DataMember = "BORROWED_BY";
            this.bORROWEDBYBindingSource.DataSource = this.library_Management_SystemDataSet;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 54);
            this.button2.TabIndex = 7;
            this.button2.Text = "Borrow";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "ISBN";
            // 
            // bOOKTableAdapter
            // 
            this.bOOKTableAdapter.ClearBeforeFill = true;
            // 
            // bORROWED_BYTableAdapter
            // 
            this.bORROWED_BYTableAdapter.ClearBeforeFill = true;
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(12, 485);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(114, 52);
            this.Home.TabIndex = 2;
            this.Home.Text = "Log Out";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 549);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.tabControl1);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_Management_SystemDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bORROWEDBYBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.BindingSource bORROWEDBYBindingSource;
        private Library_Management_SystemDataSetTableAdapters.BORROWED_BYTableAdapter bORROWED_BYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTARTDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button button3;
    }
}