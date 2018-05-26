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

namespace winformVK
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
           // GetToken.DocumentCompleted += docComplete;
           // GetToken.Navigate("https://oauth.vk.com/authorize?client_id=6485464&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends&response_type=token&v=5.52");
        }

        private void docComplete(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //MessageBox.Show(GetToken.Url.ToString());
            if (GetToken.Url.ToString().IndexOf("access_token=") != -1)
            {

                GetUserToken();
            }
            else
                MessageBox.Show("Авторизуйтесь!");      
        }

        private void GetUserToken()
        {
            char[] simb = { '=', '&' };
            string[] URL = GetToken.Url.ToString().Split(simb);
            StreamWriter sr = new StreamWriter("UserInf.txt");
            sr.WriteLine(URL[1]);
            sr.WriteLine(URL[5]);
            sr.WriteLine(GetToken.Url.ToString());
            sr.Close();
            this.Visible = false;
        }



  
    }
}
