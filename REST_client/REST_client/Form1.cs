using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REST_client
{
    public partial class Form1 : Form
    {
        String URL = "http://localhost/REST_QLCBH6/";
        String ROUTE = "index.php";
        int id = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void GetAll_btn_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.GET);

            IRestResponse<List<Autok>> response = client.Execute<List<Autok>>(request);
            autok_dgv.Rows.Clear();
            foreach (Autok v in response.Data)
            {
                autok_dgv.Rows.Add(v.id, v.tulajdonos, v.marka, v.tipus, v.szin, v.rendszam);
            }
        }

        private void GetCarById_btn_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            String ROUTE = "index.php?id=" + get_car_by_id_numeric.Value;
            var request = new RestRequest(ROUTE, Method.GET);

            IRestResponse<List<Autok>> response = client.Execute<List<Autok>>(request);

            if (get_car_by_id_numeric.Value != 0 && response.Data != null)
            {
                autok_dgv.Rows.Clear();
                autok_dgv.Rows.Add(response.Data[0].id, response.Data[0].tulajdonos,
                    response.Data[0].marka, response.Data[0].tipus, response.Data[0].szin, response.Data[0].rendszam);
            }
            else
            {
                MessageBox.Show("No car with this ID.");
            }

        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            string ROUTE = "index.php/?id=" + delete_id_numeric.Value;
            var request = new RestRequest(ROUTE, Method.DELETE);

            request.AddJsonBody(new { username = username_tb.Text, password = password_tb.Text });

            IRestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Car deleted succesfully");
            }
            else
            {
                MessageBox.Show("Car deletion failed: missing ID or unauthorized");
            }
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.POST);

            request.AddJsonBody(new
            {
                username = username_tb.Text,
                password = password_tb.Text,
                tulajdonos = tulajdonos_tb.Text,
                marka = marka_tb.Text,
                tipus = tipus_tb.Text,
                szin = szin_tb.Text,
                rendszam = rendszam_tb.Text
            });

            IRestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Car inserted succesfully");
            }
            else
            {
                MessageBox.Show("Car insertion failed: unauthorized");
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.PUT);

            request.AddJsonBody(new
            {
                username = username_tb.Text,
                password = password_tb.Text,
                tulajdonos = tulajdonos_update_tb.Text,
                marka = marka_update_tb.Text,
                tipus = tipus_update_tb.Text,
                szin = szin_update_tb.Text,
                rendszam = rendszam_update_tb.Text,
                id = id
            });

            IRestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Car updated succesfully");
            }
            else
            {
                MessageBox.Show("Car update failed: unauthorized");
            }
        }

        private void autok_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex > -1 && e.RowIndex < autok_dgv.Rows.Count - 1)
            {
                id = int.Parse(autok_dgv[0, e.RowIndex].Value.ToString());
                tulajdonos_update_tb.Text = autok_dgv[1, e.RowIndex].Value.ToString();
                marka_update_tb.Text = autok_dgv[2, e.RowIndex].Value.ToString();
                tipus_update_tb.Text = autok_dgv[3, e.RowIndex].Value.ToString();
                szin_update_tb.Text = autok_dgv[4, e.RowIndex].Value.ToString();
                rendszam_update_tb.Text = autok_dgv[5, e.RowIndex].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please click to the button! ");
            }         
        }
    }
}
