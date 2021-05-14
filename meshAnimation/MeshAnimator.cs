using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class MeshAnimator : MonoBehaviour
{
    [SerializeField] private List<MeshAnimation> meshAnimations;

    private MeshFilter _meshFilter;

    private void Start()
    {
        _meshFilter = GetComponent<MeshFilter>();
        Initialize();
    }

    public void Play(string name)
    {
        MeshAnimation animation = FindAnimation(name);

        if (animation)
            StartCoroutine(animation.RunAnimation());
        else
            throw new Exception($"Animation: {name} is not Found");
    }

    public MeshAnimation FindAnimation(string name)
    {
        MeshAnimation animation = meshAnimations.Find(m => m.Name == name);

        if (animation)
            return animation;

        return null;
    }

    private void Initialize()
    {
        for (int i = 0; i < meshAnimations.Count; i++)
        {
            meshAnimations[i] = Instantiate(meshAnimations[i]);
            meshAnimations[i].Initialize(_meshFilter);
        }
    }
}
