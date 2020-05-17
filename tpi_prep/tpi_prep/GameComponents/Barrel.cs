/*
 * Author : Tiago Gama
 * Version: V1.0
 * Date : 17.05.2020
 * Class : Barrel 
 * Desc : For now, just falls down till it its the (incorret) obstacle's hitbox,
 * is supposed to slide it down then when it arrives the bottom of the screen restart the process
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
    class Barrel : GenericSprite
    {
        Vector2 startpos = new Vector2(900, 50);
        float heightLimit;
        Vector2 velocity = new Vector2 (0, 3);

        public Barrel(Game1 _game, float heightLimit) : base(_game)
        {
            _position = startpos;
            this.heightLimit = heightLimit;
        }
        public override void Update(GameTime gameTime)
        {

            _position.Y += velocity.Y;

            if (_position.Y >= heightLimit && heightLimit != 0)
            {
                _position = startpos;
            }

            base.Update(gameTime);

        }

        public void Change_Velocity(Vector2 newVelocity)
        {
            velocity = newVelocity;
        }
    }
}
