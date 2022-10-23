using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStorageSovunja
{
    public class Message: Text
    {
        private string message;
        public Message(string _message) //Получаем сообщение здесь, при введении в основе Message("Какой-то текст")
        {
            message = _message;
        }
        public override string Add()
        {
            return($"{base.Add()} [Message] {message}");
        }
    }
}
