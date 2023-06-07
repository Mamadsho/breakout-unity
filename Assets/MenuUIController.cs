using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIController : MonoBehaviour
{
    public TMP_InputField inputField;
    public void StartMainScene()
    {
        Singleton.Instance.playername = inputField.text;
        SceneManager.LoadScene(1);
    }
}
