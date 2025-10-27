using SubscriptionManager.Core.Models;
using System.Net.Http.Json; // Потрібен NuGet 'System.Net.Http.Json'
using System.Text;
using System.Text.Json;

namespace SubscriptionManager.Client
{
    public partial class Form1 : Form
    {
        // Використовуємо порт 5070
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

        // --- Обробник GET (Всі) ---
        private async void btnGetAllPeople_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAllPeople.DataSource = null;
                var peopleList = await _httpClient.GetFromJsonAsync<List<PeopleItem>>("api/People", _jsonOptions);

                if (peopleList != null && peopleList.Any())
                {
                    dgvAllPeople.DataSource = peopleList;
                }
                else
                {
                    MessageBox.Show("Список користувачів порожній.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при отриманні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Обробник GET (за ID) ---
        private async void btnGetPersonById_Click(object sender, EventArgs e)
        {
            string id = txtPersonId.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Будь ласка, введіть ID.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                txtNameResult.Text = "";
                txtEmailResult.Text = "";

                var person = await _httpClient.GetFromJsonAsync<PeopleItem>($"api/People/{id}", _jsonOptions);

                if (person != null)
                {
                    txtNameResult.Text = person.Name;
                    txtEmailResult.Text = person.Email;
                }
            }
            catch (HttpRequestException httpEx) when (httpEx.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                MessageBox.Show($"Користувача з ID '{id}' не знайдено.", "Не знайдено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при отриманні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Обробник POST (Створення) ---
        private async void btnCreatePerson_Click(object sender, EventArgs e)
        {
            string name = txtCreateName.Text.Trim();
            string email = txtCreateEmail.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Ім'я та Email не можуть бути порожніми.", "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newPerson = new PeopleItem
            {
                Name = name,
                Email = email
            };

            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/People", newPerson, _jsonOptions);

                if (response.IsSuccessStatusCode)
                {
                    var createdPerson = await response.Content.ReadFromJsonAsync<PeopleItem>(_jsonOptions);
                    MessageBox.Show($"Користувача успішно створено!\nID: {createdPerson?.Id}\nІм'я: {createdPerson?.Name}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCreateName.Text = "";
                    txtCreateEmail.Text = "";
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Помилка: {response.StatusCode}\n{errorContent}", "Помилка сервера", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}