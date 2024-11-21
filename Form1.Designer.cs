namespace phoneBook
{
    partial class PhoneBook
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPhoneBook = new DataGridView();
            btnFirst = new Button();
            btnPrevious = new Button();
            btnLast = new Button();
            btnNext = new Button();
            Apppanel1 = new Panel();
            textMobile = new TextBox();
            textLastName = new TextBox();
            textEmail = new TextBox();
            textFirstName = new TextBox();
            textID = new TextBox();
            labelMobile = new Label();
            labelEmail = new Label();
            labeID = new Label();
            labelLastName = new Label();
            labelFirstName = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPhoneBook).BeginInit();
            Apppanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPhoneBook
            // 
            dgvPhoneBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhoneBook.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPhoneBook.BackgroundColor = SystemColors.InactiveCaption;
            dgvPhoneBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhoneBook.Location = new Point(135, 360);
            dgvPhoneBook.Name = "dgvPhoneBook";
            dgvPhoneBook.ReadOnly = true;
            dgvPhoneBook.RowHeadersWidth = 51;
            dgvPhoneBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhoneBook.Size = new Size(849, 278);
            dgvPhoneBook.TabIndex = 0;
            dgvPhoneBook.CellClick += dgvPhoneBook_CellClick;
            dgvPhoneBook.CellContentClick += dgvPhoneBook_CellClick;
            // 
            // btnFirst
            // 
            btnFirst.BackColor = Color.Green;
            btnFirst.ForeColor = SystemColors.ButtonHighlight;
            btnFirst.Location = new Point(12, 319);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(94, 29);
            btnFirst.TabIndex = 1;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.Green;
            btnPrevious.ForeColor = SystemColors.ButtonHighlight;
            btnPrevious.Location = new Point(12, 382);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 29);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnLast
            // 
            btnLast.BackColor = Color.Green;
            btnLast.ForeColor = SystemColors.ButtonHighlight;
            btnLast.Location = new Point(12, 513);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(94, 29);
            btnLast.TabIndex = 3;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = false;
            btnLast.Click += btnLast_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Green;
            btnNext.ForeColor = SystemColors.ButtonHighlight;
            btnNext.Location = new Point(12, 448);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // Apppanel1
            // 
            Apppanel1.AllowDrop = true;
            Apppanel1.BackColor = Color.Navy;
            Apppanel1.Controls.Add(textMobile);
            Apppanel1.Controls.Add(textLastName);
            Apppanel1.Controls.Add(textEmail);
            Apppanel1.Controls.Add(textFirstName);
            Apppanel1.Controls.Add(textID);
            Apppanel1.Controls.Add(labelMobile);
            Apppanel1.Controls.Add(labelEmail);
            Apppanel1.Controls.Add(labeID);
            Apppanel1.Controls.Add(labelLastName);
            Apppanel1.Controls.Add(labelFirstName);
            Apppanel1.ForeColor = SystemColors.ButtonHighlight;
            Apppanel1.Location = new Point(288, 22);
            Apppanel1.Name = "Apppanel1";
            Apppanel1.Size = new Size(503, 269);
            Apppanel1.TabIndex = 6;
            Apppanel1.Paint += Apppanel1_Paint;
            // 
            // textMobile
            // 
            textMobile.Location = new Point(118, 243);
            textMobile.Multiline = true;
            textMobile.Name = "textMobile";
            textMobile.Size = new Size(236, 34);
            textMobile.TabIndex = 9;
            // 
            // textLastName
            // 
            textLastName.Location = new Point(118, 132);
            textLastName.Multiline = true;
            textLastName.Name = "textLastName";
            textLastName.Size = new Size(236, 34);
            textLastName.TabIndex = 6;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(118, 190);
            textEmail.Multiline = true;
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(236, 34);
            textEmail.TabIndex = 8;
            // 
            // textFirstName
            // 
            textFirstName.Location = new Point(118, 78);
            textFirstName.Multiline = true;
            textFirstName.Name = "textFirstName";
            textFirstName.Size = new Size(236, 31);
            textFirstName.TabIndex = 5;
            // 
            // textID
            // 
            textID.Location = new Point(118, 26);
            textID.Multiline = true;
            textID.Name = "textID";
            textID.Size = new Size(236, 34);
            textID.TabIndex = 7;
            // 
            // labelMobile
            // 
            labelMobile.AutoSize = true;
            labelMobile.Location = new Point(21, 246);
            labelMobile.Name = "labelMobile";
            labelMobile.Size = new Size(56, 20);
            labelMobile.TabIndex = 4;
            labelMobile.Text = "Mobile";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.ForeColor = SystemColors.ButtonHighlight;
            labelEmail.Location = new Point(21, 190);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 3;
            labelEmail.Text = "Email";
            // 
            // labeID
            // 
            labeID.AutoSize = true;
            labeID.ForeColor = SystemColors.ButtonHighlight;
            labeID.Location = new Point(20, 29);
            labeID.Name = "labeID";
            labeID.Size = new Size(79, 20);
            labeID.TabIndex = 2;
            labeID.Text = "Student ID";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.ForeColor = SystemColors.ButtonHighlight;
            labelLastName.Location = new Point(21, 135);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(79, 20);
            labelLastName.TabIndex = 1;
            labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.ForeColor = SystemColors.ButtonHighlight;
            labelFirstName.Location = new Point(20, 81);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(80, 20);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "First Name";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(832, 53);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Green;
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(832, 100);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Green;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(832, 159);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Green;
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(832, 217);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Orchid;
            btnSearch.Location = new Point(135, 312);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(137, 42);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(288, 312);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(503, 44);
            txtSearch.TabIndex = 12;
            // 
            // PhoneBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(983, 638);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(Apppanel1);
            Controls.Add(btnNext);
            Controls.Add(btnLast);
            Controls.Add(btnPrevious);
            Controls.Add(btnFirst);
            Controls.Add(dgvPhoneBook);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "PhoneBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phone Book";
            Load += PhoneBook_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhoneBook).EndInit();
            Apppanel1.ResumeLayout(false);
            Apppanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPhoneBook;
        private Button btnFirst;
        private Button btnPrevious;
        private Button btnLast;
        private Button btnNext;
        private Panel Apppanel1;
        private Label labelMobile;
        private Label labelEmail;
        private Label labeID;
        private Label labelLastName;
        private Label labelFirstName;
        private TextBox textMobile;
        private TextBox textLastName;
        private TextBox textEmail;
        private TextBox textFirstName;
        private TextBox textID;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}
