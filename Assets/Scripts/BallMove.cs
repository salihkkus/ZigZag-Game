using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    Vector3 aspect;
    public GroundSpawner groundspawnerscript;
    public static bool fall;
    public float speed;
    void Start()
    {
        aspect = Vector3.forward;
        fall = false;
    }

    
    void Update()
    {
        if(transform.position.y < 0.5f)
        {
            fall = true;
        }

        if(fall == true)
        {
            return;
        }

        if(Input.GetMouseButtonDown(0))
        {
            if(aspect.x == 0)
            {
                aspect = Vector3.left;
            }
            else
            {
                aspect = Vector3.forward;
            }
        }
    }

    private void FixedUpdate()
    {
        Vector3 Move = aspect * Time.deltaTime * speed;
        transform.position += Move;
    }

private void OnCollisionExit(Collision collision)
{
    if(collision.gameObject.tag == "Ground")
    {
    groundspawnerscript.Spawn_Create();
    StartCoroutine(DeleteGround(collision.gameObject));
    }
}

IEnumerator DeleteGround(GameObject DeleteObject)
{
    yield return new WaitForSeconds(3f);
    Destroy(DeleteObject);
}

}
