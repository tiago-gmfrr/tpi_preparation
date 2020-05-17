/*
 * Author : Tiago Gama
 * Version: V1.0
 * Date : 08.10.2019
 * Classe : State 
 * Descritpion : Generic Sprite
 * 
 */
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace tpi_prep.GameComponents
{
    class GenericSprite
    {
        #region Variables
        protected Game _game;

        public Vector2 _position;

        public Texture2D _texture;
        public Rectangle hitbox;

        
        #endregion

        #region Constructor + Initialize + LoadContent
        public GenericSprite(Game game)
        {
            _game = game;
        }

        public virtual void Initialize(Vector2 position)
        {
            _position = position;
        }

        public void LoadContent(string texture)
        {
            _texture = _game.Content.Load<Texture2D>(texture);
        }

        public void UnloadContent()
        {

        }
        #endregion

        #region Update + Draw

        /// <summary>
        /// Updates the position and rectangle of the sprite
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
        /// draws the srpite with a texture an hitbox and a color
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
