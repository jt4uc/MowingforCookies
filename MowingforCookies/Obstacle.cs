using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MowingforCookies
{
    class Obstacle
    {
        public Spot currentLocation;
        public String obstacleType;
        //obstacleTexture: Texture2D
        //obstacleTextureMap: Animated Sprite

        public Obstacle(Spot currentLocation, String obstacleType)
        {
            this.currentLocation = currentLocation;
            this.obstacleType = obstacleType;
        }
        //initialize

        //draw

        //update

    }
}
