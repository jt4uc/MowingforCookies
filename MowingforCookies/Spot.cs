using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;

namespace MowingforCookies
{
    class Spot : Sprite
    {
        public int x;
        public int y;
        public bool isTraversed;
        public int travelCost; //of cookies
        public int cookiesGained;
        public Obstacle ob;

        //tileTexture: Texture2D

        private Rectangle collisionBox;
        public int cbWidth = 150;
        public int cbHeight = 150;
        //public int cbX;
        //public int cbY;

        public Spot(int x, int y, bool isTraversed, int travelCost, int cookiesGained
            , int cbX, int cbY, Obstacle ob)
        {
            this.x = x;
            this.y = y;
            this.isTraversed = isTraversed;
            this.travelCost = travelCost;
            this.cookiesGained = cookiesGained;
            this.ob = ob;

            this.collisionBox = new Rectangle(cbX, cbY, cbWidth, cbHeight); //should be x and y?
        }
        public Spot(int x, int y, bool isTraversed, int travelCost, int cookiesGained, int cbX, int cbY)
        {
            this.x = x;
            this.y = y;
            this.isTraversed = isTraversed;
            this.travelCost = travelCost;
            this.cookiesGained = cookiesGained;
            this.ob = null;

            this.collisionBox = new Rectangle(cbX, cbY, cbWidth, cbHeight);
           
        }

        public void LoadContent(ContentManager content)
        {
            image = content.Load<Texture2D>("grass.png");
        }

        public void Draw(SpriteBatch sb)
        {
            sb.Draw(image, new Rectangle(x, y, 150, 150), Color.Yellow);
        }

        //Initialized

        public bool mowerHasTraversed(){
            return this.isTraversed;
        }

        public void Update()
        {

        }

        //traversedEffect




        public Obstacle getObstacle()
        {
            return ob;
        }

        public void setObstacle(Obstacle ob)
        {
            this.ob = ob;
        }
        public Rectangle getBox()
        {
            return collisionBox;
        }


    }
}
