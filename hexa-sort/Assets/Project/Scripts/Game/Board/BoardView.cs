using UnityEngine;

namespace Project
{
    public class BoardView : MonoBehaviour
    {
        [SerializeField]
        private Transform _cellsRoot;

        public Transform CellsRoot => _cellsRoot;
    }
}