using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStorageSovunja
{
    public class Person: Text
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        public Person(string firstName, string lastName, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }
        public override string Add()
        {
            return( $"{base.Add()} [Person] {_firstName} {_lastName}, {_age} ");
        }
    }
}
