using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAssignment.Views
{
    public partial class BookDetail : Form
    {
        public BookDetail()
        {
            InitializeComponent();
        }

        public BookDetail(dynamic b)
        {
            InitializeComponent();
            textBoxId.Text = b.Id.ToString();
            textBoxName.Text = b.Name;
            textBoxAuthor.Text = b.Author;
            textBoxEdition.Text = b.Edition.ToString();
        }

        private void textBoxSrc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
