﻿using System.ComponentModel.DataAnnotations;

namespace ProjectManage.Models
{
    public class NameOfProject
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}