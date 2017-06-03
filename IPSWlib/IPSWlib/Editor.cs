using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace IPSWlib
{
    public class Editor
    {
        string PathIPSW = "";
        string FileNameIPSW = "";
        string PathUnpackedIPSW = "";
        string[] AllFilesIPSW;
        List<string> FlashManifest = new List<string>();
        string FlashManifestPath = "";

        public Editor(string pPathIPSW, string pPathUnpackedIPSW)
        {
            PathIPSW = pPathIPSW;
            FileNameIPSW = Path.GetFileName(pPathIPSW);
            FileNameIPSW = FileNameIPSW.Remove(FileNameIPSW.Length - 5, 5);

            pPathUnpackedIPSW = pPathUnpackedIPSW + FileNameIPSW;
            ZipFile.ExtractToDirectory(PathIPSW, pPathUnpackedIPSW);
            PathUnpackedIPSW = pPathUnpackedIPSW;

            AllFilesIPSW = Directory.GetFiles(PathUnpackedIPSW, "*", SearchOption.AllDirectories);
        }

        public void RebuildIPSW(string pPathUnpackedIPSW, string pPathPackedIPSW)
        {
            ZipFile.CreateFromDirectory(pPathUnpackedIPSW, pPathPackedIPSW);
        }

        public string getFileNameIPSW()
        {
            return FileNameIPSW;
        }

        public string[] getAllFilesIPSW()
        {
            return AllFilesIPSW;
        }

        public List<string> ReadFlashManifest()
        {
            string[] FlashManifestArray;
            for (int i = 0; i < AllFilesIPSW.Length; i++)
            {
                if (AllFilesIPSW[i].Contains("manifest"))
                {
                    FlashManifestPath = AllFilesIPSW[i];
                }
            }
            FlashManifestArray = File.ReadAllLines(FlashManifestPath);
            for (int i = 0; i < FlashManifestArray.Length; i++)
            {
                FlashManifest.Add(FlashManifestArray[i]);
            }
            return FlashManifest;
        }

        public void AddToFlashManifest(string pImageFileName)
        {
            File.AppendAllText(FlashManifestPath, pImageFileName);
        }
    }
}
