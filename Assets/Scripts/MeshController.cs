using System.Collections;
using UnityEngine;

public class MeshController : MonoBehaviour
{
    [SerializeField] private Mesh[] mesh;
    [SerializeField] private MeshFilter meshFilter;
    [SerializeField] private int indexOfMesh;
    void Start()
    {
        StartCoroutine (meshs());
    }

    private IEnumerator meshs()
    {
        while (true)
        {
            if (indexOfMesh <= 2)
            {
                yield return new WaitForSeconds(1);
                meshFilter.mesh = mesh[indexOfMesh];
                indexOfMesh++;
            }
        }
    }
}
