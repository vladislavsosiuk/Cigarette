using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using UserInterface.Models;
using Newtonsoft.Json;

namespace UserInterface.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("main form has been loaded");
            WebClient client = new WebClient();
            string result = await client.DownloadStringTaskAsync("https://jsonplaceholder.typicode.com/posts");
            List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(result);
            listBox1.DataSource = posts;
            listBox1.DisplayMember = nameof(Post.Title);
        }

    }
}
