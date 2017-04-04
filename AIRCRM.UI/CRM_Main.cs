using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIRCRM.UI
{
    public partial class CRM_Main : DevExpress.XtraEditors.XtraForm
    {
        public CRM_Main()
        {
            InitializeComponent();
            
        }
        
        private void CRM_Main_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2010 Black");
        }

        private void navBarItem_PolicyGet_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CRM_PolicyGet policy = new CRM_PolicyGet();
            policy.Text = e.Link.Caption;
            int count = xtraTabbedMdiManager1.Pages.Count;
            bool isExist = false;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (xtraTabbedMdiManager1.Pages[i].Text == e.Link.Caption)
                    {
                        xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[i];
                        isExist = true;
                        break;
                    }

                }
                if (isExist == false)
                {
                    policy.MdiParent = this;
                    policy.Show();
                }
            }
            else
            {
                policy.MdiParent = this;
                policy.Show();
            }
            
           
        }
        /// <summary>
        /// 关于窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navBarItem_CRM_About_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CRM_About _about = new CRM_About();
            _about.ShowDialog();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navBarItem_ExitSystem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (MessageBox.Show("确定要退出本系统吗？", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.ExitThread();
                Application.Exit();
            }
        }

        private void navBarItem_PolicyUp_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            RunTask.Form1 policy = new RunTask.Form1();
            //CRM_PolicyUp policy = new CRM_PolicyUp();
            policy.Text = e.Link.Caption;
            int count = xtraTabbedMdiManager1.Pages.Count;
            bool isExist = false;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (xtraTabbedMdiManager1.Pages[i].Text == e.Link.Caption)
                    {
                        xtraTabbedMdiManager1.SelectedPage = xtraTabbedMdiManager1.Pages[i];
                        isExist = true;
                        break;
                    }

                }
                if (isExist == false)
                {
                    policy.MdiParent = this;
                    policy.Show();
                }
            }
            else
            {
                policy.MdiParent = this;
                policy.Show();
            }
        }
    }
}
