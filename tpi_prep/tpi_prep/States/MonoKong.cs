/*
 * Author : Tiago Gama
 * Version: V1.0
 * Date : 17.05.2020
 * Class : MonoKong 
 * Desc : The actual game, with the knowledge now I have I assume its a donkey kong game
 * 
 */

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
    class MonoKong : State
    {
        Game1 game1;

        Barrel barrel;
        ObstacleBar obstacle;
        //Graphic vars
        Texture2D background;

        float HEIGHT_LIMIT;

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
            obstacle = new ObstacleBar(game1, 0.2f);
            obstacle.Initialize(new Vector2(500, 500));

            barrel = new Barrel(game1, HEIGHT_LIMIT);
        }


        public void LoadContent()
        {
            obstacle.LoadContent("Graphics/bar");
            barrel.LoadContent("Graphics/barrel2");

            background = _content.Load<Texture2D>("Graphics/background");
        }

        public override void Update(GameTime gameTime)
        {
            obstacle.Update(gameTime);
            barrel.Update(gameTime);

            if (barrel.hitbox.Intersects(obstacle.hitbox))
            {
                barrel.Change_Velocity(new Vector2(0, 0));
            }


        }

        public override void PostUpdate(GameTime gameTime)
        {

        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //Draws the background
            spriteBatch.Draw(background, new Rectangle(0, 0, _game.GraphicsDevice.Viewport.Width, _game.GraphicsDevice.Viewport.Height), Color.White);

            obstacle.Draw(spriteBatch);
            barrel.Draw(spriteBatch);

        }
    }
}
