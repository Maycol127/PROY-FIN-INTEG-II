﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioEntidades
{
    public class Curso
    {
        public int IdCurso { get; set; }
        public string Nombre { get; set; } = null!;
        public string FechaCreacion { get; set; } = null!;
    }
}