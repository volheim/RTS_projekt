using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Mine
    {
        int health = 100;

        public string position;


        public Mine()
        {

        }
<<<<<<< HEAD
        public string Position()
=======

        public void AddResourceToWorker()
>>>>>>> 23b0174308b7723ed59034d998d92bcbd9b653f2
        {
            return Position;//placeholder
        }
<<<<<<< HEAD

=======
        /*public void Position()
        {

        }*/
>>>>>>> 23b0174308b7723ed59034d998d92bcbd9b653f2
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
