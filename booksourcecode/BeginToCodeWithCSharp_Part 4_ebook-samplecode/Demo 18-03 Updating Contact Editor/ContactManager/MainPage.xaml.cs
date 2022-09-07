using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ContactManager
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ContactStore contacts = ContactStore.GetTestStore();

        public MainPage()
        {
            this.InitializeComponent();
        }

ObservableCollection<Contact> contactList;

private void SearchButton_Click(object sender, RoutedEventArgs e)
{
    string searchName = searchTextBox.Text;

List<Contact> foundList = contacts.FindContactsWithName(searchName);
contactList = new ObservableCollection<Contact>(foundList);

ContactListBox.ItemsSource = contactList;
    clearContactEdit();
}

private void saveContactFromPage(Contact destination)
{
    destination.Name = NameTextBox.Text;
    destination.Address = AddressTextBox.Text;
    destination.Phone = PhoneTextBox.Text;
    //// Find the customer in the list
    //int pos = contactList.IndexOf(destination);
    //// Remove it
    //contactList.RemoveAt(pos);
    //// Put it back again - to force a change
    //contactList.Insert(pos, destination);

    //        contactList.
}

private void placeContactOnPage(Contact source)
{
    NameTextBox.Text = source.Name;
    AddressTextBox.Text = source.Address;
    PhoneTextBox.Text = source.Phone;
}

        Contact selectedContact = null;

        private void selectContactForEdit(Contact contactToEdit)
        {
            if (selectedContact != null)
            {
                // we are about to move off a contact - save it
                saveContactFromPage(selectedContact);
            }
            placeContactOnPage(contactToEdit);
            selectedContact = contactToEdit;
        }

        private void createNewContactFromPage()
        {
            Contact newContact = new Contact(
                name: NameTextBox.Text,
                address: AddressTextBox.Text,
                phone: PhoneTextBox.Text);
            contacts.StoreCountact(newContact);
            contactList.Add(newContact);
        }

        private void clearContactEdit()
        {
            NameTextBox.Text = "";
            AddressTextBox.Text = "";
            PhoneTextBox.Text = "";
        }

        private void deleteContact()
        {
            if (selectedContact != null)
            {
                contacts.RemoveContact(selectedContact);
                clearContactEdit();
                selectedContact = null;
            }
        }

        private void ContactListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ContactListBox.SelectedItem == null)
                return;

            Contact contact = (Contact)ContactListBox.SelectedItem;
            selectContactForEdit(contact);
        }
    }
}
