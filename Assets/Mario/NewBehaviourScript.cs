using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript1 : MonoBehaviour
{
    [SerializeField] private Mesh mesh;

    [SerializeField] private MeshFilter meshFilter;
   
    private void Awake()
    {
       meshFilter = GetComponent<MeshFilter>();
        
    }

    private void Start()
    {
        meshFilter = GetComponent<MeshFilter>();
        print("ns kj[");
    }
    //
    private void OnValidate()
    {
        if (meshFilter == null)
            meshFilter = GetComponent<MeshFilter>();
        SetMesh();
    }
    private void SetMesh()
    {
        print("SetMesh");
        meshFilter.mesh = meshFilter.sharedMesh;
    }


}
