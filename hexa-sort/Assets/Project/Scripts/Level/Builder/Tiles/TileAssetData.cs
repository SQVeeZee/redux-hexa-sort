using System;
using UnityEngine;

namespace Project
{
    [Serializable]
    public struct TileAssetData
    {
        [SerializeField]
        private TileType _tileType;
        [SerializeField]
        private TileView _tileView;

        public TileType Type => _tileType;
        public TileView TileView => _tileView;
    }
}