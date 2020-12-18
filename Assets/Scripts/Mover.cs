using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//  Handles the movement of the player game object.
public class Mover : MonoBehaviour
{
    //  The target that we will be moving to.
    [SerializeField]
    Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //  Move the navMeshAgent destination property to the position of the target each frame.
        GetComponent<NavMeshAgent>().destination = target.position; 
    }
}
