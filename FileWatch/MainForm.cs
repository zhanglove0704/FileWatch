using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileWatch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        FileSystemWatcher fileWatch1 = new FileSystemWatcher();
        FileSystemWatcher fileWatch2 = new FileSystemWatcher();
        FileSystemWatcher fileWatch3 = new FileSystemWatcher();
        FileSystemWatcher fileWatch4 = new FileSystemWatcher();
        string logPath1 = Application.StartupPath + "\\log\\P1_log.txt";
        string logPath2 = Application.StartupPath + "\\log\\P2_log.txt";
        string logPath3 = Application.StartupPath + "\\log\\P3_log.txt";
        string logPath4 = Application.StartupPath + "\\log\\P4_log.txt";
        string publishPath = Application.StartupPath + "\\publish\\";
        string historyPath = Application.StartupPath + "\\history\\";
        string containExt = "|.cs|.cshtml|.js|.css|.asax|.ashx|.config|.asmx|.gif|.png|.jpg|.ico|.dll|";
        string publishContainExt = "|.cshtml|.js|.css|.asax|.ashx|.config|.asmx|.gif|.png|.jpg|.ico|.dll|";
        string publishSpecialFile = "|lcsoft.dll|";
        string publishSpecialFolderFilter = "|app_code|app_start|obj|roslyn|zh-hans|debug|release|";
        string configFile = Application.StartupPath + "\\config.data";
        bool isSaveAll = true;
        bool isClose = false;

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            Button browser = sender as Button;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                switch (browser.Tag.ToString())
                {
                    case "1":
                        txtPath1.Text = folderBrowserDialog1.SelectedPath;
                        break;
                    case "2":
                        txtPath2.Text = folderBrowserDialog1.SelectedPath;
                        break;
                    case "3":
                        txtPath3.Text = folderBrowserDialog1.SelectedPath;
                        break;
                    case "4":
                        txtPath4.Text = folderBrowserDialog1.SelectedPath;
                        break;
                    default:
                        txtPath1.Text = folderBrowserDialog1.SelectedPath;
                        break;
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;

            if (txtPath1.Text.Trim().Length == 0 && txtPath2.Text.Trim().Length == 0 && txtPath3.Text.Trim().Length == 0 && txtPath4.Text.Trim().Length == 0)
            {
                MessageBox.Show("");
                btnStart.Enabled = true;

                return;
            }

            if (!Directory.Exists(txtPath1.Text.Trim()) && !Directory.Exists(txtPath2.Text.Trim()) && !Directory.Exists(txtPath3.Text.Trim()) && !Directory.Exists(txtPath4.Text.Trim()))
            {
                MessageBox.Show("");
                btnStart.Enabled = true;

                return;
            }

            txtPath1.Enabled = false;
            btnBrowser1.Enabled = false;
            txtPath2.Enabled = false;
            btnBrowser2.Enabled = false;
            txtPath3.Enabled = false;
            btnBrowser3.Enabled = false;
            txtPath4.Enabled = false;
            btnBrowser4.Enabled = false;
            btnStop.Enabled = true;

            string logPath = Application.StartupPath + "/log/";

            if (!isSaveAll)
            {
                if (!Directory.Exists(logPath))
                {
                    Directory.CreateDirectory(logPath);
                }

                string[] logFiles = Directory.GetFiles(logPath, "*.txt");

                foreach (var logFile in logFiles)
                {
                    FileInfo file = new FileInfo(logFile);

                    string fileName = file.Name;
                    if (fileName.Split('_')[0] != DateTime.Now.ToString("yyyy-MM-dd"))
                    {
                        file.Delete();
                    }
                }
            }

            if (!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);
            }

            if (!File.Exists(logPath1))
            {
                File.Create(logPath1).Close();
            }

            if (!File.Exists(logPath2))
            {
                File.Create(logPath2).Close();
            }

            if (!File.Exists(logPath3))
            {
                File.Create(logPath3).Close();
            }

            if (!File.Exists(logPath4))
            {
                File.Create(logPath4).Close();
            }

            if (!Directory.Exists(historyPath))
            {
                Directory.CreateDirectory(historyPath);
            }

            if (Directory.Exists(txtPath1.Text.Trim()))
            {
                fileWatch1.Path = txtPath1.Text.Trim();
                fileWatch1.Filter = "*.*";
                fileWatch1.Created += FileWatch_Created;
                fileWatch1.Changed += FileWatch_Changed;
                fileWatch1.Deleted += FileWatch_Deleted;
                fileWatch1.Renamed += FileWatch_Renamed;
                fileWatch1.EnableRaisingEvents = true;
                fileWatch1.IncludeSubdirectories = true;
                fileWatch1.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.DirectoryName | NotifyFilters.FileName | NotifyFilters.LastAccess
                                      | NotifyFilters.LastWrite | NotifyFilters.Security | NotifyFilters.Size;
            }

            if (Directory.Exists(txtPath2.Text.Trim()))
            {
                fileWatch2.Path = txtPath2.Text.Trim();
                fileWatch2.Filter = "*.*";
                fileWatch2.Created += FileWatch_Created;
                fileWatch2.Changed += FileWatch_Changed;
                fileWatch2.Deleted += FileWatch_Deleted;
                fileWatch2.Renamed += FileWatch_Renamed;
                fileWatch2.EnableRaisingEvents = true;
                fileWatch2.IncludeSubdirectories = true;
                fileWatch2.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.DirectoryName | NotifyFilters.FileName | NotifyFilters.LastAccess
                                      | NotifyFilters.LastWrite | NotifyFilters.Security | NotifyFilters.Size;
            }

            if (Directory.Exists(txtPath3.Text.Trim()))
            {
                fileWatch3.Path = txtPath3.Text.Trim();
                fileWatch3.Filter = "*.*";
                fileWatch3.Created += FileWatch_Created;
                fileWatch3.Changed += FileWatch_Changed;
                fileWatch3.Deleted += FileWatch_Deleted;
                fileWatch3.Renamed += FileWatch_Renamed;
                fileWatch3.EnableRaisingEvents = true;
                fileWatch3.IncludeSubdirectories = true;
                fileWatch3.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.DirectoryName | NotifyFilters.FileName | NotifyFilters.LastAccess
                                      | NotifyFilters.LastWrite | NotifyFilters.Security | NotifyFilters.Size;
            }

            if (Directory.Exists(txtPath4.Text.Trim()))
            {
                fileWatch4.Path = txtPath4.Text.Trim();
                fileWatch4.Filter = "*.*";
                fileWatch4.Created += FileWatch_Created;
                fileWatch4.Changed += FileWatch_Changed;
                fileWatch4.Deleted += FileWatch_Deleted;
                fileWatch4.Renamed += FileWatch_Renamed;
                fileWatch4.EnableRaisingEvents = true;
                fileWatch4.IncludeSubdirectories = true;
                fileWatch4.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.DirectoryName | NotifyFilters.FileName | NotifyFilters.LastAccess
                                      | NotifyFilters.LastWrite | NotifyFilters.Security | NotifyFilters.Size;
            }
        }

        private void FileWatch_Renamed(object sender, RenamedEventArgs e)
        {
            string recordPath = e.FullPath;

            if (Filtering(recordPath))
            {
                WriteLog(recordPath);
            }
        }

        private void FileWatch_Deleted(object sender, FileSystemEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void FileWatch_Changed(object sender, FileSystemEventArgs e)
        {
            string recordPath = e.FullPath;

            if (Filtering(recordPath))
            {
                WriteLog(recordPath);
            }
        }

        private void FileWatch_Created(object sender, FileSystemEventArgs e)
        {
            string recordPath = e.FullPath;

            if (Filtering(recordPath))
            {
                WriteLog(recordPath);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            txtPath1.Enabled = true;
            btnBrowser1.Enabled = true;
            fileWatch1.EnableRaisingEvents = false;
            txtPath2.Enabled = true;
            btnBrowser2.Enabled = true;
            fileWatch2.EnableRaisingEvents = false;
            txtPath3.Enabled = true;
            btnBrowser3.Enabled = true;
            fileWatch3.EnableRaisingEvents = false;
            txtPath4.Enabled = true;
            btnBrowser4.Enabled = true;
            fileWatch4.EnableRaisingEvents = false;
        }

        private bool Filtering(string path)
        {
            FileInfo info = new FileInfo(path);

            return containExt.Contains("|" + info.Extension + "|");
        }

        private void WriteLog(string recordPath)
        {
            string logPath = "";

            if (txtPath1.Text.Trim().Length > 0 && recordPath.Contains(txtPath1.Text.Trim()))
            {
                logPath = logPath1;
            }
            else if (txtPath2.Text.Trim().Length > 0 && recordPath.Contains(txtPath2.Text.Trim()))
            {
                logPath = logPath2;
            }
            else if (txtPath3.Text.Trim().Length > 0 && recordPath.Contains(txtPath3.Text.Trim()))
            {
                logPath = logPath3;
            }
            else if (txtPath4.Text.Trim().Length > 0 && recordPath.Contains(txtPath4.Text.Trim()))
            {
                logPath = logPath4;
            }
            else
            {
                logPath = logPath1;
            }

            List<string> content = File.ReadAllLines(logPath, Encoding.UTF8).ToList();

            if (!content.Contains(recordPath))
            {
                File.AppendAllLines(logPath, new List<string> { recordPath }, Encoding.UTF8);
            }
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            if (!btnStart.Enabled)
            {
                Button publish = sender as Button;
                string projectName = "";
                string projectPath = "";
                string projectLogPath = "";

                switch (publish.Tag.ToString())
                {
                    case "1":
                        projectName = "P1";
                        projectPath = txtPath1.Text.Trim();
                        projectLogPath = logPath1;
                        break;
                    case "2":
                        projectName = "P2";
                        projectPath = txtPath2.Text.Trim();
                        projectLogPath = logPath2;
                        break;
                    case "3":
                        projectName = "P3";
                        projectPath = txtPath3.Text.Trim();
                        projectLogPath = logPath3;
                        break;
                    case "4":
                        projectName = "P4";
                        projectPath = txtPath4.Text.Trim();
                        projectLogPath = logPath4;
                        break;
                    default:
                        projectName = "P1";
                        projectPath = txtPath1.Text.Trim();
                        projectLogPath = logPath1;
                        break;
                }

                if (!Directory.Exists(projectPath.Trim()))
                {
                    MessageBox.Show("项目路径不正确！");

                    return;
                }

                if (!Directory.Exists(publishPath + projectName))
                {
                    Directory.CreateDirectory(publishPath + projectName);
                }

                List<string> filesPath = File.ReadAllLines(projectLogPath, Encoding.UTF8).ToList();

                if (filesPath.Count == 0)
                {
                    MessageBox.Show("项目未被修改！");

                    return;
                }

                bool isFirst = false;
                string[] projectHistoryFiles = Directory.GetFiles(historyPath, projectName + ".txt", SearchOption.AllDirectories);

                if (projectHistoryFiles.Length == 0)
                {
                    DialogResult dr = MessageBox.Show("是否为第一次生成！", "生成提示", MessageBoxButtons.YesNo);

                    if (dr == DialogResult.Yes)
                    {
                        isFirst = true;
                    }
                }

                if (Directory.Exists(publishPath + projectName))
                {
                    Directory.Delete(publishPath + projectName, true);
                }

                Directory.CreateDirectory(publishPath + projectName);

                foreach (var filePath in filesPath)
                {
                    FileInfo sourceFile = new FileInfo(filePath);

                    if (!publishSpecialFile.Contains("|" + sourceFile.Name.ToLower() + "|") || !sourceFile.Exists)
                    {
                        if (!sourceFile.Exists)
                        {
                            continue;
                        }
                        else if(!publishContainExt.Contains("|" + sourceFile.Extension + "|"))
                        {
                            continue;
                        }
                        else if (sourceFile.Directory.Name.ToLower() == "bin")
                        {
                            if (sourceFile.Extension.ToLower() != ".dll")
                            {
                                continue;
                            }
                            else if(!isFirst)
                            {
                                continue;
                            }
                        }
                        else if (publishSpecialFolderFilter.Contains("|" + sourceFile.Directory.Name.ToLower() + "|"))
                        {
                            continue;
                        }
                    }
                    else if(sourceFile.Directory.Name.ToLower()=="debug" || sourceFile.Directory.Parent.Name=="obj")
                    {
                        continue;
                    }

                    string targetPath = filePath.Replace(projectPath, publishPath + projectName);
                    FileInfo temp = new FileInfo(targetPath);

                    if (!temp.Directory.Exists)
                    {
                        temp.Directory.Create();
                    }

                    File.Copy(filePath, targetPath, true);
                }

                string historyFile = historyPath + DateTime.Now.ToString("yyyy-MM-dd") + "\\" + projectName + ".txt";
                FileInfo historyFileInfo = new FileInfo(historyFile);

                if (historyFileInfo.Exists)
                {
                    List<string> historyList = File.ReadAllLines(historyFile, Encoding.UTF8).ToList();
                    StreamWriter sw = historyFileInfo.AppendText();
                    sw.WriteLine(string.Join("\r\n", filesPath.Where(w => !historyList.Contains(w))));
                    sw.Flush();
                    sw.Close();
                }
                else
                {
                    if (!historyFileInfo.Directory.Exists)
                    {
                        historyFileInfo.Directory.Create();
                    }

                    File.Move(projectLogPath, historyFile);
                }

                File.Create(projectLogPath).Close();

                Process.Start(publishPath + projectName);
            }
            else
            {
                MessageBox.Show("请先开启监视！");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isClose)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void 主面板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isClose = true;
            this.Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void MainForm_MinimumSizeChanged(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(configFile))
            {
                List<string> content = File.ReadLines(configFile).Where(w => !string.IsNullOrEmpty(w)).ToList();

                foreach (string item in content)
                {
                    string[] t = item.Split('=');

                    switch (t[0])
                    {
                        case "P1":
                            txtPath1.Text = t[1];
                            break;
                        case "P2":
                            txtPath2.Text = t[1];
                            break;
                        case "P3":
                            txtPath3.Text = t[1];
                            break;
                        case "P4":
                            txtPath4.Text = t[1];
                            break;
                        default:
                            txtPath1.Text = t[1];
                            break;
                    }
                }
            }
        }

        private int WM_CLOSE = 0x0010;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_CLOSE)
            {
                string content = "";
                content += "P1=" + txtPath1.Text.Trim() + Environment.NewLine;
                content += "P2=" + txtPath2.Text.Trim() + Environment.NewLine;
                content += "P3=" + txtPath3.Text.Trim() + Environment.NewLine;
                content += "P4=" + txtPath4.Text.Trim();
                File.WriteAllText(configFile, content, Encoding.UTF8);
            }

            base.WndProc(ref m);
        }
    }
}
