using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1.Classes
{
    class Mine : GameObject
    {
        int health = 100;

        public string position;

        Graphics dc;


        public void AddResourceToWorker()
        {

        }

        public Mine()
        {

        }

        public string Position()
        {
            return Position;//placeholder
        }
        /*public void Position()
        {

        }*/
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


        public void Draw()
        {

        }
    }
}
