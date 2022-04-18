using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pdfOkuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog dosyaAc = new OpenFileDialog();
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                axAcroPDF1.LoadFile(dosyaAc.FileName);
            }
        }
    }
}
