using UnityEngine;

[CreateAssetMenu(fileName = "ScriptTemplate", menuName = "AssetsCreator/Script Template")]
public class ScriptTemplate : ScriptableObject
{
    public string templateName = "New Script";
    [TextArea(10, 20)]
    public string templateContent;

    public string description;
}