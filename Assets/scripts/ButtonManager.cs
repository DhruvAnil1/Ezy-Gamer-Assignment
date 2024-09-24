using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ButtonManager : MonoBehaviour
{
    private Animator animator;
    public GameObject objectToDeactivate; 
    public GameObject objectToActivate;
    public GameObject panel2;
    public GameObject panel3;      

    void Update()
    {
        if (!objectToDeactivate.activeInHierarchy)
        {
            objectToActivate.SetActive(true);
        }
    }

    public void medicine()
    {
        panel2.SetActive(true);
    }

    public void water()
    {
        panel3.SetActive(true);
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }




}
