using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class point : MonoBehaviour
{
    public static int points = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = points.ToString();
    }
}
