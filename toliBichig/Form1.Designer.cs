namespace toliBichig
{
    partial class Form1
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
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblLanguage = new Label();
            cmbLanguage = new ComboBox();
            txtEnglsh = new TextBox();
            txtMongolian = new TextBox();
            txtRussian = new TextBox();
            lblEnglish = new Label();
            lblMongolian = new Label();
            lblRussian = new Label();
            btnAdd = new Button();
            btnSave = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            lblCount = new Label();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(24, 21);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(63, 30);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Хайх:";
            lblSearch.Click += label1_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(93, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Хайх үг...";
            txtSearch.Size = new Size(602, 42);
            txtSearch.TabIndex = 1;
            // 
            // lblLanguage
            // 
            lblLanguage.AutoSize = true;
            lblLanguage.Location = new Point(742, 21);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(51, 30);
            lblLanguage.TabIndex = 2;
            lblLanguage.Text = "Хэл:";
            // 
            // cmbLanguage
            // 
            cmbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLanguage.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbLanguage.FormattingEnabled = true;
            cmbLanguage.Items.AddRange(new object[] { "Бүгд", "Англи", "Монгол", "Орос" });
            cmbLanguage.Location = new Point(816, 13);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(174, 44);
            cmbLanguage.TabIndex = 3;
            cmbLanguage.SelectedIndexChanged += cmbLanguage_SelectedIndexChanged;
            // 
            // txtEnglsh
            // 
            txtEnglsh.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEnglsh.Location = new Point(127, 607);
            txtEnglsh.Name = "txtEnglsh";
            txtEnglsh.Size = new Size(175, 51);
            txtEnglsh.TabIndex = 4;
            // 
            // txtMongolian
            // 
            txtMongolian.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMongolian.Location = new Point(490, 607);
            txtMongolian.Name = "txtMongolian";
            txtMongolian.Size = new Size(175, 51);
            txtMongolian.TabIndex = 5;
            // 
            // txtRussian
            // 
            txtRussian.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRussian.Location = new Point(816, 607);
            txtRussian.Name = "txtRussian";
            txtRussian.Size = new Size(175, 51);
            txtRussian.TabIndex = 6;
            // 
            // lblEnglish
            // 
            lblEnglish.AutoSize = true;
            lblEnglish.Location = new Point(51, 620);
            lblEnglish.Name = "lblEnglish";
            lblEnglish.Size = new Size(70, 30);
            lblEnglish.TabIndex = 7;
            lblEnglish.Text = "Англи";
            // 
            // lblMongolian
            // 
            lblMongolian.AutoSize = true;
            lblMongolian.Location = new Point(397, 620);
            lblMongolian.Name = "lblMongolian";
            lblMongolian.Size = new Size(87, 30);
            lblMongolian.TabIndex = 8;
            lblMongolian.Text = "Монгол";
            // 
            // lblRussian
            // 
            lblRussian.AutoSize = true;
            lblRussian.Location = new Point(742, 620);
            lblRussian.Name = "lblRussian";
            lblRussian.Size = new Size(63, 30);
            lblRussian.TabIndex = 9;
            lblRussian.Text = "Орос";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(51, 675);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 57);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "+ Нэмэх ";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Arial", 9.857143F, FontStyle.Bold);
            btnSave.Location = new Point(833, 675);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(158, 57);
            btnSave.TabIndex = 12;
            btnSave.Text = "Санах";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial", 9.857143F, FontStyle.Bold);
            btnClear.Location = new Point(635, 675);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(158, 57);
            btnClear.TabIndex = 13;
            btnClear.Text = "Цэвэрлэх";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial", 9.857143F, FontStyle.Bold);
            btnDelete.Location = new Point(444, 675);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(158, 57);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Устгах";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Arial", 9.857143F, FontStyle.Bold);
            btnEdit.Location = new Point(247, 675);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(158, 57);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Засах";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += button6_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 6.857143F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCount.Location = new Point(12, 755);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(189, 21);
            lblCount.TabIndex = 16;
            lblCount.Text = "Нийт: 0 үг ~ Санасан: 0 \r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1055, 796);
            Controls.Add(lblCount);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(lblRussian);
            Controls.Add(lblMongolian);
            Controls.Add(lblEnglish);
            Controls.Add(txtRussian);
            Controls.Add(txtMongolian);
            Controls.Add(txtEnglsh);
            Controls.Add(cmbLanguage);
            Controls.Add(lblLanguage);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гурван хэлний толь бичиг";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblLanguage;
        private ComboBox cmbLanguage;
        private TextBox txtEnglsh;
        private TextBox txtMongolian;
        private TextBox txtRussian;
        private Label lblEnglish;
        private Label lblMongolian;
        private Label lblRussian;
        private Button btnAdd;
        private Button btnSave;
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private Label lblCount;
    }
}
