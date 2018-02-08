using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Vector2
    {
        private float X;
        private float Y;
        public float GetX
        {
            get { return X; }
            set { X = value; }
        }
        public float GetY
        {
            get { return Y; }
            set { Y = value; }
        }
        public Vector2(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }
        public static Vector2 operator -(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X - v2.X, v1.Y - v2.Y);
        }
        private float Length()
        {
            return (float)Math.Sqrt((this.X * this.X) + (this.Y * this.Y));
        }
        public void Normalize()
        {
            float length = Length();

            this.X = this.X / length;
            this.Y = this.Y / length;

        }
    }
}
