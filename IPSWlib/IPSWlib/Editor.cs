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
        string AllFlashFolder = "";

        public Editor(string pPathIPSW, string pPathUnpackedIPSW)
        {
            PathIPSW = pPathIPSW;
            FileNameIPSW = Path.GetFileName(pPathIPSW);
            FileNameIPSW = FileNameIPSW.Remove(FileNameIPSW.Length - 5, 5);

            pPathUnpackedIPSW = pPathUnpackedIPSW + FileNameIPSW;
            ZipFile.ExtractToDirectory(PathIPSW, pPathUnpackedIPSW);
            PathUnpackedIPSW = pPathUnpackedIPSW;

            AllFilesIPSW = Directory.GetFiles(PathUnpackedIPSW, "*", SearchOption.AllDirectories);

            for (int i = 0; i < AllFilesIPSW.Length; i++)
            {
                if (AllFilesIPSW[i].Contains("manifest"))
                {
                    FlashManifestPath = AllFilesIPSW[i];
                }
            }

            AllFlashFolder = FlashManifestPath.Remove(FlashManifestPath.Length - 8, 8);

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

        public string getVersion()
        {
            string[] SplittedFileName;
            SplittedFileName = FileNameIPSW.Split('_');
            return SplittedFileName[1];
        }

        public string getBuildNumber()
        {
            string[] SplittedFileName;
            SplittedFileName = FileNameIPSW.Split('_');
            return SplittedFileName[2];
        }

        public List<string> ReadFlashManifest()
        {
            string[] FlashManifestArray;
            FlashManifestArray = File.ReadAllLines(FlashManifestPath);
            for (int i = 0; i < FlashManifestArray.Length; i++)
            {
                FlashManifest.Add(FlashManifestArray[i]);
            }
            return FlashManifest;
        }

        public void AddToFlashManifest(string pImageFileName)
        {
            File.AppendAllText(FlashManifestPath, pImageFileName + Environment.NewLine);
        }

        public void AddToAllFlashFolder(string pImageFilePath)
        {
            string ImageFileName = Path.GetFileName(pImageFilePath);
            File.Copy(pImageFilePath, AllFlashFolder + "\\" + ImageFileName);
        }

        public string AddToAllFlashFolder(string pImageFilePath, string pInstanceOS)
        {
            string ImageFileName = Path.GetFileName(pImageFilePath);
            string[] SplittedImageFileName = ImageFileName.Split('.');
            string UpdatedImageFileName = "";
            if (pInstanceOS == "Secondary")
            {
                SplittedImageFileName[0] = SplittedImageFileName[0] + "B";
            }
            else if (pInstanceOS == "Third")
            {
                SplittedImageFileName[0] = SplittedImageFileName[0] + "C";
            }
            else if (pInstanceOS == "Fourth")
            {
                SplittedImageFileName[0] = SplittedImageFileName[0] + "D";
            }

            if (SplittedImageFileName.Length == 3)
            {
                UpdatedImageFileName = SplittedImageFileName[0] + "." + SplittedImageFileName[1] + "." + SplittedImageFileName[2];
            }
            else if (SplittedImageFileName.Length == 4)
            {
                UpdatedImageFileName = SplittedImageFileName[0] + "." + SplittedImageFileName[1] + "." + SplittedImageFileName[2] + "." + SplittedImageFileName[3];
            }

            File.Copy(pImageFilePath, AllFlashFolder + "\\" + UpdatedImageFileName);
            return UpdatedImageFileName;
        }
    }
}
