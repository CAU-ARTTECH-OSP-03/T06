using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class switchavatar : MonoBehaviour
{
    public GameObject avatar1, avatar2, avatar3, avatar4;

    public Button button;

    float timer = 0;
    float difftimer = 1;

   
    // Start is called before the first frame update
    void Start()
    {
        Button bt1 = button.GetComponent<Button>();
        bt1.onClick.AddListener(Updata);
        
    }

    // Update is called once per frame
    public void Updata()
    {
        
        avatar1.gameObject.SetActive(false);
        avatar2.gameObject.SetActive(true);
        avatar3.gameObject.SetActive(false);
        avatar4.gameObject.SetActive(false);
        Invoke("swichav",2);
       
    }
    void swichav()
    {
        avatar2.gameObject.SetActive(false);
        avatar1.gameObject.SetActive(true);
        avatar3.gameObject.SetActive(false);
        avatar4.gameObject.SetActive(false);


    }
    
}
