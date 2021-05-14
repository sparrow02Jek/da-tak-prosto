using System.Collections;
using UnityEngine;

public class MeshAnimationLinear : MeshAnimationEngine
{
    public MeshAnimationLinear(MeshAnimation parent, MeshFilter meshFilter, MeshRenderer meshRenderer) : base(parent, meshFilter, meshRenderer)
    {

    }

    public override IEnumerator Run()
    {
        foreach(var animPart in _parent.MeshAnimParts)
        {
            yield return new WaitForSeconds(animPart.Timer);
            PlayAnimPart(animPart);
        }
    }
}
