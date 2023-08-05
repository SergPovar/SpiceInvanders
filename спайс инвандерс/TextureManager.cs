using SFML.Graphics;

namespace Space_Invader;
public class TextureManager
{
    public static Texture PlayerTexture;
    public static Texture BackgroundTexture;
    public static Texture EnemyTexture;
    public static SpriteAtlas ExplosionAtlas;
    
    private const string PLAYER_TEXTURE_PATH = "/Ships/playerShip2_red.png";
    private const string BACKGROUND_TEXTURE_PATH = "/Backgrounds/purpleBG.png";
    private const string ENEMY_TEXTURE_PATH = "/Enemies/enemyBlue1.png";
    private const string ASSETS_PATH = "/Users/sergejterehov/RiderProjects/спайс инвандерс/спайс инвандерс/Assets";
    private static readonly SpriteAtlasSettings ExplosionAtlasSettings =
        new(ASSETS_PATH + "/Explosions/explosionsAtlas.png", 4, 4);

    static TextureManager()
    {
        BackgroundTexture = new Texture(ASSETS_PATH + BACKGROUND_TEXTURE_PATH);
        PlayerTexture = new Texture(ASSETS_PATH + PLAYER_TEXTURE_PATH);
        EnemyTexture = new Texture(ASSETS_PATH + ENEMY_TEXTURE_PATH);
        ExplosionAtlas = new SpriteAtlas(ExplosionAtlasSettings);
    }
}