using Newtonsoft.Json;
using SFML.Graphics;
using SFML.Window;

namespace Space_Invader;

public class GameConfiguration
{
    public string Title { get; init; }
    public int Height { get; init; }
    public int Width { get; init; }
    
    public float BulletSpeed { get; init; }
    public float BulletRadius { get; init; } 
    public PlayerSettings PlayerSettings { get; init; }
    public float EnemySpeed { get; init; }
    public float EnemySpawnCooldown { get; init; }
     public ScoreManagerSettings ScoreManagerSettings { get; init; }
   
    public GameConfiguration(string jsonPath)
    {
        string jsonString = File.ReadAllText(jsonPath);
        JsonConvert.PopulateObject(jsonString, this);
    }
}
