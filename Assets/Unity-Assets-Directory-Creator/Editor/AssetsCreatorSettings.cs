using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AssetsCreatorSettings", menuName = "AssetsCreator/Settings")]
public class AssetsCreatorSettings : ScriptableObject
{
    [Tooltip("Path: Assets/{AssetsPath}/")]
    public string AssetsPath;

    public List<string> DefaultFolder;

}
