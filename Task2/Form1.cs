using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        string dir;
        string dirMove;
        string[] files;
        string originalExt;
        string report;
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            dir = source_txbx.Text;
            dirMove = duplicate_txbx.Text;
            originalExt = extention_txbx.Text;
            files = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories);
            Task task = Task.Factory.StartNew(searchCopies);
            task.Wait();
            task.Dispose();
        }

        private void searchCopies()
        {
            var duplicateGroups = files.GroupBy(file => Path.GetFileNameWithoutExtension(file))
               .Where(group => group.Count() > 1);

            if (!Directory.Exists(dirMove)) Directory.CreateDirectory(dirMove);
            try
            {
                foreach (var item in duplicateGroups)
                {
                    MessageBox.Show($"Files with name: {item.Key}");
                    report += $"Files with name: {item.Key}";
                    foreach (string file in item)
                    {
                        MessageBox.Show($"Companion file: {file}");
                        report += $"Companion file: {file}";
                        if (string.Compare(Path.GetExtension(file), originalExt, true) != 0)
                            File.Move(file, dirMove + "\\" + Path.GetFileName(file));
                    }
                }
            }
            catch { return; }
            
        }

        private void report_btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(report))
            {
                MessageBox.Show("The report does not consists any values");
                return;
            }
            MessageBox.Show(report);
        }
    }
}
