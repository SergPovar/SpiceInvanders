using Newtonsoft.Json;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Space_Invader;

public class Player
{
    private Sprite _sprite;
    private Bullet _bullet;
    public bool IsPlayerDead { get; private set; }
    private readonly ShootingManager _shootingManager;
    private readonly GameConfiguration _gameConfiguration;
    private readonly PlayerMovement _playerMovement;
    private readonly Keyboard.Key _shootingButton;
   
    public Player(ShootingManager shootingManager, Keyboard.Key shootingButton, Texture texture,
        Vector2f playerSpawnPosition, PlayerMovement playerMovement)
    {
        _sprite = new Sprite(texture);
        _sprite.Position = playerSpawnPosition;
        _shootingManager = shootingManager;
        _playerMovement = playerMovement;
         _shootingButton = shootingButton;
    }
    public void Destroy()
    {
        IsPlayerDead = true;
    }

    private Vector2f GetBulletSpawnPosition()
    {
        var halfSpriteSizeX = new Vector2f(_sprite.TextureRect.Width / 2f, 0f);
        var bulletSpawnPosition = _sprite.Position + halfSpriteSizeX;
        return bulletSpawnPosition;
    }

    private void MoveTo()
    {
        var newPosition = _playerMovement.GetNewPosition(_sprite.Position);
        _sprite.Position = newPosition;
    }

    public void Update()
    {
        MoveTo();
        if (Keyboard.IsKeyPressed(_shootingButton))
        {
            var bulletSpawnPosition = GetBulletSpawnPosition();
            _shootingManager.TryShoot(bulletSpawnPosition);
        }

        _shootingManager.Update();
    }

    public void Draw(RenderWindow window)
    {
        window.Draw(_sprite);
        _shootingManager.Draw(window);
    }

    public List<Bullet> GetBullets()
    {
        return _shootingManager.Bullets;
    }

    public void DestroyBullet(Bullet bullet)
    {
        _shootingManager.Bullets.Remove(bullet);
    }

    public FloatRect GetGlobalBounds()
    {
        return _sprite.GetGlobalBounds();
    }
}