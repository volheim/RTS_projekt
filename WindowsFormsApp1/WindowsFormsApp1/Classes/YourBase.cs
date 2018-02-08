using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class YourBase : GameObject
    {
        public string position;


        protected float speed;
        private int health;
        private int armor;
        private string Images;

        public YourBase(int health, float speed, int armor, string Images, Vector2 startPos) : base(startPos, 1)
        {
            this.health = health;
            this.speed = speed;
            this.armor = armor;
            this.Images = Images;
        }
        public int GetHealth
        {
            get
            {
                if (health < 0)
                {
                    health = 0;
                }
                return health;
            }
            set
            {
                if (value <= 100)
                {
                    health = value;
                }
            }
        }
        public void SetHealth(int health)
        {
            this.health = health;
        }

        public abstract void Collect();



        //public YourBase()
        //{

        //}
        
        //public void Collision()
        //{

        //}
 
        //public void ControlWorkers()
        //{

        //}
        //public void BuildNewWorker()
        //{

        //}
        //public void UpgradeWorker()
        //{

        //}
        //public void BuildPartsToRocket()
        //{

        //}
        //public void BuildRocket()
        //{

        //}
    }
}
