﻿using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IMailService
    {
        void SendMessage(string email, string body);
    }
}
