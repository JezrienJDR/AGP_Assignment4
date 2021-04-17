using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Lock : MonoBehaviour
{
    //public Transform testRing;
    private Transform activeRing;
    private int activeRingNum;
    private int numRings;
    private Transform rotator;
    private GameObject rotatorObject;
    List<EmitterRing> rings;
    List<Target> targets;
    List<BeamEmitter> emitters;

    public Puzzle test;



    // Start is called before the first frame update
    void Start()
    {
        //activeRing = testRing;
        rotatorObject = new GameObject();
        rotator = rotatorObject.transform;
        rings = new List<EmitterRing>();
        targets = new List<Target>();
        emitters = new List<BeamEmitter>();
        
        BuildPuzzle(test);
    }

    // Update is called once per frame
    
    public void BuildPuzzle(Puzzle p)
    {
        foreach(int i in p.targets)
        {
            GameObject t = (GameObject)Instantiate(Resources.Load("Prefabs/Target"),new Vector3(0,0,-1), Quaternion.Euler(0,0,-90));
            t.transform.Rotate(0, 0, -45 * i);           
            targets.Add(t.GetComponent<Target>());
        }

        GameObject r1 = (GameObject)Instantiate(Resources.Load("Prefabs/EmitterRing"), Vector3.zero, Quaternion.identity);
        rings.Add(r1.GetComponent<EmitterRing>());
        numRings = 1;

        foreach(int i in p.ring1)
        {
            GameObject e = (GameObject)Instantiate(Resources.Load("Prefabs/LaserEmitter"), new Vector3(0, 10.1f, -1), Quaternion.identity);
            e.transform.Rotate(0, 0, 90);
            e.transform.localScale = new Vector3(240.0f, 300.0f, 300.0f);

            float theta = -45.0f * i;
            e.transform.parent = rotator;
            rotator.Rotate(0, 0, theta);         
            e.transform.parent = rings[0].transform;
            emitters.Add(e.GetComponent<BeamEmitter>());
            rotator.Rotate(0, 0, -theta);
        }

        if(p.ring2.Length > 0)
        {
            GameObject r2 = (GameObject)Instantiate(Resources.Load("Prefabs/EmitterRing"), Vector3.zero, Quaternion.identity);
            r2.transform.localScale = new Vector3(28f, 28f, 1.0f);
            rings.Add(r2.GetComponent<EmitterRing>());

            numRings = 2;

            foreach (int i in p.ring2)
            {
                GameObject e = (GameObject)Instantiate(Resources.Load("Prefabs/LaserEmitter"), new Vector3(0, 7.07f, -1), Quaternion.identity);
                e.transform.Rotate(0, 0, 90);
                e.transform.localScale = new Vector3(240.0f, 300.0f, 300.0f);

                float theta = -45.0f * i;
                e.transform.parent = rotator;
                rotator.Rotate(0, 0, theta);
                e.transform.parent = rings[1].transform;
                emitters.Add(e.GetComponent<BeamEmitter>());
                rotator.Rotate(0, 0, -theta);
            }

            if (p.ring3.Length > 0)
            {
                GameObject r3 = (GameObject)Instantiate(Resources.Load("Prefabs/EmitterRing"), Vector3.zero, Quaternion.identity);
                r3.transform.localScale = new Vector3(19.6f, 19.6f, 1.0f);
                rings.Add(r3.GetComponent<EmitterRing>());

                numRings = 3;

                foreach (int i in p.ring3)
                {
                    GameObject e = (GameObject)Instantiate(Resources.Load("Prefabs/LaserEmitter"), new Vector3(0, 8.08f, -1), Quaternion.identity);
                    float theta = 45.0f * i;
                    e.transform.parent = rotator;
                    rotator.Rotate(0, 0, theta);
                    e.transform.parent = rings[2].transform;
                    emitters.Add(e.GetComponent<BeamEmitter>());
                    rotator.Rotate(0, 0, -theta);
                }

            }
        }

        activeRing = rings[0].transform;
    }


    public void OnTurnClockwise()
    {
        StartCoroutine("CW");
    }
    public void OnTurnCounterClockwise()
    {
        StartCoroutine("CCW");
    }
    public void OnRingOut()
    {
        activeRingNum--;
        if(activeRingNum < 0)
        {
            activeRingNum = 0;
        }
        activeRing = rings[activeRingNum].transform;

        RingSelect();
    }
    public void OnRingIn()
    {
        activeRingNum++;
        if (activeRingNum >= numRings)
        {
            activeRingNum = numRings - 1;
        }
        activeRing = rings[activeRingNum].transform;

        RingSelect();
        
    }

    private void RingSelect()
    {
        for (int i = 0; i < numRings; i++)
        {
            if (i == activeRingNum)
            {
                rings[i].Select();
            }
            else
            {
                rings[i].Deselect();
            }
        }
    }

    IEnumerator CW()
    {
        for(int i = 0; i < 15; i++)
        {
            activeRing.Rotate(0, 0, 3);
            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator CCW()
    {
        for (int i = 0; i < 15; i++)
        {
            activeRing.Rotate(0, 0, -3);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
