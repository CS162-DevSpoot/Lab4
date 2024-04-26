namespace CS162_Lab4
{
    public partial class PersonForm : Form
    {
        private Person selectedContact;
        public PersonForm(Person personsContact)
        {
            selectedContact = personsContact;
            InitializeComponent();
        }

        private void form_OnLoad(object sender, EventArgs e) {
            name_Label.Text = selectedContact.Name;
            email_Label.Text = selectedContact.Email;
            phone_Label.Text = selectedContact.Phone;
        }


        private void close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
