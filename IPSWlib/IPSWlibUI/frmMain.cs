using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPSWlibUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        IPSWlib.Editor PackageIPSW;

        private void btnOpenIPSW_Click(object sender, EventArgs e)
        {
            OpenFileDialog vOpenFileDialog = new OpenFileDialog();
            DialogResult result = vOpenFileDialog.ShowDialog();
            PackageIPSW = new IPSWlib.Editor(vOpenFileDialog.FileName, "./");
            MessageBox.Show("IPSW file successfully uncompressed");
        }

        private void btnRebuildIPSW_Click(object sender, EventArgs e)
        {
            string PathUnpackedIPSW = "./" + PackageIPSW.getFileNameIPSW();
            string OutputPackageFilePath = "./" + PackageIPSW.getFileNameIPSW() + ".ipsw";
            PackageIPSW.RebuildIPSW(PathUnpackedIPSW, OutputPackageFilePath);
        }

        private void btnListFilesIPSW_Click(object sender, EventArgs e)
        {
            string[] AllFilesIPSW = PackageIPSW.getAllFilesIPSW();
            for (int i = 0; i < AllFilesIPSW.Length; i++)
            {
                lbFilesIPSW.Items.Add(AllFilesIPSW[i]);
            }
        }

        private void btnAddToFLashManifest_Click(object sender, EventArgs e)
        {
            PackageIPSW.AddToFlashManifest("iBootB.n81ap.img3");
        }

        private void btnReadFlashManifest_Click(object sender, EventArgs e)
        {
            PackageIPSW.ReadFlashManifest();
        }
    }
}
