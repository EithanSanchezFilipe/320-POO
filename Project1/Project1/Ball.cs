using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public class Ball : DrawableGameComponent
{
    private Texture2D texture;
    private float _ballSpeed;
    private SpriteBatch _spriteBatch;
    private Vector2 _position;
    private Vector2 _pointRotation = new Vector2();
    private SpriteEffects _effect; // Use SpriteEffects here
    private float Weely = 0;
    private string directiongetto;

    public Ball(Game game, int screenWidth, int screenHeight) : base(game)
    {
        _position = new Vector2(screenWidth / 2, screenHeight / 2);
        _ballSpeed = 1000f; // Set an appropriate speed value here
        _effect = SpriteEffects.None; // Initialize effect
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        texture = Game.Content.Load<Texture2D>("motomoto"); // Ensure this matches your content file
    }

    public override void Update(GameTime gameTime)
    {
        float updated_ballSpeed = _ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
        var kstate = Keyboard.GetState();

        if (kstate.IsKeyDown(Keys.Up))
        {
            _position.Y -= updated_ballSpeed;
        }

        if (kstate.IsKeyDown(Keys.Down))
        {
            _position.Y += updated_ballSpeed;
        }

        if (kstate.IsKeyDown(Keys.Left))
        {
            directiongetto = "left";
            _position.X -= updated_ballSpeed;
            _effect = SpriteEffects.FlipHorizontally; // Correctly set the effect
        }
        else if (kstate.IsKeyDown(Keys.Right))
        {
            directiongetto = "right";
            _position.X += updated_ballSpeed;
            _effect = SpriteEffects.None; // Reset effect
        }
         if (kstate.IsKeyDown(Keys.B))
        {
            if (directiongetto == "left")
            {
                Weely = 45;
                _pointRotation = new Vector2(texture.Width - texture.Width / 4, texture.Height / 2);
            }


            else
            {
                Weely = -45;
                _pointRotation = new Vector2(texture.Width / 4, texture.Height / 2);
            }
            
        }
         if (kstate.IsKeyUp(Keys.B))
        {
            Weely = 0;
        }

        base.Update(gameTime);
    }

    public override void Draw(GameTime gameTime)
    {
        _spriteBatch.Begin();
        _spriteBatch.Draw(texture, _position, null, Color.White, Weely, _pointRotation, 0.3f, _effect, 0f);
        _spriteBatch.End();
        base.Draw(gameTime);
    }
}
