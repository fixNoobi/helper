using Ini;
using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace La2Coding
{
    public partial class mForm : Form
    {
        public mForm()
        {
            InitializeComponent();
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false; 
        }

        string iSubNameFolder;
        string iSubNameFile;
        string iSubNameExt;
        string[] arrayFileInSelectedFolder;
        sForm settings = new sForm();

        void ConvertToANSI(string iFileName)
        {
            StreamReader reader = new StreamReader(iFileName, Encoding.UTF8);
            string str = reader.ReadToEnd();
            reader.Close();
            StreamWriter writer = new StreamWriter(iFileName, false, Encoding.GetEncoding(1251));
            writer.Write(str);
            reader.Dispose();
            writer.Dispose();
        }
        void ConvertToUTF8(string iFileName)
        {
            StreamReader reader = new StreamReader(iFileName, Encoding.GetEncoding(1251));
            string str = reader.ReadToEnd();
            reader.Close();
            StreamWriter writer = new StreamWriter(iFileName, false, Encoding.UTF8);
            writer.Write(str);
            reader.Dispose();
            writer.Dispose();
        }

        private void iOpenFolder_Click(object sender, EventArgs e)
        {
            if (fbdOpen.ShowDialog() == DialogResult.OK)
            {
                iFolderPath.Text = fbdOpen.SelectedPath;
                Thread th = new Thread(new ThreadStart(findFileInAllDirectory));
                th.Start();
            }
        }

        void findFileInAllDirectory()
        {
            #region Основное метод поиска и добавление файлов с поддерикториями
            try
            {
                foreach (string iFileInFolder in
                    Directory.GetFiles(iFolderPath.Text, "*.htm", SearchOption.AllDirectories))
                {
                    try
                    {
                        string iFile = iFileInFolder.Replace(fbdOpen.SelectedPath + @"\", "");
                        try
                        {
                            iSubNameFolder = iFile.Remove(iFile.LastIndexOf(@"\"));
                            iSubNameFile = iFile.Replace(iSubNameFolder + @"\", "");
                            iSubNameExt = iSubNameFile.Remove(0, iSubNameFile.LastIndexOf("."));
                        }
                        catch
                        {   iSubNameFile = iFile;}

                        GroupItem(iSubNameFolder);
                        if (listView1.Groups.Count >= 1)
                        {
                            ListViewItem lvi = new ListViewItem(iSubNameFolder + @"\", listView1.Groups[listView1.Groups.Count-1]);
                            lvi.SubItems.Add(iSubNameFile);
                            lvi.SubItems.Add(iSubNameExt);
                            listView1.Items.Add(lvi).Group.Name = iSubNameFolder;
                        }
                        
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            #endregion

            #region Альтернативный вариант
            //DirectoryInfo diFromDir = new DirectoryInfo(iFolderPath.Text);

            //DirectoryInfo[] diFromArr = diFromDir.GetDirectories();

            //foreach (DirectoryInfo DirName in diFromArr)
            //{
            //    DirectoryInfo fFromDir = new DirectoryInfo(iFolderPath.Text + "/" + DirName);

            //    foreach (FileInfo Fname in fFromDir.GetFiles())
            //    {
            //        FileInfo ufInfo = new FileInfo(iFolderPath.Text + "\\" + DirName + "\\" + Fname);
            //        ListViewItem lvi = new ListViewItem(DirName + "\\" + Fname);
            //        listView1.Items.Add(lvi);
            //    }
            //}
            #endregion

            //Автоширина
            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                listView1.Columns[i].Width = -1;
            }
        }

        
        void findFileInTopDirectory()
        {
            #region Основное метод поиска и добавление файлов в дериктории
            try
            {
                foreach (string iFileInFolder in
                    Directory.GetFiles(iFolderPath.Text, "*.htm", SearchOption.TopDirectoryOnly))
                {
                    try
                    {
                        string iFile = iFileInFolder.Replace(fbdOpen.SelectedPath + @"\", "");
                        try
                        {
                            iSubNameFolder = iFile.Remove(iFile.LastIndexOf(@"\"));
                            iSubNameFile = iFile.Replace(iSubNameFolder + @"\", "");
                            iSubNameExt = iSubNameFile.Remove(0, iSubNameFile.LastIndexOf("."));
                        }
                        catch
                        {   iSubNameFile = iFile;}

                        GroupItem(iSubNameFolder);
                        if (listView1.Groups.Count >= 1)
                        {
                            ListViewItem lvi = new ListViewItem(iSubNameFolder + @"\", listView1.Groups[listView1.Groups.Count-1]);
                            lvi.SubItems.Add(iSubNameFile);
                            lvi.SubItems.Add(iSubNameExt);
                            listView1.Items.Add(lvi).Group.Name = iSubNameFolder;
                        }
                        
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            #endregion

            //Автоширина
            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                listView1.Columns[i].Width = -1;
            }
        }

        //Проверка группы
        #region Проверка существования группы
        private void GroupItem(string item)
        {
            // This flag will tell us if proper group already exists
            bool group_exists = false;

            // Check each group if it fits to the item
            foreach (ListViewGroup group in this.listView1.Groups)
            {
                // Compare group's header to selected subitem's text
                if (group.Header == item)
                {
                    // Add item to the group.
                    // Alternative is: group.Items.Add(item);
                    //item.Group = group;
                    group_exists = true;
                    break;
                }
            }

            // Create new group if no proper group was found
            if (!group_exists)
            {
                // Create group and specify its header by
                // getting selected subitem's text
                ListViewGroup group = new ListViewGroup(item);
                // We need to add the group to the ListView first
                this.listView1.Groups.Add(group);
                //item.Group = group;
            }

        }
        #endregion

        private void вUTF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem NameS in listView1.SelectedItems)
            {
                //MessageBox.Show(iFolderPath.Text+@"\"+NameS.SubItems[0].Text+NameS.SubItems[1].Text);
                ConvertToUTF8(iFolderPath.Text + @"\" + NameS.SubItems[0].Text + NameS.SubItems[1].Text);
            }
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            settings.ShowDialog();
        }

        public void LoadParam()
        {
            IniFile ini = new IniFile(Environment.CurrentDirectory + "\\set.ini");
            settings.qFindInTopDir.Checked = Convert.ToBoolean(ini.IniReadValue("General", "FindInTopDir"));
            settings.qExtModeCh.Checked = Convert.ToBoolean(ini.IniReadValue("General", "FindMask"));
            settings.qExtMode.SelectedItem = ini.IniReadValue("General", "FindMaskExt");

        }

        private void вANSIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem NameS in listView1.SelectedItems)
            {
                //MessageBox.Show(iFolderPath.Text+@"\"+NameS.SubItems[0].Text+NameS.SubItems[1].Text);
                ConvertToUTF8(iFolderPath.Text + @"\" + NameS.SubItems[0].Text + NameS.SubItems[1].Text);
            }
        }

    }
}
