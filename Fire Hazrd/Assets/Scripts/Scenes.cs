using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    public void playScene(string name)
    {

        StartCoroutine(LoadScene(name));
        Time.timeScale = 1f;
    }
    IEnumerator LoadScene(string name)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(name);
    }
}
