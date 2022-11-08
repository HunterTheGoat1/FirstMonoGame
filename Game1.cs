using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Security.Cryptography;
using System.Threading;

namespace FirstMonoGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D dino1;
        Texture2D dino2;
        Texture2D dino3;
        Texture2D dino4;
        Texture2D dinoKilla;
        Texture2D background;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _graphics.PreferredBackBufferWidth = 1200; // Sets the width of the window
            _graphics.PreferredBackBufferHeight = 900; // Sets the height of the window
            _graphics.ApplyChanges(); // Applies the new dimensions
            this.Window.Title = "Rawr";
            
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            dino1 = Content.Load<Texture2D>("dino1");
            dino2 = Content.Load<Texture2D>("dino2");
            dino3 = Content.Load<Texture2D>("dino3");
            dino4 = Content.Load<Texture2D>("dino4");
            dinoKilla = Content.Load<Texture2D>("dinoKilla");
            background = Content.Load<Texture2D>("background");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(background, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(dino1, new Vector2(-100, _graphics.PreferredBackBufferHeight - dino1.Height), Color.White);
            _spriteBatch.Draw(dino2, new Vector2(650, _graphics.PreferredBackBufferHeight - dino2.Height - 230), Color.White);
            _spriteBatch.Draw(dino3, new Vector2(700, _graphics.PreferredBackBufferHeight - dino3.Height), Color.White);
            _spriteBatch.Draw(dino4, new Vector2(370, _graphics.PreferredBackBufferHeight - dino4.Height), Color.White);
            _spriteBatch.Draw(dinoKilla, new Vector2(0, -150), Color.White);


            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}