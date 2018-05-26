using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace winformVK
{
    public partial class Form1 : Form
    {
        string userId = "156407440";
        string token = "8e4394a95afbf67518512401cf049c394756119c32ef8b719a89da9ef1083c22a1d9a62e003b418247425";
        public Form1()
        {
            InitializeComponent();
        }

     
        private void buttonGetInfo_Click(object sender, EventArgs e)
        {

            userId = textBoxUserID.Text;
            string s = "https://api.vk.com/method/users.get?user_ids=" + userId + "&fields=bdate&access_token=" + token + "&v=5.52";
            HttpClient client = new HttpClient();
            // string s = "https://api.vk.com/method/users.get?user_ids=210700286&fields=bdate&access_token=533bacf01e11f55b536a565b57531ac114461ae8736d6506a3&v=5.52";
            var responseString = client.GetStringAsync(s);
            MessageBox.Show(responseString.Result.ToString());
            JObject joResponse = JObject.Parse(responseString.Result.ToString());
            var jarray = joResponse["response"][0];
            var nnn = jarray["first_name"];
            labelFirstName.Text = nnn.ToString();
            labelLastName.Text = jarray["last_name"].ToString();
            labelBeDay.Text = jarray["bdate"].ToString();
        }

      
    }
}
