using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CRUDWinFormsMVPP.Views
{
    public partial class PetView : Form, IPetView
    {
        public PetView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            if (tabControl1.TabPages.Contains(tabPageDetail))
            {
                tabControl1.TabPages.Remove(tabPageDetail);
            }
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };


            btnAddNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                if (tabControl1.TabPages.Contains(tabPageList))
                    tabControl1.TabPages.Remove(tabPageList);
                if (!tabControl1.TabPages.Contains(tabPageDetail))
                    tabControl1.TabPages.Add(tabPageDetail);
                tabPageDetail.Text = "Tambah Hewan Baru";
            };

            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                if (tabControl1.TabPages.Contains(tabPageList))
                    tabControl1.TabPages.Remove(tabPageList);
                if (!tabControl1.TabPages.Contains(tabPageDetail))
                    tabControl1.TabPages.Add(tabPageDetail);
                tabPageDetail.Text = "Edit Data Hewan";
            };

            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    if (tabControl1.TabPages.Contains(tabPageDetail))
                        tabControl1.TabPages.Remove(tabPageDetail);
                    if (!tabControl1.TabPages.Contains(tabPageList))
                        tabControl1.TabPages.Add(tabPageList);
                }
                MessageBox.Show(Message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                if (tabControl1.TabPages.Contains(tabPageDetail))
                    tabControl1.TabPages.Remove(tabPageDetail);
                if (!tabControl1.TabPages.Contains(tabPageList))
                    tabControl1.TabPages.Add(tabPageList);
            };

            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Peringatan",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
        }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PetId { get => txtPetId.Text; set => txtPetId.Text = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PetName { get => txtPetName.Text; set => txtPetName.Text = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PetType { get => txtPetType.Text; set => txtPetType.Text = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PetColour { get => txtPetColour.Text; set => txtPetColour.Text = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SearchValue { get => txtSearch.Text; set => txtSearch.Text = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsEdit { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsSuccessful { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Message { get; set; }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetPetListBindingSource(BindingSource petList)
        {
            dataGridView1.DataSource = petList;
        }

        private void tabPageList_Click(object sender, EventArgs e)
        {
        }

        private void txtPetId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}