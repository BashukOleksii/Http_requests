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
            tabPageUpdatePerson = new TabPage();
            btnUpdatePerson = new Button();
            txtUpdateEmail = new TextBox();
            label6 = new Label();
            txtUpdateName = new TextBox();
            label7 = new Label();
            txtUpdateId = new TextBox();
            label8 = new Label();
            tabPageDeletePerson = new TabPage();
            tabPageSubscriptions = new TabPage();
            tabControlMain.SuspendLayout();
            tabPagePeople.SuspendLayout();
            tabControlPeopleOperations.SuspendLayout();
            tabPageUpdatePerson.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPagePeople);
            tabControlMain.Controls.Add(tabPageSubscriptions);
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
            tabPageUpdatePerson.Size = new Size(874, 541);
            tabPageUpdatePerson.TabIndex = 3;
            tabPageUpdatePerson.Text = "Оновити";
            tabPageUpdatePerson.UseVisualStyleBackColor = true;
            tabPageUpdatePerson.Click += tabPageUpdatePerson_Click;
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
            tabPageDeletePerson.Location = new Point(4, 29);
            tabPageDeletePerson.Margin = new Padding(3, 4, 3, 4);
            tabPageDeletePerson.Name = "tabPageDeletePerson";
            tabPageDeletePerson.Size = new Size(872, 536);
            tabPageDeletePerson.TabIndex = 4;
            tabPageDeletePerson.Text = "Видалити";
            tabPageDeletePerson.UseVisualStyleBackColor = true;
            // 
            // tabPageSubscriptions
            // 
            tabPageSubscriptions.Location = new Point(4, 29);
            tabPageSubscriptions.Margin = new Padding(3, 4, 3, 4);
            tabPageSubscriptions.Name = "tabPageSubscriptions";
            tabPageSubscriptions.Padding = new Padding(3, 4, 3, 4);
            tabPageSubscriptions.Size = new Size(888, 582);
            tabPageSubscriptions.TabIndex = 1;
            tabPageSubscriptions.Text = "Підписки (Subscriptions)";
            tabPageSubscriptions.UseVisualStyleBackColor = true;
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
            tabControlMain.ResumeLayout(false);
            tabPagePeople.ResumeLayout(false);
            tabControlPeopleOperations.ResumeLayout(false);
            tabPageUpdatePerson.ResumeLayout(false);
            tabPageUpdatePerson.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPagePeople;
        private TabControl tabControlPeopleOperations;
        private TabPage tabPageDeletePerson;
        private TabPage tabPageSubscriptions;
        
        // --- Елементи для PUT ---
        private TabPage tabPageUpdatePerson;
        private Button btnUpdatePerson;
        private TextBox txtUpdateEmail;
        private Label label6;
        private TextBox txtUpdateName;
        private Label label7;
        private TextBox txtUpdateId;
        private Label label8;
    }
}