using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private StarterAssetsInputs starterAssetsInputs;
    public GameObject thePlayer;
    private Animator animator;
    public const int ANIMATION_LAYER_SNAP = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        starterAssetsInputs = GetComponent<StarterAssetsInputs>();
    }

    // Update is called once per frame
    void Update()
    {
        if (starterAssetsInputs.snap)
        {
            Debug.Log("Snap");
            starterAssetsInputs.snap = false;
            animator.Play("Snap", 0, 0f);
            animator.SetLayerWeight(ANIMATION_LAYER_SNAP, 1);
        }
    }
}
