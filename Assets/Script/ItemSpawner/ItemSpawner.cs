using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils.Randomizer;

public class ItemSpawner : MonoBehaviour
{
    public List<GameObject> itemsToSpawn;
    [HideInInspector]
    public float amountToScale = 0.1f;
    [HideInInspector]
    public Vector3 absoluteScale = new Vector3(2, 2, 2);


    public GameObject SpawnRandomItem()
    {
        var prefab = Instantiate(itemsToSpawn.GetRandom());
        prefab.transform.localPosition = Vector3.zero;
        return prefab;
    }

}
