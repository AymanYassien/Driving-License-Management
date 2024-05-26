using System;
using System.IO;
using System.Windows.Forms;


namespace DriverCarLicences
{
    internal class clsUtil
    {

        // generate guid
        // createfolderif doesnotexist
        // replacefilenamewithguid
        // copy image to projectImageFolder

        public static string generateGUID()
        {
            //Guid guid = new Guid();
            return new Guid().ToString();

        }

        public static bool createFolderIfDoesNotExist(string FolderPath) 
        {
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
                return true;
            }
            return Directory.Exists(FolderPath);
        }

        public static string ReplaceFileNameWithGuid(string srcFile)
        {
            string fileName = srcFile;

            FileInfo f = new FileInfo(fileName);
            string exten = f.Extension;

            return  generateGUID() +  exten;

        }

        public static bool CopyImageToProjectImageFolder(ref string srcFile)
        {
            string destinationfolder = "C:\\Users\\aymanyassien\\source\\repos\\DriverCarLicences\\DriverCarLicences";

            if (!createFolderIfDoesNotExist(destinationfolder))
            {
                return false;
            }
            string destinationfile = destinationfolder + ReplaceFileNameWithGuid(srcFile);

            try
            {
                File.Copy(srcFile, destinationfile, true);
            }
            catch(IOException iox)
            {
                MessageBox.Show(iox.Message, "Error");
                return false;
            }
            srcFile = destinationfile;
            return true;
        }
    }
}
