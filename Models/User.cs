﻿namespace DogAdoptionProject.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Level { get; set; } = 0;

        public User() { }

    }
}
