using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void BaseLine()
    {
        SceneManager.LoadScene("BaseLine");
    }

    public void Training()
    {
        SceneManager.LoadScene("Training");
    }


    public void RekabetçiMod ()
    {
        SceneManager.LoadScene("Rekabetçi");
    }

    public void KooperatifMod()
    {
        SceneManager.LoadScene("Kooperatif");
    }

    public void KollaboratifMod()
    {
        SceneManager.LoadScene("Kollaboratif");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void HazýrlýkSeviyeler()
    {
        SceneManager.LoadScene("HazýrlýkSeviyeler");
    }

}
