using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformLookAt : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    [SerializeField]
    private bool flip;

    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            target = Camera.main.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.position);
        transform.Rotate(new Vector3(0, 180 * Convert.ToInt16(flip), 0));
    }
}