﻿
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace tpi_prep.States
{

    /// <summary>
    /// Allows the creation of multiple states
    /// Source : https://github.com/Oyyou/MonoGame_Tutorials
    /// </summary>
    public abstract class State
    {
        #region Variables

        protected ContentManager _content;

        protected GraphicsDevice _graphicsDevice;

        protected Game1 _game;

        #endregion

        #region Methods


        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);

        public abstract void PostUpdate(GameTime gameTime);

        public State(Game1 game, GraphicsDevice graphicsDevice, ContentManager content)
        {
            _game = game;

            _graphicsDevice = graphicsDevice;

            _content = content;
        }

        public abstract void Update(GameTime gameTime);

        #endregion
    }
}

