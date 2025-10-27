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
            this.tabPageUpdatePerson = new System.Windows.Forms.TabPage();
            this.btnUpdatePerson = new System.Windows.Forms.Button();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdateId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageDeletePerson = new System.Windows.Forms.TabPage();
            this.tabPageSubscriptions = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.tabPagePeople.SuspendLayout();
            this.tabControlPeopleOperations.SuspendLayout();
            this.tabPageUpdatePerson.SuspendLayout();
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
            this.tabControlPeopleOperations.Controls.Add(this.tabPageUpdatePerson);
            this.tabControlPeopleOperations.Controls.Add(this.tabPageDeletePerson);
            this.tabControlPeopleOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPeopleOperations.Location = new System.Drawing.Point(3, 3);
            this.tabControlPeopleOperations.Name = "tabControlPeopleOperations";
            this.tabControlPeopleOperations.SelectedIndex = 0;
            this.tabControlPeopleOperations.Size = new System.Drawing.Size(770, 427);
            this.tabControlPeopleOperations.TabIndex = 0;
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
            this.tabPageUpdatePerson.ResumeLayout(false);
            this.tabPageUpdatePerson.PerformLayout();
            this.ResumeLayout(false);

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