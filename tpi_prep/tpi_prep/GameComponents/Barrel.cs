
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
    /// For now, just falls down till it its the (incorret) obstacle's hitbox,
    /// Is supposed to slide it down then when it arrives the bottom of the screen restart the process
    /// </summary>
    class Barrel : GenericSprite
    {
        Vector2 startpos = new Vector2(700, 50);
        float heightLimit;
        Vector2 velocity = new Vector2 (0, 3);
       
        /// <summary>
        /// Constructor, requires the game to be able to load content
        /// And the height limit to reposition the barrel when it its the bottom
        /// </summary>
        /// <param name="heightLimit">User's screen height</param>
        public Barrel(Game1 _game, float heightLimit) : base(_game)
        {
            _position = startpos;
            this.heightLimit = heightLimit;
        }

        /// <summary>
        /// Moves the barrel downwards till it hits the height limit
        /// </summary>
        public override void Update(GameTime gameTime)
        {

            _position += velocity;

            if (_position.Y >= heightLimit && heightLimit != 0)
            {
                _position = startpos;
            }

            base.Update(gameTime);

        }

        /// <summary>
        /// Changes the velocity variable which is a vector2, 
        /// </summary>
        /// <param name="newVelocity">A new vector2 with x and y speed</param>
        public void Change_Velocity(Vector2 newVelocity)
        {
            velocity = newVelocity;
        }
    }
}
