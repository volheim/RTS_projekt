using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Numerics;

namespace WindowsFormsApp1
{
    public class Worker : GameObject
    {

        Graphics dc;

        public Vector2 targetPosition;
        public Vector2 position;

        float speed;
        int carryWeight;
        int carrying;
        public float tempResources;

        public Worker(Vector2 pos, Vector2 targetPos, float speed, int carryWeight)
        {
            position = pos;
            targetPosition = targetPos;
            this.speed = speed;
            this.carryWeight = carryWeight;
        }

        public void CheckResources()
        {
            if(tempResources >= carryWeight)
            {
                carrying = carryWeight;
            }
        }

        private void Colission()
        {

        }


        public void Draw(Graphics dc)
        {

        }

    }
}
