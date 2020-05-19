
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpi_prep
{
    /// <summary>
    /// An abstract class to facilitate the creation of other components such as buttons
    /// Original source : https://github.com/Oyyou/MonoGame_Tutorials
    /// </summary>
    public abstract class Component
    {
        #region Draw + Update
        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);

        public abstract void Update(GameTime gameTime);

        #endregion
    }
}
