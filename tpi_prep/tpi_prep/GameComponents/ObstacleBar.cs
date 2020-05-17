/*
 * Author : Tiago Gama
 * Version: V1.0
 * Date : 17.05.2020
 * Class : ObstacleBar
 * Desc : Obstacles for the barrel, having a problem with rotating the hitbox
 * 
 */

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpi_prep.GameComponents
{
    class ObstacleBar : GenericSprite
    {

        private float rotation;

        public ObstacleBar(Game1 _game, float rotation) : base(_game)
        {
            this.rotation = rotation;
        }

        public override void Update(GameTime gameTime)
        {



            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.Draw(_texture,_position,null, Color.White, rotation, new Vector2(0,0),1.0f,SpriteEffects.None, 1.0f );
        }


    }
}
