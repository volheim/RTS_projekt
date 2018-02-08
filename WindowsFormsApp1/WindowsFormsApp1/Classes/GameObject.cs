using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Numerics;


namespace WindowsFormsApp1
{
    public class GameObject
    {
     
        Graphics dc;

        RectangleF colissionBox;

        //Spillets sprite
        protected Image sprite;

        //Position
        protected Vector2 position;

        private List<Image> animationFrames;

        //private float currentFrameIndex;
        protected float currentFrameIndex;

        // private float animationSpeed;
        protected float animationSpeed;

        private float scaleFactor;


        //Går ind og finder billedstien, start position og scalere billedet.
        public GameObject(Vector2 pos, float scaleFactor)
        {
            this.scaleFactor = scaleFactor;

            //string[] imagePaths = imagePath.Split(';');

            this.position = pos;
            animationSpeed = 2f;
            this.animationFrames = new List<Image>();


           /* foreach (string path in imagePaths)
            {
                animationFrames.Add(Image.FromFile(path));
            }
            this.sprite = this.animationFrames[0]; */
        }

        //Tegner billede og scalere den og så laver en rød rectangle om den
        public virtual void Draw(Graphics dc)
        {
            dc.DrawImage(sprite, position.X, position.Y, sprite.Width * scaleFactor, sprite.Height * scaleFactor);
            dc.DrawRectangle(new Pen(Brushes.Red), CollisionBox.X, CollisionBox.Y, CollisionBox.Width, CollisionBox.Height);
        }

        //opdatere position og tjekker om der kollision
        public virtual void Update(float fps)
        {

            float speedFPS = 50f / fps;

            //CheckCollision();
        }
        //Opdatere animation på billede, så den skifter mellem de forskellige billeder.
        /*public virtual void UpdateAnimations(float fps)
        {
            float factor = 1 / fps;

            currentFrameIndex += factor * animationSpeed;

            if (currentFrameIndex >= animationFrames.Count -1)
            {
                currentFrameIndex = 0;
            }
            sprite = animationFrames[(int)currentFrameIndex];
        }*/

        public void IntersectsWith()
        {
            Rectangle workerRect = new Rectangle();
            Rectangle enemyRect = new Rectangle();
            if (workerRect.IntersectsWith(enemyRect))
            {

            }
        }
        //Laver en hitbox uden om billedet på den nye position
        public RectangleF CollisionBox
        {
            get
            {
                return new RectangleF(position.X, position.Y, sprite.Width * scaleFactor, sprite.Height * scaleFactor);
            }
        }
        public bool isCollidingWith(GameObject other)
        {
            return CollisionBox.IntersectsWith(other.CollisionBox);
        }

        public void OnCollision(GameObject other)
        {

        }

        //Tjekker kollision mellem de forskellige objekter
        /*public void CheckCollision()
        {
            foreach (GameObject go in Classes.GameWorld.objects)
            {
                if (go != this)
                {
                    if (this.isCollidingWith(go))
                    {
                        OnCollision(go);
                    }
                }
            }
        }*/

    }
}
