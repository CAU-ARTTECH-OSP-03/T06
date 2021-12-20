using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class CLickpoint : MonoBehaviour
{
    public GameObject Heart;
  
    // Start is called before the first frame update
    void Start()
    {
        Heart.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            
             if (EventSystem.current.IsPointerOverGameObject())
            {
                Debug.Log("Clicked on the UI");
            }
            else {           
                 point.points = point.points + 1;
                Heart.SetActive(true);
                Invoke("HideHeart",1);

            }




        }
        
    }
    void HideHeart(){
        Heart.SetActive(false);
    }
}
