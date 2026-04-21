using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void selected()
    {
        Invoke(nameof(changeScene), 10.0f);
    }

    public void changeScene()
    {
        SceneManager.LoadScene("Museum", LoadSceneMode.Single);
        Debug.Log("selected");
    }
}
