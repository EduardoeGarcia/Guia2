﻿using System.ComponentModel.DataAnnotations;

namespace Guia2.Models
{
    public class facultades
    {
        [Key]
        public int facultad_id { get; set; }
        public string? nombre_facultad { get; set; }
        public char estado { get; set; }
    }
}
