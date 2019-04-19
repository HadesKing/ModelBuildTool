using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeBuildTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private delegate void DlgShowMessage(String argContent);
        private Int32 m_msgRowNumber = 0;

        /// <summary>
        /// 显示提示信息
        /// </summary>
        /// <param name="argContent">信息内容</param>
        public void ShowMessage(String argContent)
        {
            if (String.IsNullOrWhiteSpace(argContent)) return;

            if(this.InvokeRequired)
            {
                DlgShowMessage dlgShowMessage = new DlgShowMessage(ShowMessage);
                this.Invoke(dlgShowMessage, argContent);
                //this.Invoke(new MethodInvoker(() => { ShowMessage(argContent); }));
            }
            else
            {
                m_msgRowNumber++;
                //判断是否需要进行清空
                if (m_msgRowNumber > 20) tbMessage.Text = "";

                if (String.IsNullOrWhiteSpace(tbMessage.Text))
                {
                    tbMessage.Text = argContent;
                }
                else
                {
                    tbMessage.Text += "\r\n" + argContent;
                }
            }

        }

        private void BtnConnectOrTest_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
            {
                ShowMessage(String.Format("出错了：{0}", ex.Message));
                
            }
        }

        private void BtnBuild_Click(object sender, EventArgs e)
        {

        }
    }
}
