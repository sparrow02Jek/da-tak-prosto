using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MeshAnimationEngine
{
    protected MeshAnimation _parent;
    protected MeshFilter _meshFilter;

    public MeshAnimationEngine(MeshAnimation parent, MeshFilter meshFilter)
    {
        _parent = parent;
        _meshFilter = meshFilter;
    }

    public abstract IEnumerator Run();
}
