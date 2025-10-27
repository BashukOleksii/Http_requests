using SubscriptionManager.Core.Models;
using System.Net.Http.Json; // Потрібен NuGet 'System.Net.Http.Json'
using System.Text.Json;

namespace SubscriptionManager.Client
{
    public partial class Form1 : Form
    {
        // === ВАЖЛИВО! ===
        // Зміни цей URL на той, де запущено твій API
        private const string BASE_URL = "http://localhost:5070";
        // ===============

        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonOptions;

        public Form1()
        {
            InitializeComponent(); // Цей метод генерується дизайнером

            // Налаштовуємо HttpClient
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(BASE_URL)
            };

            // Налаштовуємо JSON, щоб імена властивостей (Id, Name) 
            // не були чутливі до регістру при десеріалізації
            _jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }

        // --- Обробники подій для вкладки "Користувачі" ---

        private async void btnGetAllPeople_Click(object sender, EventArgs e)
        {
            try
            {
                // Очищуємо попередні результати
                dgvAllPeople.DataSource = null;

                // Робимо асинхронний запит до /api/People
                var peopleList = await _httpClient.GetFromJsonAsync<List<PeopleItem>>("api/People", _jsonOptions);

                // Відображаємо дані у DataGridView
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
                // Очищуємо поля
                txtNameResult.Text = "";
                txtEmailResult.Text = "";

                // Робимо запит до /api/People/{id}
                var person = await _httpClient.GetFromJsonAsync<PeopleItem>($"api/People/{id}", _jsonOptions);

                if (person != null)
                {
                    // Відображаємо результат
                    txtNameResult.Text = person.Name;
                    txtEmailResult.Text = person.Email;
                }
            }
            // Обробляємо випадок, коли API повертає 404 (NotFound)
            catch (HttpRequestException httpEx) when (httpEx.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                MessageBox.Show($"Користувача з ID '{id}' не знайдено.", "Не знайдено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при отриманні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}