using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitterRing : MonoBehaviour
{
    private Material mat;

    private void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
    }

    public void Select()
    {
        mat.SetColor("_Color", Color.white * 4);
    }

    public void Deselect()
    {
        mat.SetColor("_Color", Color.white * 1.5f);
    }

    void Update()
    {
        //transform.Rotate(0, 0, 0.1f);        
    }
}
