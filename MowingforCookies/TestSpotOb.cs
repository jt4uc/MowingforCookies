#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace MowingforCookies
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class TestSpotOb : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // for the background
        Texture2D background;
        int screenWidth;
        int screenHeight;

        Player player;
        Controls controls;

        List<Rectangle> patches;
        List<Spot> patches2;
        Texture2D patch;

        public TestSpotOb()
            : base()
        {
            graphics = new GraphicsDeviceManager(this); /// default is 800x600
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {

            Window.Title = "TEST";
            player = new Player(210, 210, 30, 30);
           // patches = new List<Rectangle>();
           // for (int r = 101; r < 400; r += 50)
           // {
           //     for (int c = 201; c < 600; c += 50)
          //      {
          //          Rectangle p = new Rectangle(c, r, 48, 48);
           //         patches.Add(p);
           //     }
          //  }
            patches2 = new List<Spot>();
            Spot t = new Spot(210, 210, false, 3, 3);
            patches2.Add(t);
            base.Initialize();
            controls = new Controls();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            background = Content.Load<Texture2D>("MowingforCookiesBackground");
            patch = Content.Load<Texture2D>("MiniMower.png");
            foreach (Spot s in patches2)
            {
                s.LoadContent(this.Content);
            }
            player.LoadContent(this.Content);
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {

            controls.Update();
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
          //  player.Update(controls, gameTime);
       //     int i = 0;
        //    foreach (Rectangle r in patches)
       //     {
        //        if (r.Intersects(player.getBox()))
       //         {
       //             patches.RemoveAt(i);
       //             break;
       //         }
       //         i++;
       //     }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            // TODO: Add your drawing code here
            GraphicsDevice.Clear(Color.LimeGreen);
            spriteBatch.Begin();
            DrawBackground();
           // DrawGrass();
          //  player.Draw(spriteBatch);

            foreach (Spot s in patches2)
            {
                s.Draw(spriteBatch);
            }
            spriteBatch.End();


                base.Draw(gameTime);
        }

        private void DrawGrass()
        {
            foreach (Rectangle r in patches)
            {
                spriteBatch.Draw(patch, r, Color.White);
            }

        }
        private void DrawBackground()
        {
            Rectangle screenRectangle = new Rectangle(0, 0, 800, 600);
            spriteBatch.Draw(background, screenRectangle, Color.White);

        }
    }
}
