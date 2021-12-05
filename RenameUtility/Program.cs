using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace RenameUtility
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

    }
    public class FileInfo
    {
        //Первоначальное имя файла
        private string fileName = String.Empty;
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        //Новое имя файла
        private string fileNameNew;
        public string FileNameNew
        {
            get { return fileNameNew; }
            set { fileNameNew = value; }
        }
        //Расширение файла
        private string fileExtension;
        public string FileExtension
        {
            get { return fileExtension; }
            set { fileExtension = value; }
        }
        //Директория файла
        private string fileDirectory;
        public string FileDirectory
        {
            get { return fileDirectory; }
            set { fileDirectory = value; }
        }
        //Подлежит ли файл переименованию
        private bool fileRename;
        public bool FileRename
        {
            get { return fileRename; }
            set { fileRename = value; }
        }
    }
    public class FileInfoCount
    {
        public static BindingList<FileInfo> FileInfoList = new BindingList<FileInfo>();
        //Подлежит ли хотя бы один файл из списка к переименованию.
        public static bool ListRename;
    }

    /// <summary>
    /// Хранение данных формата файла для тегов к видео и изображениям
    /// </summary>
    public static class Extensions
    {
        public static readonly string[] forVideo = new string[] { ".3gp", ".mp4" };
        public static readonly string[] forPicture = new string[] { ".jpg", ".jpeg", ".png" };
    }
}
