﻿namespace LibrarySystem
{
    partial class frmBorrow
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
            this.TabControl2 = new System.Windows.Forms.TabControl();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btn_Bsave = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAccesionNumBorrow = new System.Windows.Forms.TextBox();
            this.lblAccessionNumBorrow = new System.Windows.Forms.Label();
            this.txtbooktype = new System.Windows.Forms.TextBox();
            this.txtpublisher = new System.Windows.Forms.TextBox();
            this.txtDatePublish = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.grp_Bgroup = new System.Windows.Forms.GroupBox();
            this.txtBorrowerId = new System.Windows.Forms.TextBox();
            this.cboPurpose = new System.Windows.Forms.ComboBox();
            this.txtdue = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.dtg_BlistOfBooks = new System.Windows.Forms.DataGridView();
            this.check_due = new System.Windows.Forms.Timer(this.components);
            this.TabControl2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.grp_Bgroup.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_BlistOfBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl2
            // 
            this.TabControl2.Controls.Add(this.TabPage3);
            this.TabControl2.Controls.Add(this.TabPage4);
            this.TabControl2.Location = new System.Drawing.Point(18, 18);
            this.TabControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(1258, 675);
            this.TabControl2.TabIndex = 22;
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.btnClose);
            this.TabPage3.Controls.Add(this.btnNew);
            this.TabPage3.Controls.Add(this.btn_Bsave);
            this.TabPage3.Controls.Add(this.GroupBox1);
            this.TabPage3.Controls.Add(this.grp_Bgroup);
            this.TabPage3.Location = new System.Drawing.Point(4, 29);
            this.TabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPage3.Size = new System.Drawing.Size(1250, 642);
            this.TabPage3.TabIndex = 0;
            this.TabPage3.Text = "Details";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1047, 445);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(174, 60);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(864, 445);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(174, 60);
            this.btnNew.TabIndex = 17;
            this.btnNew.Text = "Clear";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btn_Bsave
            // 
            this.btn_Bsave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bsave.Location = new System.Drawing.Point(682, 445);
            this.btn_Bsave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Bsave.Name = "btn_Bsave";
            this.btn_Bsave.Size = new System.Drawing.Size(174, 60);
            this.btn_Bsave.TabIndex = 17;
            this.btn_Bsave.Text = "Borrow";
            this.btn_Bsave.UseVisualStyleBackColor = true;
            this.btn_Bsave.Click += new System.EventHandler(this.btn_Bsave_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtAccesionNumBorrow);
            this.GroupBox1.Controls.Add(this.lblAccessionNumBorrow);
            this.GroupBox1.Controls.Add(this.txtbooktype);
            this.GroupBox1.Controls.Add(this.txtpublisher);
            this.GroupBox1.Controls.Add(this.txtDatePublish);
            this.GroupBox1.Controls.Add(this.txtTitle);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.txtAuthor);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label12);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(22, 40);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Size = new System.Drawing.Size(586, 448);
            this.GroupBox1.TabIndex = 14;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Book\'s Details";
            // 
            // txtAccesionNumBorrow
            // 
            this.txtAccesionNumBorrow.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAccesionNumBorrow.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAccesionNumBorrow.Location = new System.Drawing.Point(177, 77);
            this.txtAccesionNumBorrow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccesionNumBorrow.Name = "txtAccesionNumBorrow";
            this.txtAccesionNumBorrow.Size = new System.Drawing.Size(373, 33);
            this.txtAccesionNumBorrow.TabIndex = 17;
            this.txtAccesionNumBorrow.TextChanged += new System.EventHandler(this.txtAccesionNumBorrow_TextChanged);
            // 
            // lblAccessionNumBorrow
            // 
            this.lblAccessionNumBorrow.AutoSize = true;
            this.lblAccessionNumBorrow.Location = new System.Drawing.Point(22, 80);
            this.lblAccessionNumBorrow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccessionNumBorrow.Name = "lblAccessionNumBorrow";
            this.lblAccessionNumBorrow.Size = new System.Drawing.Size(142, 28);
            this.lblAccessionNumBorrow.TabIndex = 16;
            this.lblAccessionNumBorrow.Text = "Accession No. :";
            // 
            // txtbooktype
            // 
            this.txtbooktype.Enabled = false;
            this.txtbooktype.Location = new System.Drawing.Point(177, 323);
            this.txtbooktype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbooktype.Name = "txtbooktype";
            this.txtbooktype.Size = new System.Drawing.Size(373, 33);
            this.txtbooktype.TabIndex = 14;
            // 
            // txtpublisher
            // 
            this.txtpublisher.Enabled = false;
            this.txtpublisher.Location = new System.Drawing.Point(177, 275);
            this.txtpublisher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpublisher.Name = "txtpublisher";
            this.txtpublisher.Size = new System.Drawing.Size(373, 33);
            this.txtpublisher.TabIndex = 14;
            // 
            // txtDatePublish
            // 
            this.txtDatePublish.Enabled = false;
            this.txtDatePublish.Location = new System.Drawing.Point(177, 228);
            this.txtDatePublish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDatePublish.Name = "txtDatePublish";
            this.txtDatePublish.Size = new System.Drawing.Size(373, 33);
            this.txtDatePublish.TabIndex = 14;
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(177, 129);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(373, 33);
            this.txtTitle.TabIndex = 13;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(21, 328);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(143, 28);
            this.Label6.TabIndex = 11;
            this.Label6.Text = "Type of Books :";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Location = new System.Drawing.Point(177, 180);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(373, 33);
            this.txtAuthor.TabIndex = 13;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(66, 280);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(101, 28);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Publisher :";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(38, 232);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(130, 28);
            this.Label12.TabIndex = 11;
            this.Label12.Text = "Date Publish :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(110, 129);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 28);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Title :";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(87, 185);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(82, 28);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Author :";
            // 
            // grp_Bgroup
            // 
            this.grp_Bgroup.Controls.Add(this.txtBorrowerId);
            this.grp_Bgroup.Controls.Add(this.cboPurpose);
            this.grp_Bgroup.Controls.Add(this.txtdue);
            this.grp_Bgroup.Controls.Add(this.txtCourse);
            this.grp_Bgroup.Controls.Add(this.txtName);
            this.grp_Bgroup.Controls.Add(this.Label15);
            this.grp_Bgroup.Controls.Add(this.Label13);
            this.grp_Bgroup.Controls.Add(this.Label7);
            this.grp_Bgroup.Controls.Add(this.Label17);
            this.grp_Bgroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Bgroup.Location = new System.Drawing.Point(651, 85);
            this.grp_Bgroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_Bgroup.Name = "grp_Bgroup";
            this.grp_Bgroup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_Bgroup.Size = new System.Drawing.Size(570, 351);
            this.grp_Bgroup.TabIndex = 15;
            this.grp_Bgroup.TabStop = false;
            this.grp_Bgroup.Text = "Borrower\'s";
            // 
            // txtBorrowerId
            // 
            this.txtBorrowerId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBorrowerId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBorrowerId.Location = new System.Drawing.Point(168, 92);
            this.txtBorrowerId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBorrowerId.Name = "txtBorrowerId";
            this.txtBorrowerId.Size = new System.Drawing.Size(367, 33);
            this.txtBorrowerId.TabIndex = 24;
            this.txtBorrowerId.TextChanged += new System.EventHandler(this.txtBorrowerId_TextChanged);
            // 
            // cboPurpose
            // 
            this.cboPurpose.FormattingEnabled = true;
            this.cboPurpose.Items.AddRange(new object[] {
            "Overnight",
            "Research",
            "Photocopy"});
            this.cboPurpose.Location = new System.Drawing.Point(168, 235);
            this.cboPurpose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboPurpose.Name = "cboPurpose";
            this.cboPurpose.Size = new System.Drawing.Size(367, 36);
            this.cboPurpose.TabIndex = 22;
            this.cboPurpose.Text = "Select";
            // 
            // txtdue
            // 
            this.txtdue.Location = new System.Drawing.Point(440, 235);
            this.txtdue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdue.Name = "txtdue";
            this.txtdue.Size = new System.Drawing.Size(58, 33);
            this.txtdue.TabIndex = 18;
            // 
            // txtCourse
            // 
            this.txtCourse.Enabled = false;
            this.txtCourse.Location = new System.Drawing.Point(168, 188);
            this.txtCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(367, 33);
            this.txtCourse.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(168, 140);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(367, 33);
            this.txtName.TabIndex = 20;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(64, 240);
            this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(92, 28);
            this.Label15.TabIndex = 18;
            this.Label15.Text = "Purpose :";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(27, 192);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(130, 28);
            this.Label13.TabIndex = 16;
            this.Label13.Text = "Year/Section :";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(33, 97);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(123, 28);
            this.Label7.TabIndex = 10;
            this.Label7.Text = "Borrower Id :";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.Location = new System.Drawing.Point(84, 145);
            this.Label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(73, 28);
            this.Label17.TabIndex = 14;
            this.Label17.Text = "Name :";
            // 
            // TabPage4
            // 
            this.TabPage4.Controls.Add(this.GroupBox6);
            this.TabPage4.Location = new System.Drawing.Point(4, 29);
            this.TabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPage4.Size = new System.Drawing.Size(1250, 642);
            this.TabPage4.TabIndex = 1;
            this.TabPage4.Text = "Borrowed Books";
            this.TabPage4.UseVisualStyleBackColor = true;
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.Label2);
            this.GroupBox6.Controls.Add(this.txt_Search);
            this.GroupBox6.Controls.Add(this.dtg_BlistOfBooks);
            this.GroupBox6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox6.Location = new System.Drawing.Point(9, 9);
            this.GroupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox6.Size = new System.Drawing.Size(1228, 603);
            this.GroupBox6.TabIndex = 16;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "List Of Borrowed Books";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(642, 43);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(105, 36);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Search :";
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.White;
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(760, 37);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(457, 42);
            this.txt_Search.TabIndex = 1;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // dtg_BlistOfBooks
            // 
            this.dtg_BlistOfBooks.AllowUserToAddRows = false;
            this.dtg_BlistOfBooks.AllowUserToDeleteRows = false;
            this.dtg_BlistOfBooks.AllowUserToResizeColumns = false;
            this.dtg_BlistOfBooks.AllowUserToResizeRows = false;
            this.dtg_BlistOfBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_BlistOfBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_BlistOfBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_BlistOfBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_BlistOfBooks.Location = new System.Drawing.Point(9, 94);
            this.dtg_BlistOfBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtg_BlistOfBooks.Name = "dtg_BlistOfBooks";
            this.dtg_BlistOfBooks.RowHeadersVisible = false;
            this.dtg_BlistOfBooks.RowHeadersWidth = 62;
            this.dtg_BlistOfBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_BlistOfBooks.Size = new System.Drawing.Size(1210, 500);
            this.dtg_BlistOfBooks.TabIndex = 0;
            // 
            // check_due
            // 
            this.check_due.Tick += new System.EventHandler(this.check_due_Tick);
            // 
            // frmBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 708);
            this.Controls.Add(this.TabControl2);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBorrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow Books";
            this.Load += new System.EventHandler(this.frmBorrow_Load);
            this.TabControl2.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.grp_Bgroup.ResumeLayout(false);
            this.grp_Bgroup.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_BlistOfBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl2;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button btn_Bsave;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtAccesionNumBorrow;
        internal System.Windows.Forms.Label lblAccessionNumBorrow;
        internal System.Windows.Forms.TextBox txtbooktype;
        internal System.Windows.Forms.TextBox txtpublisher;
        internal System.Windows.Forms.TextBox txtDatePublish;
        internal System.Windows.Forms.TextBox txtTitle;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtAuthor;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.GroupBox grp_Bgroup;
        internal System.Windows.Forms.TextBox txtBorrowerId;
        internal System.Windows.Forms.ComboBox cboPurpose;
        internal System.Windows.Forms.TextBox txtdue;
        internal System.Windows.Forms.TextBox txtCourse;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.TabPage TabPage4;
        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txt_Search;
        internal System.Windows.Forms.DataGridView dtg_BlistOfBooks;
        internal System.Windows.Forms.Timer check_due;
    }
}