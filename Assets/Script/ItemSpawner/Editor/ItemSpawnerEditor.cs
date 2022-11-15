using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(ItemSpawner))]
public class ItemSpawnerEditor : Editor
{
    private GameObject _current;

    [MenuItem("Utils/ItemSpawner")]
    public static void CreateSpawner()
    {
        var go = new GameObject();
        go.name = "ItemSpawner";
        go.AddComponent<ItemSpawner>();
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        ItemSpawner _target = (ItemSpawner)target;

        _target.absoluteScale = EditorGUILayout.Vector3Field("Absolute Scale", _target.absoluteScale);
        _target.amountToScale = EditorGUILayout.FloatField("Relative Scale", _target.amountToScale);

        if (GUILayout.Button("Spawn Item"))
        {
            if (_current != null)
                DestroyImmediate(_current);

            _current = _target.SpawnRandomItem();
        }
        
        if (GUILayout.Button("Scale Absolute Item"))
        {
            _current.transform.ScaleAbsolute(_target.absoluteScale);
        }

        if (GUILayout.Button("Scale Relative Item"))
        {
            _current.transform.ScaleRelative(_target.amountToScale);
        }
    }


}
