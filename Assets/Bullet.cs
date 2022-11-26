using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float TimeD = 2f;

    void Start()
    {
        Destroy(gameObject, TimeD);
    }

}
