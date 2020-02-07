using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Linkman
    {
        public string id;
        public string name;
        public string sex;
        public string workAddress;
        public string phoneNum;
        public string email;
        public Linkman(string id, string name, string sex, string workAdd, string phone, string email)
        {
            this.id = id;
            this.name = name;
            this.sex = sex;
            this.workAddress = workAdd;
            this.phoneNum = phone;
            this.email = email;
        }
    }

   
}
