using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class Character //by default class is 'internal', to use externally need to set as 'public'
    {
        //public - will be accessed from outside, not only from project but from entyre solution projects. In extrenal project should be referenced to this project
        //Project-> Dependencies-> Add reference-> select needed reference project.
        //Import namespace from required project to project where class will be used
        // using D_OOP;

        //internal - accessible only inside the project
        //protected - will be accessible inside the class, and in legacy classes.
        //private - by default if not set any

        //private int Health = 100; // the same behavior as without private

        //private int health = 100;

        public int Health { get; private set; } = 100;
        public void Hit(int damage)
        {
            if (damage > Health)
                damage = Health;
            
            Health -= damage;
            //health -= damage
        }

        //value - can be reproduced as 2 methods, value more preferable as methods for Get\Set operations
        //public int Health
        //{
        //    get
        //    {
        //        return health;
        //    }
        //    private set
        //    {
        //        health = value;
        //    }
        //}

        //public int GetHealth()
        //{
        //    return ealth;
        //}
        //private void SetHealth(int value)
        //{
        //    health = value;
        //}

        private static int speed = 10;

        public int PrintSpeed()
        {
            return speed;
        }

        public void IncreaseSpeed()
        {
            speed += 10;
        }
    }
}
