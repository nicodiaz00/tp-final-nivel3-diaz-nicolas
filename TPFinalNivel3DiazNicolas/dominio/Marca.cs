﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Marca
    {
        public  int Id { get; set; }
        public string DescripcionMarca {  get; set; }

        public override string ToString()
        {
            return DescripcionMarca;
        }
    }
}
