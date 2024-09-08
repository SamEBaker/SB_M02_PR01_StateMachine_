using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Player : MonoBehaviour
{
    public IPlayerState currentState;


    public PostProcessVolume volume;
    public ColorGrading colorGrading;
    public GameObject hat;
    public GameObject stash;
    public List<GameObject> teleportPos;



    private void Awake()
    {
        volume.profile.TryGetSettings(out colorGrading);
        currentState = new PlayerController();
    }

    void Update()
    {
        currentState.Handle(this);
    }
}
