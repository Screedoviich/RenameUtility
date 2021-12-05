using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RenameUtility
{
    public class Methods
    {
        /// <summary>
        /// Проверка, выбрана ли папка. Очистка таблицы, если папка выбрана.
        /// </summary>
        /// <param name="openFolder">Путь к папке.</param>
        /// <param name="TextBoxFolder">Заданное текстовое поле.</param>
        public bool CheckedSetFolder(string openFolderPath, TextBox TextBoxFolder)
        {
            if (openFolderPath.Length > 0)
            {
                FileInfoCount.FileInfoList.Clear();
                string directory = TextBoxFolder.Text = openFolderPath;
                SetNameAndExtension(directory);
                return true;
            }
            else
            {
                return false;
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
                //Запись текущего имени файла
                strBuildName.Append(nameAllFiles[i]);
                //Удаление директории из имени файла
                strBuildName.Remove(0, directory.Length + 1);
                //Запись имени в другую переменную для установки расширения
                strBuildExtension.Append(strBuildName.ToString());
                //Удаление "расширения" для имени файла
                strBuildName.Remove(strBuildName.ToString().LastIndexOf('.'), strBuildName.Length - strBuildName.ToString().LastIndexOf('.'));
                // Удаление имени файла для имени расширения
                strBuildExtension.Remove(0, strBuildExtension.ToString().LastIndexOf('.')); 

                FileInfoCount.FileInfoList[i].FileExtension = strBuildExtension.ToString();
                FileInfoCount.FileInfoList[i].FileName = strBuildName.ToString();
                FileInfoCount.FileInfoList[i].FileDirectory = directory + @"\";
            }
        }

        /// <summary>
        /// Проверка, является ли файл изображением или видео, которое подлежит к переименованию.
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <returns>Необходимость переименования файла.</returns>
        public bool Checked(string fileName, string extension)
        {
            try
            {
                //В массив отправлять все известные общие теги для файлов.
                string[] tagsChecked = new string[] { "IMG_", "VID_", "PXL_", "PixelCam_Plus_" };
                //Никому не нужно знать, что здесь происходит. Давайте представим, что здесь очень хитрый алгоритм проверки. Необходим рефакторинг.
                if ((Array.IndexOf(Extensions.forPicture, extension) != -1) || (Array.IndexOf(Extensions.forVideo, extension) != -1))
                {
                    
                    if (Array.IndexOf(tagsChecked, fileName.Substring(0, 4)) != -1)
                    {
                        return true;
                    }
                    else if (Array.IndexOf(tagsChecked, fileName.Substring(0, 14)) != -1)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Возвращает изменённое имя в соответствии с настройками.
        /// </summary>
        /// <param name="fileName">Начальное имя.</param>
        /// <param name="tagsChecked">Необходимость добавления меток.</param>
        /// <param name="tagPhoto">Тег для фото.</param>
        /// <param name="tagVideo">Тег для видео.</param>
        /// <param name="tagSelf">Общий конечный тег.</param>
        /// <returns>Редактированное имя.</returns>
        public string ChangeName(string fileName, bool tagsChecked, string tagPhoto, string tagVideo, string tagSelf, string extension)
        {
            var strBuildName = new StringBuilder();
            strBuildName.Append(fileName);
            strBuildName.Replace("PixelCam_Plus_", String.Empty);
            strBuildName.Replace("PXL_", String.Empty);
            strBuildName.Replace("IMG_", String.Empty);
            strBuildName.Replace("VID_", String.Empty);
            strBuildName.Insert(4, ".");
            strBuildName.Insert(7, ".");
            strBuildName.Insert(13, "-");
            strBuildName.Insert(16, "-");
            if (tagsChecked)
            {
                if (ExtensionChecked(extension, Extensions.forPicture))
                {
                    strBuildName.Append(tagPhoto);
                }
                else if (ExtensionChecked(extension, Extensions.forVideo))
                {
                    strBuildName.Append(tagVideo);
                }
            }
            strBuildName.Append(tagSelf);
            return strBuildName.ToString();
        }

        /// <summary>
        /// Проверяет, содержится ли в массиве указаная строка.
        /// ReUt: Применение тегов _IMG и _VID через имя расширения.
        /// </summary>
        /// <param name="extension">Проверяемая строка.</param>
        /// <param name="extensionList">Массив, где будет производится поиск.</param>
        /// <returns>Наличие строки в массиве.</returns>
        static bool ExtensionChecked(string extension, string[] extensionList)
        {
            if (Array.IndexOf(extensionList, extension.ToLower()) != -1)
            {
                return true;
            }
            return false;
        }

        public void SaveChecked(bool typeSave, Button bSave, Button bSaveIn)
        {
            //Наличие в списке каких-либо элементов. В случае их отсутствия - файлов для переименования не существует.
            if (FileInfoCount.FileInfoList.Count > 0)
            {
                //Наличие хотя бы одного файла, который необходимо переименовать.
                if (FileInfoCount.ListRename)
                {
                    //Реагирование на кнопку "Сохранить в..."
                    var openFolder = new FolderBrowserDialog();
                    if (typeSave)
                    {
                        openFolder.ShowNewFolderButton = false;
                        openFolder.ShowDialog();
                        if (openFolder.SelectedPath.Length == 0)
                        {
                            return;
                        }
                    }
                    FileSave(typeSave, openFolder.SelectedPath, bSave, bSaveIn);

                    

                    MessageBox.Show("Все заданные файлы сохранены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Файлы не нуждаются в переименовании", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Нет выбранных файлов для переименования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FileSave(bool typeSave, string openFolderPath, Button bSave, Button bSaveIn)
        {
            string fromSave = String.Empty;
            string whereSave = String.Empty;
            for (int i = 0; i < FileInfoCount.FileInfoList.Count; i++)
            {
                if (FileInfoCount.FileInfoList[i].FileRename)
                {
                    fromSave = FileInfoCount.FileInfoList[i].FileDirectory + FileInfoCount.FileInfoList[i].FileName + FileInfoCount.FileInfoList[i].FileExtension;
                    if (!typeSave)
                    {
                        whereSave = FileInfoCount.FileInfoList[i].FileDirectory + FileInfoCount.FileInfoList[i].FileNameNew + FileInfoCount.FileInfoList[i].FileExtension;
                        File.Move(fromSave, whereSave);
                        bSave.Enabled = false;
                        bSaveIn.Enabled = false;
                    }
                    else
                    {
                        whereSave = openFolderPath + @"\" + FileInfoCount.FileInfoList[i].FileNameNew + FileInfoCount.FileInfoList[i].FileExtension;
                        File.Copy(fromSave, whereSave);
                    }
                }
            }
        }

        public void StartRename(Control buttonStart)
        {
            if (FileInfoCount.FileInfoList.Count > 0)
            {
                bool renameFileTemp = false;
                for (int i = 0; i < FileInfoCount.FileInfoList.Count; i++)
                {
                    if (Checked(FileInfoCount.FileInfoList[i].FileName, FileInfoCount.FileInfoList[i].FileExtension))
                    {
                        FileInfoCount.FileInfoList[i].FileNameNew = ChangeName(FileInfoCount.FileInfoList[i].FileName, FormTagsSettings.Tags, FormTagsSettings.TagPhoto, FormTagsSettings.TagVideo, FormTagsSettings.TagSelf, FileInfoCount.FileInfoList[i].FileExtension);
                        FileInfoCount.FileInfoList[i].FileRename = true;
                        renameFileTemp = true;
                    }
                    else
                    {
                        FileInfoCount.FileInfoList[i].FileNameNew = "Файл не нуждается в переименовании";
                        FileInfoCount.FileInfoList[i].FileRename = false;

                    }
                }
                buttonStart.Refresh();
                FileInfoCount.ListRename = renameFileTemp;
            }
            else
            {
                MessageBox.Show("Нет выбранных файлов для переименования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
