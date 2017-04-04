using System;
using System.Data;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using ICSharpCode.SharpZipLib.Zip;

namespace DetelePolicyTool
{
    public partial class FormDelelePolicy : Form
    {
        public FormDelelePolicy()
        {
            InitializeComponent();
        }

        private void FormDelelePolicy_Load(object sender, EventArgs e)
        {
            cmb_Platfrom.SelectedIndex = 0;
            cmb_PolicyType.SelectedIndex = 0;
        }
        /// <summary>
        /// 删除政策
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DeletePolicy_Click(object sender, EventArgs e)
        {
            #region 读取政策XML模板文件到DataSet
            DataSet tmpds = new DataSet("xmldataset");
            tmpds.ReadXml(Application.StartupPath + string.Format(@"{0}", "\\common.xml"));
            #endregion

            #region 政策头部信息

            tmpds.Tables["PolicyList"].Rows[0]["username"] = "sijieair";
            tmpds.Tables["PolicyList"].Rows[0]["password"] = "410211";
            string execType = chk_FULL.Checked ? chk_FULL.Text : chk_ADD.Text;
            tmpds.Tables["PolicyList"].Rows[0]["execType"] = execType;
            tmpds.Tables["PolicyList"].Rows[0]["ext"] = "del";

            #endregion


            #region 生成XML文件-UTF8
            string strFileName = Application.StartupPath + @"\del.xml";
            XmlTextWriter xmlWriter = new XmlTextWriter(strFileName, Encoding.UTF8);//UTF-8编码
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.Indentation = 4;
            xmlWriter.WriteStartDocument();//写入XML头声明
            #region PolicyList根节点
            xmlWriter.WriteStartElement("PolicyList");//PolicyList根节点
            int policyColumns = tmpds.Tables["PolicyList"].Columns.Count;
            //PolicyList根节点属性
            for (int i = 0; i < policyColumns - 1; i++)
            {
                xmlWriter.WriteStartAttribute(tmpds.Tables["PolicyList"].Columns[i].ColumnName);
                xmlWriter.WriteString(tmpds.Tables["PolicyList"].Rows[0][i].ToString());
                xmlWriter.WriteEndAttribute();
            }
            #endregion

            #region DeletePolicy节点
            xmlWriter.WriteStartElement("DeletePolicy");//DeletePolicy节点
            int delPolicyColumns = tmpds.Tables["DeletePolicy"].Columns.Count;
            for (int i = 0; i < delPolicyColumns - 1; i++)
            {
                xmlWriter.WriteStartAttribute(tmpds.Tables["DeletePolicy"].Columns[i].ColumnName);
                if (tmpds.Tables["DeletePolicy"].Rows.Count > 0)
                {
                    xmlWriter.WriteString(tmpds.Tables["DeletePolicy"].Rows[0][i].ToString());
                    xmlWriter.WriteEndAttribute();
                }
            }
            xmlWriter.WriteEndElement(); 
            #endregion

            //#region Policy节点
            ////Policy节点
            //int policyCounts = tmpds.Tables["Policy"].Rows.Count;
            //for (int i = 0; i < policyCounts; i++)
            //{
            //    xmlWriter.WriteStartElement("Policy");
            //    int pColumns = tmpds.Tables["Policy"].Columns.Count;
            //    for (int j = 0; j < pColumns - 1; j++)
            //    {
            //        xmlWriter.WriteStartAttribute(tmpds.Tables["Policy"].Columns[j].ColumnName);
            //        xmlWriter.WriteString(tmpds.Tables["Policy"].Rows[i][j].ToString());
            //        xmlWriter.WriteEndAttribute();
            //    }
            //    xmlWriter.WriteEndElement();
            //}
            //#endregion

            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();
            #endregion
            CompressFile(strFileName, "del.zip");
            UploadFile("del.zip");
        }

        private void chk_ADD_Click(object sender, EventArgs e)
        {
            chk_ADD.Checked = true;
            chk_FULL.Checked = false;
        }

        private void chk_FULL_Click(object sender, EventArgs e)
        {
            chk_ADD.Checked = false;
            chk_FULL.Checked = true;
        }


        #region 压缩文件
        /// <summary>
        /// 压缩文件
        /// </summary>
        /// <param name="strSouceFile">源文件</param>
        /// <param name="strDestFile">目标文件</param>
        public void CompressFile(string strSouceFile, string strDestFile)
        {
            using (ZipOutputStream stream = new ZipOutputStream(File.Create(strDestFile)))
            {
                stream.SetLevel(5);
                byte[] buffer = new byte[0x1000];
                ZipEntry entry = new ZipEntry(Path.GetFileName(strSouceFile));
                entry.DateTime = DateTime.Now;
                stream.PutNextEntry(entry);
                using (FileStream stream2 = File.OpenRead(strSouceFile))
                {
                    int num;
                    do
                    {
                        num = stream2.Read(buffer, 0, buffer.Length);
                        stream.Write(buffer, 0, num);
                    }
                    while (num > 0);

                }
                stream.Finish();
                stream.Close();
            }
        }
        #endregion
        #region 上传文件
        /// <summary>
        /// 上传文件 
        /// </summary>
        /// <param name="filename"></param>
        public void UploadFile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] bytes = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            fs.Dispose();
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://sjd.trade.qunar.com/tts/interface/policy.jsp");
            req.Method = "POST";
            req.ContentLength = bytes.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(bytes, 0, bytes.Length);
                reqStream.Close();
            }
            HttpWebResponse response = (HttpWebResponse)req.GetResponse();
        }
        #endregion
    }
}
