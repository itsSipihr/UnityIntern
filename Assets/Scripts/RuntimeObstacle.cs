using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RuntimeObstacle : MonoBehaviour
{
    NavMeshObstacle navMeshObstacle;
    void Start()
    {
        navMeshObstacle = gameObject.GetComponent<NavMeshObstacle>();
        navMeshObstacle.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
