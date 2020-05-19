using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpi_prep.GameComponents
{
    /// <summary>
    /// Obstacles for the barrel, having a problem with rotating the hitbox
    /// </summary>
    class ObstacleBar : GenericSprite
    {

        private float rotation;
        GenericSprite aa;

        Vector2 tmp1;
        Vector2 tmp2;
        Vector2 tmp3;
        Vector2 tmp4;

        /// <summary>
        /// Constructor, requires the game to be able to load content
        /// And a rotation to be able to turn
        /// Maybe implement in the future so the rotation is in degrees (and look up what it is now)
        /// </summary>
        public ObstacleBar(Game1 _game, float rotation) : base(_game)
        {
            this.rotation = MathHelper.ToRadians(rotation);
            aa = new GenericSprite(_game);
            
        }
        public override void Initialize(Vector2 position)
        {

            base.Initialize(position);
            aa.Initialize(position);
            aa.LoadContent("Graphics/debugPixel");

        }

        // matrix b4 update

        public override void Update(GameTime gameTime)
        {

            //hitbox = new Rectangle();
            float rot = MathHelper.ToRadians(2f);

            tmp1 = _position;//Vector2.Transform(_position, Matrix.CreateRotationZ(rot));
            tmp2 = Vector2.Transform(new Vector2(_position.X, _position.Y + _texture.Height), Matrix.CreateRotationZ(rot));
            tmp3 = Vector2.Transform(new Vector2(_position.X + _texture.Width, _position.Y), Matrix.CreateRotationZ(rot));
            tmp4 = Vector2.Transform(new Vector2(_position.X + _texture.Width, _position.Y + +_texture.Height), Matrix.CreateRotationZ(rot));

            base.Update(gameTime);

            
        }

        /// <summary>
        /// Draws the object with a rotation
        /// </summary>
        public override void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.Draw(_texture,_position,null, Color.White, rotation, new Vector2(0,0),1.0f,SpriteEffects.None, 1.0f );
            
            


            /*spriteBatch.Draw(aa._texture, tmp1, Color.White);
            spriteBatch.Draw(aa._texture, tmp2, Color.White);
            spriteBatch.Draw(aa._texture, tmp3, Color.White);
            spriteBatch.Draw(aa._texture, tmp4, Color.White);*/
        }


    }
}
