using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void c'est une fonction qui donne un ordre mais n'a pas de resultats comme une reponse d'un calcul
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //detect collision with the target 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            Debug.Log("Ball hit the target!");



            //load next scene in 2 seconde (so that the sound can play)
            Invoke("LoadNextScene", 2f);

        }
        
                if (collision.gameObject.CompareTag("ballloss"))
        {
            Debug.Log("ball is lost");

            

            //reload current scene
            Invoke("ReloadScene", 2f);

        }
    }

    private void ReloadScene()
    {
        //load next scene
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);

    }

   // private void NextScene()
   // {
        //load next scene
//    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    //}


    private void LoadNextScene()
    {
        //Load next scene or the first scene if we are at the last scene
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(nextSceneIndex);
    }
}
