using System;
using System.Collections.Generic;
using System.Linq;
using Plumber_Game.Constants;

namespace Plumber_Game.Utilities
{
    /// <summary>
    /// Utility class for tile-related operations and validations.
    /// </summary>
    public static class TileHelper
    {
        private static readonly int[] ExitTileIds = 
        { 
            TileConstants.ExitLeft,
            TileConstants.ExitUp,
            TileConstants.ExitRight,
            TileConstants.ExitDown
        };

        private static readonly int[] DisabledTileIds = 
        { 
            TileConstants.DisabledKneeLeftUp,
            TileConstants.DisabledKneeUpRight,
            TileConstants.DisabledKneeRightDown,
            TileConstants.DisabledKneeDownLeft,
            TileConstants.DisabledTubeHorizontal,
            TileConstants.DisabledTubeVertical
        };

        /// <summary>
        /// Determines if a tile ID represents an exit tile.
        /// </summary>
        public static bool IsExitTile(int tileId) => 
            ExitTileIds.Contains(tileId);

        /// <summary>
        /// Determines if a tile ID represents a disabled (non-rotatable) tile.
        /// </summary>
        public static bool IsDisabledTile(int tileId) => 
            DisabledTileIds.Contains(tileId);

        /// <summary>
        /// Counts the number of exit tiles in the level data.
        /// </summary>
        public static int CountExitTiles(int[] levelData) => 
            levelData.Count(IsExitTile);

        /// <summary>
        /// Validates the exit count for a level.
        /// </summary>
        public static (bool isValid, string errorMessage) ValidateExitCount(int exitCount)
        {
            if (exitCount < TileConstants.RequiredExitCount)
                return (false, LocalizationConstants.InsufficientExitsError);
            
            if (exitCount > TileConstants.RequiredExitCount)
                return (false, LocalizationConstants.TooManyExitsError);
            
            return (true, string.Empty);
        }

        /// <summary>
        /// Wraps a tile ID within valid bounds (circular).
        /// </summary>
        public static int WrapTileId(int tileId)
        {
            if (tileId < TileConstants.MinTileId)
                return TileConstants.MaxTileId;
            
            if (tileId > TileConstants.MaxTileId)
                return TileConstants.MinTileId;
            
            return tileId;
        }

        /// <summary>
        /// Gets the next tile ID in circular order.
        /// </summary>
        public static int GetNextTileId(int currentId) => 
            currentId == TileConstants.MaxTileId ? TileConstants.MinTileId : currentId + 1;

        /// <summary>
        /// Gets the previous tile ID in circular order.
        /// </summary>
        public static int GetPreviousTileId(int currentId) => 
            currentId == TileConstants.MinTileId ? TileConstants.MaxTileId : currentId - 1;
    }
}
