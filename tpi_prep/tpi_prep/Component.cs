/*
 * Version: V1.0
 * Date : 08.10.2019
 * Classe : Component 
 * Original source : https://github.com/Oyyou/MonoGame_Tutorials
 * 
 */
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpi_prep
{
    public abstract class Component
    {
        #region Draw + Update
        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);

        public abstract void Update(GameTime gameTime);

        #endregion
    }
}
