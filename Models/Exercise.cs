﻿namespace GymAppReal.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public required string ExerciseName { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public double Weight { get; set; }
        public DateOnly Date { get; set; }
        public int UserId { get; set; }
        public required User User { get; set; }
    }
}
