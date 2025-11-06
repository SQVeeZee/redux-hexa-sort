using System;
using UnityEngine;

namespace Project
{
    [Serializable]
    public struct TowerPattern
    {
        [SerializeField]
        private TileType _type;
        [SerializeField]
        private int _height;

        public TileType TileType => _type;
        public int Height => _height;
    }
}