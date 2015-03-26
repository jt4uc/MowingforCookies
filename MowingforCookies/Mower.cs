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
        private Rectangle collisionBox;
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
            this.x = currentLocation.x;
            this.y = currentLocation.y;
            this.cookies = cookies;
            
            //speed = 5;
            //movedX = 0;
            collisionBox = new Rectangle(x, y, 50, 50);
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
                moveIndex += 5;

                if (moveIndex > 54 || collisionObject(patches[moveIndex]) == false)
                {
                    moveIndex -= 5;
                }
                else
                {
                    x = patches[moveIndex].x;
                    y = patches[moveIndex].y;

                    collisionBox.X += patches[moveIndex].x;
                    collisionBox.Y += patches[moveIndex].y;
                }

                //this.x = patches[3].getBox().Center.X;
                //this.y = patches[3].getBox().Center.Y;
            }
            else if (controls.onPress(Keys.Left, Buttons.DPadLeft))
            {
                moveIndex -= 5;
                if (moveIndex < 0 || collisionObject(patches[moveIndex]) == false)
                {
                    moveIndex += 5;
                }
                else
                {
                    x = patches[moveIndex].x;
                    y = patches[moveIndex].y;

                    collisionBox.X += patches[moveIndex].x;
                    collisionBox.Y += patches[moveIndex].y;
                }
                
            }
            else if (controls.onPress(Keys.Down, Buttons.DPadDown))
            {
                moveIndex += 1;

                if (moveIndex > 54 || collisionObject(patches[moveIndex]) == false)
                {
                    moveIndex -= 1;
                }
                else { 
                    x = patches[moveIndex].x;
                    y = patches[moveIndex].y;

                    collisionBox.X += patches[moveIndex].x;
                    collisionBox.Y += patches[moveIndex].y;
                }
                
            }

            else if (controls.onPress((Keys.Up), Buttons.DPadUp))
            {
                moveIndex -= 1;
               
                if (moveIndex < 0 || collisionObject(patches[moveIndex]) == false)
                {
                    moveIndex += 1;
                }
                else { 
                    x = patches[moveIndex].x;
                    y = patches[moveIndex].y;

                    collisionBox.X += patches[moveIndex].x;
                    collisionBox.Y += patches[moveIndex].y;
                }
                
            }

        }

        public bool collisionObject(Spot objectSpot)
        {
            if (objectSpot.canTraverse == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //collisionEnemy
        //updateCookieAmount
    }
}
