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

        /// <summary>
        /// Constructor, requires the game to be able to load content
        /// And a rotation to be able to turn
        /// Maybe implement in the future so the rotation is in degrees (and look up what it is now)
        /// </summary>
        public ObstacleBar(Game1 _game, float rotation) : base(_game)
        {
            this.rotation = rotation;
        }

        /// <summary>
        /// Draws the object with a rotation
        /// </summary>
        public override void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.Draw(_texture,_position,null, Color.White, rotation, new Vector2(0,0),1.0f,SpriteEffects.None, 1.0f );
        }


    }
}
