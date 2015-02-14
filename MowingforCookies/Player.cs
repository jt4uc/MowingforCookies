using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;

namespace MowingforCookies
{
    class Player : Sprite
    {
        private int speed;
        public int movedX;
        public int movedY;
        private Rectangle collisionBox;


        public Player(int x, int y, int width, int height)
        {
            this.spriteX = x;
            this.spriteY = y;
            this.spriteWidth = width;
            this.spriteHeight = height;

            speed = 5;
            movedX = 0;
            collisionBox = new Rectangle(x, y, width, height);
        }

        public int getX()
        {
            return spriteX;
        }
        public int getY()
        {
            return spriteY;
        }
        public void setX(int x)
        {
            collisionBox.X = x;
            spriteX = x;
        }
        public void setY(int y)
        {
            collisionBox.Y = y;
            spriteY = y;
        }
        public void setSpeed(int s)
        {
            speed = s;
        }
        public Rectangle getBox()
        {
            return collisionBox;
        }
        public void LoadContent(ContentManager content)
        {
            image = content.Load<Texture2D>("MiniMower.png");
        }

        public void Draw(SpriteBatch sb)
        {
            sb.Draw(image, new Rectangle(spriteX, spriteY, spriteWidth, spriteHeight), Color.White);
        }

        public void Update(Controls controls, GameTime gameTime)
        {
            Move(controls);
        }

        public void Move(Controls controls)
        {
            // Sideways Acceleration 
            if (controls.onPress(Keys.Right, Buttons.DPadRight))
                movedX = speed;
            else if (controls.onRelease(Keys.Right, Buttons.DPadRight))
                movedX = 0;
            if (controls.onPress(Keys.Left, Buttons.DPadLeft))
                movedX = -speed;
            else if (controls.onRelease(Keys.Left, Buttons.DPadLeft))
                movedX = 0;

            collisionBox.X += movedX;
            spriteX += movedX;

            // Vertical Acceleration
            if (controls.onPress(Keys.Up, Buttons.DPadUp))
                movedY = -speed;
            else if (controls.onRelease(Keys.Up, Buttons.DPadUp))
                movedY = 0;
            if (controls.onPress(Keys.Down, Buttons.DPadDown))
                movedY = speed;
            else if (controls.onRelease(Keys.Down, Buttons.DPadDown))
                movedY = 0;

            collisionBox.Y += movedY;
            spriteY += movedY;

        }
    }
}

