﻿namespace WhatsAppSpammer.NumberBase
{
    public class Message
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string MessageText { get; set; }
        public string PathToImage { get; set; }

        public Message(string messageText)
        {
            MessageText = messageText;
        }
    }
}
