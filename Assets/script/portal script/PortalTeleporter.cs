using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PortalTeleporter : MonoBehaviour
{

    public Transform player;
    public Transform destination;
    public GameObject playerg;

    private bool playerIsOverlapping = false;

    // Update is called once per frame
    void Update()
    {
        if (playerIsOverlapping)
        {

            Vector3 portalToPlayer = player.position - transform.position;

            float dotProduct = Vector3.Dot(transform.up, portalToPlayer);

            Debug.Log("1");

            if (dotProduct < 0f)
            {
                // Teleport him!
                float rotationDiff = -Quaternion.Angle(transform.rotation, destination.rotation);
                rotationDiff += 180;
                player.Rotate(Vector3.up, rotationDiff);

                playerg.SetActive(false);
                player.position = destination.position;
                playerg.SetActive(true);

                playerIsOverlapping = false;
            }

            playerIsOverlapping = false;

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIsOverlapping = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIsOverlapping = false;
        }
    }
}