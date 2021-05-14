using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "meshAnimation")]
public class MeshAnimation : ScriptableObject
{
    [SerializeField] private MeshAnimationType meshAnimationType = MeshAnimationType.Cycling;// Изменение этого поля в Play mode ничего не даст

    [SerializeField] private Material defaultMaterial;
    [SerializeField] private Mesh defaultMesh;

    [SerializeField] private string name;
    [SerializeField] private MeshAnimPart[] meshAnim;

    public MeshAnimPart[] MeshAnimParts => meshAnim;
    public string Name => name;

    public Mesh DefaultMesh => defaultMesh;
    public Material DefaultMaterial => defaultMaterial;

    private MeshAnimationEngine _meshAnimationLinear;
    private MeshAnimationEngine _meshAnimationCycling;

    private MeshAnimationEngine _currentAnimationEngine;

    public virtual void Initialize(MeshFilter meshFilter,MeshRenderer meshRenderer)
    {
        _meshAnimationLinear = new MeshAnimationLinear(this, meshFilter, meshRenderer);
        _meshAnimationCycling = new MeshAnimationCycling(this, meshFilter, meshRenderer);
    }

    public IEnumerator RunAnimation()
    {
        return Run();
    }

    private IEnumerator Run()
    {
        switch (meshAnimationType) 
        {
            case (MeshAnimationType.Cycling):
                _currentAnimationEngine = _meshAnimationCycling;
                break;
            case (MeshAnimationType.Linear):
                _currentAnimationEngine = _meshAnimationLinear;
                break;
        }
        return _currentAnimationEngine.Run();
    }
}
