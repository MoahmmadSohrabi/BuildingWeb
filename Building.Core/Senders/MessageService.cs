using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building.Core.Senders
{
    public static class MessageService
    {
        public static bool SendMessage(string MobileNumber,string text)
        {
            var result = false;
            try
            {
                var sender = "100047778";
                var receptor = MobileNumber;
                var message = text;
                var api = new Kavenegar.KavenegarApi("67314E5152444944717A5A376C65773536333455456E4F42563970567048425A654334394A6A6765474D673D");
                api.Send(sender, receptor, message);
                result = true;
            }
            catch(Exception)
            {
                result = false;
            }
            return result;
           
        }
    }
}
