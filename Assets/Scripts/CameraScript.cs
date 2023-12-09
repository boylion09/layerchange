using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public PlayerMovementController player; // Дефиниране на контролер за героя.
    public Camera gameCamera; // Дефиниране на обект камера.
    
    // Старт се извиква преди първия фрейм.
    void Start()
    {
        
    }

    // Update се извиква веднъж за всеки фрейм.
    void Update()
    {
        // Правим позицията на Камерата да равна по X и Y с героя и с 15 по-малък Z от героя.
        gameCamera.transform.position = new Vector3(Mathf.Lerp(gameCamera.transform.position.x, player.transform.position.x, 1f), player.transform.position.y, Mathf.Lerp(gameCamera.transform.position.z, player.transform.position.z - 15, 0.01f));
    }
}
