using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Attack(); 
        }
    }

    void Attack()
    {
        //Play an attack animation
        //Detect enemies in range of attack
        //Damage the enemies


    }

}
