using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imgTimeFix1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variables

        //file variables
        private DirectoryInfo folder1;
        private List<FileInfo> files;
        private List<FileInfo> files1;
        private String[] fileTypes;


        //set variables
        public void setVariables(String p)
        {

            folder1 = new DirectoryInfo(p);
            files = new List<FileInfo>();

            scan(folder1);

            fileTypes = new String[files.Count];
            for (int i = 0; i < files.Count; i++)
            {
                fileTypes[i] = files[i].Extension;

            }

        }

        private void scan(DirectoryInfo dir)
        {
            try
            {

                FileSystemInfo[] fileInfo = dir.GetFileSystemInfos();

                foreach (FileSystemInfo f in fileInfo)
                {
                    if (f != null)
                    {
                        if (f is DirectoryInfo)
                        {
                            DirectoryInfo subdir = new DirectoryInfo(f.FullName);
                            scan(subdir);
                        }

                        else
                        {
                            files.Add((FileInfo)f);
                        }
                    }

                }
            }

            catch (Exception e)
            {
                throw;
            }

        }

        #endregion

        #region All File Info

        //list file info
        public void listFileInfo(int n)
        {
            //clear list
            //listView1.Clear();

            //get type
            String tp = typeInput1.Text;

            //file amount3
            int l = files.Count;

            //file info
            String[] fileNames = new String[l];
            String[] creationTime = new String[l];
            String[] takenDate = new String[l];

            //get info
            for (int i = 0; i < files.Count; i++)
            {
                fileNames[i] = files[i].Name;
                creationTime[i] = files[i].CreationTime.ToString();

                if (files[i].Extension == ".jpg")
                    takenDate[i] = getImageTakenDate(files[i].FullName).ToString();

            }

            //fill info list
            for (int i = 0; i < files.Count; i++)
            {
                String s = files[i].Extension;

                if (tp.Equals("File Type") || s.ToLower().Equals(tp.ToLower()))
                {
                    ListViewItem item = listView1.Items.Add(fileNames[i]);

                    item.SubItems.Add(creationTime[i]);
                    item.SubItems.Add(fileTypes[i]);
                    item.SubItems.Add(takenDate[i]);
                }

            }

        }

        //get take picture date
        private String getImageTakenDate(String f)
        {
            Encoding ascii = Encoding.ASCII;
            string picDate;

            FileStream stream = new FileStream(f, FileMode.Open, FileAccess.Read);
            Image image = Image.FromStream(stream, true, false);

            foreach (PropertyItem p in image.PropertyItems)
            {
                //获取拍摄日期时间

                if (p.Id == 0x9003) // 0x0132 最后更新时间
                {
                    stream.Close();
                    picDate = ascii.GetString(p.Value);
                    if ((!"".Equals(picDate)) && picDate.Length >= 10)
                    {
                        // 拍摄日期
                        String pd = picDate.Substring(0, 10);
                        pd = pd.Replace(":", "/");
                        pd += picDate.Substring(10);
                        return pd;
                    }
                }

            }
            stream.Close();
            return "";
        }

        #endregion

        #region Modify File Info

        //change properties
        private void changePprt()
        {

            int i = listView1.SelectedItems[0].Index - 1;

            if (newName.Text != "Change Name")
            {
                String st = files[i].FullName;
                st = st.Substring(0, st.IndexOf(files[i].Name));
                st += newName.Text + files[i].Extension;

                files[i].MoveTo(st);

                MessageBox.Show("Name changed to \n" + files[i].Name);
            }

            if (newCreation.Text != "Change Creation Time")
            {
                files[i].CreationTime = DateTime.Parse(newCreation.Text);

                MessageBox.Show("Creation Time changed to \n" + files[i].CreationTime);
            }
            
            if (newType.Text != "Change File Type")
            {
                String st = files[i].FullName;
                st = st.Substring(0, st.IndexOf(files[i].Extension));
                st += newType.Text;

                files[i].MoveTo(st);

                MessageBox.Show("Type changed to \n" + files[i].Extension);
            }

        }

        #endregion

        #region Events
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void scanBtn1_Click(object sender, EventArgs e)
        {
            String path1 = pathInput1.Text;

            setVariables(path1);
            listFileInfo(1);

            files1 = files;
            
        }

        private void editBtn1_Click(object sender, EventArgs e)
        {
            changePprt();
            MessageBox.Show("Edit Completed");
        }

        private void switchBtn1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < files.Count; i++)
            {
                String t = getImageTakenDate(files[i].FullName);
                files[i].CreationTime = DateTime.Parse(t);
            }

            MessageBox.Show("Time Switched");
        }

        #endregion
    }
}
