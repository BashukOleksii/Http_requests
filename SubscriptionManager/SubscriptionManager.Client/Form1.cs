using SubscriptionManager.Core.Models;
using System.Net.Http.Json; // Потрібен NuGet 'System.Net.Http.Json'
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

        // --- Обробник PUT (Оновлення) ---
        private async void btnUpdatePerson_Click(object sender, EventArgs e)
        {
            // 1. Збираємо дані з полів
            string id = txtUpdateId.Text.Trim();
            string name = txtUpdateName.Text.Trim();
            string email = txtUpdateEmail.Text.Trim();

            // 2. Валідація
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("ID, Ім'я та Email не можуть бути порожніми.", "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Створюємо об'єкт для оновлення
            var updatedPerson = new PeopleItem
            {
                Id = id, // Передаємо ID, щоб знати, який документ оновлювати
                Name = name,
                Email = email
            };

            try
            {
                // 4. Відправляємо PUT-запит
                var response = await _httpClient.PutAsJsonAsync($"api/People/{id}", updatedPerson, _jsonOptions);

                // 5. Обробляємо відповідь
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Користувача з ID: {id} успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Очищуємо поля
                    txtUpdateId.Text = "";
                    txtUpdateName.Text = "";
                    txtUpdateEmail.Text = "";
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show($"Користувача з ID '{id}' не знайдено.", "Не знайдено", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void tabPageUpdatePerson_Click(object sender, EventArgs e)
        {

        }
    }
}