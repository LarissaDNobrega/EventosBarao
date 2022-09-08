using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_To_Home : MonoBehaviour
{
    public void Next(){
        SceneManager.LoadScene("Home");
    }
}
