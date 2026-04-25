using System;
using System.Collections.Generic;
using Plumber_Game.Constants;

namespace Plumber_Game.Services
{
    /// <summary>
    /// Service for managing tile image lookups and mappings.
    /// Provides O(1) lookup time for finding tile IDs from images.
    /// </summary>
    public class TileImageService
    {
        private readonly List<System.Drawing.Image> _tileIcons;
        private Dictionary<System.Drawing.Image, int> _imageToIdMap;

        public TileImageService(List<System.Drawing.Image> tileIcons)
        {
            _tileIcons = tileIcons ?? throw new ArgumentNullException(nameof(tileIcons));
            InitializeImageMap();
        }

        /// <summary>
        /// Initializes the image-to-ID mapping for O(1) lookups.
        /// </summary>
        private void InitializeImageMap()
        {
            _imageToIdMap = new Dictionary<System.Drawing.Image, int>(_tileIcons.Count);
            
            for (int i = 0; i < _tileIcons.Count; i++)
            {
                if (_tileIcons[i] != null)
                {
                    _imageToIdMap[_tileIcons[i]] = i;
                }
            }
        }

        /// <summary>
        /// Finds the tile ID for a given image with O(1) complexity.
        /// </summary>
        public int FindTileId(System.Drawing.Image tileImage)
        {
            if (tileImage == null)
                return TileConstants.EmptyTile;
            
            return _imageToIdMap.TryGetValue(tileImage, out int id) 
                ? id 
                : TileConstants.EmptyTile;
        }

        /// <summary>
        /// Gets the image for a tile ID.
        /// </summary>
        public System.Drawing.Image GetTileImage(int tileId)
        {
            if (tileId < 0 || tileId >= _tileIcons.Count)
                return null;
            
            return _tileIcons[tileId];
        }

        /// <summary>
        /// Gets the total count of tile types.
        /// </summary>
        public int TileCount => _tileIcons.Count;
    }
}
