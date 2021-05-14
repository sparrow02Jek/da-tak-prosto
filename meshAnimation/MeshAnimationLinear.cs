using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshAnimationLinear : MeshAnimationEngine
{
    public MeshAnimationLinear(MeshAnimation parent, MeshFilter meshFilter) : base(parent, meshFilter)
    {

    }

    public override IEnumerator Run()
    {
        foreach(var animPart in _parent.MeshAnimParts)
        {
            yield return new WaitForSeconds(animPart.Timer);
            _meshFilter.mesh = animPart.Mesh;
        }
    }
}
