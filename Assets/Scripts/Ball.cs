using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private bool stickToPlayer;
    public GameObject myObject;

    [SerializeField] private Transform transformPlayer;
    [SerializeField] private Transform playerBallPosition;
    [SerializeField] private Transform playerBallRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!stickToPlayer)
        {
            float distanceToPlayer = Vector3.Distance(transformPlayer.position, transform.position);
            if (distanceToPlayer < 1)
            {
                stickToPlayer = true;
            }
            myObject.GetComponent<SphereCollider>().enabled = true; 
        }
        else
        {
            //Prevent ball collider from messing with player
            myObject.GetComponent<SphereCollider>().enabled = false; 
            //place ball in specific location on player
            transform.position = playerBallPosition.position;
            transform.rotation = playerBallRotation.rotation;
        }
    }
}
