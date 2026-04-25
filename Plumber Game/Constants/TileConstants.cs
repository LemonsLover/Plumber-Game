namespace Plumber_Game.Constants
{
    /// <summary>
    /// Defines all tile IDs and related constants for the Plumber Game.
    /// </summary>
    public static class TileConstants
    {
        // Tile IDs
        public const int RandomTile = 0;
        
        // Exit tiles (pipe endpoints)
        public const int ExitLeft = 1;
        public const int ExitUp = 2;
        public const int ExitRight = 3;
        public const int ExitDown = 4;
        
        // Connection tiles
        public const int KneeLeftUp = 5;
        public const int KneeUpRight = 6;
        public const int KneeRightDown = 7;
        public const int KneeDownLeft = 8;
        public const int TubeHorizontal = 9;
        public const int TubeVertical = 10;
        
        // Empty tile
        public const int EmptyTile = 11;
        
        // Disabled connection tiles
        public const int DisabledKneeLeftUp = 12;
        public const int DisabledKneeUpRight = 13;
        public const int DisabledKneeRightDown = 14;
        public const int DisabledKneeDownLeft = 15;
        public const int DisabledTubeHorizontal = 16;
        public const int DisabledTubeVertical = 17;
        
        // Grid dimensions
        public const int GridWidth = 5;
        public const int GridHeight = 5;
        public const int GridSize = GridWidth * GridHeight;
        
        // Validation
        public const int RequiredExitCount = 2;
        public const int MinExitId = ExitLeft;
        public const int MaxExitId = ExitDown;
        public const int MinTileId = RandomTile;
        public const int MaxTileId = DisabledTubeVertical;
        
        // UI boundaries (for no-clip mode)
        public const int UIBoundaryBoxCount = 10;
    }
}
