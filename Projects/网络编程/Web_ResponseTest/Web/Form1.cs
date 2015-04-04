using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;

namespace Web
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //通用的接受信息的文件
            string path=@"E:\Source\DotNet\Response\response.txt";
            /*
             *WebRequest用法
             * webrequest wb=webrequest.create(uri);
httpwebresponse re=(httpwebresponse)wb.getResponse();
-----------------
stream datastream =re.getResponseStream();
streamreader r=new streamreader(datastream);
string s=r.readtoend();
             * */
            /*
            Uri u = new Uri("http://www.zhihu.com/");
            WebRequest w = WebRequest.Create(u);
            //w.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse rs = (HttpWebResponse)w.GetResponse();
            //MessageBox.Show(rs.StatusDescription);
            Stream dataStream = rs.GetResponseStream();
            StreamReader r = new StreamReader(dataStream);
            string s = r.ReadToEnd();
            //FileStream f=new FileStream(@"C:\a.txt",FileMode.OpenOrCreate);
            if(!File.Exists(@"C:\a.txt")){
                File.CreateText(@"C:\a.txt"); 
            }
            StreamWriter sw = new StreamWriter(@"C:\a.txt",true,Encoding.UTF8);
            sw.Write(s);
            //4File.WriteAllText(@"C:\a.txt", s);
            dataStream.Close() ;
            r.Close();
            rs.Close(); 
            //WebClient wc = new WebClient();
            //wc.BaseAddress = u.ToString();
            */
            WebClient wc = new WebClient();
            wc.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            Stream s = wc.OpenRead("http://pan.baidu.com/");
            StreamReader reader = new StreamReader(s);
            FileStream fs = new FileStream(path,FileMode.OpenOrCreate);
            fs.Close();
            StreamWriter sw = new StreamWriter(path, true, Encoding.UTF8);
            sw.WriteLine(reader.ReadToEnd());
            sw.Close();
            reader.Close();
            s.Close();
        }
    }
}
