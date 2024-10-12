using AdressbokTest.Classes;

namespace AdressbokTest
{
    public partial class Adressbok : Form
    {
        public Adressbok()
        {
            InitializeComponent();
        }

        //Laddar in alla kontakter i listboxen n�r programmet startar
        private void Adressbok_Load(object sender, EventArgs e)
        {
            UpdateContactList();
        }

        //"Rensa f�lt" = rensar alla textboxar i formul�ret
        //och laddar in alla kontakter i listboxen
        private void buttonNew_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            UpdateContactList();
        }

        //"Spara" = l�gger till en ny kontakt i textfilen
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Skapar upp en ny instans av klassen Contact och skickar till metoden i klassen
            Contact contact = new Contact(textBoxFirstName.Text, textBoxLastName.Text,
                textBoxStreet.Text, textBoxPostalCode.Text, textBoxCity.Text, textBoxPhone.Text,
                textBoxEmail.Text);

            contact.Save();
            ClearAllFields();

            //Uppdaterar listan med den sparade kontakten
            UpdateContactList();

        }

        //"Uppdatera" = �ndrar en kontakts uppgifter i textfilen
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string file = @"C:\Users\jessc\Desktop\Inl�mningsuppgift 1\Adressbok.txt";
            string selectedContact = listBoxSearchResults.SelectedItem.ToString();

            //L�ser alla rader i textfilen och skapar upp en lista av dessa
            List<string> contacts = File.ReadAllLines(file).ToList();

            //Tar reda p� vilket index kontakten har
            int contactIndex = contacts.IndexOf(selectedContact);

            if (contactIndex != -1)
            {
                //Skapar en ny kontakt av det som st�r i textboxarna
                string editedContact = $"{textBoxFirstName.Text}, {textBoxLastName.Text}, {textBoxStreet.Text}, " +
                    $"{textBoxPostalCode.Text}, {textBoxCity.Text}, {textBoxPhone.Text}, {textBoxEmail.Text}";

                //Byter ut den valda kontakten med den nya
                contacts[contactIndex] = editedContact;

                //Skickar tillbaka den nya datan in i textfilen
                File.WriteAllLines(file, contacts);
            }
            ClearAllFields();
            UpdateContactList();
        }

        //"Radera" = Tar bort en kontakt helt fr�n textfilen
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string file = @"C:\Users\jessc\Desktop\Inl�mningsuppgift 1\Adressbok.txt";
            string selectedContact = listBoxSearchResults.SelectedItem.ToString();

            //L�ser fr�n textfilen och skapar upp en lista med str�ngar av alla rader
            List<string> contacts = File.ReadAllLines(file).ToList();

            //Letar efter den valda kontakten genom att j�mf�ra med alla rader i listan och tar bort den
            //Skriver till filen med den uppdaterade listan
            contacts.Remove(selectedContact);
            File.WriteAllLines(file, contacts);

            ClearAllFields();
            UpdateContactList();
        }

        //"S�k" = s�ker igenom textfilen efter det som skrevs i s�kf�ltet
        //och skickar in resultatet i listboxen
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string file = @"C:\Users\jessc\Desktop\Inl�mningsuppgift 1\Adressbok.txt";
            string searchCondition = textBoxSearchCondition.Text;

            //Rensar listboxen p� kontakter innan s�kresultatet visas
            listBoxSearchResults.Items.Clear();
            
            using (StreamReader reader = new StreamReader(file))
            {
                string row;

                //G�r till textfilen och letar igenom den, rad f�r rad, efter
                //allt som matchar s�kningen. L�gger till det som st�mmer �verens
                //i listboxen
                while ((row = reader.ReadLine()) != null)
                {
                    if (row.ToLower().Contains(searchCondition))
                    {
                        listBoxSearchResults.Items.Add(row);
                    }
                }
            }
        }

        //Detta h�nder n�r man klickar p� en kontakt i listboxen
        private void listBoxSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedContact = listBoxSearchResults.SelectedIndex;

            //Om man har klickat p� en kontakt i listboxen s� splittas str�ngen och
            //skapar upp en array. 
            if (listBoxSearchResults.SelectedItem != null)
            {
                string selectedRow = listBoxSearchResults.SelectedItem.ToString();
                string[] contactInfo = selectedRow.Split(", ");

                //H�r skickas v�rdena i arrayen till de olika textboxarna
                textBoxFirstName.Text = contactInfo[0];
                textBoxLastName.Text = contactInfo[1];
                textBoxStreet.Text = contactInfo[2];
                textBoxPostalCode.Text = contactInfo[3];
                textBoxCity.Text = contactInfo[4];
                textBoxPhone.Text = contactInfo[5];
                textBoxEmail.Text = contactInfo[6];

            }

        }

        //Metod som rensar och uppdaterar listboxen med kontakter
        public void UpdateContactList()
        {
            listBoxSearchResults.Items.Clear();

            string file = @"C:\Users\jessc\Desktop\Inl�mningsuppgift 1\Adressbok.txt";
            using (StreamReader reader = new StreamReader(file))
            {
                string row;
                //H�mtar och l�gger till en rad fr�n textfilen i listboxen,
                //s� l�nge det inte �r tomt
                while ((row = reader.ReadLine()) != null)
                {
                    listBoxSearchResults.Items.Add(row);
                }
            }
        }

        //Metod som rensar alla textboxar
        public void ClearAllFields()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxStreet.Clear();
            textBoxPostalCode.Clear();
            textBoxCity.Clear();
            textBoxPhone.Clear();
            textBoxEmail.Clear();
            textBoxSearchCondition.Clear();
        }
    }
}
