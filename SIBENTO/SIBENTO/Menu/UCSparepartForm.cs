using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using SIBENTO.Class.Utility;
using SIBENTO.Class.Model;
using System.IO;
using System.Drawing.Imaging;

namespace SIBENTO
{
    public partial class UCSparepartForm : UserControl
    {
        string ID;
        private static UCSparepartForm _instance;
        static HttpClient client = new HttpClient();

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (Visible && !Disposing)
            {
                Debug.WriteLine("FORM SPAREPART LOADED");
            }; //<-- your population logic
        }

        protected override void OnLoad(EventArgs e)
        {

            ///More code here...
            base.OnLoad(e);
        }

        public static UCSparepartForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCSparepartForm();
                return _instance;
            }
        }

        public void transactionData(Dictionary<string, string> data)
        {
            ID = data["id"];
            txtKodeSparepart.Text = ID;
            txtSparepart.Text = data["name"];
            txtMerk.Text = data["brand"];
            txtMinStok.Text = data["min_stock"];
            txtStok.Text = data["stock"];
            txtHargaBeli.Text = data["buy_price"];
            txtHargaJual.Text = data["sell_price"];
            txtNomer.Text = data["placement_number"];
            txtGambar.Text = data["image"];
            cmbTipe.Text = data["type"];
            cmbPosition.Text = data["placement_position"];
            cmbPlace.Text = data["placement_place"];
        }

        public UCSparepartForm()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("http://sibento.yafetrakan.com/");
            dropdownLoad();
            dropDownPlacement();

            //if (ID != "" || ID != null)
            //{
            //    txtKodeSparepart.ReadOnly = true;
            //}
        }

        public class position
        {
            public string val { get; set; }
            public string posisi { get; set; }
        }

        public class place
        {
            public string val { get; set; }
            public string tempat { get; set; }
        }

        private async void dropdownLoad()
        {
            //disableInput();
          
            //load combobox jabatan
            cmbTipe.DataSource = await GetTipe();
            cmbTipe.ValueMember = "id";
            cmbTipe.DisplayMember = "name";
        }

        private void dropDownPlacement()
        {
            //dropdown placement position
            List<position> LstPosisi = new List<position>()
            {
                new position(){val = "DPN", posisi = "DPN" },
                new position(){val = "TGH", posisi = "TGH" },
                new position(){val = "BLK", posisi = "BLK" },
            };
            cmbPosition.DataSource = LstPosisi;
            cmbPosition.DisplayMember = "posisi";
            cmbPosition.ValueMember = "val";

            //Dropdown placement place
            List<place> LstPlace = new List<place>()
            {
                new place(){val = "KACA", tempat = "KACA" },
                new place(){val = "DUS", tempat = "DUS" },
                new place(){val = "BAN", tempat = "BAN" },
                new place(){val = "KAYU", tempat = "KAYU" }
            };
            cmbPlace.DataSource = LstPlace;
            cmbPlace.DisplayMember = "tempat";
            cmbPlace.ValueMember = "val";
        }

        //setingan textbox input
        public void disableInput()
        {
            txtKodeSparepart.Enabled = false;
            txtSparepart.Enabled = false;
            txtHargaBeli.Enabled = false;
            txtHargaJual.Enabled = false;
            txtMerk.Enabled = false;
            txtMinStok.Enabled = false;
            txtNomer.Enabled = false;
            txtStok.Enabled = false;
            txtGambar.Enabled = false;
        }

        public void enableInput()
        {
            txtKodeSparepart.Enabled = true;
            txtHargaBeli.Enabled = true;
            txtHargaJual.Enabled = true;
            txtMerk.Enabled = true;
            txtMinStok.Enabled = true;
            txtNomer.Enabled = true;
            txtSparepart.Enabled = true;
            txtStok.Enabled = true;
            txtGambar.Enabled = true;
        }

        public void clearInput()
        {
            txtKodeSparepart.Text = "";
            txtHargaBeli.Text = "";
            txtHargaJual.Text = "";
            txtMerk.Text = "";
            txtMinStok.Text = "";
            txtNomer.Text = "";
            txtSparepart.Text = "";
            txtStok.Text = "";
            txtGambar.Text = "";
            imgBox.Image = null;
        }

        static async Task<DataTable> GetTipe()
        {
            //Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync("api/spareparttype");

            var arr = await response.Content.ReadAsStringAsync();
            DataTable DT = new DataTable();
            DT = json_convert(arr);
            Debug.WriteLine(DT.Rows.Count);
            
            return DT;
        }
        
        public static DataTable json_convert(string json)
        {
            JObject json_object = JObject.Parse(json);

            DataTable dt = new DataTable();

            JArray json_array = JArray.Parse(json_object["data"].ToString());
            dt = JsonConvert.DeserializeObject<DataTable>(json_array.ToString());

            return dt;
        }

        public static byte[] ImageToByteArray(Image img, PictureBox pictureBox)
        {
            MemoryStream ms = new MemoryStream();
            if (pictureBox.Image != null)
            {
                img.Save(ms, ImageFormat.Jpeg);
            }
            return ms.ToArray();
        }

        private async Task AddSparepartAsync(Dictionary<string, string> body)
        {
            JObject json = await ApiClient.SendPostRequest(body, "http://sibento.yafetrakan.com/api/sparepart");

            if (json.ContainsKey("error") || json.ContainsKey("errors"))
            {
                JToken jError = json.GetValue("error") ?? json.GetValue("errors");
                int count = jError.Children().Count<JToken>();
            }
            else
            {
                JToken respond = json.GetValue("data");

                Sparepart employee = (Sparepart)respond.ToObject(typeof(Sparepart));
                UCSparepart.Instance.loadSparepart();
            }
        }

        private async Task EditSparepartAsync(Dictionary<string, string> body, string id)
        {
            Debug.WriteLine("http://sibento.yafetrakan.com/api/sparepart/" + id);
            JObject json = await ApiClient.SendPutRequest(body, "http://sibento.yafetrakan.com/api/sparepart/" + id);

            if (json.ContainsKey("error") || json.ContainsKey("errors"))
            {
                Debug.WriteLine(" contain eror");
                JToken jError = json.GetValue("error") ?? json.GetValue("errors");
                int count = jError.Children().Count<JToken>();

            }
            else
            {
                Debug.WriteLine("not contain eror");
                JToken dataSparepart = json.GetValue("data");
                Sparepart sparepart = (Sparepart)dataSparepart.ToObject(typeof(Sparepart));
                //Debug.WriteLine(sparepart);

                UCSparepart.Instance.loadSparepart();
            }
        }

        private void btnCariGambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Choose Image";
            open.Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if(open.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(open.FileName);
                imgBox.Image = img;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> values = new Dictionary<string, string>();
            string placement = cmbPosition.SelectedValue.ToString()+"-"+cmbPlace.SelectedValue.ToString()+"-"+txtNomer.Text;
            byte[] byteImg = ImageToByteArray(imgBox.Image, imgBox);
            string img = Convert.ToBase64String(byteImg);
            //MemoryStream ms = new MemoryStream();
            //imgBox.Image.Save(ms, ImageFormat.Jpeg);
            //byte[] buff = ms.GetBuffer();
            Debug.WriteLine(img);

            values.Add("id_sparepart", txtKodeSparepart.Text);
            values.Add("name_sparepart", txtSparepart.Text);
            values.Add("brand_sparepart", txtMerk.Text);
            values.Add("stock_sparepart", txtStok.Text);
            values.Add("minimal_stock_sparepart", txtMinStok.Text);
            values.Add("buy_price", txtHargaBeli.Text);
            values.Add("sell_price", txtHargaJual.Text);
            values.Add("placement", placement);
            values.Add("image", img);
            values.Add("id_sparepart_type",cmbTipe.SelectedValue.ToString());
            
            if (ID != null)
            {
                Debug.WriteLine("masuk edit");
                EditSparepartAsync(values, ID);
            }
            else
            {
                Debug.WriteLine("masuk tambah");
                //Debug.WriteLine(values);
                AddSparepartAsync(values);
            }
            ID =null;

            clearInput();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ID = null;
            clearInput();
            UCSparepart.Instance.loadSparepart();
            UCSparepart.Instance.BringToFront();
        }
    }
}
