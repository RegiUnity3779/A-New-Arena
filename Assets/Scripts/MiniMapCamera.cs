using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapCamera : MonoBehaviour
{
    public Player player;
    public float cameraYPosition = 10f;

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 pos = new Vector3(player.gameObject.transform.position.x, cameraYPosition, player.gameObject.transform.position.z);
        transform.position = pos;
    }
}
