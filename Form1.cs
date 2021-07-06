using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Savebttn_Click(object sender, EventArgs e)
        {
            contactTracingRecordsBindingSource.AddNew();
        }

        private void No3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxpurpose_TextChanged(object sender, EventArgs e)
        {

        }

        private void Viewrecords_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 mainform = new Form2();
            mainform.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Contact_Tracing_Records' table. You can move, or remove it, as needed.
            this.contact_Tracing_RecordsTableAdapter.Fill(this.database1DataSet.Contact_Tracing_Records);

        }
    }
}
