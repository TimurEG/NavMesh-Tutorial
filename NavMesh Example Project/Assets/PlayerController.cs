using UnityEngine.AI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera cam;

    public NavMeshAgent agent;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Debug.Log("click");

            if (Physics.Raycast(ray, out hit))
            {
                //This is where we move our agent
                agent.SetDestination(hit.point);
                Debug.Log(hit.point);
            }
        }
    }
}
