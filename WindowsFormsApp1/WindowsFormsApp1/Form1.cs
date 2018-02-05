using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static List<object> objList;
        static List<string> locationList;
        static Graphics dc;
        BufferedGraphics backBuffer;

        int money;

        int maxWorkerCount;
        List<object> workerList;

        string baseLoccation;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void GameLoop()
        {



            Draw();
        }

        public void RemoveObjFromList(object obj)
        {
            objList.Remove(obj);
        }

        public void AddObjToList(object obj)
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
            foreach(object obj in objList)
            {
                UpdateLocations(obj, i);

                obj.Draw
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
