﻿using PrismExample.Services.Interfaces;

namespace PrismExample.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
