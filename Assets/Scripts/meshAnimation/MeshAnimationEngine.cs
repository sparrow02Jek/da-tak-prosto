using System.Collections;
using UnityEngine;

public abstract class MeshAnimationEngine
{
    protected MeshAnimation _parent;
    protected MeshFilter _meshFilter;
    protected MeshRenderer _meshRenderer;

    public MeshAnimationEngine(MeshAnimation parent, MeshFilter meshFilter, MeshRenderer meshRenderer)
    {
        _parent = parent;
        _meshFilter = meshFilter;
        _meshRenderer = meshRenderer;
    }

    public abstract IEnumerator Run();
    
    protected void PlayAnimPart(MeshAnimPart meshAnimPart)
    {
        if (meshAnimPart.Material == null)
            _meshRenderer.material = _parent.DefaultMaterial;
        else
            _meshRenderer.material = meshAnimPart.Material;

        if (meshAnimPart.Mesh == null)
            _meshFilter.mesh = _parent.DefaultMesh;
        else
            _meshFilter.mesh = meshAnimPart.Mesh;

    }
}