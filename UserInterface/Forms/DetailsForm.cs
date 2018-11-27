using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Models;

namespace UserInterface.Forms
{
    public partial class DetailsForm : Form
    {
        private Post post;

        public DetailsForm(Post post)
        {
            InitializeComponent();
            this.post = post;
        }

        private void Details_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = new List<Post> { post };
        }
    }
}
