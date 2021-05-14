using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "meshAnimation")]
public class MeshAnimation : ScriptableObject
{
    [SerializeField] private MeshAnimationType meshAnimationType = MeshAnimationType.Cycling;

    [SerializeField] private string name;
    [SerializeField] private MeshAnimPart[] meshAnim;

    public MeshAnimPart[] MeshAnimParts => meshAnim;
    public string Name => name;

    private MeshAnimationEngine _meshAnimationLinear;
    private MeshAnimationEngine _meshAnimationCycling;

    private MeshFilter _meshFilter;

    private MeshAnimationEngine _currentAnimationEngine;

    public virtual void Initialize(MeshFilter meshFilter)
    {
        _meshFilter = meshFilter;
        
        _meshAnimationLinear = new MeshAnimationLinear(this, _meshFilter);
        _meshAnimationCycling = new MeshAnimationCycling(this,_meshFilter);

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
