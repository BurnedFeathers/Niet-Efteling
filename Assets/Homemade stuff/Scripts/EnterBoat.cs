using UnityEngine;

public class EnterBoat : MonoBehaviour
{
    //define the boats
    public GameObject StaticBoat;
    public GameObject DynamicBoat;

    public StarterAssets.FirstPersonController firstPersonController;

    private void OnTriggerEnter(Collider other)
    {
        //show dynamic boat
        DynamicBoat.GetComponent<MeshRenderer>().enabled = true;
        DynamicBoat.GetComponent<MeshCollider>().enabled = true;

        //hides static boat
        StaticBoat.GetComponent<MeshRenderer>().enabled = false;
        StaticBoat.GetComponent<MeshCollider>().enabled = false;
        
        //message in log
        Debug.Log("Boat entered");

        //change stuff in firstpersoncontroller
        firstPersonController.MoveSpeed = 15;
        firstPersonController.JumpHeight = 0;
    }
}
