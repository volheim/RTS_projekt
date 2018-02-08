using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace WindowsFormsApp1.Classes
{
    /*public class GameWorld
    {
        private Graphics dc;
        public static List<GameObject> objects;

        private DateTime endTime; //Sætter maskines tidspunkt
        private float currentFPS;

        private BufferedGraphics backBuffer; //Gør så at billede et ikke flicker




        //public static List<GameObject> Objects
        //{
        //    get { return GameWorld.objects; }
        //    set { GameWorld.objects = value; }
        //}

        public GameWorld(Graphics dc, Rectangle displayRectangle)
        {
            this.backBuffer = BufferedGraphicsManager.Current.Allocate(dc, displayRectangle);

            this.dc = backBuffer.Graphics;
            //this.dc = dc;
            SetupWorld();
        }

        public void SetupWorld()
        {
            
            objects = new List<GameObject>();
            objects.Add(new Worker(new System.Numerics.Vector2(40, 40), 10, 10, 10, @"Images\Sprites\Worker\spaceAstronauts_001.png"));
           
            // objects.Add(new enemy(new System.Numerics.Vector2(40, 40), 10, 10, 10, @"Images\Sprites\Worker\spaceAstronauts_001.png"));
            endTime = DateTime.Now;
        }

        public void GameLoop()
        {
            DateTime startTime = DateTime.Now;
            TimeSpan deltaTime = startTime - endTime;
            int milliseconds = deltaTime.Milliseconds > 0 ? deltaTime.Milliseconds : 1;
            endTime = DateTime.Now;
            currentFPS = 1000 / milliseconds;


            Update(currentFPS);
            UpdateAnimations(currentFPS);
            Draw();
        }

        private void Draw()
        {
            dc.Clear(Color.Blue);
            foreach (GameObject go in objects)
            {
                go.Draw(dc);
            }
#if DEBUG //kommer kun op når der de bugges
            Font f = new Font("Arial", 16);
            dc.DrawString(string.Format("FPS: {0}", currentFPS), f, Brushes.Black, 0, 0);
#endif
            backBuffer.Render();
        }

        private void Update(float fps)
        {
            foreach (GameObject go in objects)
            {
                go.Update(fps);
            }
        }


        private void UpdateAnimations(float fps)
        {
            foreach (GameObject go in objects)
            {
                //go.UpdateAnimations(fps);
            }
        }

    }*/
}
