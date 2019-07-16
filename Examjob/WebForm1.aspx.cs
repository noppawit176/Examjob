using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;

namespace Examjob
{
    public class User
    {
        public string login { get; set; }
        public int id { get; set; }
        public string node_id { get; set; }
        public string avatar_url { get; set; }
        public string gravatar_id { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string followers_url { get; set; }
        public string following_url { get; set; }
        public string gists_url { get; set; }
        public string starred_url { get; set; }
        public string subscriptions_url { get; set; }
        public string organizations_url { get; set; }
        public string repos_url { get; set; }
        public string events_url { get; set; }
        public string received_events_url { get; set; }
        public string type { get; set; }
        public bool site_admin { get; set; }
        public double score { get; set; }
    }

    public class RootObject
    {
        public int total_count { get; set; }
        public bool incomplete_results { get; set; }
        public List<User> items { get; set; }


    }
    public partial class WebForm1 : System.Web.UI.Page
    {
        RootObject r;
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
          
            if (!string.IsNullOrEmpty(seach)) { 
           GET("https://api.github.com/search/users?q="+seach);

                String alluser="";
                for(int i = 0; i < r.total_count - 1; i++)
                {
    

                    alluser = alluser+"<a href='"+r.items.ElementAt(i).html_url +"' >" + r.items.ElementAt(i).login+ "</a>" + "<br>";
                }
                usertext.Text =alluser ;
        }   
            else { Response.Write("insert text for search"); }
             }


        void GET(string url)
        {

            WebClient wc = new WebClient();
            wc.Headers.Add("User-Agent: User");
            string json = wc.DownloadString(url);
            JObject Rjson = JObject.Parse(json);
            r = JsonConvert.DeserializeObject<RootObject>(json);
            Response.Write(r.total_count);


        }


    }
}