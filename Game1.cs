using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace spel
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D Player;
        Vector2 PlayerPosision = new Vector2(250,200);
        Texture2D Player2;
        Vector2 Player2Posision = new Vector2(0,200);
        Rectangle PlayerRect= new Rectangle(250,200,100,100);
        Rectangle Player2Rect= new Rectangle(0,200,100,100);

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {er=this.Content.Load<Texture2D>("Sus");
            Player2=this.Content.Load<Texture2D>("Sus2");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Butto
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            Playns.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            if(Keyboard.GetState().IsKeyDown(Keys.Right))
            PlayerRect.X++;
            if(Keyboard.GetState().IsKeyDown(Keys.Left))
            PlayerRect.X--;
            if(Keyboard.GetState().IsKeyDown(Keys.Up))
            PlayerRect.Y--;
            if(Keyboard.GetState().IsKeyDown(Keys.Down))
            PlayerRect.Y++;
            
            if(PlayerRect.Intersects(Player2Rect))
            Player2Rect.Y--;                    
            

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(Player, PlayerRect, Color.White); 
            _spriteBatch.Draw(Player2, Player2Rect, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
