using UnityEngine;

namespace Project.Extension
{
    public abstract class MonoFactory<TPrefab> where TPrefab : MonoBehaviour
    {
        protected TPrefab Create(TPrefab prefab, Transform parent) => Object.Instantiate(prefab, parent);
        protected void Destroy(TPrefab prefab) => Object.Destroy(prefab.gameObject);
    }
}