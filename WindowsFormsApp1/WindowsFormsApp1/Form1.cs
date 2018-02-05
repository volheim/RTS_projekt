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
            int i = 0;
            foreach(object obj in objList)
            {
                UpdateLocations(obj, i);
                i++;
                
            }
        }
    }
}
