using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootTarget : MonoBehaviour

{
    public GameObject target;
    public AudioSource shoot;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        DestroyImmediate(target);
        Debug.Log("It works");
        shoot.Play();
    }
}
