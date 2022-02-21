using Bench_RestTest.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Bench_RestTest.Services
{
    public class ContactRepository
    {
        public ContactModel[] GetAllContacts()
        {
            var assembly = Assembly.GetExecutingAssembly();
            ContactModel[] contactList = new ContactModel[] { };
            using (var stream = assembly.GetManifestResourceStream("Bench_RestTest.Repository.Bench.json"))
            {
                StreamReader reader = new StreamReader(stream);
                string jsonString = reader.ReadToEnd();
                contactList = Newtonsoft.Json.JsonConvert.DeserializeObject<ContactModel[]>(jsonString);
            }

            return contactList;
        }
    }
}