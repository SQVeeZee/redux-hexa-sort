using UnityEngine;

namespace Project
{
    public class CellView : MonoBehaviour
    {
        [SerializeField]
        private Transform _tilesRoot;

        public Transform TilesRoot => _tilesRoot;
        public void ApplyPosition(Vector3 position) => transform.position = position;
    }
}