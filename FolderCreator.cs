using UnityEditor;
using UnityEngine;

public class FolderCreator : EditorWindow
{
    [MenuItem("Tools/Create Project Folders")]
    public static void ShowWindow()
    {
        GetWindow<FolderCreator>("Folder Creator");
    }

    private void OnGUI()
    {
        GUILayout.Label("Create Default Folder Structure", EditorStyles.boldLabel);

        if (GUILayout.Button("Create Folders"))
        {
            CreateFolders();
        }
    }

    private void CreateFolders()
    {
        string[] folders =
        {
            "Animations",
            "Fonts",
            "Materials",
            "Models",
            "Others",
            "Prefabs",
            "Scenes",
            "Scripts",
            "Shaders",
            "Sprites",
            "StorePackages",
            "TextMeshPro",
            "Textures"
        };

        foreach (string folder in folders)
        {
            string folderPath = $"Assets/{folder}";
            if (!AssetDatabase.IsValidFolder(folderPath))
            {
                AssetDatabase.CreateFolder("Assets", folder);
                Debug.Log($"Created folder: {folderPath}");
            }
            else
            {
                Debug.LogWarning($"Folder already exists: {folderPath}");
            }
        }

        AssetDatabase.Refresh();
    }
}
