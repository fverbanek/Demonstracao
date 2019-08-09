using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Destinadas
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            
            DateTime dataini;
            DateTime datafim;
            string last_id = "";
            
            dataini = DateTime.Parse(txtDtInicial.Text);
            datafim = DateTime.Parse(txtDtFinal.Text);
            API busca = new API(txtToken.Text, txtLogin.Text, txtSenha.Text);

            txtRetorno.Text = busca.RetornaChaveXML(dataini,datafim,"NFE", last_id);
            var teste = txtRetorno.Text;
            dynamic result = JsonConvert.DeserializeObject(txtRetorno.Text);


            foreach (var item in result.data.invoices)
            {
                txtRetorno.Text = txtRetorno.Text + " / " + item.key;
            }
            
        }
    }
}
