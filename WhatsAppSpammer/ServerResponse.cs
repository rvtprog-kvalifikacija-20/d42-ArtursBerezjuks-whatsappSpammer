using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsappSpammer
{
    public class ServerResponse
    {
        public bool Sent { get; set; }
        public string Message { get; set; }
        public int Queue { get; set; }

        public ServerResponse(bool sent, string message, int queue)
        {
            Sent = sent;
            Message = message;
            Queue = queue;
        }
    }
}
