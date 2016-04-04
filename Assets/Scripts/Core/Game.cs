using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{
    private int HP = 1;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(GameLoop());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator GameLoop()
    {
        yield return StartCoroutine(StartingMainGame());
        yield return StartCoroutine(MainGame());
        yield return StartCoroutine(GameOver());
        //Application.LoadLevel(Application.loadedLevel);
        StartCoroutine(GameLoop());

    }

    private IEnumerator StartingMainGame()
    {
        yield return null;
    }
    private IEnumerator MainGame()
    {
        while (HP != 0)
        {
            Debug.Log("running");
            yield return null;
        }
        yield return null;
    }
    private IEnumerator GameOver()
    {
        yield return null;
    }
}
