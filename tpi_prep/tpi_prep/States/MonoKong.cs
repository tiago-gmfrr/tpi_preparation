
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using tpi_prep.Controls;
using tpi_prep.GameComponents;

namespace tpi_prep.States
{
    /// <summary>
    /// The actual game, with the knowledge now I have I assume its a donkey kong game
    /// </summary>
    class MonoKong : State
    {
        Game1 game1;

        Barrel barrel;
        ObstacleBar obstacle;
        //Graphic vars
        Texture2D background;
        bool test = false;
        float a;
        float HEIGHT_LIMIT;

        /// <summary>
        /// Creates the game state
        /// </summary>
        /// <param name="graphicsDevice">Users screen</param>
        /// <param name="content">Where the texture files are located</param>
        public MonoKong(Game1 game, GraphicsDevice graphicsDevice, ContentManager content)
         : base(game, graphicsDevice, content)
        {
            game1 = game;

            HEIGHT_LIMIT = graphicsDevice.Viewport.Height;

            Initialize();
            LoadContent();
        }

        /// <summary>
        /// Creates all the necessary objects
        /// </summary>
        public void Initialize()
        {
            obstacle = new ObstacleBar(game1, 10f);
            obstacle.Initialize(new Vector2(500, 500));

            barrel = new Barrel(game1, HEIGHT_LIMIT);
        }

        /// <summary>
        /// Loads the textures into the variables
        /// </summary>
        public void LoadContent()
        {
            obstacle.LoadContent("Graphics/bar");
            barrel.LoadContent("Graphics/barrel2");

            background = _content.Load<Texture2D>("Graphics/background");
        }
        /// <summary>
        /// General flow of the game
        /// </summary>
        public override void Update(GameTime gameTime)
        {
            obstacle.Update(gameTime);
            barrel.Update(gameTime);
            
            //temporary just for testing
            if (test == false)
            {
                if (barrel.hitbox.Intersects(obstacle.hitbox))
                {
                    a = GetA();
                    test = true;
                }
                else
                {
                    test = false;
                    barrel.Change_Velocity(new Vector2(0, 3));
                }

            }
            else
            {
                if (barrel._position.Y >= obstacle._position.Y + a - obstacle._texture.Height)
                {
                    barrel.Change_Velocity(new Vector2(3, 0));
                    GetA();
                    test = false;
                }
                else
                {
                    barrel.Change_Velocity(new Vector2(0, 3));
                }

            }

        }

        private float GetA()
        {
            float r = barrel._position.X - obstacle._position.X;

            float rotationInDegrees = 10f;

            return (float)Math.Sin(MathHelper.ToRadians(rotationInDegrees)) * r;
        }

        public override void PostUpdate(GameTime gameTime)
        {

        }
        /// <summary>
        /// Draws the game state
        /// </summary>
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //Draws the background
            spriteBatch.Draw(background, new Rectangle(0, 0, _game.GraphicsDevice.Viewport.Width, _game.GraphicsDevice.Viewport.Height), Color.White);

            obstacle.Draw(spriteBatch);
            barrel.Draw(spriteBatch);

        }
    }
}
