using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EditorReloadTool : EditorWindow
{
    [MenuItem("Tools/Editor Reload Tool")]
    public static void ShowWindow()
    {
        EditorReloadTool window = GetWindow<EditorReloadTool>();
        window.titleContent = new GUIContent("Domain Reloader");
        window.Show();
    }

    private void OnGUI()
    {
        EditorGUI.BeginDisabledGroup(EditorApplication.isCompiling);

        if (GUILayout.Button("Reload Domain"))
        {
            EditorUtility.RequestScriptReload();
            AssetDatabase.Refresh();
        }
        EditorGUI.EndDisabledGroup();

        if (GUILayout.Button("Reload Scene"))
        {
            if (!EditorApplication.isPlaying) return;

            var scene = SceneManager.GetActiveScene();
            if (scene == null) return;

            EditorSceneManager.LoadSceneInPlayMode(scene.path, new LoadSceneParameters());
        }
    }
}