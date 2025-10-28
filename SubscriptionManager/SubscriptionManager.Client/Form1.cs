using SubscriptionManager.Core.Models;
using System.Net.Http.Json; // ������� NuGet 'System.Net.Http.Json'
using System.Text.Json;

namespace SubscriptionManager.Client
{
    public partial class Form1 : Form
    {
        // ������������� ���� 5070
        private const string BASE_URL = "http://localhost:5070";

        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonOptions;

        public Form1()
        {
            InitializeComponent();

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(BASE_URL)
            };

            _jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }

        // --- �������� PUT (���������) ---
        private async void btnUpdatePerson_Click(object sender, EventArgs e)
        {
            // 1. ������� ��� � ����
            string id = txtUpdateId.Text.Trim();
            string name = txtUpdateName.Text.Trim();
            string email = txtUpdateEmail.Text.Trim();

            // 2. ��������
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("ID, ��'� �� Email �� ������ ���� ��������.", "������� ��������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. ��������� ��'��� ��� ���������
            var updatedPerson = new PeopleItem
            {
                Id = id, // �������� ID, ��� �����, ���� �������� ����������
                Name = name,
                Email = email
            };

            try
            {
                // 4. ³���������� PUT-�����
                var response = await _httpClient.PutAsJsonAsync($"api/People/{id}", updatedPerson, _jsonOptions);

                // 5. ���������� �������
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"����������� � ID: {id} ������ ��������!", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // ������� ����
                    txtUpdateId.Text = "";
                    txtUpdateName.Text = "";
                    txtUpdateEmail.Text = "";
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show($"����������� � ID '{id}' �� ��������.", "�� ��������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"�������: {response.StatusCode}\n{errorContent}", "������� �������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������� �������: {ex.Message}", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPageUpdatePerson_Click(object sender, EventArgs e)
        {

        }
    }
}