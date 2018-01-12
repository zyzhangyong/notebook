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

namespace DesktopNote
{
    public partial class SelectDirectoryForm : Form
    {
            public String s_dir = @"c:\";
        public String Dir
        {
            get { return s_dir; }
            set{
                if (Directory.Exists(value))
                {
                    s_dir = value;
                    this.workDirectoryTextBox.Text = s_dir;
                }
                

            }

        }
        
        public SelectDirectoryForm()
        {
            InitializeComponent();
            this.logicalDriveComboBox.Items.AddRange(Environment.GetLogicalDrives());
            this.logicalDriveComboBox.SelectedIndex = 0;
        }
        public void UPdateList(string directory)
        {
            this.dirctoryListBox.Items.Clear();
            this.Dir = directory;
            DirectoryInfo currentDirectoryInfo = new DirectoryInfo(directory);
            try
            {
                this.dirctoryListBox.Items.AddRange(currentDirectoryInfo.GetDirectories());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void logicalDriveComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.logicalDriveComboBox.SelectedItem.ToString().Equals("")) return;
            UPdateList(this.logicalDriveComboBox.SelectedItem.ToString());
        }

        private void UPbutton_Click(object sender, EventArgs e)
        {
            if (Directory.GetParent(this.Dir) == null) return;
            UPdateList(Directory.GetParent(this.Dir).FullName);
        }

        private void dirctoryListBox_DoubleClick(object sender, EventArgs e)
        {
            DirectoryInfo curfsi = (DirectoryInfo)this.dirctoryListBox.SelectedItem;
            UPdateList(curfsi.FullName);
        }
    
    }
    
}
