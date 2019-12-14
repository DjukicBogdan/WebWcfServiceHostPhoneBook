using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebWcfServiceHostPhoneBook.Models;

namespace WebWcfServiceHostPhoneBook
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPhoneBookService" in both code and config file together.
    [ServiceContract]
    public interface IPhoneBookService
    {
        [OperationContract]
        IEnumerable<PersonCon> GetPersons();

        [OperationContract]
        PersonCon GetPerson(int id);
    }
}
