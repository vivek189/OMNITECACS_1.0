using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CASSDPWORLD
{
    public partial class frmSplash : Form,ISplashForm
    {
        public frmSplash()
        {
            InitializeComponent();
            //this.TransparencyKey = (BackColor);
        }

        #region ISplashForm

        void ISplashForm.SetStatusInfo(string NewStatusInfo)
        {
            lbStatusInfo.Text = NewStatusInfo;
        }

        #endregion

    }
}