using SubscriptionManager.Core.Models;
using System.Net.Http.Json; // ������� NuGet 'System.Net.Http.Json'
using System.Text.Json;

namespace SubscriptionManager.Client
{
    public partial class Form1 : Form
    {
        // === �������! ===
        // ���� ��� URL �� ���, �� �������� ��� API
        private const string BASE_URL = "http://localhost:5070";
        // ===============

        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonOptions;

        public Form1()
        {
            InitializeComponent(); // ��� ����� ���������� ����������

            // ����������� HttpClient
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(BASE_URL)
            };

            // ����������� JSON, ��� ����� ������������ (Id, Name) 
            // �� ���� ������ �� ������� ��� ������������
            _jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }

        // --- ��������� ���� ��� ������� "�����������" ---

        private async void btnGetAllPeople_Click(object sender, EventArgs e)
        {
            try
            {
                // ������� �������� ����������
                dgvAllPeople.DataSource = null;

                // ������ ����������� ����� �� /api/People
                var peopleList = await _httpClient.GetFromJsonAsync<List<PeopleItem>>("api/People", _jsonOptions);

                // ³��������� ��� � DataGridView
                if (peopleList != null && peopleList.Any())
                {
                    dgvAllPeople.DataSource = peopleList;
                }
                else
                {
                    MessageBox.Show("������ ������������ �������.", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������� ��� �������� �����: {ex.Message}", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGetPersonById_Click(object sender, EventArgs e)
        {
            string id = txtPersonId.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("���� �����, ������ ID.", "������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // ������� ����
                txtNameResult.Text = "";
                txtEmailResult.Text = "";

                // ������ ����� �� /api/People/{id}
                var person = await _httpClient.GetFromJsonAsync<PeopleItem>($"api/People/{id}", _jsonOptions);

                if (person != null)
                {
                    // ³��������� ���������
                    txtNameResult.Text = person.Name;
                    txtEmailResult.Text = person.Email;
                }
            }
            // ���������� �������, ���� API ������� 404 (NotFound)
            catch (HttpRequestException httpEx) when (httpEx.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                MessageBox.Show($"����������� � ID '{id}' �� ��������.", "�� ��������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������� ��� �������� �����: {ex.Message}", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}