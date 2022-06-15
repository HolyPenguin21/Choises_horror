using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterController : MonoBehaviour
{
    public GameObject characterPrefab;

    private GameObject obj;
    private Transform tr;
    private Rigidbody2D rb;

    private void Awake()
    {
        obj = Create_MainCharacter(Vector3.zero);
        tr = obj.transform;
        rb = obj.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        
    }

    private void Movement()
    {
        
    }

    private GameObject Create_MainCharacter(Vector3 pos)
    {
        obj = Instantiate(characterPrefab, pos, Quaternion.identity);
        obj.name = "MainCharacter";

        return obj;
    }
}
