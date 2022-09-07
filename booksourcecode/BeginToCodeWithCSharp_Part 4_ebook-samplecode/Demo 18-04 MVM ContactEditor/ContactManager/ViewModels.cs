using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class ContactManagerViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Contact> foundList;

        public ObservableCollection<Contact> FoundList
        {
            get
            {
                return foundList;
            }
            set
            {
                foundList = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this,
                            new PropertyChangedEventArgs("FoundList"));
                }
            }
        }

        ContactStore contacts = ContactStore.GetTestStore();

        private string searchText;

        public string SearchText
        {
            get
            {
                return searchText;
            }

            set
            {
                searchText = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this,
                            new PropertyChangedEventArgs("SearchText"));
                }
            }
        }

        public void DoSearch()
        {
            List<Contact> foundList = contacts.FindContactsWithName(searchText);

            FoundList = new ObservableCollection<Contact>(foundList);
        }


private Contact selectedContact;

public Contact SelectedContact
{
    get
    {
        return selectedContact;
    }
    set
    {
        if (selectedContact != null)
            saveContactFromPage(selectedContact);

        selectedContact = value;

        if (selectedContact != null)
        {
            placeContactOnPage(SelectedContact);
        }

        if (PropertyChanged != null)
        {
            PropertyChanged(this,
                    new PropertyChangedEventArgs("SelectedContact"));
        }
    }
}

        public ContactManagerViewModel()
        {
            this.searchText = "";
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
                    PropertyChanged(this,
                            new PropertyChangedEventArgs("Name"));
                }
            }
        }

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
                    PropertyChanged(this,
                            new PropertyChangedEventArgs("Address"));
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
                    PropertyChanged(this,
                            new PropertyChangedEventArgs("Phone"));
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
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void placeContactOnPage(Contact contact)
        {
            Name = contact.Name;
            Address = contact.Address;
            Phone = contact.Phone;
            minutesSpent = contact.MinutesSpent;
        }

        public void saveContactFromPage(Contact contact)
        {
            contact.Name = Name;
            contact.Address = Address;
            contact.Phone = Phone;
            contact.MinutesSpent = minutesSpent;
        }

        public bool ContactChanged(Contact contact)
        {
            if (contact.Name != this.Name)
                return true;
            if (contact.Address != this.Address)
                return true;
            if (contact.Phone != this.Phone)
                return true;
            if (contact.MinutesSpent != this.MinutesSpent)
                return true;

            return false;
        }
    }
}
