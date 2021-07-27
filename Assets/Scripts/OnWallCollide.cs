using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnWallCollide : MonoBehaviour
{
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        var collidedTransform = collision.gameObject.transform;
        Vector3 delta = collidedTransform.localPosition - transform.localPosition;
        delta = new Vector3(Mathf.Floor(delta.x), Mathf.Floor(delta.y), 0);
        Debug.Log(delta);
        ProccessCollision(collidedTransform,delta);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.gameObject.SendMessage("AccessMovementToAllDirections");
    }


    private void ProccessCollision(Transform collidedObject, Vector3 delta)
    {
        switch (collidedObject.tag)
        {
            case "Player":
                collidedObject.SendMessage("StopMovingByDirection",delta);
                break;
            default:
                break;
        }
    }

}
