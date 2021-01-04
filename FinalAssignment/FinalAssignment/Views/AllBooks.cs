using FinalAssignment.Controllers;
using FinalAssignment.Models;
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
    public partial class AllBooks : Form
    {
        public AllBooks()
        {
            InitializeComponent();
            dataGridViewSrc.DataSource = BookController.GetAllBooks();
        }

        private void buttonSrc_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSrc_TextChanged(object sender, EventArgs e)
        {
            dataGridViewSrc.DataSource = BookController.SearchBook(textBoxSrc.Text);
        }

        private void dataGridViewSrc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Book b = new Book();
            b.Id = Int32.Parse(this.dataGridViewSrc.CurrentRow.Cells[0].Value.ToString());
            b.Name = this.dataGridViewSrc.CurrentRow.Cells[1].Value.ToString();
            b.Author = this.dataGridViewSrc.CurrentRow.Cells[2].Value.ToString();
            b.Edition = Int32.Parse(this.dataGridViewSrc.CurrentRow.Cells[3].Value.ToString());
            new BookDetail(b).Show();
        }
    }
}
