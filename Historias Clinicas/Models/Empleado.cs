﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Historias_Clinicas.Models
{
    public class Empleado : Persona
    {

        [Required(ErrorMessage = MensajeError.Requerido)]
        public int Legajo { get; set; }

    }
}
