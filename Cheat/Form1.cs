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

using Aspose.Cells;
using ICSharpCode.SharpZipLib.Zip;

namespace Cheat
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();             // 存放信息的数据表
        public Form1()
        {
            InitializeComponent();
        }

        // 扫描文件夹
        private void btnSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();            // 实例化：“用户选择文件夹对象”
            double size = 0;                        // 定义文件大小变量
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)                // 判断点击的是否是确认按钮
            {
                dt.Clear();                             // 清空数据表中的数据
                string selectedPath = folderBrowserDialog.SelectedPath;             // 获取用户选中的路径
                DirectoryInfo directory = new DirectoryInfo(selectedPath);              // 获得相对应路径上的文件目录信息
                GetFiles(directory, out size);
            }
            dataGridView1.DataSource = dt;
            lblSize.Text = (size / 1024 / 1024).ToString("0.00") + "  MB";
        }

        // 根据文件目录信息，获得文件夹下的文件
        public void GetFiles(DirectoryInfo directory, out double size)
        {
            FileInfo[] fileInfo = directory.GetFiles();                     // 获得当前文件目录下的文件列表
            size = 0;
            foreach (var item in fileInfo)                          // 循环遍历文件列表  获取文件中的信息
            {
                DataRow dr = dt.NewRow();           // 给数据表中的数据赋值
                if ((dateTimePicker1.Value.Subtract(item.LastWriteTime).Seconds) > 0)               // 获取 选定时间段之间的文件
                {
                    dr["Name"] = item.Name;
                    dr["Size"] = item.Length;
                    dr["Time"] = item.LastWriteTime;
                    size += item.Length;                   // 将文件的大小进行相加
                    dt.Rows.Add(dr);                // 将数据添加到数据表中
                }
            }

            DirectoryInfo[] childDirectory = directory.GetDirectories();                // 获得当前目录的子目录

            foreach (var item in childDirectory)            // 遍历 子目录  
            {
                GetFiles(item, out size);             // 递归调用子目录中的文件
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Name");
            dt.Columns.Add("Size");
            dt.Columns.Add("Time");
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();           // 实例化保存的路径

            saveFileDialog.Filter = "所有文件|*.|Excel|*.xls";                  // 加入后缀名属性

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string savePath = saveFileDialog.FileName;
                #region 导出Excel

                Aspose.Cells.License license = new Aspose.Cells.License();              // 实例化证书对象
                license.SetLicense(@"E:\C#高级特性\Code\NineMonthExam\Cheat\Aid\License.lic");

                Workbook workbook = new Workbook();                         // 实例化文件薄对象
                Worksheet worksheet = workbook.Worksheets[0];           // 为文件表对象赋值

                worksheet.Cells.ImportDataTable(dt, true, "A1");                    // 导出数据
                workbook.Save(savePath);                                            // 进行保存


                #endregion

                #region 压缩
                string zipName = savePath.Substring(0, savePath.LastIndexOf("."));              // 获得文件的路径 以及无后缀的文件名

                using (ZipFile zipFile = ZipFile.Create(zipName + ".zip"))                      // 实例化文件压缩对象
                {
                    zipFile.BeginUpdate();                  // 开始压缩
                    zipFile.Add(savePath);                  // 保存压缩
                    zipFile.CommitUpdate();                     // 关闭压缩
                }

                #endregion


                MessageBox.Show("导出并压缩成功！");

            }





        }
    }
}
