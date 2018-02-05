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
        public List<Object> objList;

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

        void Draw()
        {

        }
    }
}
