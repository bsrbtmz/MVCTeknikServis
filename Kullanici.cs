﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeknikServis.UI.AppClasses
{
    public class Kullanici
    {
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public string Email { get; set; }
        public string GizliSoru { get; set; }
        public string GizliCevap { get; set; }
    }
}