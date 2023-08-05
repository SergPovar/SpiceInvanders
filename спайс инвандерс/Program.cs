// See https://aka.ms/new-console-template for more information

using System.Security;
using System.Security.Cryptography;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
namespace Space_Invader;

public class Program
{
    private const string GAME_CONFIGURATION_JSON_PATH = "GameConfiguration.json";
    static void Main(string[] args)
    {
        var gameConfiguration = new GameConfiguration(GAME_CONFIGURATION_JSON_PATH);
        Game game = new Game(gameConfiguration);
        game.Run();
        game.ShowGameOverScreen();
    }
}