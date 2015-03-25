using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;

namespace MowingforCookies
{
    class Mower : Sprite
    {
        public int x;
        public int y;
        public int moveIndex;
        //private Rectangle collisionBox;
        public Spot currentLocation;
        public int cookies;
        public Spot targetLocation;
        public bool alize;
        public double speed;
        public Texture2D mowerTexture;
        //public Animated Sprite?? mowerTextureMap

        //Content Manager?
        public Mower(Spot currentLocation, int cookies)
        {
            
            this.currentLocation = currentLocation;
            this.moveIndex = 0;
            this.x = currentLocation.x + 25;
            this.y = currentLocation.y + 25;
            this.cookies = cookies;
            
            //speed = 5;
            //movedX = 0;
            //collisionBox = new Rectangle(x, y, width, height);
        }

        //public int getX()
        //{
        //    return spriteX;
        //}
        //public int getY()
        //{
        //    return spriteY;
        //}
        //public void setX(int x)
        //{
        //    collisionBox.X = x;
        //    spriteX = x;
        //}
        //public void setY(int y)
        //{
        //    collisionBox.Y = y;
        //    spriteY = y;
        //}
        //public void setSpeed(int s)
        //{
        //    speed = s;
        //}
        //public Rectangle getBox()
        //{
        //    return collisionBox;
        //}

        public void LoadContent(ContentManager content)
        {
            image = content.Load<Texture2D>("MiniMower.png");
        }

        public void Draw(SpriteBatch sb)
        {
            sb.Draw(image, new Rectangle(x, y, 50, 50), Color.White);
        }

        public void Update(Controls controls, List<Spot> patches, GameTime gameTime)
        {
            Move(controls, patches);
        }

        public void Move(Controls controls, List<Spot> patches)
        {
            // Sideways Acceleration 
            if (controls.onPress(Keys.Right, Buttons.DPadRight)){
                moveIndex += 3;

                if (moveIndex > 17)
                {
                    x = x;
                    y = y;
                }
                else
                {
                    x = patches[moveIndex].x + 25;
                    y = patches[moveIndex].y + 25;
                }

                //this.x = patches[3].getBox().Center.X;
                //this.y = patches[3].getBox().Center.Y;
            }
            else if (controls.onPress(Keys.Left, Buttons.DPadLeft))
            {
                moveIndex -= 3;
                if (moveIndex < 0)
                {
                    x = x;
                    y = y;
                }
                else
                {
                    x = patches[moveIndex].x + 25;
                    y = patches[moveIndex].y + 25;
                }
                
            }
            else if (controls.onPress(Keys.Down, Buttons.DPadDown))
            {
                moveIndex += 1;
                x = patches[moveIndex].x + 25;
                y = patches[moveIndex].y + 25;
            }

            else if (controls.onPress((Keys.Up), Buttons.DPadUp))
            {
                moveIndex -= 1;

                x = patches[moveIndex].x + 25;
                y = patches[moveIndex].y + 25;
            }
            //else if (controls.onRelease(Keys.Right, Buttons.DPadRight))
            //    movedX = 0;
            //if (controls.onPress(Keys.Left, Buttons.DPadLeft))
            //    movedX = -speed;
            //else if (controls.onRelease(Keys.Left, Buttons.DPadLeft))
            //    movedX = 0;

            //collisionBox.X += movedX;
            //spriteX += movedX;

            //// Vertical Acceleration
            //if (controls.onPress(Keys.Up, Buttons.DPadUp))
            //    movedY = -speed;
            //else if (controls.onRelease(Keys.Up, Buttons.DPadUp))
            //    movedY = 0;
            //if (controls.onPress(Keys.Down, Buttons.DPadDown))
            //    movedY = speed;
            //else if (controls.onRelease(Keys.Down, Buttons.DPadDown))
            //    movedY = 0;

            //collisionBox.Y += movedY;
            //spriteY += movedY;

        }

        //collisionObstacle
        //collisionEnemy
        //updateCookieAmount
    }
}
