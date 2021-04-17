using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamEmitter : MonoBehaviour
{
    private LineRenderer beam;
    private Material mat;
    // Start is called before the first frame update
    void Start()
    {
        beam = GetComponent<LineRenderer>();
        mat = beam.material;
    }


    private void UpdateBeam()
    {
        beam.SetPosition(0, transform.position);

        RaycastHit hit;

        //Physics.Raycast(transform.position, transform.right, out hit, )
        if(Physics.Linecast(transform.position, transform.right * -30.0f, out hit))
        {
            beam.SetPosition(1, hit.point);
            if(hit.collider.gameObject.CompareTag("Target"))
            {
                hit.collider.gameObject.GetComponent<Target>().AccessGranted();
                GreenBeam();
            }
            else
            {
                RedBeam();
            }
        }
        else
        {
            beam.SetPosition(1, transform.position + transform.right * -30.0f);
            RedBeam();
        }
    }


    public Vector3 GetEndPoint()
    {
        return beam.GetPosition(1);
    }

    public void GreenBeam()
    {
        mat.SetColor("_Color", Color.green * 9.5f);
    }

    public void RedBeam()
    {
        mat.SetColor("_Color", Color.red * 7.5f);
    }


    // Update is called once per frame
    void Update()
    {
        UpdateBeam();
    }
}
