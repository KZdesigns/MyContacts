using System;

namespace MyContacts.Data
{
    public class Contact
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, Phone: {1}, Email: {2}, Birthday: {3}", this.FullName, this.PhoneNumber, this.Email, this.Birthday.ToString("mm/dd/yyyy"));
        }
    }
}
