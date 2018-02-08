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

        public Main()
        {
            if(addWorker > 0)
            {
                workerThread = new Thread(NewWorkerLoop);
                addWorker--;
            }
            if(addMine > 0)
            {
                mineThread = new Thread(MineLoop);
                addMine--;
            }
            

            GameLoop();
        }

        public void GameLoop()
        {
            startTime = DateTime.Now;
            
            

            Draw();
            endTime = DateTime.Now;
            fps = (endTime - startTime).Milliseconds;
            fps = 1 / fps;
            GameLoop();
        }

        void NewWorkerLoop()
        {
            Worker newWorker = new Worker(spawnPosition, initialDestination, 2.5f, 25);
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
            if(i > 0 || (i += money) >= 0)
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

        void Draw()
        {

            dc.Clear(Color.White);

            int i = 0;
            foreach (GameObject obj in objList)
            {
                UpdateLocations(obj, i);

                
                i++;
            }


            /*dc.Clear(Color.Cornsilk);
            Font f = new Font("Arial", 16);
            foreach (GameObject go in objects)
            {
                go.Draw(dc);

    #if DEBUG //This code will only be run in   debug mode
                dc.DrawString(string.Format("FPS: {0}", currentFps), f, Brushes.Black, 550, 0);
    #endif

            }
            foreach (Explosion ex in explosions_List)
            {
                ex.Draw(dc);
            }
            foreach (Player player in playerList)
            {
                DrawUiPlayer(player);

            }
            //Renders the content of the buffered graphics context to the real context(Swap buffers)*/
            backBuffer.Render();
        }
    }
}
