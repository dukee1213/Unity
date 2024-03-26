using UnityEngine;

public class Credits : MonoBehaviour
{
    // must be public to make objects access the button
    public void Quit()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
