﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class MailService
    {
        public void onVideoEncoded(object sender, EventArgs e)
        {
            Console.WriteLine("MailService: Sending an email...");
        }
    }
}
