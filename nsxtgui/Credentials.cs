﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsxtgui
{
    public class Credentials
    {
        public string Hostname { set; get; }
        public string Password { set; get; }    
        public string Username { set; get; }
        public bool? validateCertificate { set; get; }
    }
}
