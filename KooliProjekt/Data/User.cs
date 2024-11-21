﻿using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
    }
}
