using System.IO;
using JetBrains.Annotations;
using Newtonsoft.Json;
using UnityEditor;
using UnityEngine;

namespace Project.Editor
{
    [UsedImplicitly]
    public static class EditorSerialization
    {
        private const string LevelsFolderPath = "Assets/Resources/Levels";

        public static void SaveLevel(string levelName, LevelData levelData)
        {
            if (string.IsNullOrWhiteSpace(levelName))
            {
                Debug.LogError("Level name is empty. Set _levelName in inspector.");
                return;
            }

            if (levelData == null)
            {
                Debug.LogError("LevelData is null.");
                return;
            }

            if (!Directory.Exists(LevelsFolderPath))
            {
                Directory.CreateDirectory(LevelsFolderPath);
                Debug.Log($"Created folder: {LevelsFolderPath}");
            }

            var fileName = $"{levelName}.json";
            var fullPath = Path.Combine(LevelsFolderPath, fileName);

            var json = JsonConvert.SerializeObject(
                levelData,
                Formatting.Indented,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });

            File.WriteAllText(fullPath, json);

            AssetDatabase.Refresh();

            Debug.Log($"Level '{levelName}' saved to: {fullPath}");
        }
    }
}