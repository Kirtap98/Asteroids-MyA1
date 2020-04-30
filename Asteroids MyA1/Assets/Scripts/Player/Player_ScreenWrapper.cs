using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_ScreenWrapper : MonoBehaviour
{


    public float screenHeight;
    public float screenWidth;




   
    private void FixedUpdate()
    {
        ScreenWrapper();
    }
    private void ScreenWrapper()
    {
        Vector2 playerpos = transform.position;
        if (transform.position.y > screenHeight)
            playerpos.y = -screenHeight;
        if (transform.position.y < -screenHeight)
            playerpos.y = screenHeight;
        if (transform.position.x > screenWidth)
            playerpos.x = -screenWidth;
        if (transform.position.x < -screenWidth)
            playerpos.x = screenWidth;
        transform.position = playerpos;
    }
   

}
