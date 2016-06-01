using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Text;

namespace PodzialRas
{
    public partial class MainForm : Form
    {

        const string ConfigPath = "podzial.txt";

        public MainForm()
        {
            InitializeComponent();
        }

        private Dictionary<string, string> readConfig(string path)
        {
            var config = new Dictionary<string, string>();
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            string actualGroup = "";

            foreach (string line in lines)
            {
                if(line.StartsWith("["))
                {
                    var dirs = line.Trim('[', ']').Split('.');
                    actualGroup = Path.Combine(dirs);
                }
                else
                {
                    config[line.ToLower().Trim()] = actualGroup;
                }
            }

            return config;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if(dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                folderPath.Text = dlg.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> files = Directory.EnumerateFiles(folderPath.Text, "*.doc").ToList();
            var config = readConfig(ConfigPath);

            progress.Minimum = 0;
            progress.Maximum = files.Count;

            foreach (var f in files)
            {
                var filename = Path.GetFileName(f);
                var name = Path.GetFileNameWithoutExtension(f).ToLower().Trim();
                string subdir;
                if(config.TryGetValue(name, out subdir))
                {
                    var dest = Path.Combine(new string[] { folderPath.Text, subdir });
                    Directory.CreateDirectory(dest);
                    File.Copy(f, Path.Combine(dest, filename));
                }

                progress.Value++;
            }
        }

    }
}
