using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public Spot(int x, int y, bool isTraversed, int travelCost, int cookiesGained
            , Obstacle ob)
        {
            this.x = x;
            this.y = y;
            this.isTraversed = isTraversed;
            this.travelCost = travelCost;
            this.cookiesGained = cookiesGained;
            this.ob = ob;
        }

        //Initialized

        public bool mowerHasTraversed(){
            return this.isTraversed;
        }

        //update

        //draw

        //traversedEffect

        public Obstacle getObstacle()
        {
            return ob;
        }

        public void setObstacle(Obstacle ob)
        {
            this.ob = ob;
        }


    }
}
