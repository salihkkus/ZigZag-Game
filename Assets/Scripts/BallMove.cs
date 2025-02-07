using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class BallMove : MonoBehaviour
{
    Vector3 aspect; // Stores the current movement direction
    public GroundSpawner groundspawnerscript; // Reference to the ground spawner script
    public static bool fall; // Tracks if the ball has fallen
    public float speed; // Movement speed of the ball
    public float addedspeed; // Additional speed increment

    void Start()
    {
        aspect = Vector3.forward; // Default movement direction
        fall = false; // Reset fall status
    }

    void Update()
    {
        if (transform.position.y < 0.5f) // Check if the ball falls below a certain height
        {
            fall = true;
            StartCoroutine(RestartGame()); // Start the game restart process
        }

        if (fall == true)
        {
            return; // Stop movement when the ball falls
        }

        if (Input.GetMouseButtonDown(0)) // Detect mouse click
        {
            if (aspect.x == 0)
            {
                aspect = Vector3.left; // Change movement direction
            }
            else
            {
                aspect = Vector3.forward; // Change movement direction
            }
            speed += addedspeed * Time.deltaTime; // Increase speed gradually
        }
    }

    private void FixedUpdate()
    {
        Vector3 Move = aspect * Time.deltaTime * speed; // Calculate movement vector
        transform.position += Move; // Apply movement
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground") // Check if the ball leaves the ground
        {
            Score.scores++; // Increase score
            collision.gameObject.AddComponent<Rigidbody>(); // Add physics effect
            groundspawnerscript.Spawn_Create(); // Spawn new ground
            StartCoroutine(DeleteGround(collision.gameObject)); // Start deletion process
        }
    }

    IEnumerator DeleteGround(GameObject DeleteObject)
    {
        yield return new WaitForSeconds(3f); // Wait for 3 seconds before deleting
        Destroy(DeleteObject); // Remove ground object
    }

    // Function to restart the game
    IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(1f); // Wait for 1 second before restarting
        SceneManager.LoadScene("MainScene"); // Reload the main scene
    }
}
