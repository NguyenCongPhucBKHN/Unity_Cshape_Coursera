using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{   
    //Jump location support
    [SerializeField]float minX, maxX, minY, maxY;
    
    //Timer Support
    float TotalJumpDelaySeconds= 1;
    float elapsedJumpDelaySeconds= 0;
    
    //Update time and check ii it's done
    void Update()
    {
        elapsedJumpDelaySeconds += Time.deltaTime;
        if(elapsedJumpDelaySeconds>=TotalJumpDelaySeconds)
        {
            elapsedJumpDelaySeconds=0;
            // Cach 1
            // transform.position += new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);
            // Cach 2
            Vector3 position = transform.position;
            position.x =Random.Range(minX, maxX);
            position.y = Random.Range(minY, maxY);
            transform.position= position;

        }
    }
}
