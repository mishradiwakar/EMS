using EMS.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace EMS
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            //Gender 
            Dictionary<string, string> comboGender = new Dictionary<string, string>();
            comboGender.Add("m", "male");
            comboGender.Add("f", "female");
            txtGender.DataSource = new BindingSource(comboGender, null);
            txtGender.DisplayMember = "Value";
            txtGender.ValueMember = "Key";
            //Status
            Dictionary<string, string> combostatue = new Dictionary<string, string>();
            combostatue.Add("a", "active");
            combostatue.Add("n", "inactive");
            txtStatus.DataSource = new BindingSource(combostatue, null);
            txtStatus.DisplayMember = "Value";
            txtStatus.ValueMember = "Key";
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
           var response= await userhelper.GetAll();
            txtresponse.Text = userhelper.beautifyJson(response);
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            var response = await userhelper.Post(txtName.Text,txtEmail.Text,txtGender.Text,txtStatus.Text);
            txtresponse.Text = userhelper.beautifyJson(response);
        }

        private async void btnSingleUser_Click(object sender, EventArgs e)
        {
            var response = await userhelper.Get(txtid.Text);
            txtresponse.Text = userhelper.beautifyJson(response);
        }

        private async void btnPut_Click(object sender, EventArgs e)
        {
            if (txtuserid.Text != "")
            {
                var response = await userhelper.Put(txtuserid.Text, txtName.Text, txtEmail.Text, txtGender.Text, txtStatus.Text);
                txtresponse.Text = userhelper.beautifyJson(response);
            }
            else
            {
                MessageBox.Show("please enter the Id for which you want to update details.");
            }
        }

        private async void btndelete_Click(object sender, EventArgs e)
        {
            var response = await Delete(txtid.Text);
            txtresponse.Text = response;
        }
        private static async Task<string> Delete(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.DeleteAsync("https://gorest.co.in/public/v2/users/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        MessageBox.Show(((int)res.StatusCode).ToString());
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }

                }

            }
            return string.Empty;

        }

        private async void getbyName_Click(object sender, EventArgs e)
        {
            var response = await userhelper.GetByName(txtbyname.Text);
            txtresponse.Text = userhelper.beautifyJson(response);
        }
    }
}
