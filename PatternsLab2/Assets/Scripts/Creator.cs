using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour, ICreator
{
    [SerializeField] GameObject _prefab;
    public GameObject Create()
    {
        return Instantiate( _prefab );
    }
}