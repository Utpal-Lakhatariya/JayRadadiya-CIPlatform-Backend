﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI_Platform.Entity.Models
{
    public class EmailSetting
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string Host { get; set; }

        public string Displayname { get; set; }
        public int Port { get; set; }
    }
}
