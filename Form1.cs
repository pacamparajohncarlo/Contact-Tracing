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
            this.Hide();
            Form2 pageforviewingrecords = new Form2();
            pageforviewingrecords.Show();
        }
    }
}
