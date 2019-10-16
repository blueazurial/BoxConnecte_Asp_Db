﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxConnecte.Entities
{
    //mes entité on tous les referance des tables corespondent 
    class Address
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Street { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
    }
}