﻿namespace _05.MordorsCrueltyPlan.Models
{
    public abstract class Food
    {
        public string Name => this.GetType().Name;
        public int Happiness { get; protected set; }
    }
}