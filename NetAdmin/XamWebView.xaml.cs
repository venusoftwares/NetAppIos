using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NetAdmin
{
    [DesignTimeVisible(false)]
    public partial class XamWebView : ContentPage
    {
        public XamWebView()
        {
            InitializeComponent();
            webView.Source = "https://nanda-et.com/nandaet_adminlogin";
        }
    }
}