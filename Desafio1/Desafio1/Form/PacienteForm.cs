﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Consultorio.Form
{
    public class PacienteForm
    {
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? DataNascimento { get; set; }

        public PacienteForm() { }
    }
}