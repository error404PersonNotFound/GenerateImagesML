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

namespace DrawBot
{
    public partial class GANmain : Form
    {
        public GANmain()
        {
            InitializeComponent();
        }

        private void GANmain_Load(object sender, EventArgs e)
        {
            var testData = new List<string>();
            testData.AddRange(Directory.GetFiles(Constants.TestImagesDirectoryPath));
            TestDataListBox.Items.AddRange(testData.ToArray<string>());
        }

        private void TestDataListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SourceImage.Image = (Bitmap)Image.FromFile(TestDataListBox.SelectedItem.ToString());
            ShowSizeLabel.Text = string.Format("{0} x {1}", SourceImage.Image.Width, SourceImage.Image.Height);
        }

        private void PoolBtn_Click(object sender, EventArgs e)
        {



        }


    }
}
