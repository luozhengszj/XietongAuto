using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Mail;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace XietongAuto
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void fasong_btn_Click(object sender, EventArgs e)
        {
            read_excel();
        }

        private void send_mail(List<EmailItem> allemails)
        {
            DialogResult result = MessageBox.Show("将对" + allemails.Count + "条邮件进行发送", "请确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FileStream stream = File.Open(DateTime.Now.ToString("yyyy-MM-dd HH mm ss") + "发送日志.txt", FileMode.CreateNew, FileAccess.Write);
                StreamWriter sw = new StreamWriter(stream);

                textBox_log.AppendText("正在对" + allemails.Count + "条邮件进行发送...\r\n");
                foreach (EmailItem e in allemails)
                {
                    SmtpClient smtp = new SmtpClient(textBox_url.Text.ToString());
                    smtp.Port = Convert.ToInt32(textBox_url_port.Text.ToString());
                    MailAddress from = new MailAddress(textbox_from.ToString());
                    MailAddress to = new MailAddress(e.email);
                    MailMessage mail = new MailMessage(from, to);

                    string mail_body = textBox_body.Text;
                    List<string> allparams = e.allparams;
                    for (int i = 0; i < allparams.Count; i++)
                    {
                        mail_body = mail_body.Replace("luozhengQAQ" + i.ToString(), allparams[i]);
                    }
                    mail.Subject = textBox_title.Text.ToString();
                    mail.Body = mail_body;
                    mail.IsBodyHtml = true;
                    NetworkCredential cred = new NetworkCredential("luo_z.ggg@im.gx.csg", "aa123456!@");
                    smtp.Credentials = cred;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    try
                    {
                        smtp.Send(mail);
                        textBox_log.AppendText("发送成功：" + e.username + e.email + "\r\n");
                        sw.WriteLine("发送成功：" + e.username + e.email);
                    }
                    catch (System.Net.Mail.SmtpFailedRecipientException)
                    {
                        textBox_log.AppendText("发送失败：" + e.username + e.email + "，目标邮件错误\r\n");
                        sw.WriteLine("发送失败：" + e.username + e.email + "，目标邮件错误");
                    }
                    catch (Exception) {
                        textBox_log.AppendText("发送失败：" + e.username + e.email + "，其他错误\r\n");
                        sw.WriteLine("发送失败：" + e.username + e.email + "，其他错误");
                    }
                }
                sw.Flush();
                sw.Close();
                stream.Close();
            }
        }

        private int read_excel()
        {
            string excelpath = textBox_path.Text;
            
            int count = 0;
            IWorkbook wk = null;
            int number = Convert.ToInt32(textBox_number.Text);
            if (File.Exists(excelpath))
            {
                string extension = System.IO.Path.GetExtension(excelpath);
                FileStream fs = File.OpenRead(excelpath);
                if (extension.Equals(".xls"))
                {
                    //把xls文件中的数据写入wk中
                    wk = new HSSFWorkbook(fs);
                }
                else
                {
                    //把xlsx文件中的数据写入wk中
                    wk = new XSSFWorkbook(fs);
                }

                fs.Close();

                ISheet sheet = wk.GetSheetAt(0);
                string sheetname = wk.GetSheetName(0);
                int rowcount = sheet.LastRowNum;

                List<EmailItem> allemails = new List<EmailItem>();
                for (int j = 2; j <= rowcount; j++)
                {
                    IRow row = sheet.GetRow(j);  //读取当前行数据
                    EmailItem eitem = new EmailItem();
                    List<string> list = new List<string>();

                    if (row.GetCell(2) != null && row.GetCell(2).ToString().Trim() != "")
                    {
                        eitem.username = row.GetCell(1).ToString().Trim();
                        eitem.email = row.GetCell(2).ToString().Trim();
                        string logstr = "";
                        for (int i = 0; i < number; i++)
                        {
                            if (row.GetCell(i + 3) != null && row.GetCell(i).ToString() != "")
                            {
                                list.Add(row.GetCell(i + 3).ToString().Trim());
                            }
                            else
                            {
                                logstr = logstr + (j + 1).ToString() + "行" + (i + 3).ToString() + "列数据有误！,程序已停止运行。\n\r";
                                textBox_log.AppendText((j + 1).ToString() + "行" + (i + 3).ToString() + "列数据有误！\n\r");
                                break;
                            }
                        }
                        eitem.allparams = list;
                        allemails.Add(eitem);
                    }
                    else
                    {
                        MessageBox.Show((j + 1).ToString() + "行数据为空,程序已停止运行。");
                        textBox_log.AppendText((j + 1).ToString() + "行数据为空\n\r");
                        break;
                    }
                }
                send_mail(allemails);
                return count;
            }
            else
            {
                return 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SmtpClient smtp = new SmtpClient(textBox_url.Text.ToString().Trim());
            MailAddress from = new MailAddress("luo_z.ggg@im.gx.csg");
            MailAddress to = new MailAddress("luo_z.ggg@im.gx.csg");
            MailMessage mail = new MailMessage(from, to);

            mail.Subject = "bb";
            mail.Body = "aa";
            mail.IsBodyHtml = true;
            NetworkCredential cred = new NetworkCredential("luo_z.ggg@im.gx.csg", "aa123456!@");
            smtp.Credentials = cred;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(mail);
        }

        private void shuomingtbn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("1、读取的excel从第三行开始；\r\n2、需要替换的字符请用luozhengQAQ+数字代替，数字从0开始，如“luozhengQAQ0”“luozhengQAQ1”；\r\n3、填写了替换次数后，在excel中，第三列往后为替换的内容；\r\n4、日志为发送成功并且邮箱后缀正确，则发送成功；\r\n5、如果后缀不正确，提示发送成功但不一定成功，例如发送到“luo_z.ggg@im.gx1.csg”，后缀“@im.gx1.csg”明显错误，实际是发送失败的；\r\n6、有问题请联系 罗正", "使用说明", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }

    class EmailItem
    {
        public string username { get; set; }
        public string email { get; set; }
        public List<string> allparams { get; set; }
    }
}
