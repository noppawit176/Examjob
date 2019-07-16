using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Web.Script.Serialization;

namespace Examjob
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        String seach;
        void Page_Load(object sender, EventArgs e)
        {
            Button1.Click += new EventHandler(this.seaching);

        }
        void seaching(Object sender, EventArgs e)
        {

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            Button but = (Button)sender;
            seach = txtName.Text;
            Response.Write(seach);
            this.tabel.Text = seach;
           GET("https://api.github.com/search/users?q="+seach);
        }

        void GET(string url)
        {

            WebClient wc = new WebClient();
            wc.Headers.Add("User-Agent: User");
            string json = wc.DownloadString(url);
            Response.Write(json);

        }
    }
}