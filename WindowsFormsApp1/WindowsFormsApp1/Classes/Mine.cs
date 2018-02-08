using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Numerics;
using System.Threading;

namespace WindowsFormsApp1
{
    public class Mine : GameObject
    {
        int health = 100;

        public Vector2 position;

        Graphics dc;

        int maxWorkerCount;
        List<Worker> currentWorkers;
        float resourcesPerSecond;

        static Semaphore mineGate = new Semaphore(0, 3);

        bool atMine;
        bool atBase;


        public void MineLoop()
        {

            if (atMine)
            {
                AddResourceToWorkers();
            }
            else if (atBase)
            {

            }
            MineLoop();
        }

        public void AddResourceToWorkers()
        {
            mineGate.WaitOne();

        }

        public Mine(int maxWorkerCount, float resourcesPerSecond, Vector2 position)
        {
            this.maxWorkerCount = maxWorkerCount;
            this.resourcesPerSecond = resourcesPerSecond;
            this.position = position;
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

        public void Draw()
        {

        }
    }
}
