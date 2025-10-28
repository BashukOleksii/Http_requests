namespace SubscriptionManager.Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlMain = new TabControl();
            tabPagePeople = new TabPage();
            tabControlPeopleOperations = new TabControl();
            tabPageGetAllPeople = new TabPage();
            dgvAllPeople = new DataGridView();
            btnGetAllPeople = new Button();
            tabPageGetOnePerson = new TabPage();
            txtEmailResult = new TextBox();
            label3 = new Label();
            txtNameResult = new TextBox();
            label2 = new Label();
            btnGetPersonById = new Button();
            txtPersonId = new TextBox();
            label1 = new Label();
            tabPageCreatePerson = new TabPage();
            btnCreatePerson = new Button();
            txtCreateEmail = new TextBox();
            label5 = new Label();
            txtCreateName = new TextBox();
            label4 = new Label();
            tabPageUpdatePerson = new TabPage();
            btnUpdatePerson = new Button();
            txtUpdateEmail = new TextBox();
            label6 = new Label();
            txtUpdateName = new TextBox();
            label7 = new Label();
            txtUpdateId = new TextBox();
            label8 = new Label();
            tabPageDeletePerson = new TabPage();
            btnDeletePerson = new Button();
            txtDeleteId = new TextBox();
            label9 = new Label();
            tabPageSubscriptions = new TabPage();
            tabControlSubscriptionOperations = new TabControl();
            tabPageGetAllSubscriptions = new TabPage();
            dgvAllSubscriptions = new DataGridView();
            btnGetAllSubscriptions = new Button();
            tabPageGetOneSubscription = new TabPage();
            txtSubStatusResult = new TextBox();
            label13 = new Label();
            txtSubServiceResult = new TextBox();
            label12 = new Label();
            txtSubOwnerIdResult = new TextBox();
            label11 = new Label();
            btnGetSubscriptionById = new Button();
            txtSubscriptionId = new TextBox();
            label10 = new Label();
            tabPageCreateSubscription = new TabPage();
            btnCreateSubscription = new Button();
            txtCreateSubStatus = new TextBox();
            label16 = new Label();
            txtCreateSubService = new TextBox();
            label15 = new Label();
            txtCreateSubOwnerId = new TextBox();
            label14 = new Label();
            tabPageUpdateSubscription = new TabPage();
            btnUpdateSubscription = new Button();
            txtUpdateSubStatus = new TextBox();
            label17 = new Label();
            txtUpdateSubService = new TextBox();
            label18 = new Label();
            txtUpdateSubOwnerId = new TextBox();
            label19 = new Label();
            txtUpdateSubId = new TextBox();
            label20 = new Label();
            tabPageDeleteSubscription = new TabPage();
            btnDeleteSubscription = new Button();
            txtDeleteSubId = new TextBox();
            label21 = new Label();
            tabPageMessages = new TabPage();
            tabControlMessageOperations = new TabControl();
            tabPageGetAllMessages = new TabPage();
            dgvAllMessages = new DataGridView();
            btnGetAllMessages = new Button();
            tabPageGetOneMessage = new TabPage();
            txtMsgSubIdResult = new TextBox();
            label24 = new Label();
            txtMsgOwnerIdResult = new TextBox();
            label23 = new Label();
            txtMsgTitleResult = new TextBox();
            label22 = new Label();
            btnGetMessageById = new Button();
            txtMessageId = new TextBox();
            label25 = new Label();
            tabPageCreateMessage = new TabPage();
            tabPageUpdateMessage = new TabPage();
            tabPageDeleteMessage = new TabPage();
            tabControlMain.SuspendLayout();
            tabPagePeople.SuspendLayout();
            tabControlPeopleOperations.SuspendLayout();
            tabPageGetAllPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllPeople).BeginInit();
            tabPageGetOnePerson.SuspendLayout();
            tabPageCreatePerson.SuspendLayout();
            tabPageUpdatePerson.SuspendLayout();
            tabPageDeletePerson.SuspendLayout();
            tabPageSubscriptions.SuspendLayout();
            tabControlSubscriptionOperations.SuspendLayout();
            tabPageGetAllSubscriptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllSubscriptions).BeginInit();
            tabPageGetOneSubscription.SuspendLayout();
            tabPageCreateSubscription.SuspendLayout();
            tabPageUpdateSubscription.SuspendLayout();
            tabPageDeleteSubscription.SuspendLayout();
            tabPageMessages.SuspendLayout();
            tabControlMessageOperations.SuspendLayout();
            tabPageGetAllMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllMessages).BeginInit();
            tabPageGetOneMessage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPagePeople);
            tabControlMain.Controls.Add(tabPageSubscriptions);
            tabControlMain.Controls.Add(tabPageMessages);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Margin = new Padding(3, 4, 3, 4);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(896, 615);
            tabControlMain.TabIndex = 0;
            // 
            // tabPagePeople
            // 
            tabPagePeople.Controls.Add(tabControlPeopleOperations);
            tabPagePeople.Location = new Point(4, 29);
            tabPagePeople.Margin = new Padding(3, 4, 3, 4);
            tabPagePeople.Name = "tabPagePeople";
            tabPagePeople.Padding = new Padding(3, 4, 3, 4);
            tabPagePeople.Size = new Size(888, 582);
            tabPagePeople.TabIndex = 0;
            tabPagePeople.Text = "Користувачі (People)";
            tabPagePeople.UseVisualStyleBackColor = true;
            // 
            // tabControlPeopleOperations
            // 
            tabControlPeopleOperations.Controls.Add(tabPageGetAllPeople);
            tabControlPeopleOperations.Controls.Add(tabPageGetOnePerson);
            tabControlPeopleOperations.Controls.Add(tabPageCreatePerson);
            tabControlPeopleOperations.Controls.Add(tabPageUpdatePerson);
            tabControlPeopleOperations.Controls.Add(tabPageDeletePerson);
            tabControlPeopleOperations.Dock = DockStyle.Fill;
            tabControlPeopleOperations.Location = new Point(3, 4);
            tabControlPeopleOperations.Margin = new Padding(3, 4, 3, 4);
            tabControlPeopleOperations.Name = "tabControlPeopleOperations";
            tabControlPeopleOperations.SelectedIndex = 0;
            tabControlPeopleOperations.Size = new Size(882, 574);
            tabControlPeopleOperations.TabIndex = 0;
            // 
            // tabPageGetAllPeople
            // 
            tabPageGetAllPeople.Controls.Add(dgvAllPeople);
            tabPageGetAllPeople.Controls.Add(btnGetAllPeople);
            tabPageGetAllPeople.Location = new Point(4, 29);
            tabPageGetAllPeople.Margin = new Padding(3, 4, 3, 4);
            tabPageGetAllPeople.Name = "tabPageGetAllPeople";
            tabPageGetAllPeople.Padding = new Padding(3, 4, 3, 4);
            tabPageGetAllPeople.Size = new Size(874, 541);
            tabPageGetAllPeople.TabIndex = 0;
            tabPageGetAllPeople.Text = "Отримати всіх";
            tabPageGetAllPeople.UseVisualStyleBackColor = true;
            // 
            // dgvAllPeople
            // 
            dgvAllPeople.AllowUserToAddRows = false;
            dgvAllPeople.AllowUserToDeleteRows = false;
            dgvAllPeople.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAllPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllPeople.Location = new Point(7, 55);
            dgvAllPeople.Margin = new Padding(3, 4, 3, 4);
            dgvAllPeople.Name = "dgvAllPeople";
            dgvAllPeople.ReadOnly = true;
            dgvAllPeople.RowHeadersWidth = 51;
            dgvAllPeople.RowTemplate.Height = 25;
            dgvAllPeople.Size = new Size(859, 468);
            dgvAllPeople.TabIndex = 1;
            // 
            // btnGetAllPeople
            // 
            btnGetAllPeople.Location = new Point(7, 8);
            btnGetAllPeople.Margin = new Padding(3, 4, 3, 4);
            btnGetAllPeople.Name = "btnGetAllPeople";
            btnGetAllPeople.Size = new Size(137, 39);
            btnGetAllPeople.TabIndex = 0;
            btnGetAllPeople.Text = "Оновити список";
            btnGetAllPeople.UseVisualStyleBackColor = true;
            btnGetAllPeople.Click += btnGetAllPeople_Click;
            // 
            // tabPageGetOnePerson
            // 
            tabPageGetOnePerson.Controls.Add(txtEmailResult);
            tabPageGetOnePerson.Controls.Add(label3);
            tabPageGetOnePerson.Controls.Add(txtNameResult);
            tabPageGetOnePerson.Controls.Add(label2);
            tabPageGetOnePerson.Controls.Add(btnGetPersonById);
            tabPageGetOnePerson.Controls.Add(txtPersonId);
            tabPageGetOnePerson.Controls.Add(label1);
            tabPageGetOnePerson.Location = new Point(4, 29);
            tabPageGetOnePerson.Margin = new Padding(3, 4, 3, 4);
            tabPageGetOnePerson.Name = "tabPageGetOnePerson";
            tabPageGetOnePerson.Padding = new Padding(3, 4, 3, 4);
            tabPageGetOnePerson.Size = new Size(872, 536);
            tabPageGetOnePerson.TabIndex = 1;
            tabPageGetOnePerson.Text = "Отримати за ID";
            tabPageGetOnePerson.UseVisualStyleBackColor = true;
            // 
            // txtEmailResult
            // 
            txtEmailResult.Location = new Point(22, 212);
            txtEmailResult.Margin = new Padding(3, 4, 3, 4);
            txtEmailResult.Name = "txtEmailResult";
            txtEmailResult.ReadOnly = true;
            txtEmailResult.Size = new Size(342, 27);
            txtEmailResult.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 188);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Email:";
            // 
            // txtNameResult
            // 
            txtNameResult.Location = new Point(22, 141);
            txtNameResult.Margin = new Padding(3, 4, 3, 4);
            txtNameResult.Name = "txtNameResult";
            txtNameResult.ReadOnly = true;
            txtNameResult.Size = new Size(342, 27);
            txtNameResult.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 117);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 3;
            label2.Text = "Ім'я:";
            // 
            // btnGetPersonById
            // 
            btnGetPersonById.Location = new Point(371, 44);
            btnGetPersonById.Margin = new Padding(3, 4, 3, 4);
            btnGetPersonById.Name = "btnGetPersonById";
            btnGetPersonById.Size = new Size(86, 31);
            btnGetPersonById.TabIndex = 2;
            btnGetPersonById.Text = "Знайти";
            btnGetPersonById.UseVisualStyleBackColor = true;
            btnGetPersonById.Click += btnGetPersonById_Click;
            // 
            // txtPersonId
            // 
            txtPersonId.Location = new Point(22, 45);
            txtPersonId.Margin = new Padding(3, 4, 3, 4);
            txtPersonId.Name = "txtPersonId";
            txtPersonId.Size = new Size(342, 27);
            txtPersonId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 0;
            label1.Text = "Введіть ID користувача:";
            // 
            // tabPageCreatePerson
            // 
            tabPageCreatePerson.Controls.Add(btnCreatePerson);
            tabPageCreatePerson.Controls.Add(txtCreateEmail);
            tabPageCreatePerson.Controls.Add(label5);
            tabPageCreatePerson.Controls.Add(txtCreateName);
            tabPageCreatePerson.Controls.Add(label4);
            tabPageCreatePerson.Location = new Point(4, 29);
            tabPageCreatePerson.Margin = new Padding(3, 4, 3, 4);
            tabPageCreatePerson.Name = "tabPageCreatePerson";
            tabPageCreatePerson.Size = new Size(872, 536);
            tabPageCreatePerson.TabIndex = 2;
            tabPageCreatePerson.Text = "Створити";
            tabPageCreatePerson.UseVisualStyleBackColor = true;
            // 
            // btnCreatePerson
            // 
            btnCreatePerson.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCreatePerson.Location = new Point(22, 183);
            btnCreatePerson.Margin = new Padding(3, 4, 3, 4);
            btnCreatePerson.Name = "btnCreatePerson";
            btnCreatePerson.Size = new Size(138, 41);
            btnCreatePerson.TabIndex = 4;
            btnCreatePerson.Text = "Створити";
            btnCreatePerson.UseVisualStyleBackColor = true;
            btnCreatePerson.Click += btnCreatePerson_Click;
            // 
            // txtCreateEmail
            // 
            txtCreateEmail.Location = new Point(22, 120);
            txtCreateEmail.Margin = new Padding(3, 4, 3, 4);
            txtCreateEmail.Name = "txtCreateEmail";
            txtCreateEmail.Size = new Size(342, 27);
            txtCreateEmail.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 96);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 2;
            label5.Text = "Введіть Email:";
            // 
            // txtCreateName
            // 
            txtCreateName.Location = new Point(22, 48);
            txtCreateName.Margin = new Padding(3, 4, 3, 4);
            txtCreateName.Name = "txtCreateName";
            txtCreateName.Size = new Size(342, 27);
            txtCreateName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 24);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 0;
            label4.Text = "Введіть ім'я:";
            // 
            // tabPageUpdatePerson
            // 
            tabPageUpdatePerson.Controls.Add(btnUpdatePerson);
            tabPageUpdatePerson.Controls.Add(txtUpdateEmail);
            tabPageUpdatePerson.Controls.Add(label6);
            tabPageUpdatePerson.Controls.Add(txtUpdateName);
            tabPageUpdatePerson.Controls.Add(label7);
            tabPageUpdatePerson.Controls.Add(txtUpdateId);
            tabPageUpdatePerson.Controls.Add(label8);
            tabPageUpdatePerson.Location = new Point(4, 29);
            tabPageUpdatePerson.Margin = new Padding(3, 4, 3, 4);
            tabPageUpdatePerson.Name = "tabPageUpdatePerson";
            tabPageUpdatePerson.Size = new Size(872, 536);
            tabPageUpdatePerson.TabIndex = 3;
            tabPageUpdatePerson.Text = "Оновити";
            tabPageUpdatePerson.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePerson
            // 
            btnUpdatePerson.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnUpdatePerson.Location = new Point(22, 256);
            btnUpdatePerson.Margin = new Padding(3, 4, 3, 4);
            btnUpdatePerson.Name = "btnUpdatePerson";
            btnUpdatePerson.Size = new Size(138, 41);
            btnUpdatePerson.TabIndex = 6;
            btnUpdatePerson.Text = "Оновити";
            btnUpdatePerson.UseVisualStyleBackColor = true;
            btnUpdatePerson.Click += btnUpdatePerson_Click;
            // 
            // txtUpdateEmail
            // 
            txtUpdateEmail.Location = new Point(22, 196);
            txtUpdateEmail.Margin = new Padding(3, 4, 3, 4);
            txtUpdateEmail.Name = "txtUpdateEmail";
            txtUpdateEmail.Size = new Size(342, 27);
            txtUpdateEmail.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 172);
            label6.Name = "label6";
            label6.Size = new Size(152, 20);
            label6.TabIndex = 4;
            label6.Text = "Введіть новий Email:";
            // 
            // txtUpdateName
            // 
            txtUpdateName.Location = new Point(22, 124);
            txtUpdateName.Margin = new Padding(3, 4, 3, 4);
            txtUpdateName.Name = "txtUpdateName";
            txtUpdateName.Size = new Size(342, 27);
            txtUpdateName.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 100);
            label7.Name = "label7";
            label7.Size = new Size(131, 20);
            label7.TabIndex = 2;
            label7.Text = "Введіть нове ім'я:";
            // 
            // txtUpdateId
            // 
            txtUpdateId.Location = new Point(22, 51);
            txtUpdateId.Margin = new Padding(3, 4, 3, 4);
            txtUpdateId.Name = "txtUpdateId";
            txtUpdateId.Size = new Size(342, 27);
            txtUpdateId.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 27);
            label8.Name = "label8";
            label8.Size = new Size(191, 20);
            label8.TabIndex = 0;
            label8.Text = "Введіть ID для оновлення:";
            // 
            // tabPageDeletePerson
            // 
            tabPageDeletePerson.Controls.Add(btnDeletePerson);
            tabPageDeletePerson.Controls.Add(txtDeleteId);
            tabPageDeletePerson.Controls.Add(label9);
            tabPageDeletePerson.Location = new Point(4, 29);
            tabPageDeletePerson.Margin = new Padding(3, 4, 3, 4);
            tabPageDeletePerson.Name = "tabPageDeletePerson";
            tabPageDeletePerson.Size = new Size(872, 536);
            tabPageDeletePerson.TabIndex = 4;
            tabPageDeletePerson.Text = "Видалити";
            tabPageDeletePerson.UseVisualStyleBackColor = true;
            // 
            // btnDeletePerson
            // 
            btnDeletePerson.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnDeletePerson.ForeColor = Color.Red;
            btnDeletePerson.Location = new Point(22, 100);
            btnDeletePerson.Margin = new Padding(3, 4, 3, 4);
            btnDeletePerson.Name = "btnDeletePerson";
            btnDeletePerson.Size = new Size(138, 41);
            btnDeletePerson.TabIndex = 2;
            btnDeletePerson.Text = "Видалити";
            btnDeletePerson.UseVisualStyleBackColor = true;
            btnDeletePerson.Click += btnDeletePerson_Click;
            // 
            // txtDeleteId
            // 
            txtDeleteId.Location = new Point(22, 48);
            txtDeleteId.Margin = new Padding(3, 4, 3, 4);
            txtDeleteId.Name = "txtDeleteId";
            txtDeleteId.Size = new Size(342, 27);
            txtDeleteId.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 24);
            label9.Name = "label9";
            label9.Size = new Size(189, 20);
            label9.TabIndex = 0;
            label9.Text = "Введіть ID для видалення:";
            // 
            // tabPageSubscriptions
            // 
            tabPageSubscriptions.Controls.Add(tabControlSubscriptionOperations);
            tabPageSubscriptions.Location = new Point(4, 29);
            tabPageSubscriptions.Margin = new Padding(3, 4, 3, 4);
            tabPageSubscriptions.Name = "tabPageSubscriptions";
            tabPageSubscriptions.Padding = new Padding(3, 4, 3, 4);
            tabPageSubscriptions.Size = new Size(888, 582);
            tabPageSubscriptions.TabIndex = 1;
            tabPageSubscriptions.Text = "Підписки (Subscriptions)";
            tabPageSubscriptions.UseVisualStyleBackColor = true;
            // 
            // tabControlSubscriptionOperations
            // 
            tabControlSubscriptionOperations.Controls.Add(tabPageGetAllSubscriptions);
            tabControlSubscriptionOperations.Controls.Add(tabPageGetOneSubscription);
            tabControlSubscriptionOperations.Controls.Add(tabPageCreateSubscription);
            tabControlSubscriptionOperations.Controls.Add(tabPageUpdateSubscription);
            tabControlSubscriptionOperations.Controls.Add(tabPageDeleteSubscription);
            tabControlSubscriptionOperations.Dock = DockStyle.Fill;
            tabControlSubscriptionOperations.Location = new Point(3, 4);
            tabControlSubscriptionOperations.Margin = new Padding(3, 4, 3, 4);
            tabControlSubscriptionOperations.Name = "tabControlSubscriptionOperations";
            tabControlSubscriptionOperations.SelectedIndex = 0;
            tabControlSubscriptionOperations.Size = new Size(882, 574);
            tabControlSubscriptionOperations.TabIndex = 0;
            // 
            // tabPageGetAllSubscriptions
            // 
            tabPageGetAllSubscriptions.Controls.Add(dgvAllSubscriptions);
            tabPageGetAllSubscriptions.Controls.Add(btnGetAllSubscriptions);
            tabPageGetAllSubscriptions.Location = new Point(4, 29);
            tabPageGetAllSubscriptions.Margin = new Padding(3, 4, 3, 4);
            tabPageGetAllSubscriptions.Name = "tabPageGetAllSubscriptions";
            tabPageGetAllSubscriptions.Padding = new Padding(3, 4, 3, 4);
            tabPageGetAllSubscriptions.Size = new Size(874, 541);
            tabPageGetAllSubscriptions.TabIndex = 0;
            tabPageGetAllSubscriptions.Text = "Отримати всіх";
            tabPageGetAllSubscriptions.UseVisualStyleBackColor = true;
            // 
            // dgvAllSubscriptions
            // 
            dgvAllSubscriptions.AllowUserToAddRows = false;
            dgvAllSubscriptions.AllowUserToDeleteRows = false;
            dgvAllSubscriptions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAllSubscriptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllSubscriptions.Location = new Point(7, 55);
            dgvAllSubscriptions.Margin = new Padding(3, 4, 3, 4);
            dgvAllSubscriptions.Name = "dgvAllSubscriptions";
            dgvAllSubscriptions.ReadOnly = true;
            dgvAllSubscriptions.RowHeadersWidth = 51;
            dgvAllSubscriptions.RowTemplate.Height = 25;
            dgvAllSubscriptions.Size = new Size(859, 468);
            dgvAllSubscriptions.TabIndex = 3;
            // 
            // btnGetAllSubscriptions
            // 
            btnGetAllSubscriptions.Location = new Point(7, 8);
            btnGetAllSubscriptions.Margin = new Padding(3, 4, 3, 4);
            btnGetAllSubscriptions.Name = "btnGetAllSubscriptions";
            btnGetAllSubscriptions.Size = new Size(137, 39);
            btnGetAllSubscriptions.TabIndex = 2;
            btnGetAllSubscriptions.Text = "Оновити список";
            btnGetAllSubscriptions.UseVisualStyleBackColor = true;
            btnGetAllSubscriptions.Click += btnGetAllSubscriptions_Click;
            // 
            // tabPageGetOneSubscription
            // 
            tabPageGetOneSubscription.Controls.Add(txtSubStatusResult);
            tabPageGetOneSubscription.Controls.Add(label13);
            tabPageGetOneSubscription.Controls.Add(txtSubServiceResult);
            tabPageGetOneSubscription.Controls.Add(label12);
            tabPageGetOneSubscription.Controls.Add(txtSubOwnerIdResult);
            tabPageGetOneSubscription.Controls.Add(label11);
            tabPageGetOneSubscription.Controls.Add(btnGetSubscriptionById);
            tabPageGetOneSubscription.Controls.Add(txtSubscriptionId);
            tabPageGetOneSubscription.Controls.Add(label10);
            tabPageGetOneSubscription.Location = new Point(4, 29);
            tabPageGetOneSubscription.Margin = new Padding(3, 4, 3, 4);
            tabPageGetOneSubscription.Name = "tabPageGetOneSubscription";
            tabPageGetOneSubscription.Padding = new Padding(3, 4, 3, 4);
            tabPageGetOneSubscription.Size = new Size(872, 536);
            tabPageGetOneSubscription.TabIndex = 1;
            tabPageGetOneSubscription.Text = "Отримати за ID";
            tabPageGetOneSubscription.UseVisualStyleBackColor = true;
            // 
            // txtSubStatusResult
            // 
            txtSubStatusResult.Location = new Point(22, 285);
            txtSubStatusResult.Margin = new Padding(3, 4, 3, 4);
            txtSubStatusResult.Name = "txtSubStatusResult";
            txtSubStatusResult.ReadOnly = true;
            txtSubStatusResult.Size = new Size(342, 27);
            txtSubStatusResult.TabIndex = 12;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(22, 261);
            label13.Name = "label13";
            label13.Size = new Size(55, 20);
            label13.TabIndex = 11;
            label13.Text = "Статус:";
            // 
            // txtSubServiceResult
            // 
            txtSubServiceResult.Location = new Point(22, 213);
            txtSubServiceResult.Margin = new Padding(3, 4, 3, 4);
            txtSubServiceResult.Name = "txtSubServiceResult";
            txtSubServiceResult.ReadOnly = true;
            txtSubServiceResult.Size = new Size(342, 27);
            txtSubServiceResult.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(22, 189);
            label12.Name = "label12";
            label12.Size = new Size(57, 20);
            label12.TabIndex = 9;
            label12.Text = "Сервіс:";
            // 
            // txtSubOwnerIdResult
            // 
            txtSubOwnerIdResult.Location = new Point(22, 141);
            txtSubOwnerIdResult.Margin = new Padding(3, 4, 3, 4);
            txtSubOwnerIdResult.Name = "txtSubOwnerIdResult";
            txtSubOwnerIdResult.ReadOnly = true;
            txtSubOwnerIdResult.Size = new Size(342, 27);
            txtSubOwnerIdResult.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(22, 117);
            label11.Name = "label11";
            label11.Size = new Size(74, 20);
            label11.TabIndex = 7;
            label11.Text = "Owner ID:";
            // 
            // btnGetSubscriptionById
            // 
            btnGetSubscriptionById.Location = new Point(371, 44);
            btnGetSubscriptionById.Margin = new Padding(3, 4, 3, 4);
            btnGetSubscriptionById.Name = "btnGetSubscriptionById";
            btnGetSubscriptionById.Size = new Size(86, 31);
            btnGetSubscriptionById.TabIndex = 5;
            btnGetSubscriptionById.Text = "Знайти";
            btnGetSubscriptionById.UseVisualStyleBackColor = true;
            btnGetSubscriptionById.Click += btnGetSubscriptionById_Click;
            // 
            // txtSubscriptionId
            // 
            txtSubscriptionId.Location = new Point(22, 45);
            txtSubscriptionId.Margin = new Padding(3, 4, 3, 4);
            txtSubscriptionId.Name = "txtSubscriptionId";
            txtSubscriptionId.Size = new Size(342, 27);
            txtSubscriptionId.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 21);
            label10.Name = "label10";
            label10.Size = new Size(148, 20);
            label10.TabIndex = 3;
            label10.Text = "Введіть ID підписки:";
            // 
            // tabPageCreateSubscription
            // 
            tabPageCreateSubscription.Controls.Add(btnCreateSubscription);
            tabPageCreateSubscription.Controls.Add(txtCreateSubStatus);
            tabPageCreateSubscription.Controls.Add(label16);
            tabPageCreateSubscription.Controls.Add(txtCreateSubService);
            tabPageCreateSubscription.Controls.Add(label15);
            tabPageCreateSubscription.Controls.Add(txtCreateSubOwnerId);
            tabPageCreateSubscription.Controls.Add(label14);
            tabPageCreateSubscription.Location = new Point(4, 29);
            tabPageCreateSubscription.Margin = new Padding(3, 4, 3, 4);
            tabPageCreateSubscription.Name = "tabPageCreateSubscription";
            tabPageCreateSubscription.Size = new Size(872, 536);
            tabPageCreateSubscription.TabIndex = 2;
            tabPageCreateSubscription.Text = "Створити";
            tabPageCreateSubscription.UseVisualStyleBackColor = true;
            // 
            // btnCreateSubscription
            // 
            btnCreateSubscription.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCreateSubscription.Location = new Point(22, 256);
            btnCreateSubscription.Margin = new Padding(3, 4, 3, 4);
            btnCreateSubscription.Name = "btnCreateSubscription";
            btnCreateSubscription.Size = new Size(138, 41);
            btnCreateSubscription.TabIndex = 11;
            btnCreateSubscription.Text = "Створити";
            btnCreateSubscription.UseVisualStyleBackColor = true;
            btnCreateSubscription.Click += btnCreateSubscription_Click;
            // 
            // txtCreateSubStatus
            // 
            txtCreateSubStatus.Location = new Point(22, 196);
            txtCreateSubStatus.Margin = new Padding(3, 4, 3, 4);
            txtCreateSubStatus.Name = "txtCreateSubStatus";
            txtCreateSubStatus.Size = new Size(342, 27);
            txtCreateSubStatus.TabIndex = 10;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(22, 172);
            label16.Name = "label16";
            label16.Size = new Size(301, 20);
            label16.TabIndex = 9;
            label16.Text = "Введіть статус (1 - Expectation, 2 - Active...):";
            // 
            // txtCreateSubService
            // 
            txtCreateSubService.Location = new Point(22, 124);
            txtCreateSubService.Margin = new Padding(3, 4, 3, 4);
            txtCreateSubService.Name = "txtCreateSubService";
            txtCreateSubService.Size = new Size(342, 27);
            txtCreateSubService.TabIndex = 8;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(22, 100);
            label15.Name = "label15";
            label15.Size = new Size(110, 20);
            label15.TabIndex = 7;
            label15.Text = "Введіть сервіс:";
            // 
            // txtCreateSubOwnerId
            // 
            txtCreateSubOwnerId.Location = new Point(22, 51);
            txtCreateSubOwnerId.Margin = new Padding(3, 4, 3, 4);
            txtCreateSubOwnerId.Name = "txtCreateSubOwnerId";
            txtCreateSubOwnerId.Size = new Size(342, 27);
            txtCreateSubOwnerId.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(22, 27);
            label14.Name = "label14";
            label14.Size = new Size(129, 20);
            label14.TabIndex = 5;
            label14.Text = "Введіть Owner ID:";
            // 
            // tabPageUpdateSubscription
            // 
            tabPageUpdateSubscription.Controls.Add(btnUpdateSubscription);
            tabPageUpdateSubscription.Controls.Add(txtUpdateSubStatus);
            tabPageUpdateSubscription.Controls.Add(label17);
            tabPageUpdateSubscription.Controls.Add(txtUpdateSubService);
            tabPageUpdateSubscription.Controls.Add(label18);
            tabPageUpdateSubscription.Controls.Add(txtUpdateSubOwnerId);
            tabPageUpdateSubscription.Controls.Add(label19);
            tabPageUpdateSubscription.Controls.Add(txtUpdateSubId);
            tabPageUpdateSubscription.Controls.Add(label20);
            tabPageUpdateSubscription.Location = new Point(4, 29);
            tabPageUpdateSubscription.Margin = new Padding(3, 4, 3, 4);
            tabPageUpdateSubscription.Name = "tabPageUpdateSubscription";
            tabPageUpdateSubscription.Size = new Size(872, 536);
            tabPageUpdateSubscription.TabIndex = 3;
            tabPageUpdateSubscription.Text = "Оновити";
            tabPageUpdateSubscription.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSubscription
            // 
            btnUpdateSubscription.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnUpdateSubscription.Location = new Point(22, 331);
            btnUpdateSubscription.Margin = new Padding(3, 4, 3, 4);
            btnUpdateSubscription.Name = "btnUpdateSubscription";
            btnUpdateSubscription.Size = new Size(138, 41);
            btnUpdateSubscription.TabIndex = 15;
            btnUpdateSubscription.Text = "Оновити";
            btnUpdateSubscription.UseVisualStyleBackColor = true;
            btnUpdateSubscription.Click += btnUpdateSubscription_Click;
            // 
            // txtUpdateSubStatus
            // 
            txtUpdateSubStatus.Location = new Point(22, 271);
            txtUpdateSubStatus.Margin = new Padding(3, 4, 3, 4);
            txtUpdateSubStatus.Name = "txtUpdateSubStatus";
            txtUpdateSubStatus.Size = new Size(342, 27);
            txtUpdateSubStatus.TabIndex = 14;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(22, 247);
            label17.Name = "label17";
            label17.Size = new Size(279, 20);
            label17.TabIndex = 13;
            label17.Text = "Введіть новий статус (1 - Expectation...):";
            // 
            // txtUpdateSubService
            // 
            txtUpdateSubService.Location = new Point(22, 199);
            txtUpdateSubService.Margin = new Padding(3, 4, 3, 4);
            txtUpdateSubService.Name = "txtUpdateSubService";
            txtUpdateSubService.Size = new Size(342, 27);
            txtUpdateSubService.TabIndex = 12;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(22, 175);
            label18.Name = "label18";
            label18.Size = new Size(158, 20);
            label18.TabIndex = 11;
            label18.Text = "Введіть новий сервіс:";
            // 
            // txtUpdateSubOwnerId
            // 
            txtUpdateSubOwnerId.Location = new Point(22, 127);
            txtUpdateSubOwnerId.Margin = new Padding(3, 4, 3, 4);
            txtUpdateSubOwnerId.Name = "txtUpdateSubOwnerId";
            txtUpdateSubOwnerId.Size = new Size(342, 27);
            txtUpdateSubOwnerId.TabIndex = 10;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(22, 103);
            label19.Name = "label19";
            label19.Size = new Size(177, 20);
            label19.TabIndex = 9;
            label19.Text = "Введіть новий Owner ID:";
            // 
            // txtUpdateSubId
            // 
            txtUpdateSubId.Location = new Point(22, 51);
            txtUpdateSubId.Margin = new Padding(3, 4, 3, 4);
            txtUpdateSubId.Name = "txtUpdateSubId";
            txtUpdateSubId.Size = new Size(342, 27);
            txtUpdateSubId.TabIndex = 8;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(22, 27);
            label20.Name = "label20";
            label20.Size = new Size(191, 20);
            label20.TabIndex = 7;
            label20.Text = "Введіть ID для оновлення:";
            // 
            // tabPageDeleteSubscription
            // 
            tabPageDeleteSubscription.Controls.Add(btnDeleteSubscription);
            tabPageDeleteSubscription.Controls.Add(txtDeleteSubId);
            tabPageDeleteSubscription.Controls.Add(label21);
            tabPageDeleteSubscription.Location = new Point(4, 29);
            tabPageDeleteSubscription.Margin = new Padding(3, 4, 3, 4);
            tabPageDeleteSubscription.Name = "tabPageDeleteSubscription";
            tabPageDeleteSubscription.Size = new Size(872, 536);
            tabPageDeleteSubscription.TabIndex = 4;
            tabPageDeleteSubscription.Text = "Видалити";
            tabPageDeleteSubscription.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSubscription
            // 
            btnDeleteSubscription.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnDeleteSubscription.ForeColor = Color.Red;
            btnDeleteSubscription.Location = new Point(22, 100);
            btnDeleteSubscription.Margin = new Padding(3, 4, 3, 4);
            btnDeleteSubscription.Name = "btnDeleteSubscription";
            btnDeleteSubscription.Size = new Size(138, 41);
            btnDeleteSubscription.TabIndex = 5;
            btnDeleteSubscription.Text = "Видалити";
            btnDeleteSubscription.UseVisualStyleBackColor = true;
            btnDeleteSubscription.Click += btnDeleteSubscription_Click;
            // 
            // txtDeleteSubId
            // 
            txtDeleteSubId.Location = new Point(22, 48);
            txtDeleteSubId.Margin = new Padding(3, 4, 3, 4);
            txtDeleteSubId.Name = "txtDeleteSubId";
            txtDeleteSubId.Size = new Size(342, 27);
            txtDeleteSubId.TabIndex = 4;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(22, 24);
            label21.Name = "label21";
            label21.Size = new Size(189, 20);
            label21.TabIndex = 3;
            label21.Text = "Введіть ID для видалення:";
            // 
            // tabPageMessages
            // 
            tabPageMessages.Controls.Add(tabControlMessageOperations);
            tabPageMessages.Location = new Point(4, 29);
            tabPageMessages.Margin = new Padding(3, 4, 3, 4);
            tabPageMessages.Name = "tabPageMessages";
            tabPageMessages.Padding = new Padding(3, 4, 3, 4);
            tabPageMessages.Size = new Size(888, 582);
            tabPageMessages.TabIndex = 2;
            tabPageMessages.Text = "Повідомлення (Messages)";
            tabPageMessages.UseVisualStyleBackColor = true;
            // 
            // tabControlMessageOperations
            // 
            tabControlMessageOperations.Controls.Add(tabPageGetAllMessages);
            tabControlMessageOperations.Controls.Add(tabPageGetOneMessage);
            tabControlMessageOperations.Controls.Add(tabPageCreateMessage);
            tabControlMessageOperations.Controls.Add(tabPageUpdateMessage);
            tabControlMessageOperations.Controls.Add(tabPageDeleteMessage);
            tabControlMessageOperations.Dock = DockStyle.Fill;
            tabControlMessageOperations.Location = new Point(3, 4);
            tabControlMessageOperations.Margin = new Padding(3, 4, 3, 4);
            tabControlMessageOperations.Name = "tabControlMessageOperations";
            tabControlMessageOperations.SelectedIndex = 0;
            tabControlMessageOperations.Size = new Size(882, 574);
            tabControlMessageOperations.TabIndex = 0;
            // 
            // tabPageGetAllMessages
            // 
            tabPageGetAllMessages.Controls.Add(dgvAllMessages);
            tabPageGetAllMessages.Controls.Add(btnGetAllMessages);
            tabPageGetAllMessages.Location = new Point(4, 29);
            tabPageGetAllMessages.Margin = new Padding(3, 4, 3, 4);
            tabPageGetAllMessages.Name = "tabPageGetAllMessages";
            tabPageGetAllMessages.Padding = new Padding(3, 4, 3, 4);
            tabPageGetAllMessages.Size = new Size(874, 541);
            tabPageGetAllMessages.TabIndex = 0;
            tabPageGetAllMessages.Text = "Отримати всіх";
            tabPageGetAllMessages.UseVisualStyleBackColor = true;
            // 
            // dgvAllMessages
            // 
            dgvAllMessages.AllowUserToAddRows = false;
            dgvAllMessages.AllowUserToDeleteRows = false;
            dgvAllMessages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAllMessages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllMessages.Location = new Point(7, 55);
            dgvAllMessages.Margin = new Padding(3, 4, 3, 4);
            dgvAllMessages.Name = "dgvAllMessages";
            dgvAllMessages.ReadOnly = true;
            dgvAllMessages.RowHeadersWidth = 51;
            dgvAllMessages.RowTemplate.Height = 25;
            dgvAllMessages.Size = new Size(859, 468);
            dgvAllMessages.TabIndex = 5;
            // 
            // btnGetAllMessages
            // 
            btnGetAllMessages.Location = new Point(7, 8);
            btnGetAllMessages.Margin = new Padding(3, 4, 3, 4);
            btnGetAllMessages.Name = "btnGetAllMessages";
            btnGetAllMessages.Size = new Size(137, 39);
            btnGetAllMessages.TabIndex = 4;
            btnGetAllMessages.Text = "Оновити список";
            btnGetAllMessages.UseVisualStyleBackColor = true;
            btnGetAllMessages.Click += btnGetAllMessages_Click;
            // 
            // tabPageGetOneMessage
            // 
            tabPageGetOneMessage.Controls.Add(txtMsgSubIdResult);
            tabPageGetOneMessage.Controls.Add(label24);
            tabPageGetOneMessage.Controls.Add(txtMsgOwnerIdResult);
            tabPageGetOneMessage.Controls.Add(label23);
            tabPageGetOneMessage.Controls.Add(txtMsgTitleResult);
            tabPageGetOneMessage.Controls.Add(label22);
            tabPageGetOneMessage.Controls.Add(btnGetMessageById);
            tabPageGetOneMessage.Controls.Add(txtMessageId);
            tabPageGetOneMessage.Controls.Add(label25);
            tabPageGetOneMessage.Location = new Point(4, 29);
            tabPageGetOneMessage.Margin = new Padding(3, 4, 3, 4);
            tabPageGetOneMessage.Name = "tabPageGetOneMessage";
            tabPageGetOneMessage.Padding = new Padding(3, 4, 3, 4);
            tabPageGetOneMessage.Size = new Size(872, 536);
            tabPageGetOneMessage.TabIndex = 1;
            tabPageGetOneMessage.Text = "Отримати за ID";
            tabPageGetOneMessage.UseVisualStyleBackColor = true;
            // 
            // txtMsgSubIdResult
            // 
            txtMsgSubIdResult.Location = new Point(22, 285);
            txtMsgSubIdResult.Margin = new Padding(3, 4, 3, 4);
            txtMsgSubIdResult.Name = "txtMsgSubIdResult";
            txtMsgSubIdResult.ReadOnly = true;
            txtMsgSubIdResult.Size = new Size(342, 27);
            txtMsgSubIdResult.TabIndex = 18;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(22, 261);
            label24.Name = "label24";
            label24.Size = new Size(56, 20);
            label24.TabIndex = 17;
            label24.Text = "Sub ID:";
            // 
            // txtMsgOwnerIdResult
            // 
            txtMsgOwnerIdResult.Location = new Point(22, 213);
            txtMsgOwnerIdResult.Margin = new Padding(3, 4, 3, 4);
            txtMsgOwnerIdResult.Name = "txtMsgOwnerIdResult";
            txtMsgOwnerIdResult.ReadOnly = true;
            txtMsgOwnerIdResult.Size = new Size(342, 27);
            txtMsgOwnerIdResult.TabIndex = 16;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(22, 189);
            label23.Name = "label23";
            label23.Size = new Size(74, 20);
            label23.TabIndex = 15;
            label23.Text = "Owner ID:";
            // 
            // txtMsgTitleResult
            // 
            txtMsgTitleResult.Location = new Point(22, 141);
            txtMsgTitleResult.Margin = new Padding(3, 4, 3, 4);
            txtMsgTitleResult.Name = "txtMsgTitleResult";
            txtMsgTitleResult.ReadOnly = true;
            txtMsgTitleResult.Size = new Size(342, 27);
            txtMsgTitleResult.TabIndex = 14;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(22, 117);
            label22.Name = "label22";
            label22.Size = new Size(84, 20);
            label22.TabIndex = 13;
            label22.Text = "Заголовок:";
            // 
            // btnGetMessageById
            // 
            btnGetMessageById.Location = new Point(371, 44);
            btnGetMessageById.Margin = new Padding(3, 4, 3, 4);
            btnGetMessageById.Name = "btnGetMessageById";
            btnGetMessageById.Size = new Size(86, 31);
            btnGetMessageById.TabIndex = 9;
            btnGetMessageById.Text = "Знайти";
            btnGetMessageById.UseVisualStyleBackColor = true;
            btnGetMessageById.Click += btnGetMessageById_Click;
            // 
            // txtMessageId
            // 
            txtMessageId.Location = new Point(22, 45);
            txtMessageId.Margin = new Padding(3, 4, 3, 4);
            txtMessageId.Name = "txtMessageId";
            txtMessageId.Size = new Size(342, 27);
            txtMessageId.TabIndex = 8;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(22, 21);
            label25.Name = "label25";
            label25.Size = new Size(186, 20);
            label25.TabIndex = 7;
            label25.Text = "Введіть ID повідомлення:";
            // 
            // tabPageCreateMessage
            // 
            tabPageCreateMessage.Location = new Point(4, 29);
            tabPageCreateMessage.Margin = new Padding(3, 4, 3, 4);
            tabPageCreateMessage.Name = "tabPageCreateMessage";
            tabPageCreateMessage.Size = new Size(872, 536);
            tabPageCreateMessage.TabIndex = 2;
            tabPageCreateMessage.Text = "Створити";
            tabPageCreateMessage.UseVisualStyleBackColor = true;
            // 
            // tabPageUpdateMessage
            // 
            tabPageUpdateMessage.Location = new Point(4, 29);
            tabPageUpdateMessage.Margin = new Padding(3, 4, 3, 4);
            tabPageUpdateMessage.Name = "tabPageUpdateMessage";
            tabPageUpdateMessage.Size = new Size(872, 536);
            tabPageUpdateMessage.TabIndex = 3;
            tabPageUpdateMessage.Text = "Оновити";
            tabPageUpdateMessage.UseVisualStyleBackColor = true;
            // 
            // tabPageDeleteMessage
            // 
            tabPageDeleteMessage.Location = new Point(4, 29);
            tabPageDeleteMessage.Margin = new Padding(3, 4, 3, 4);
            tabPageDeleteMessage.Name = "tabPageDeleteMessage";
            tabPageDeleteMessage.Size = new Size(872, 536);
            tabPageDeleteMessage.TabIndex = 4;
            tabPageDeleteMessage.Text = "Видалити";
            tabPageDeleteMessage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 615);
            Controls.Add(tabControlMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Subscription Manager Client";
            Load += Form1_Load;
            tabControlMain.ResumeLayout(false);
            tabPagePeople.ResumeLayout(false);
            tabControlPeopleOperations.ResumeLayout(false);
            tabPageGetAllPeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAllPeople).EndInit();
            tabPageGetOnePerson.ResumeLayout(false);
            tabPageGetOnePerson.PerformLayout();
            tabPageCreatePerson.ResumeLayout(false);
            tabPageCreatePerson.PerformLayout();
            tabPageUpdatePerson.ResumeLayout(false);
            tabPageUpdatePerson.PerformLayout();
            tabPageDeletePerson.ResumeLayout(false);
            tabPageDeletePerson.PerformLayout();
            tabPageSubscriptions.ResumeLayout(false);
            tabControlSubscriptionOperations.ResumeLayout(false);
            tabPageGetAllSubscriptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAllSubscriptions).EndInit();
            tabPageGetOneSubscription.ResumeLayout(false);
            tabPageGetOneSubscription.PerformLayout();
            tabPageCreateSubscription.ResumeLayout(false);
            tabPageCreateSubscription.PerformLayout();
            tabPageUpdateSubscription.ResumeLayout(false);
            tabPageUpdateSubscription.PerformLayout();
            tabPageDeleteSubscription.ResumeLayout(false);
            tabPageDeleteSubscription.PerformLayout();
            tabPageMessages.ResumeLayout(false);
            tabControlMessageOperations.ResumeLayout(false);
            tabPageGetAllMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAllMessages).EndInit();
            tabPageGetOneMessage.ResumeLayout(false);
            tabPageGetOneMessage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;

        // --- People ---
        private TabPage tabPagePeople;
        private TabControl tabControlPeopleOperations;
        private TabPage tabPageGetAllPeople;
        private DataGridView dgvAllPeople;
        private Button btnGetAllPeople;
        private TabPage tabPageGetOnePerson;
        private TextBox txtEmailResult;
        private Label label3;
        private TextBox txtNameResult;
        private Label label2;
        private Button btnGetPersonById;
        private TextBox txtPersonId;
        private Label label1;
        private TabPage tabPageCreatePerson;
        private Label label4;
        private TextBox txtCreateName;
        private Label label5;
        private TextBox txtCreateEmail;
        private Button btnCreatePerson;
        private TabPage tabPageUpdatePerson;
        private Button btnUpdatePerson;
        private TextBox txtUpdateEmail;
        private Label label6;
        private TextBox txtUpdateName;
        private Label label7;
        private TextBox txtUpdateId;
        private Label label8;
        private TabPage tabPageDeletePerson;
        private Button btnDeletePerson;
        private TextBox txtDeleteId;
        private Label label9;

        // --- Subscriptions ---
        private TabPage tabPageSubscriptions;
        private TabControl tabControlSubscriptionOperations;
        private TabPage tabPageGetAllSubscriptions;
        private DataGridView dgvAllSubscriptions;
        private Button btnGetAllSubscriptions;
        private TabPage tabPageGetOneSubscription;
        private TextBox txtSubStatusResult;
        private Label label13;
        private TextBox txtSubServiceResult;
        private Label label12;
        private TextBox txtSubOwnerIdResult;
        private Label label11;
        private Button btnGetSubscriptionById;
        private TextBox txtSubscriptionId;
        private Label label10;
        private TabPage tabPageCreateSubscription;
        private Button btnCreateSubscription;
        private TextBox txtCreateSubStatus;
        private Label label16;
        private TextBox txtCreateSubService;
        private Label label15;
        private TextBox txtCreateSubOwnerId;
        private Label label14;
        private TabPage tabPageUpdateSubscription;
        private Button btnUpdateSubscription;
        private TextBox txtUpdateSubStatus;
        private Label label17;
        private TextBox txtUpdateSubService;
        private Label label18;
        private TextBox txtUpdateSubOwnerId;
        private Label label19;
        private TextBox txtUpdateSubId;
        private Label label20;
        private TabPage tabPageDeleteSubscription;
        private Button btnDeleteSubscription;
        private TextBox txtDeleteSubId;
        private Label label21;

        // --- Messages ---
        private TabPage tabPageMessages;
        private TabControl tabControlMessageOperations;
        private TabPage tabPageGetAllMessages;
        private DataGridView dgvAllMessages;
        private Button btnGetAllMessages;
        private TabPage tabPageGetOneMessage;
        private TextBox txtMsgSubIdResult;
        private Label label24;
        private TextBox txtMsgOwnerIdResult;
        private Label label23;
        private TextBox txtMsgTitleResult;
        private Label label22;
        private Button btnGetMessageById;
        private TextBox txtMessageId;
        private Label label25;
        private TabPage tabPageCreateMessage; // Порожня
        private TabPage tabPageUpdateMessage; // Порожня
        private TabPage tabPageDeleteMessage; // Порожня
    }
}