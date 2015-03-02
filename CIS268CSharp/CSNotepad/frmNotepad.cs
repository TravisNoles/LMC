using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSNotepad
{
    public partial class frmNotepad : Form
    {
        public frmNotepad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int[] NoteTabProperties = {1};
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // if open_document_changed = false
            // then goto newdocument()
            // create new document
            // else
            // display "Do you want to discard all changes?"




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sidebarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NPSidebar.Visible = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
