using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct MeshAnimPart
{
    public Mesh Mesh; 
    public Material Material;

    [Header("время должно быть больше 0")]
    public float Timer;
}