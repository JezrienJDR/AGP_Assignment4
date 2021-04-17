using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Puzzle")]
public class Puzzle : ScriptableObject
{
    public int[] targets;
    public int[] ring1;
    public int[] ring2;
    public int[] ring3;
}
