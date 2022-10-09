using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField]
    GameObject objectoToDestroy;

    public void DestroyGameObject()
    {
        Destroy (objectoToDestroy);
    }
}
