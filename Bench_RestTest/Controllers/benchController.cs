using Bench_RestTest.Models;
using Bench_RestTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bench_RestTest.Controllers
{
    public class benchController : ApiController
    {
        private ContactRepository contactRepository;

        public benchController()
        {
            contactRepository = new ContactRepository();
        }

        [HttpGet]
        [Route("api/bench")]
        public ContactModel[] Get()
        {
            return contactRepository.GetAllContacts();
        }

        [HttpGet]
        [Route("api/bench/company")]
        public string[] GetCompany()
        {            
            return contactRepository.GetAllContacts().Select(x => x.Company).ToArray();
        }
        [HttpGet]
        [Route("api/bench/Ledger")]

        public string[] GetLedger()
        {
            return contactRepository.GetAllContacts().Select(x =>x.Ledger).ToArray();
        }
        [HttpGet]
        [Route("api/bench/Amount")]
        public string[] GetAmount()
        {
            return contactRepository.GetAllContacts().Select(x => x.Amount).ToArray();
        }
    }
}
