using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Numerics;

namespace WindowsFormsApp1
{
    class Main
    {
        public DateTime startTime;
        public DateTime endTime;
        public float fps;


        int addWorker;
        int addMine;


        GameObject go;

        List<GameObject> objList;
        List<Vector2> locationList;
        Graphics dc;
        BufferedGraphics backBuffer;

        Vector2 spawnPosition;
        Vector2 initialDestination;

        bool lastPurchaseValid;
        int money;

        int maxWorkerCount;
        List<Worker> workerList;
        List<Mine> mineList;

        string baseLoccation;


        Thread workerThread;
        Thread mineThread;



        public static List<GameObject> objects;

        private float currentFPS;
        


        public Main()
        {
            Rectangle displayRectangle = new Rectangle();
            if (addWorker > 0)
            {
                workerThread = new Thread(NewWorkerLoop);
                addWorker--;
            }
            if (addMine > 0)
            {
                mineThread = new Thread(MineLoop);
                addMine--;
            }

            backBuffer = BufferedGraphicsManager.Current.Allocate(dc, displayRectangle);

            dc = backBuffer.Graphics;
            //this.dc = dc;
            SetupWorld();
            
        }


        void NewWorkerLoop()
        {
            Worker newWorker = new Worker(new System.Numerics.Vector2(40, 40), 10, 10, 10, @"Images\Sprites\Worker\spaceAstronauts_001.png");
            WorkerLoop();
        }
        public void WorkerLoop()
        {



            WorkerLoop();
        }

        void NewMineLoop()
        {
            Mine newMine = new Mine(3, 15, new Vector2(spawnPosition.X + 100, spawnPosition.Y + 100));
            MineLoop();
        }
        public void MineLoop()
        {
            foreach (Object obj in mineList)
            {

            }

            MineLoop();
        }

        public void RemoveObjFromList(GameObject obj)
        {
            objList.Remove(obj);
        }

        public void AddObjToList(GameObject obj)
        {
            objList.Add(obj);
        }

        public void CheckResources(int i)
        {
            if (i > 0 || (i += money) >= 0)
            {
                money += i;
                lastPurchaseValid = true;
            }
            else
            {
                lastPurchaseValid = false;
            }
        }

        public void UpdateLocations(object obj, int i)
        {

            //locationList[i] = objList[i]/*get x & y location as string*/
        }



        public void SetupWorld()
        {

            objects = new List<GameObject>();
            objects.Add(new Worker(new System.Numerics.Vector2(40, 40), 10, 10, 10, @"Images\Sprites\Worker\spaceAstronauts_001.png"));

            // objects.Add(new enemy(new System.Numerics.Vector2(40, 40), 10, 10, 10, @"Images\Sprites\Worker\spaceAstronauts_001.png"));
            endTime = DateTime.Now;
            GameLoop();
        }

        public void GameLoop()
        {
            DateTime startTime = DateTime.Now;
            TimeSpan deltaTime = startTime - endTime;
            int milliseconds = deltaTime.Milliseconds > 0 ? deltaTime.Milliseconds : 1;
            endTime = DateTime.Now;
            currentFPS = 1000 / milliseconds;


            //Update(currentFPS);
            UpdateAnimations(currentFPS);
            Draw();
            GameLoop();
        }

        private void Draw()
        {
            dc.Clear(Color.Blue);
            /*foreach (GameObject go in objects)
            {
                go.Draw(dc);
            }*/
/*#if DEBUG //kommer kun op når der de bugges
            Font f = new Font("Arial", 16);
            dc.DrawString(string.Format("FPS: {0}", currentFPS), f, Brushes.Black, 0, 0);
#endif*/
            backBuffer.Render();
        }

        /*private void Update(float fps)
        {
            foreach (GameObject go in objects)
            {
                go.Update(fps);
            }
        }*/


        private void UpdateAnimations(float fps)
        {
            foreach (GameObject go in objects)
            {
                //go.UpdateAnimations(fps);
            }
        }


    }
}
