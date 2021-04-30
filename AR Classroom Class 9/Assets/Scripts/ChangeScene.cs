using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeScene1() {
        SceneManager.LoadScene("hetero", LoadSceneMode.Single);
    }

    public void ChangeScene2()
    {
        SceneManager.LoadScene("autotrophic", LoadSceneMode.Single);
    }

    public void ChangeHomeScene()
    {
        SceneManager.LoadScene("homeScene", LoadSceneMode.Single);
    }

    public void ChangeScene3()
    {
        SceneManager.LoadScene("nutrition in amoeba", LoadSceneMode.Single);
    }

    public void ChangeScene4()
    {
        SceneManager.LoadScene("nutrition in human", LoadSceneMode.Single);
    }

    public void ChangeScene5()
    {
        SceneManager.LoadScene("Respiration in plants", LoadSceneMode.Single);
    }

    public void ChangeScene6()
    {
        SceneManager.LoadScene("Respiration", LoadSceneMode.Single);
    }

    public void ChangeScene7()
    {
        SceneManager.LoadScene("Soil-Profile", LoadSceneMode.Single);
    }
    public void ChangeScene8()
    {
        SceneManager.LoadScene("Sun dial", LoadSceneMode.Single);
    }

    public void ChangeScene9()
    {
        SceneManager.LoadScene("teeth", LoadSceneMode.Single);
    }

   
    public void ChangeScene10()
    {
        SceneManager.LoadScene("Transyst plants", LoadSceneMode.Single);
    }

    public void ChangeScene11()
    {
        SceneManager.LoadScene("ruminant", LoadSceneMode.Single);
    }


    public void ChangeScene12()
    {
        SceneManager.LoadScene("HeatFlow", LoadSceneMode.Single);
    }

    public void ChangeScene13()
    {
        SceneManager.LoadScene("AnimalFiber2", LoadSceneMode.Single);
    }

    public void ChangeScene14()
    {
        SceneManager.LoadScene("AnimalFiber1", LoadSceneMode.Single);
    }

    public void ChangeScene15()
    {
        SceneManager.LoadScene("moth", LoadSceneMode.Single);
    }


    public void ChangeScene16()
    {
        SceneManager.LoadScene("Caterpiller", LoadSceneMode.Single);
    }

    public void MyAppQuite()
    {
        Application.Quit();
    }

}
