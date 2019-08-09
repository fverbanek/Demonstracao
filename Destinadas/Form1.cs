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
    public partial class Destinadas : Form
    {

        public Destinadas()
        {
            InitializeComponent();
            txtLogin.Text = "lucas.santos@tecnospeed.com.br";
            txtSenha.Text = "n$260318";
            txtToken.Text = "e1260095f9df4c7c748d59d43b0658b9351d1c11";


        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {

            DateTime dataini;
            DateTime datafim;
            string last_id = "";

            try
            {
                dataini = DateTime.Parse(txtDtInicial.Text);
                datafim = DateTime.Parse(txtDtFinal.Text);
                API busca = new API(txtToken.Text, txtLogin.Text, txtSenha.Text);

                var teste = busca.RetornaChaveXML(dataini, datafim, "NFE", last_id);
                string key, id;
                dynamic result = JsonConvert.DeserializeObject(teste);


                List<Xml> xmls = new List<Xml>();
                foreach (var invoices in result.data.invoices)
                {
                    key = invoices.key;
                    id = invoices.id;
                    xmls.Add(new Xml(key, id));
                }


                int total = result.data.total;
                int count = result.data.count;
                last_id = result.data.last_id;
                total -= count;

                while (total > 0)
                {
                    teste = busca.RetornaChaveXML(dataini, datafim, "NFE", last_id);
                    result = JsonConvert.DeserializeObject(teste);

                    foreach (var invoices in result.data.invoices)
                    {
                        key = invoices.key;
                        id = invoices.id;
                        xmls.Add(new Xml(key, id));
                    }

                    last_id = result.data.last_id;
                    count = result.data.count;
                    total -= count;
                }
                this.dataGridView1.DataSource = xmls;


                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception erro) {
                MessageBox.Show(erro.Message);
            }
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                API busca = new API(txtToken.Text, txtLogin.Text, txtSenha.Text);
                var retorno = busca.RetornaXml(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                dynamic json = JsonConvert.DeserializeObject(retorno);


                txtRetorno.Text = json.data.xml.ToString();
                
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

    }

    class Xml
    {
        public string key { get; set; }
        public string id { get; set; }

        public Xml(string key, string id)
        {
            this.key = key;
            this.id = id;
        }
        public Xml(){ }
    }
}
