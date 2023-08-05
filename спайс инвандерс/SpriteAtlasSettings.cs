namespace Space_Invader;

public class SpriteAtlasSettings
{
    public string TexturePath { get; }
    public int Rows { get; }
    public int Columns { get; }

    public SpriteAtlasSettings(string texturePath, int columns, int rows)
    {
        TexturePath = texturePath;
        Rows = rows;
        Columns = columns;
    }
}