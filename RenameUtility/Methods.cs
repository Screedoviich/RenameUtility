using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RenameUtility
{
    public class Methods
    {
        /// <summary>
        /// Проверка, выбрана ли папка. Отчистка таблицы, если папка выбрана.
        /// </summary>
        /// <param name="openFolder">Объект открытия папки.</param>
        /// <param name="TextBoxFolder">Заданное текстовое поле.</param>
        /// <param name="ProgressBar">Заданная шкала прогресса.</param>
        public void CheckedSetFolder(FolderBrowserDialog openFolder, TextBox TextBoxFolder, ProgressBar ProgressBar)
        {
            if (openFolder.SelectedPath.Length != 0)
            {
                FileInfoCount.FileInfoList.Clear();
                ProgressBar.Value = 0;
                string directory = TextBoxFolder.Text = openFolder.SelectedPath;
                SetNameAndExtension(directory);
            }
            else
            {
                MessageBox.Show("Вы не выбрали папку", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// Принимает директорию и устанавливает значение в свойства.
        /// </summary>
        /// <param name="directory">Директория.</param>
        public void SetNameAndExtension(string directory)
        {
            string[] nameAllFiles = Directory.GetFiles(directory);
            for(int i = 0; i < nameAllFiles.Length; i++)
            {
                var strBuildName = new StringBuilder();
                var strBuildExtension = new StringBuilder();
                FileInfoCount.FileInfoList.Add(new FileInfo()); 
                strBuildName.Append(nameAllFiles[i]); //Запись текущего имени файла
                strBuildName.Remove(0, directory.Length + 1); //Удаление директории из имени файла
                strBuildExtension.Append(strBuildName.ToString()); //Запись имени в другую переменную для установки расширения
                strBuildName.Remove(strBuildName.ToString().LastIndexOf('.'), strBuildName.Length - strBuildName.ToString().LastIndexOf('.')); //Удаление "расширения" для имени файла
                strBuildExtension.Remove(0, strBuildExtension.ToString().LastIndexOf('.')); // Удаление имени файла для имени расширения
                FileInfoCount.FileInfoList[i].FileExtension = strBuildExtension.ToString();
                FileInfoCount.FileInfoList[i].FileName = strBuildName.ToString();
                FileInfoCount.FileInfoList[i].FileDirectory = directory + @"\";
            }
        }
        /// <summary>
        /// Метод проверяет, является ли выбранный файл фотографией или видеозаписью.
        /// </summary>
        /// <param name="fileName">Имя файла.</param>
        /// <returns>Истинное или ложное значение.</returns>
        public bool Checked(string fileName)
        {
            if ((fileName.Length > 18) && ((fileName.Contains("IMG")) || (fileName.Contains("VID"))))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Возвращает редактированное значение имени файла.
        /// </summary>
        /// <param name="fileName">Изначальное имя файла.</param>
        /// <returns>Редактированное имя файла.</returns>
        public string ChangeName(string fileName)
        {
            var strBuildName = new StringBuilder();
            strBuildName.Append(fileName);
            strBuildName.Replace("IMG_", String.Empty);
            strBuildName.Replace("VID_", String.Empty);
            strBuildName.Insert(4, ".");
            strBuildName.Insert(7, ".");
            strBuildName.Insert(13, "-");
            strBuildName.Insert(16, "-");
            return strBuildName.ToString();
        }
        public void SaveIn(FolderBrowserDialog openFolder, FormSave formSave)
        {
            string fromSave;
            string whereSave;
            formSave.ProgressBarSave.Maximum = ChangesCount();
            if (openFolder.SelectedPath.Length != 0)
            {
                for (int i = 0; i < FileInfoCount.FileInfoList.Count; i++)
                {
                    if (FileInfoCount.FileInfoList[i].FileRename)
                    {
                        fromSave = FileInfoCount.FileInfoList[i].FileDirectory + FileInfoCount.FileInfoList[i].FileName + FileInfoCount.FileInfoList[i].FileExtension;
                        whereSave = openFolder.SelectedPath + @"\" + FileInfoCount.FileInfoList[i].FileNameNew + FileInfoCount.FileInfoList[i].FileExtension;
                        File.Copy(fromSave, whereSave);
                        formSave.ProgressBarSave.Value++;
                        formSave.LabelSave.Text = whereSave;
                        formSave.Refresh();
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали папку", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public int ChangesCount()
        {
            int tempCount = 0;
            for (int i = 0; i < FileInfoCount.FileInfoList.Count; i++)
            {
                if (FileInfoCount.FileInfoList[i].FileRename)
                {
                    tempCount++;
                }
            }
            return tempCount;
        }
    }
}
