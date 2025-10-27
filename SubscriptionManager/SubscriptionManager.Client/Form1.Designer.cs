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
            this.tabPageUpdatePerson = new System.Windows.Forms.TabPage();
            this.tabPageDeletePerson = new System.Windows.Forms.TabPage();
            this.tabPageSubscriptions = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.tabPagePeople.SuspendLayout();
            this.tabControlPeopleOperations.SuspendLayout();
            this.tabPageGetAllPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPeople)).BeginInit();
            this.tabPageGetOnePerson.SuspendLayout();
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
            this.tabPageCreatePerson.Location = new System.Drawing.Point(4, 24);
            this.tabPageCreatePerson.Name = "tabPageCreatePerson";
            this.tabPageCreatePerson.Size = new System.Drawing.Size(762, 399);
            this.tabPageCreatePerson.TabIndex = 2;
            this.tabPageCreatePerson.Text = "Створити";
            this.tabPageCreatePerson.UseVisualStyleBackColor = true;
            // 
            // tabPageUpdatePerson
            // 
            this.tabPageUpdatePerson.Location = new System.Drawing.Point(4, 24);
            this.tabPageUpdatePerson.Name = "tabPageUpdatePerson";
            this.tabPageUpdatePerson.Size = new System.Drawing.Size(762, 399);
            this.tabPageUpdatePerson.TabIndex = 3;
            this.tabPageUpdatePerson.Text = "Оновити";
            this.tabPageUpdatePerson.UseVisualStyleBackColor = true;
            // 
            // tabPageDeletePerson
            // 
            this.tabPageDeletePerson.Location = new System.Drawing.Point(4, 24);
            this.tabPageDeletePerson.Name = "tabPageDeletePerson";
            this.tabPageDeletePerson.Size = new System.Drawing.Size(762, 399);
            this.tabPageDeletePerson.TabIndex = 4;
            this.tabPageDeletePerson.Text = "Видалити";
            this.tabPageDeletePerson.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        // Головний TabControl для Ресурсів
        private TabControl tabControlMain;

        // --- Сторінка Користувачів ---
        private TabPage tabPagePeople;
        // Вкладений TabControl для Операцій
        private TabControl tabControlPeopleOperations;
        // Вкладка "Отримати всіх"
        private TabPage tabPageGetAllPeople;
        private Button btnGetAllPeople;
        private DataGridView dgvAllPeople;
        // Вкладка "Отримати одного"
        private TabPage tabPageGetOnePerson;
        private Label label1;
        private TextBox txtPersonId;
        private Button btnGetPersonById;
        private Label label2;
        private TextBox txtNameResult;
        private Label label3;
        private TextBox txtEmailResult;
        // Заглушки для майбутніх операцій
        private TabPage tabPageCreatePerson;
        private TabPage tabPageUpdatePerson;
        private TabPage tabPageDeletePerson;

        // --- Сторінка Підписок (поки порожня, для розширення) ---
        private TabPage tabPageSubscriptions;
    }
}