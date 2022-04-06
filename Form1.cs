using System.IO;

namespace FilesViewer
{
    public partial class Form1 : Form
    {

        private List<string> DirPaths = new List<string>();
        private List<string> MainPaths = new List<string>();
        private int undoCounter = -1;
        private int redoCounter;


        public Form1()
        {
            InitializeComponent();
        }



        // undo arrow
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // checking that there is previous action happend which will increace the undo counter
            if (MainPaths.Count >= 1 && undoCounter > 0)
            {
                //decreacing the undo counter and increasing the redo counter to help leter if I make redo
                undoCounter--;
                redoCounter++;
                // last index of MainPaths list
                int buffer_index = MainPaths.Count - 1;
                
                // getting the item of last index from the MainPaths list and insert it at the first index + shifting each other items
                string bufferPath = MainPaths[buffer_index];
                MainPaths.RemoveAt(buffer_index);
                MainPaths.Insert(0, bufferPath);

                // display the next path and and performing click to open the next path
                pathText.Text = MainPaths[buffer_index];
                openButton.PerformClick();

            }


        }



        // redo arrow
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // checking that there is previous action happend which will increace the redo counter
            if (MainPaths.Count >= 1 && redoCounter > 0)
            {
                //decreacing the redo counter and increasing the undo counter to help me leter if I make redo
                undoCounter++;
                redoCounter--;
                
                // getting the item of the first index from the MainPaths list and add it at the last index
                string bufferPath = MainPaths[0];
                MainPaths.RemoveAt(0);
                MainPaths.Add(bufferPath);

                // display the next path and and performing click to open the next path
                pathText.Text = MainPaths[MainPaths.Count - 1];
                openButton.PerformClick();

            }
        }



        // show the files and folders in the boxlist
        private void showListBox()
        {
            // clearing the Dirpaths list and the listbox items
            DirPaths.Clear();
            listBox.Items.Clear();

            // the current folder path
            string path = pathText.Text;

            DirectoryInfo DirInfo = new DirectoryInfo(@path);
            foreach (FileSystemInfo file in DirInfo.EnumerateFileSystemInfos())
            {
                // adding files and folders to listbox to be displayed in the form
                // adding them to DirPaths to be used in CheckingItem method
                listBox.Items.Add(file.Name);
                DirPaths.Add(file.FullName);

            }

            // increase undo counter if it is a new path
            if (!MainPaths.Contains(path))
            {
                undoCounter++;
                MainPaths.Add(path);
            }
        }



        // open button click will let the list box diplay
        private void openButton_Click(object sender, EventArgs e)
        {
            if (!listBox.Visible) listBox.Visible = true;
            showListBox();
            this.ActiveControl = null;
        }
        // select the path automatically when double clicking on the text box to make it easy for user to change the path 
        private void pathText_DoubleClick(object sender, EventArgs e)
        {
            pathText.SelectAll();
            pathText.Focus();
        }
        // Typing Enter on keyboard is equal to clicking open button 
        private void pathText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) openButton.PerformClick();
        }



        // double clicking by mouse or typing enter on the list box will lead to two results
        // it's file, the full name, length, and last access time will appear under the list box
        // but if it's folder it will show what inside in a new page
        private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CheckingItem();
        }

        private void listBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) CheckingItem();
        }

        private void CheckingItem()
        {
            int index = listBox.SelectedIndex;
            string path = DirPaths[index];
            if (Directory.Exists(@path))
            {
                pathText.Text = path;
                openButton.PerformClick();
            }
            else if(File.Exists(@path))
            {
                fileDetails(@path);
            }
        }



        // fileDetails method will display the fullname.. in the windows form
        private void fileDetails(string path)
        {
            FileInfo fi = new FileInfo(path);
            string full_name = fi.FullName;
            string len = fi.Length.ToString();
            string last_access_time = fi.LastAccessTime.ToString();

            fullName.Text = "Full Name: " + full_name;
            length.Text = "Length: " + len;
            LAT.Text = "Last Access Time: " + last_access_time;
            if (!fullName.Visible || !length.Visible || !LAT.Visible)
            {
                fullName.Visible = true;
                length.Visible = true;
                LAT.Visible = true;
            }
        }
    }
}