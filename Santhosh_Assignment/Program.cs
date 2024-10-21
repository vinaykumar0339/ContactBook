using System;
using Santhosh_Assignment.ContactsManager;

namespace Santhosh_Assignment
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ContactsManager.ContactsManager contactsManager = new ContactsManager.ContactsManager();
            contactsManager.run();
        }
    }
}
