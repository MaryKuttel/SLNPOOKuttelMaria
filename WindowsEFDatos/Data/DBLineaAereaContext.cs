﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WindowsEFDatos.Modelos;

namespace WindowsEFDatos.Data
{
    public class DBLineaAereaContext : DbContext
    {

        public DBLineaAereaContext() : base("KeyDB") 
        {
        
        }

        public DbSet<LineaAerea> LineaAereas { get; set;}
        public DbSet<Avion> Aviones { get; set;}



    }
}
