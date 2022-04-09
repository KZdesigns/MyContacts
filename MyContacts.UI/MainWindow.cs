using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyContacts.Data;

namespace MyContacts.UI
{
    public partial class MainWindow : Form
    {
        List<Contact> contacts = new List<Contact>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            // add the contact to the the list
            AddNewContact();
            // update list
            UpdateContactList();
            // clear controls
            ClearItems();
        }

        private void AddNewContact()
        {
            var contact = new Contact();

            contact.FullName = textBoxFullName.Text;
            contact.PhoneNumber = textBoxPhoneNumber.Text;
            contact.Email = textBoxEmail.Text;
            contact.Birthday = dateTimePickerBirthday.Value;

            contacts.Add(contact);
        }

        private void UpdateContactList()
        {
            listBoxContacts.Items.Clear();

            foreach(var contact in contacts)
            {
                listBoxContacts.Items.Add(contact.ToString());
            }
        }

        private void ClearItems()
        {
            textBoxFullName.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxEmail.Text = "";
        }
    }
}
