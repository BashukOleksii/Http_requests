using SubscriptionManager.Core.Models;
using System.Net.Http.Json; // Потрібен NuGet 'System.Net.Http.Json'
using System.Text.Json;

namespace SubscriptionManager.Client
{
    public partial class Form1 : Form
    {
        // === ВАЖЛИВО! ===
        // Виправлений порт
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

        // --- Обробник події для POST ---

        private async void btnCreatePerson_Click(object sender, EventArgs e)
        {
            // 1. Збираємо дані з полів
            string name = txtCreateName.Text.Trim();
            string email = txtCreateEmail.Text.Trim();

            // 2. Проста валідація
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Ім'я та Email не можуть бути порожніми.", "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Створюємо об'єкт для відправки
            var newPerson = new PeopleItem
            {
                // Id буде присвоєно сервером (MongoDB), тому тут його не вказуємо
                Name = name,
                Email = email
            };

            try
            {
                // 4. Відправляємо POST-запит
                var response = await _httpClient.PostAsJsonAsync("api/People", newPerson, _jsonOptions);

                // 5. Обробляємо відповідь
                if (response.IsSuccessStatusCode)
                {
                    var createdPerson = await response.Content.ReadFromJsonAsync<PeopleItem>(_jsonOptions);
                    MessageBox.Show($"Користувача успішно створено!\nID: {createdPerson?.Id}\nІм'я: {createdPerson?.Name}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Очищуємо поля
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