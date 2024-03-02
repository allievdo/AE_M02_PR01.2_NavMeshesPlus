using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GenerateNewLevel : MonoBehaviour
{
    public void GenerateLevel()
    {
        SceneManager.LoadScene("Scene02");
    }
}
