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

        public Spot(int x, int y, bool isTraversed, int travelCost, int cookiesGained
            , Obstacle ob)
        {
            this.x = x;
            this.y = y;
            this.isTraversed = isTraversed;
            this.travelCost = travelCost;
            this.cookiesGained = cookiesGained;
            this.ob = ob;

            this.collisionBox = new Rectangle(200, 200, 50, 50);
        }
        public Spot(int x, int y, bool isTraversed, int travelCost, int cookiesGained)
        {
            this.x = x;
            this.y = y;
            this.isTraversed = isTraversed;
            this.travelCost = travelCost;
            this.cookiesGained = cookiesGained;
            this.ob = null;

            this.collisionBox = new Rectangle(200, 200, 50, 50);
           
        }

        public void LoadContent(ContentManager content)
        {
            image = content.Load<Texture2D>("Patch.png");
        }

        public void Draw(SpriteBatch sb)
        {
            sb.Draw(image, new Rectangle(x, y, 50, 50), Color.Red);
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
