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
        GameObject go;

        List<GameObject> objList;
        List<string> locationList;
        Graphics dc;
        BufferedGraphics backBuffer;

        int money;

        int maxWorkerCount;
        List<Worker> workerList;
        List<Mine> mineList;

        string baseLoccation;

        public Main()
        {
            
            Thread workerThread = new Thread(WorkerLoop);
            Thread mineThread = new Thread(MineLoop);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void GameLoop()
        {

            
            
            Draw();
        }

        public void WorkerLoop()
        {
            foreach (Worker obj in workerList)
            {
                
            }

            WorkerLoop();
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
