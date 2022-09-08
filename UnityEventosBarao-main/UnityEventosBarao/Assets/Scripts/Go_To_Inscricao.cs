using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go_To_Inscricao : MonoBehaviour
{
    public void Next(){
        SceneManager.LoadScene("Inscricao");
    }
}
