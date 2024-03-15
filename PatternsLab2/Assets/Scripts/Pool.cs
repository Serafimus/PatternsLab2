using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Pool : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private int _amount = 10;
    private ObjectPool<GameObject> _objects;
    private void Awake()
    {
        _objects = _objects = new ObjectPool<GameObject>(CreateObject, OnGetObject, OnReleaseObject, OnDestroyObject, false, _amount);
    }
    public GameObject Get()
    {
        return _objects.Get(); 
    }
    public void Release(GameObject obj)
    {
        _objects.Release(obj);
    }
    public GameObject CreateObject()
    {
        GameObject obj = Instantiate(_prefab);
        obj.transform.SetParent(transform);
        return obj;
    }
    public void OnGetObject(GameObject obj)
    {
        obj.SetActive(true);
    }
    public void OnReleaseObject(GameObject obj)
    {
        obj.SetActive(false);
    }
    public void OnDestroyObject(GameObject obj)
    {
        Destroy(obj);
    }
}
