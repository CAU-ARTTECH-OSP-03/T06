using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeline2 : MonoBehaviour
{
    public GameObject line1;
    public GameObject line2;
    public GameObject line3;
    AudioSource changesound;
    // Start is called before the first frame update
    void Start()
    {
        changesound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void change()
    {
        line1.SetActive(true);
        line2.SetActive(false);
        line3.SetActive(false);
        changesound.Play();
    }
}
