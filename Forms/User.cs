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
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
           var response= await userhelper.GetAll();
            txtresponse.Text = userhelper.beautifyJson(response);
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            var response = await userhelper.Post(txtName.Text,txtEmail.Text,txtgender.Text,txtstatus.Text);
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
                var response = await userhelper.Put(txtuserid.Text, txtName.Text, txtEmail.Text, txtgender.Text, txtstatus.Text);
                txtresponse.Text = userhelper.beautifyJson(response);
            }
            else
            {
                MessageBox.Show("please enter the Id for which you want to update details.");
            }
        }

        private async void btndelete_Click(object sender, EventArgs e)
        {
            var response = await userhelper.Delete(txtid.Text);
            txtresponse.Text = response;
        }

        private async void getbyName_Click(object sender, EventArgs e)
        {
            var response = await userhelper.GetByName(txtbyname.Text);
            txtresponse.Text = userhelper.beautifyJson(response);
        }
    }
}
