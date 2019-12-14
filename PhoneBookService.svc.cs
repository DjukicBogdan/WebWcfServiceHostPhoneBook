using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebWcfServiceHostPhoneBook.Models;

namespace WebWcfServiceHostPhoneBook
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PhoneBookService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PhoneBookService.svc or PhoneBookService.svc.cs at the Solution Explorer and start debugging.
    public class PhoneBookService : IPhoneBookService
    {
        private PhoneBook db = new PhoneBook();

        public PersonCon GetPerson(int id)
        {
            Person p1 = db.People.Find(id);

            if (p1 == null)
            {
                return new PersonCon { Id = 0 };
            }

            PersonCon p = new PersonCon {
                Id = p1.Id,
                Name = p1.Name,
                Phone = p1.Phone,
                Mobile = p1.Mobile,
                Email = p1.Email,
                Address = p1.Address
            };
            return p;
        }

        public IEnumerable<PersonCon> GetPersons()
        {
            IEnumerable<PersonCon> listPersons = db.People.Select(p => new PersonCon {
                Id = p.Id,
                Name = p.Name,
                Phone = p.Phone,
                Mobile = p.Mobile,
                Email = p.Email,
                Address = p.Address
            });
            return listPersons;
        }
    }
}
