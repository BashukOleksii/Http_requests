using SubscriptionManager.Core.Models;
using System.Net.Http.Json; // ������� NuGet 'System.Net.Http.Json'
using System.Text.Json;

namespace SubscriptionManager.Client
{
    public partial class Form1 : Form
    {
        // === �������! ===
        // ����������� ����
        private const string BASE_URL = "http://localhost:5070";
        // ===============

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

        // --- �������� ��䳿 ��� POST ---

        private async void btnCreatePerson_Click(object sender, EventArgs e)
        {
            // 1. ������� ��� � ����
            string name = txtCreateName.Text.Trim();
            string email = txtCreateEmail.Text.Trim();

            // 2. ������ ��������
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("��'� �� Email �� ������ ���� ��������.", "������� ��������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. ��������� ��'��� ��� ��������
            var newPerson = new PeopleItem
            {
                // Id ���� �������� �������� (MongoDB), ���� ��� ���� �� �������
                Name = name,
                Email = email
            };

            try
            {
                // 4. ³���������� POST-�����
                var response = await _httpClient.PostAsJsonAsync("api/People", newPerson, _jsonOptions);

                // 5. ���������� �������
                if (response.IsSuccessStatusCode)
                {
                    var createdPerson = await response.Content.ReadFromJsonAsync<PeopleItem>(_jsonOptions);
                    MessageBox.Show($"����������� ������ ��������!\nID: {createdPerson?.Id}\n��'�: {createdPerson?.Name}", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // ������� ����
                    txtCreateName.Text = "";
                    txtCreateEmail.Text = "";
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
    }
}