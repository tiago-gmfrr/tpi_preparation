
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using tpi_prep.Controls;

namespace tpi_prep.States 
{
    /// <summary>
    ///  Just a menu with Play and Exit buttons
    ///  Original source : https://github.com/Oyyou/MonoGame_Tutorials
    /// </summary>
    class HomeMenu : State
    {

        #region Variables
        //List of components, for now just buttons
        private List<Component> _components;

        //Graphic vars
        Texture2D background;


        Game1 _game;
        #endregion

        #region Constructor

        public HomeMenu(Game1 game, GraphicsDevice graphicsDevice, ContentManager content)
          : base(game, graphicsDevice, content)
        {
            _game = game;

            #region Buttons

            //Button textures and fonts
            var buttonTexture = _content.Load<Texture2D>("Controls/Button");
            var buttonFont = _content.Load<SpriteFont>("basicFont");

            var playGameButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2((_game.GraphicsDevice.Viewport.Width / 2) - 120, (_game.GraphicsDevice.Viewport.Height / 2) - 60),
                Text = "Play Game",
            };

            //Button on click event
            playGameButton.Click += PlayGameButton_Click;


            var quitGameButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2((_game.GraphicsDevice.Viewport.Width / 2) - 120, (_game.GraphicsDevice.Viewport.Height / 2) + 120),
                Text = "Quit Game",
            };

            //Button on click event
            quitGameButton.Click += QuitGameButton_Click;

            //List of components, with all the buttons
            _components = new List<Component>()
             {
                playGameButton,
                quitGameButton,
            };
            #endregion

            background = _content.Load<Texture2D>("Graphics/background");
        }
        #endregion

        #region Updates + Draw
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {

            //Draws the background
            spriteBatch.Draw(background, new Rectangle(0, 0, _game.GraphicsDevice.Viewport.Width, _game.GraphicsDevice.Viewport.Height), Color.White);

            //Draw every component in the component list, aka all the buttons
            foreach (var component in _components)
                component.Draw(gameTime, spriteBatch);
        }


        public override void PostUpdate(GameTime gameTime)
        {
            // remove sprites if they're not needed
        }

        public override void Update(GameTime gameTime)
        {

            //Update the component list, so we can use the buttons
            foreach (var component in _components)
            {

                component.Update(gameTime);
            }

        }
        #endregion

        #region Button events
        /// <summary>
        /// Starts the game in survival mode, which is represented has "level 0"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayGameButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new MonoKong(_game, _graphicsDevice, _content));

        }
        /// <summary>
        /// Exits the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitGameButton_Click(object sender, EventArgs e)
        {
            _game.Exit();
        }
        #endregion
    }
}
