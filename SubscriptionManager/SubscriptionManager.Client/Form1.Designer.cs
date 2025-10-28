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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPagePeople = new System.Windows.Forms.TabPage();
            this.tabControlPeopleOperations = new System.Windows.Forms.TabControl();
            this.tabPageGetAllPeople = new System.Windows.Forms.TabPage();
            this.dgvAllPeople = new System.Windows.Forms.DataGridView();
            this.btnGetAllPeople = new System.Windows.Forms.Button();
            this.tabPageGetOnePerson = new System.Windows.Forms.TabPage();
            this.txtEmailResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetPersonById = new System.Windows.Forms.Button();
            this.txtPersonId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageCreatePerson = new System.Windows.Forms.TabPage();
            this.btnCreatePerson = new System.Windows.Forms.Button();
            this.txtCreateEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCreateName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageUpdatePerson = new System.Windows.Forms.TabPage();
            this.btnUpdatePerson = new System.Windows.Forms.Button();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdateId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageDeletePerson = new System.Windows.Forms.TabPage();
            this.btnDeletePerson = new System.Windows.Forms.Button();
            this.txtDeleteId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPageSubscriptions = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.tabPagePeople.SuspendLayout();
            this.tabControlPeopleOperations.SuspendLayout();
            this.tabPageGetAllPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPeople)).BeginInit();
            this.tabPageGetOnePerson.SuspendLayout();
            this.tabPageCreatePerson.SuspendLayout();
            this.tabPageUpdatePerson.SuspendLayout();
            this.tabPageDeletePerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPagePeople);
            this.tabControlMain.Controls.Add(this.tabPageSubscriptions);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(784, 461);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPagePeople
            // 
            this.tabPagePeople.Controls.Add(this.tabControlPeopleOperations);
            this.tabPagePeople.Location = new System.Drawing.Point(4, 24);
            this.tabPagePeople.Name = "tabPagePeople";
            this.tabPagePeople.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePeople.Size = new System.Drawing.Size(776, 433);
            this.tabPagePeople.TabIndex = 0;
            this.tabPagePeople.Text = "Користувачі (People)";
            this.tabPagePeople.UseVisualStyleBackColor = true;
            // 
            // tabControlPeopleOperations
            // 
            this.tabControlPeopleOperations.Controls.Add(this.tabPageGetAllPeople);
            this.tabControlPeopleOperations.Controls.Add(this.tabPageGetOnePerson);
            this.tabControlPeopleOperations.Controls.Add(this.tabPageCreatePerson);
            this.tabControlPeopleOperations.Controls.Add(this.tabPageUpdatePerson);
            this.tabControlPeopleOperations.Controls.Add(this.tabPageDeletePerson);
            this.tabControlPeopleOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPeopleOperations.Location = new System.Drawing.Point(3, 3);
            this.tabControlPeopleOperations.Name = "tabControlPeopleOperations";
            this.tabControlPeopleOperations.SelectedIndex = 0;
            this.tabControlPeopleOperations.Size = new System.Drawing.Size(770, 427);
            this.tabControlPeopleOperations.TabIndex = 0;
            // 
            // tabPageGetAllPeople
            // 
            this.tabPageGetAllPeople.Controls.Add(this.dgvAllPeople);
            this.tabPageGetAllPeople.Controls.Add(this.btnGetAllPeople);
            this.tabPageGetAllPeople.Location = new System.Drawing.Point(4, 24);
            this.tabPageGetAllPeople.Name = "tabPageGetAllPeople";
            this.tabPageGetAllPeople.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGetAllPeople.Size = new System.Drawing.Size(762, 399);
            this.tabPageGetAllPeople.TabIndex = 0;
            this.tabPageGetAllPeople.Text = "Отримати всіх";
            this.tabPageGetAllPeople.UseVisualStyleBackColor = true;
            // 
            // dgvAllPeople
            // 
            this.dgvAllPeople.AllowUserToAddRows = false;
            this.dgvAllPeople.AllowUserToDeleteRows = false;
            this.dgvAllPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPeople.Location = new System.Drawing.Point(6, 41);
            this.dgvAllPeople.Name = "dgvAllPeople";
            this.dgvAllPeople.ReadOnly = true;
            this.dgvAllPeople.RowTemplate.Height = 25;
            this.dgvAllPeople.Size = new System.Drawing.Size(750, 352);
            this.dgvAllPeople.TabIndex = 1;
            // 
            // btnGetAllPeople
            // 
            this.btnGetAllPeople.Location = new System.Drawing.Point(6, 6);
            this.btnGetAllPeople.Name = "btnGetAllPeople";
            this.btnGetAllPeople.Size = new System.Drawing.Size(120, 29);
            this.btnGetAllPeople.TabIndex = 0;
            this.btnGetAllPeople.Text = "Оновити список";
            this.btnGetAllPeople.UseVisualStyleBackColor = true;
            this.btnGetAllPeople.Click += new System.EventHandler(this.btnGetAllPeople_Click);
            // 
            // tabPageGetOnePerson
            // 
            this.tabPageGetOnePerson.Controls.Add(this.txtEmailResult);
            this.tabPageGetOnePerson.Controls.Add(this.label3);
            this.tabPageGetOnePerson.Controls.Add(this.txtNameResult);
            this.tabPageGetOnePerson.Controls.Add(this.label2);
            this.tabPageGetOnePerson.Controls.Add(this.btnGetPersonById);
            this.tabPageGetOnePerson.Controls.Add(this.txtPersonId);
            this.tabPageGetOnePerson.Controls.Add(this.label1);
            this.tabPageGetOnePerson.Location = new System.Drawing.Point(4, 24);
            this.tabPageGetOnePerson.Name = "tabPageGetOnePerson";
            this.tabPageGetOnePerson.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGetOnePerson.Size = new System.Drawing.Size(762, 399);
            this.tabPageGetOnePerson.TabIndex = 1;
            this.tabPageGetOnePerson.Text = "Отримати за ID";
            this.tabPageGetOnePerson.UseVisualStyleBackColor = true;
            // 
            // txtEmailResult
            // 
            this.txtEmailResult.Location = new System.Drawing.Point(19, 159);
            this.txtEmailResult.Name = "txtEmailResult";
            this.txtEmailResult.ReadOnly = true;
            this.txtEmailResult.Size = new System.Drawing.Size(300, 23);
            this.txtEmailResult.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            // 
            // txtNameResult
            // 
            this.txtNameResult.Location = new System.Drawing.Point(19, 106);
            this.txtNameResult.Name = "txtNameResult";
            this.txtNameResult.ReadOnly = true;
            this.txtNameResult.Size = new System.Drawing.Size(300, 23);
            this.txtNameResult.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ім\'я:";
            // 
            // btnGetPersonById
            // 
            this.btnGetPersonById.Location = new System.Drawing.Point(325, 33);
            this.btnGetPersonById.Name = "btnGetPersonById";
            this.btnGetPersonById.Size = new System.Drawing.Size(75, 23);
            this.btnGetPersonById.TabIndex = 2;
            this.btnGetPersonById.Text = "Знайти";
            this.btnGetPersonById.UseVisualStyleBackColor = true;
            this.btnGetPersonById.Click += new System.EventHandler(this.btnGetPersonById_Click);
            // 
            // txtPersonId
            // 
            this.txtPersonId.Location = new System.Drawing.Point(19, 34);
            this.txtPersonId.Name = "txtPersonId";
            this.txtPersonId.Size = new System.Drawing.Size(300, 23);
            this.txtPersonId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть ID користувача:";
            // 
            // tabPageCreatePerson
            // 
            this.tabPageCreatePerson.Controls.Add(this.btnCreatePerson);
            this.tabPageCreatePerson.Controls.Add(this.txtCreateEmail);
            this.tabPageCreatePerson.Controls.Add(this.label5);
            this.tabPageCreatePerson.Controls.Add(this.txtCreateName);
            this.tabPageCreatePerson.Controls.Add(this.label4);
            this.tabPageCreatePerson.Location = new System.Drawing.Point(4, 24);
            this.tabPageCreatePerson.Name = "tabPageCreatePerson";
            this.tabPageCreatePerson.Size = new System.Drawing.Size(762, 399);
            this.tabPageCreatePerson.TabIndex = 2;
            this.tabPageCreatePerson.Text = "Створити";
            this.tabPageCreatePerson.UseVisualStyleBackColor = true;
            // 
            // btnCreatePerson
            // 
            this.btnCreatePerson.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreatePerson.Location = new System.Drawing.Point(19, 137);
            this.btnCreatePerson.Name = "btnCreatePerson";
            this.btnCreatePerson.Size = new System.Drawing.Size(121, 31);
            this.btnCreatePerson.TabIndex = 4;
            this.btnCreatePerson.Text = "Створити";
            this.btnCreatePerson.UseVisualStyleBackColor = true;
            this.btnCreatePerson.Click += new System.EventHandler(this.btnCreatePerson_Click);
            // 
            // txtCreateEmail
            // 
            this.txtCreateEmail.Location = new System.Drawing.Point(19, 90);
            this.txtCreateEmail.Name = "txtCreateEmail";
            this.txtCreateEmail.Size = new System.Drawing.Size(300, 23);
            this.txtCreateEmail.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Введіть Email:";
            // 
            // txtCreateName
            // 
            this.txtCreateName.Location = new System.Drawing.Point(19, 36);
            this.txtCreateName.Name = "txtCreateName";
            this.txtCreateName.Size = new System.Drawing.Size(300, 23);
            this.txtCreateName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Введіть ім\'я:";
            // 
            // tabPageUpdatePerson
            // 
            this.tabPageUpdatePerson.Controls.Add(this.btnUpdatePerson);
            this.tabPageUpdatePerson.Controls.Add(this.txtUpdateEmail);
            this.tabPageUpdatePerson.Controls.Add(this.label6);
            this.tabPageUpdatePerson.Controls.Add(this.txtUpdateName);
            this.tabPageUpdatePerson.Controls.Add(this.label7);
            this.tabPageUpdatePerson.Controls.Add(this.txtUpdateId);
            this.tabPageUpdatePerson.Controls.Add(this.label8);
            this.tabPageUpdatePerson.Location = new System.Drawing.Point(4, 24);
            this.tabPageUpdatePerson.Name = "tabPageUpdatePerson";
            this.tabPageUpdatePerson.Size = new System.Drawing.Size(762, 399);
            this.tabPageUpdatePerson.TabIndex = 3;
            this.tabPageUpdatePerson.Text = "Оновити";
            this.tabPageUpdatePerson.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePerson
            // 
            this.btnUpdatePerson.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatePerson.Location = new System.Drawing.Point(19, 192);
            this.btnUpdatePerson.Name = "btnUpdatePerson";
            this.btnUpdatePerson.Size = new System.Drawing.Size(121, 31);
            this.btnUpdatePerson.TabIndex = 6;
            this.btnUpdatePerson.Text = "Оновити";
            this.btnUpdatePerson.UseVisualStyleBackColor = true;
            this.btnUpdatePerson.Click += new System.EventHandler(this.btnUpdatePerson_Click);
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Location = new System.Drawing.Point(19, 147);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(300, 23);
            this.txtUpdateEmail.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Введіть новий Email:";
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(19, 93);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(300, 23);
            this.txtUpdateName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Введіть нове ім\'я:";
            // 
            // txtUpdateId
            // 
            this.txtUpdateId.Location = new System.Drawing.Point(19, 38);
            this.txtUpdateId.Name = "txtUpdateId";
            this.txtUpdateId.Size = new System.Drawing.Size(300, 23);
            this.txtUpdateId.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Введіть ID для оновлення:";
            // 
            // tabPageDeletePerson
            // 
            this.tabPageDeletePerson.Controls.Add(this.btnDeletePerson);
            this.tabPageDeletePerson.Controls.Add(this.txtDeleteId);
            this.tabPageDeletePerson.Controls.Add(this.label9);
            this.tabPageDeletePerson.Location = new System.Drawing.Point(4, 24);
            this.tabPageDeletePerson.Name = "tabPageDeletePerson";
            this.tabPageDeletePerson.Size = new System.Drawing.Size(762, 399);
            this.tabPageDeletePerson.TabIndex = 4;
            this.tabPageDeletePerson.Text = "Видалити";
            this.tabPageDeletePerson.UseVisualStyleBackColor = true;
            // 
            // btnDeletePerson
            // 
            this.btnDeletePerson.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletePerson.ForeColor = System.Drawing.Color.Red;
            this.btnDeletePerson.Location = new System.Drawing.Point(19, 75);
            this.btnDeletePerson.Name = "btnDeletePerson";
            this.btnDeletePerson.Size = new System.Drawing.Size(121, 31);
            this.btnDeletePerson.TabIndex = 2;
            this.btnDeletePerson.Text = "Видалити";
            this.btnDeletePerson.UseVisualStyleBackColor = true;
            this.btnDeletePerson.Click += new System.EventHandler(this.btnDeletePerson_Click);
            // 
            // txtDeleteId
            // 
            this.txtDeleteId.Location = new System.Drawing.Point(19, 36);
            this.txtDeleteId.Name = "txtDeleteId";
            this.txtDeleteId.Size = new System.Drawing.Size(300, 23);
            this.txtDeleteId.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Введіть ID для видалення:";
            // 
            // tabPageSubscriptions
            // 
            this.tabPageSubscriptions.Location = new System.Drawing.Point(4, 24);
            this.tabPageSubscriptions.Name = "tabPageSubscriptions";
            this.tabPageSubscriptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubscriptions.Size = new System.Drawing.Size(776, 433);
            this.tabPageSubscriptions.TabIndex = 1;
            this.tabPageSubscriptions.Text = "Підписки (Subscriptions)";
            this.tabPageSubscriptions.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "Subscription Manager Client";
            this.tabControlMain.ResumeLayout(false);
            this.tabPagePeople.ResumeLayout(false);
            this.tabControlPeopleOperations.ResumeLayout(false);
            this.tabPageGetAllPeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPeople)).EndInit();
            this.tabPageGetOnePerson.ResumeLayout(false);
            this.tabPageGetOnePerson.PerformLayout();
            this.tabPageCreatePerson.ResumeLayout(false);
            this.tabPageCreatePerson.PerformLayout();
            this.tabPageUpdatePerson.ResumeLayout(false);
            this.tabPageUpdatePerson.PerformLayout();
            this.tabPageDeletePerson.ResumeLayout(false);
            this.tabPageDeletePerson.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPagePeople;
        private TabControl tabControlPeopleOperations;
        private TabPage tabPageSubscriptions;

        // --- Елементи для GET ---
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

        // --- Елементи для POST ---
        private TabPage tabPageCreatePerson;
        private Label label4;
        private TextBox txtCreateName;
        private Label label5;
        private TextBox txtCreateEmail;
        private Button btnCreatePerson;

        // --- Елементи для PUT ---
        private TabPage tabPageUpdatePerson;
        private Button btnUpdatePerson;
        private TextBox txtUpdateEmail;
        private Label label6;
        private TextBox txtUpdateName;
        private Label label7;
        private TextBox txtUpdateId;
        private Label label8;

        // --- (НОВЕ) Елементи для DELETE ---
        private TabPage tabPageDeletePerson;
        private Button btnDeletePerson;
        private TextBox txtDeleteId;
        private Label label9;
    }
}