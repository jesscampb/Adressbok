namespace AdressbokTest
{
    partial class Adressbok
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
            labelFirstName = new Label();
            labelLastName = new Label();
            labelStreet = new Label();
            labelPostalCode = new Label();
            labelCity = new Label();
            labelPhone = new Label();
            labelEmail = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxStreet = new TextBox();
            textBoxPostalCode = new TextBox();
            textBoxCity = new TextBox();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            textBoxSearchCondition = new TextBox();
            buttonSave = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonNew = new Button();
            buttonSearch = new Button();
            listBoxSearchResults = new ListBox();
            SuspendLayout();
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(21, 18);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(87, 25);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "Förnamn:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(21, 55);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(97, 25);
            labelLastName.TabIndex = 1;
            labelLastName.Text = "Efternamn:";
            // 
            // labelStreet
            // 
            labelStreet.AutoSize = true;
            labelStreet.Location = new Point(21, 95);
            labelStreet.Name = "labelStreet";
            labelStreet.Size = new Size(113, 25);
            labelStreet.TabIndex = 2;
            labelStreet.Text = "Gatauadress:";
            // 
            // labelPostalCode
            // 
            labelPostalCode.AutoSize = true;
            labelPostalCode.Location = new Point(21, 129);
            labelPostalCode.Name = "labelPostalCode";
            labelPostalCode.Size = new Size(117, 25);
            labelPostalCode.TabIndex = 3;
            labelPostalCode.Text = "Postnummer:";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(297, 129);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(73, 25);
            labelCity.TabIndex = 4;
            labelCity.Text = "Postort:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(21, 166);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(72, 25);
            labelPhone.TabIndex = 5;
            labelPhone.Text = "Telefon:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(21, 203);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(68, 25);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "E-post:";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(144, 15);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(510, 31);
            textBoxFirstName.TabIndex = 8;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(144, 52);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(510, 31);
            textBoxLastName.TabIndex = 9;
            // 
            // textBoxStreet
            // 
            textBoxStreet.Location = new Point(144, 89);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(510, 31);
            textBoxStreet.TabIndex = 10;
            // 
            // textBoxPostalCode
            // 
            textBoxPostalCode.Location = new Point(144, 126);
            textBoxPostalCode.Name = "textBoxPostalCode";
            textBoxPostalCode.Size = new Size(137, 31);
            textBoxPostalCode.TabIndex = 11;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(376, 126);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(278, 31);
            textBoxCity.TabIndex = 12;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(144, 163);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(510, 31);
            textBoxPhone.TabIndex = 13;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(144, 200);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(510, 31);
            textBoxEmail.TabIndex = 14;
            // 
            // textBoxSearchCondition
            // 
            textBoxSearchCondition.Location = new Point(21, 274);
            textBoxSearchCondition.Name = "textBoxSearchCondition";
            textBoxSearchCondition.Size = new Size(633, 31);
            textBoxSearchCondition.TabIndex = 15;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(679, 60);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(151, 39);
            buttonSave.TabIndex = 16;
            buttonSave.Text = "Spara";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(679, 105);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(151, 39);
            buttonUpdate.TabIndex = 17;
            buttonUpdate.Text = "Uppdatera";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(679, 150);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(151, 39);
            buttonDelete.TabIndex = 18;
            buttonDelete.Text = "Radera";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(679, 15);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(151, 39);
            buttonNew.TabIndex = 19;
            buttonNew.Text = "Rensa fält";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(679, 270);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(151, 39);
            buttonSearch.TabIndex = 20;
            buttonSearch.Text = "Sök";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // listBoxSearchResults
            // 
            listBoxSearchResults.FormattingEnabled = true;
            listBoxSearchResults.HorizontalScrollbar = true;
            listBoxSearchResults.ItemHeight = 25;
            listBoxSearchResults.Location = new Point(21, 320);
            listBoxSearchResults.Name = "listBoxSearchResults";
            listBoxSearchResults.Size = new Size(809, 329);
            listBoxSearchResults.TabIndex = 21;
            listBoxSearchResults.SelectedIndexChanged += listBoxSearchResults_SelectedIndexChanged;
            // 
            // Adressbok
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 671);
            Controls.Add(listBoxSearchResults);
            Controls.Add(buttonSearch);
            Controls.Add(buttonNew);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonSave);
            Controls.Add(textBoxSearchCondition);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxCity);
            Controls.Add(textBoxPostalCode);
            Controls.Add(textBoxStreet);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelEmail);
            Controls.Add(labelPhone);
            Controls.Add(labelCity);
            Controls.Add(labelPostalCode);
            Controls.Add(labelStreet);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Name = "Adressbok";
            Text = "Adressbok";
            Load += Adressbok_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFirstName;
        private Label labelLastName;
        private Label labelStreet;
        private Label labelPostalCode;
        private Label labelCity;
        private Label labelPhone;
        private Label labelEmail;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxStreet;
        private TextBox textBoxPostalCode;
        private TextBox textBoxCity;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxSearchCondition;
        private Button buttonSave;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonNew;
        private Button buttonSearch;
        private ListBox listBoxSearchResults;
    }
}
