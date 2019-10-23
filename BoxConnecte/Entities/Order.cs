﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxConnecte.Entities
{
    class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int QrCode { get; set; }
        public int PswBox { get; set; }
        public bool OrderWithdrawn { get; set; }
        public int NumberBox { get; set; }
    }
}
