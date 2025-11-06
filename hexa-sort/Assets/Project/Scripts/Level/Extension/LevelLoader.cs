using Newtonsoft.Json;
using UnityEngine;

namespace Project
{
    public static class LevelLoader
    {
        public static LevelData LoadLevel(string levelName)
        {
            var textAsset = Resources.Load<TextAsset>($"Levels/{levelName}");
            if (textAsset == null)
            {
                Debug.LogError($"Level json not found: Resources/Levels/{levelName}.json");
                return null;
            }

            var levelData = JsonConvert.DeserializeObject<LevelData>(textAsset.text);
            return levelData;
        }
    }
}