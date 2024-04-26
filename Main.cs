namespace CS162_Lab4
{
    /*
     * Email address bok application thingy.
     * 
     * @author Nathaniel rivera
     * @verison CS162 Lab 4, 4/26/2024
     */
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        List<Person> personList = new List<Person>();

        public void main_OnLoad(object snder, EventArgs e)
        {
            try
            {
                StreamReader contactFile = File.OpenText("ContactList.txt");

                while (!contactFile.EndOfStream)
                {
                    string[] currentContact = contactFile.ReadLine().Split(';');

                    Person newContact = new Person(currentContact[0], currentContact[1], currentContact[2]);
                    personList.Add(newContact);
                    contact_ListBox.Items.Add(newContact.Name);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contact_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listSender = (ListBox)sender;

            Form contactView = new PersonForm(personList[listSender.SelectedIndex]);
            contactView.ShowDialog();
        }
    }
}
