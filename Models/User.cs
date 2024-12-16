﻿namespace GymAppReal.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}