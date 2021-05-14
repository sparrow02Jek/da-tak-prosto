using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshAnimationCycling : MeshAnimationEngine
{

    public MeshAnimationCycling(MeshAnimation parent, MeshFilter meshFilter) : base(parent, meshFilter)
    {

    }

    public override IEnumerator Run()
    {
        while (true)
        {
            foreach (var animPart in _parent.MeshAnimParts)
            {
                yield return new WaitForSeconds(animPart.Timer);
                _meshFilter.mesh = animPart.Mesh;
            }
        }
    }
}
