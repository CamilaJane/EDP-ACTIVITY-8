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
using Newtonsoft.Json;

namespace WindowsFormsAppAPI
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtOutput.Clear();
                HttpResponseMessage response = await client.GetAsync("http://localhost/PHPAPI/API.php?type=GET_BorrowedBooks");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                txtOutput.Text = responseBody;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var borrowedBookData = new { book_name = txtbookname.Text, student_id = txtstudent_id.Text, borrow_date = txtborrow_date.Text, return_date = txtreturn_date.Text };
            string json = JsonConvert.SerializeObject(borrowedBookData);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync("http://localhost/PHPAPI/API.php?type=POST_BorrowedBooks", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                txtOutput.Text = responseBody;

                // Clear text fields
                txtbookname.Text = "";
                txtstudent_id.Text = "";
                txtborrow_date.Text = "";
                txtreturn_date.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
