using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ContactBAL
    {
        /*
        public List<Contact> GetContact()
        {
            return ContactDAL.contactList;
            //var x - DB.memos.Where(m => m.Id = 5).Select(y => y.Id = 5) )
        }   
        
        public Contact getAllContacts(int id)
        {
            return ContactDAL.contactList.Select<id>;
        }*/


        // Get All Method
        public List<Contact> GetAll()
        {
            List<Contact> activeContactList = new List<Contact>();
            foreach(var contact in ContactDAL.contactList)
            {
                if (contact.Active == true)
                {
                    activeContactList.Add(contact);
                }
            }
            return activeContactList;
        }
            // Add Record Method
        public void add(Contact c)
        {
            c.Id = ContactDAL.LastId++;
            if (c.MobilePhoneNum == null || string.IsNullOrWhiteSpace(c.MobilePhoneNum)
                || string.IsNullOrEmpty(c.MobilePhoneNum))
                c.MobilePhoneNum = "Not Available";
            c.Active = true;
            ContactDAL.contactList.Add(c);
        }
            // Delete Record Method
        public void DeleteRecord(int id)
        {
            // ContactDAL.contactList.Remove(Details(id));
            Contact c = ContactDAL.contactList.Where(x => x.Id == id).First();
            c.Active = false;
        }
            // Get data from specific record.
        public Contact Details(int id)
        {
            return ContactDAL.contactList.Where(x => x.Id == id).SingleOrDefault();
        }

        // Update/Edit Record Method
        public void Update(Contact c)
        {
            Contact cont = ContactDAL.contactList.Where(x => x.Id == c.Id).First();
            if (c.MobilePhoneNum == null || string.IsNullOrWhiteSpace(c.MobilePhoneNum)
                || string.IsNullOrEmpty(c.MobilePhoneNum))
                c.MobilePhoneNum = "Not Available";

            cont.FirstName = c.FirstName;
            cont.LastName = c.LastName;
            cont.MobilePhoneNum = c.MobilePhoneNum;
            cont.HomePhoneNum = c.HomePhoneNum;
            cont.BusinessPhoneNum = c.BusinessPhoneNum;
            cont.Address = c.Address;
            cont.Note = c.Note;


        }
    }
}
