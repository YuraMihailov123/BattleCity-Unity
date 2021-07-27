using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingComponent : MonoBehaviour
{
    public static PoolingComponent SharedInstance;
    public List<GameObject> pooledObjects;
}
