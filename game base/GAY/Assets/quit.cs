using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class quit : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene("menu");
    }
}
