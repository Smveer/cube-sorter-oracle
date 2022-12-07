using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    public Transform[] cubesTransforms;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello in the start method");
        Debug.Log($"There are {cubesTransforms.Length} components in the tab cubesTransforms");
        ShufflePositions(cubesTransforms);
    }

    public static void ShufflePositions(Transform[] cubes)
    {
        for (var i = 0; i < cubes.Length; i++)
        {
            var rdmIdx = Random.Range(i, cubes.Length);
            (cubes[i].position, cubes[rdmIdx].position) = (cubes[rdmIdx].position, cubes[i].position);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        ShufflePositions(cubesTransforms);
    }
    
}
