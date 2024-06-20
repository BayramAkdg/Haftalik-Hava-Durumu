using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hava_Durumu
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        string city;

        private async void button1_Click(object sender, EventArgs e)
        {
            city = txtcity.Text; // TextBox'tan şehir adını al
            if (string.IsNullOrWhiteSpace(city)) // Eğer şehir adı boş veya geçersizse
            {
                MessageBox.Show("Lütfen geçerli bir şehir adı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }

            string uri = $"http://api.openweathermap.org/data/2.5/forecast?q={city}&appid=549070366c9e28bf92b1f55cf110263f&units=metric"; // API isteği için URI oluştur

            try
            {
                string response = await client.GetStringAsync(uri); // API'den JSON yanıtını al
                JObject weatherData = JsonConvert.DeserializeObject<JObject>(response); // JSON yanıtını JObject'e dönüştür

                if (weatherData["cod"].ToString() != "200") 
                {
                    MessageBox.Show("Şehir bulunamadı. Lütfen doğru bir şehir adı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string iconUri = $"http://openweathermap.org/img/w/{weatherData["list"][0]["weather"][0]["icon"]}.png"; // Hava durumu simgesi URI'si oluştur
                byte[] image = await client.GetByteArrayAsync(iconUri); // Simgeyi indir

                MemoryStream stream = new MemoryStream(image); // Simgeyi MemoryStream'e yükle
                Bitmap newBitmap = new Bitmap(stream); // MemoryStream'den Bitmap oluştur

                // Hava durumu bilgilerini JSON'dan çek ve değişkenlere ata
                string temp_max = weatherData["list"][0]["main"]["temp_max"].ToString();
                string temp_min = weatherData["list"][0]["main"]["temp_min"].ToString();
                string humidity = weatherData["list"][0]["main"]["humidity"].ToString();
                string maxwind = weatherData["list"][0]["wind"]["speed"].ToString();
                string country = weatherData["city"]["country"].ToString();
                string cloud = weatherData["list"][0]["weather"][0]["description"].ToString();

                // Bilgileri ilgili form elemanlarına yerleştir
                txtmaxtemp.Text = temp_max;
                txtmintemp.Text = temp_min;
                txtwind.Text = maxwind;
                txthumidity.Text = humidity;
                label7.Text = cloud;
                txtcountry.Text = country;
                pictureBox1.Image = newBitmap;
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("API'ye ulaşırken bir hata oluştu. Lütfen internet bağlantınızı kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmedik bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); // Yeni bir DataTable oluştur
            dt.Columns.Add("country", typeof(string));
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("Max Temp", typeof(string));
            dt.Columns.Add("Min Temp", typeof(string));
            dt.Columns.Add("wind", typeof(string));
            dt.Columns.Add("humidity", typeof(string));
            dt.Columns.Add("cloud", typeof(string));
            dt.Columns.Add("icon", typeof(Bitmap));

            city = txtcity.Text; // TextBox'tan şehir adını al
            if (string.IsNullOrWhiteSpace(city))
            {
                MessageBox.Show("Lütfen geçerli bir şehir adı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string uri = $"http://api.openweathermap.org/data/2.5/forecast?q={city}&appid=549070366c9e28bf92b1f55cf110263f&units=metric"; // API isteği için URI oluştur

            try
            {
                string response = await client.GetStringAsync(uri); // API'den JSON yanıtını al
                JObject weatherData = JsonConvert.DeserializeObject<JObject>(response); // JSON yanıtını JObject'e dönüştür

                if (weatherData["cod"].ToString() != "200")
                {
                    MessageBox.Show("Şehir bulunamadı. Lütfen doğru bir şehir adı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (var item in weatherData["list"]) // JSON listesindeki her öğe için
                {
                    string iconUri = $"http://openweathermap.org/img/w/{item["weather"][0]["icon"]}.png"; // Hava durumu simgesi URI'si oluştur
                    byte[] image = await client.GetByteArrayAsync(iconUri); // Simgeyi indir

                    MemoryStream stream = new MemoryStream(image);
                    Bitmap newBitmap = new Bitmap(stream);

                    // Her bir satır için verileri DataTable'e ekle
                    dt.Rows.Add(new object[]
                    {
                        weatherData["city"]["country"].ToString(),
                        item["dt_txt"].ToString(),
                        item["main"]["temp_max"].ToString(),
                        item["main"]["temp_min"].ToString(),
                        item["wind"]["speed"].ToString(),
                        item["main"]["humidity"].ToString(),
                        item["weather"][0]["description"].ToString(),
                        newBitmap
                    });
                }

                dataGridView1.DataSource = dt; // DataTable'i DataGridView'e ata
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("API'ye ulaşırken bir hata oluştu. Lütfen internet bağlantınızı kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmedik bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
