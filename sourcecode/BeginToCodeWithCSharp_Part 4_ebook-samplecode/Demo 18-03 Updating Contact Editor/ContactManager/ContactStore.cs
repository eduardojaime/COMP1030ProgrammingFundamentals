using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Contact : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string address;

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Address"));
                }
            }
        }

        private string phone;

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Phone"));
                }
            }
        }

        private int minutesSpent;

        public int MinutesSpent
        {
            get
            {
                return minutesSpent;
            }

            set
            {
                minutesSpent = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("MinutesSpent"));
                }
            }
        }

        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }

        public Contact(string name, string address, string phone)
        {
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.MinutesSpent = 0;
        }

        public override string ToString()
        {
            return this.name;
        }
    }

    public class ContactStore
    {
        public static ContactStore GetTestStoreAddresses()
        {
            ContactStore result = new ContactStore();

            string[] testNames = {
"Rob", "Mary", "David", "Jenny","Chris",
"Simon", "Kevin", "Helen", "Neil",
"Amanda", "Sally", "Rory", "Robin" };

            string[] testAddresses = { "Hull" };

            // the number of minutes for contacts
            int minutes = 0;

            foreach (string name in testNames)
            {
                foreach (string address in testAddresses)
                {
                    Contact newContact = new Contact(name: name,
                        address: name + "'s house in " + address,
                        phone: name + "'s phone in" + address);
                    newContact.MinutesSpent = minutes;
                    minutes = minutes + 30;
                    result.contacts.Add(newContact);
                }
            }
            return result;
        }

        public static ContactStore GetTestStore()
        {
            ContactStore result = new ContactStore();

            string[] testNames = {
"Rob", "Mary", "David", "Jenny","Chris",
"Simon", "Kevin", "Helen", "Neil",
"Amanda", "Sally", "Rory", "Robin" };

            // the number of minutes for contacts
            int minutes = 0;

            foreach (string name in testNames)
            {
                Contact newContact = new Contact(name: name,
                    address: name + "'s house",
                    phone: name + "'s phone");
                newContact.MinutesSpent = minutes;
                minutes = minutes + 30;
                result.contacts.Add(newContact);
            }

            return result;
        }

        private List<Contact> contacts = new List<Contact>();

        public void StoreCountact(Contact contact)
        {
            contacts.Add(contact);
        }

        public void RemoveContact(Contact contact)
        {
            contacts.Remove(contact);
        }

        public List<Contact> FindContactsWithName(string searchName)
        {
            searchName = searchName.ToUpper();

            List<Contact> result = new List<Contact>();

            foreach (Contact contact in contacts)
            {
                string contactName = contact.Name.ToUpper();
                if (contactName.Contains(searchName))
                {
                    result.Add(contact);
                }
            }
            return result;
        }
    }
}
