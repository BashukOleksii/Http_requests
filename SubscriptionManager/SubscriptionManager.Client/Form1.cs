using SubscriptionManager.Core.Models;
using System.Net.Http.Json;
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

        // =============================================
        // === МЕТОДИ ДЛЯ КОРИСТУВАЧІВ (PEOPLE) ===
        // =============================================

        #region People Handlers

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

        private async void btnCreatePerson_Click(object sender, EventArgs e)
        {
            string name = txtCreateName.Text.Trim();
            string email = txtCreateEmail.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Ім'я та Email не можуть бути порожніми.", "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newPerson = new PeopleItem { Name = name, Email = email };

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

        private async void btnUpdatePerson_Click(object sender, EventArgs e)
        {
            string id = txtUpdateId.Text.Trim();
            string name = txtUpdateName.Text.Trim();
            string email = txtUpdateEmail.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("ID, Ім'я та Email не можуть бути порожніми.", "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var updatedPerson = new PeopleItem { Id = id, Name = name, Email = email };

            try
            {
                var response = await _httpClient.PutAsJsonAsync($"api/People/{id}", updatedPerson, _jsonOptions);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Користувача з ID: {id} успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        
        private async void btnDeletePerson_Click(object sender, EventArgs e)
        {
            string id = txtDeleteId.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Будь ласка, введіть ID.", "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show($"Ви впевнені, що хочете видалити користувача з ID: {id}?",
                                                 "Підтвердіть видалення",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.No)
            {
                return;
            }

            try
            {
                var response = await _httpClient.DeleteAsync($"api/People/{id}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Користувача з ID: {id} успішно видалено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDeleteId.Text = "";
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

        #endregion

        // ==================================================
        // === МЕТОДИ ДЛЯ ПІДПИСОК (SUBSCRIPTIONS) ===
        // ==================================================

        #region Subscription Handlers

        private async void btnGetAllSubscriptions_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAllSubscriptions.DataSource = null;
                var subList = await _httpClient.GetFromJsonAsync<List<SubscriptionItem>>("api/Subscriptions", _jsonOptions);

                if (subList != null && subList.Any())
                {
                    dgvAllSubscriptions.DataSource = subList;
                }
                else
                {
                    MessageBox.Show("Список підписок порожній.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при отриманні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGetSubscriptionById_Click(object sender, EventArgs e)
        {
            string id = txtSubscriptionId.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Будь ласка, введіть ID.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                txtSubOwnerIdResult.Text = "";
                txtSubServiceResult.Text = "";
                txtSubStatusResult.Text = "";

                var sub = await _httpClient.GetFromJsonAsync<SubscriptionItem>($"api/Subscriptions/{id}", _jsonOptions);

                if (sub != null)
                {
                    txtSubOwnerIdResult.Text = sub.OwnerId;
                    txtSubServiceResult.Text = sub.Service;
                    txtSubStatusResult.Text = sub.Status.ToString();
                }
            }
            catch (HttpRequestException httpEx) when (httpEx.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                MessageBox.Show($"Підписку з ID '{id}' не знайдено.", "Не знайдено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при отриманні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnCreateSubscription_Click(object sender, EventArgs e)
        {
            string ownerId = txtCreateSubOwnerId.Text.Trim();
            string service = txtCreateSubService.Text.Trim();
            string statusStr = txtCreateSubStatus.Text.Trim();

            if (string.IsNullOrEmpty(ownerId) || string.IsNullOrEmpty(service) || string.IsNullOrEmpty(statusStr))
            {
                MessageBox.Show("Owner ID, Сервіс та Статус не можуть бути порожніми.", "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(statusStr, out int statusInt) || !Enum.IsDefined(typeof(SubStatus), statusInt))
            {
                 MessageBox.Show("Невірний формат статусу. Введіть число (напр., 1 = Expectation, 2 = Active).", "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
            }

            var newSub = new SubscriptionItem
            {
                OwnerId = ownerId,
                Service = service,
                Status = (SubStatus)statusInt
            };

            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/Subscriptions", newSub, _jsonOptions);

                if (response.IsSuccessStatusCode)
                {
                    var createdSub = await response.Content.ReadFromJsonAsync<SubscriptionItem>(_jsonOptions);
                    MessageBox.Show($"Підписку успішно створено!\nID: {createdSub?.Id}\nСервіс: {createdSub?.Service}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCreateSubOwnerId.Text = "";
                    txtCreateSubService.Text = "";
                    txtCreateSubStatus.Text = "";
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

        // --- (НОВЕ) Обробник PUT (Оновлення Subscription) ---
        private async void btnUpdateSubscription_Click(object sender, EventArgs e)
        {
            // 1. Збираємо дані
            string id = txtUpdateSubId.Text.Trim();
            string ownerId = txtUpdateSubOwnerId.Text.Trim();
            string service = txtUpdateSubService.Text.Trim();
            string statusStr = txtUpdateSubStatus.Text.Trim();

            // 2. Валідація
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(ownerId) || string.IsNullOrEmpty(service) || string.IsNullOrEmpty(statusStr))
            {
                MessageBox.Show("ID, Owner ID, Сервіс та Статус не можуть бути порожніми.", "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(statusStr, out int statusInt) || !Enum.IsDefined(typeof(SubStatus), statusInt))
            {
                MessageBox.Show("Невірний формат статусу. Введіть число (напр., 1 = Expectation, 2 = Active).", "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Створюємо об'єкт
            var updatedSub = new SubscriptionItem
            {
                Id = id,
                OwnerId = ownerId,
                Service = service,
                Status = (SubStatus)statusInt
            };

            try
            {
                // 4. Відправляємо PUT-запит
                var response = await _httpClient.PutAsJsonAsync($"api/Subscriptions/{id}", updatedSub, _jsonOptions);

                // 5. Обробляємо відповідь
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Підписку з ID: {id} успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Очищуємо поля
                    txtUpdateSubId.Text = "";
                    txtUpdateSubOwnerId.Text = "";
                    txtUpdateSubService.Text = "";
                    txtUpdateSubStatus.Text = "";
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show($"Підписку з ID '{id}' не знайдено.", "Не знайдено", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        #endregion
    }
}