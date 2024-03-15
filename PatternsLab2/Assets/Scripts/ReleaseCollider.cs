using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseCollider : MonoBehaviour
{
    [SerializeField] private Pool _pool;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Potion"))
        {
            Debug.Log($"{other.tag} has entered.");
            _pool.Release(other.gameObject);
        }
    }
}
