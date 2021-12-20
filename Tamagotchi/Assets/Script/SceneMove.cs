using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{ 
    public void SceneChange1(){
        SceneManager.LoadScene("Game1");
    }
    public void SceneChange2(){
        SceneManager.LoadScene("Game2");
    }
 
}
