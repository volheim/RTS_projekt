﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Mine
    {
        int health = 100;
        public void AddResourceToWorker()
        {

        }
        public string Position()
        {
            return Position;//placeholder
        }

        public int Health
        {
            set
            {
                health = value;
                if (health <= 0)
                {
                    
                }
            }
            get
            {
                return health;
            }
        }
        public int WorkerCount()
        {
            return WorkCounter;//placeholder
        }
        public int WorkTime()
        {
            return Time; //placeholder
        }
    }
}
