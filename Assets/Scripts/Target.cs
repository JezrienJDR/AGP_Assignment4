using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    private Material mat;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
        mat.SetColor("_Color", Color.red);

        StartCoroutine("TestCycle");
    }

    public void AccessGranted()
    {
        mat.SetColor("_Color", Color.green * 1.5f);
        //Debug.Log("NAILED IT!");
    }

    public void AccessDenied()
    {
        mat.SetColor("_Color", Color.red);
    }

    private void CheckBeams()
    {
        bool found = false;

        foreach (BeamEmitter e in FindObjectsOfType<BeamEmitter>())
        {
            if (e.GetEndPoint() == transform.position)
            {
                found = true;
            }
        }

        if(!found)
        {
            AccessDenied();
        }
    }

    IEnumerator TestCycle()
    {
        int iteration = 0;
        while (iteration < 1000)
        {
            yield return new WaitForSeconds(0.5f);
            CheckBeams();
            //yield return new WaitForSeconds(0.5f);
            iteration++;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
