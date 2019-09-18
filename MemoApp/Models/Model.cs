using System;
using Entities;
using BLL;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemoApp.Models
{
    public class Model
    {
        private ContactBAL bll = new ContactBAL();
        public List<Contact> GetList()
        {
            return bll.GetAll();
        }
    }
}