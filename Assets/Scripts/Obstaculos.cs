using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstaculos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        Debug.Log("Game Over");
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
