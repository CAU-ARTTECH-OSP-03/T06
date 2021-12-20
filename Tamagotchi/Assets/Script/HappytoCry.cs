using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HappytoCry : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();}
     
    

    // Update is called once per frame
    void Update()
    {
        if (Health.happiness > 80f){
            anim.SetBool("happytocry",true);
        }
        else if (Health.happiness <= 80f ){
            anim.SetBool("happytocry",false);
        }


         if (Health.happiness <= 1 ){
            anim.SetBool("death",false);
        }
    }
}

