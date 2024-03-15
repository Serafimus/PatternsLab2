using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Pool))]
public class Spawner : MonoBehaviour
{
    private Pool _pool;
    private void Awake()
    {
        _pool = GetComponent<Pool>();
    }
    public void Spawn()
    {
        GameObject obj = _pool.Get();
        obj.GetComponent<Rigidbody>().velocity = Vector3.zero;
        obj.transform.position = transform.position;
    }
}
