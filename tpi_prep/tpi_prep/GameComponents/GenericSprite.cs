﻿
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace tpi_prep.GameComponents
{
    /// <summary>
    /// A class to help us create other objects, has the basic elements other classes will need
    /// such as texture, position, hitbox and the game itself to be able to load its texture
    /// </summary>
    class GenericSprite
    {
        #region Variables
        protected Game _game;

        public Vector2 _position;

        public Texture2D _texture;
        public Rectangle hitbox;


        #endregion

        #region Constructor + Initialize + LoadContent
        /// <summary>
        /// Constructor, requires the game to be able to load content
        /// Usually not used by anyone but its children, leaving it public for now just in case
        /// </summary>
        public GenericSprite(Game game)
        {
            _game = game;
        }

        /// <summary>
        /// Initializes the object in a certain position
        /// </summary>
        /// <param name="position">Position in the screen</param>
        public virtual void Initialize(Vector2 position)
        {
            _position = position;
        }

        /// <summary>
        /// Loads the file texture into a variable
        /// </summary>
        /// <param name="texture">Name of the file</param>
        public void LoadContent(string texture)
        {
            _texture = _game.Content.Load<Texture2D>(texture);
        }

        #endregion

        #region Update + Draw

        /// <summary>
        /// Updates the position and hitbox of the sprite
        /// </summary>
        /// <param name="gameTime"></param>
        public virtual void Update(GameTime gameTime)
        {

            
            hitbox = new Rectangle(
                    (int)_position.X,
                    (int)_position.Y,
                    _texture.Width,
                    _texture.Height);
        }
        /// <summary>
        /// Draws the sprite with a texture an hitbox and keeps its original color
        /// </summary>
        /// <param name="spriteBatch"></param>
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            //Draw the sprite
            spriteBatch.Draw(_texture, hitbox, Color.White);
        }

        #endregion
    }
}
