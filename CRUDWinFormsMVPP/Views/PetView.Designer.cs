namespace CRUDWinFormsMVPP.Views
{
    partial class PetView
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
            tabControl1 = new TabControl();
            tabPageList = new TabPage();
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAddNew = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            tabPageDetail = new TabPage();
            btnCancel = new Button();
            btnSave = new Button();
            txtPetColour = new TextBox();
            txtPetType = new TextBox();
            txtPetName = new TextBox();
            txtPetId = new TextBox();
            tabControl1.SuspendLayout();
            tabPageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPageDetail.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageList);
            tabControl1.Controls.Add(tabPageDetail);
            tabControl1.Location = new Point(12, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 262);
            tabControl1.TabIndex = 0;
            // 
            // tabPageList
            // 
            tabPageList.Controls.Add(dataGridView1);
            tabPageList.Controls.Add(btnDelete);
            tabPageList.Controls.Add(btnEdit);
            tabPageList.Controls.Add(btnAddNew);
            tabPageList.Controls.Add(btnSearch);
            tabPageList.Controls.Add(txtSearch);
            tabPageList.Location = new Point(4, 24);
            tabPageList.Name = "tabPageList";
            tabPageList.Padding = new Padding(3);
            tabPageList.Size = new Size(768, 234);
            tabPageList.TabIndex = 0;
            tabPageList.Text = "tabPageList";
            tabPageList.UseVisualStyleBackColor = true;
            tabPageList.Click += tabPageList_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(214, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(548, 222);
            dataGridView1.TabIndex = 6;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(6, 119);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(6, 90);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(6, 61);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(75, 23);
            btnAddNew.TabIndex = 2;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(6, 32);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(6, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 0;
            // 
            // tabPageDetail
            // 
            tabPageDetail.Controls.Add(btnCancel);
            tabPageDetail.Controls.Add(btnSave);
            tabPageDetail.Controls.Add(txtPetColour);
            tabPageDetail.Controls.Add(txtPetType);
            tabPageDetail.Controls.Add(txtPetName);
            tabPageDetail.Controls.Add(txtPetId);
            tabPageDetail.Location = new Point(4, 24);
            tabPageDetail.Name = "tabPageDetail";
            tabPageDetail.Padding = new Padding(3);
            tabPageDetail.Size = new Size(768, 234);
            tabPageDetail.TabIndex = 1;
            tabPageDetail.Text = "tabPageDetail";
            tabPageDetail.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(6, 151);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(6, 122);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtPetColour
            // 
            txtPetColour.Location = new Point(6, 93);
            txtPetColour.Name = "txtPetColour";
            txtPetColour.Size = new Size(100, 23);
            txtPetColour.TabIndex = 3;
            txtPetColour.Text = "warna";
            // 
            // txtPetType
            // 
            txtPetType.Location = new Point(6, 64);
            txtPetType.Name = "txtPetType";
            txtPetType.Size = new Size(100, 23);
            txtPetType.TabIndex = 2;
            txtPetType.Text = "Tipe";
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(6, 35);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(100, 23);
            txtPetName.TabIndex = 1;
            txtPetName.Text = "Nama";
            // 
            // txtPetId
            // 
            txtPetId.Location = new Point(6, 6);
            txtPetId.Name = "txtPetId";
            txtPetId.Size = new Size(100, 23);
            txtPetId.TabIndex = 0;
            txtPetId.Text = "ID";
            txtPetId.TextChanged += txtPetId_TextChanged;
            // 
            // PetView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "PetView";
            Text = "PetView";
            tabControl1.ResumeLayout(false);
            tabPageList.ResumeLayout(false);
            tabPageList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPageDetail.ResumeLayout(false);
            tabPageDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageList;
        private TabPage tabPageDetail;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAddNew;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtPetColour;
        private TextBox txtPetType;
        private TextBox txtPetName;
        private TextBox txtPetId;
    }
}