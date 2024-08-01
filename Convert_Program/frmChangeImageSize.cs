using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convert_Program
{
    public partial class frmChangeImageSize : Form
    {
        public frmChangeImageSize()
        {
            InitializeComponent();
        }

        private void frmChangeImageSize_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "Image Files | *.jpg;*.png;*.ico";
                of.Multiselect = true;
                if (of.ShowDialog() == DialogResult.OK)
                {
                    foreach (var i in of.FileNames)
                    {
                        lbxFiles.Items.Add(i);
                    }
                    if (lbxFiles.Items.Count > 0) btnConvert.Enabled = true;
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("New Photo")) Directory.CreateDirectory("New Photo");
            {

            }
            foreach (var i in lbxFiles.Items)
            {
                Bitmap bmp = new Bitmap(Image.FromFile(i + ""), new Size(Convert.ToInt32(nudWidth.Value), Convert.ToInt32(nudHight.Value)));
                bmp.Save("New Photo\\" + Path.GetFileName(i + ""));
            }
        }

    }
}
