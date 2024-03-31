using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]private GameObject theObs;
    private float theHight;
    // Start is called before the first frame update
    void Awake()
    {
        theHight = 0f;
    }

    private void Start()
    {
        StartCoroutine(TheGenerate());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            TheReset();   
        }
    }

    IEnumerator TheGenerate()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            TheObstacles();
            Time.timeScale += 0.01f;
        }
    }

    void TheObstacles()
    {
        GameObject _theObs = Instantiate(theObs);
        if (theHight >= 4f) { theHight -= 0.5f; }
        else if (theHight <= -4f) { theHight += 0.5f; }
        else { theHight += Random.Range(-1f, 1f); }
        _theObs.transform.position = new Vector2(9, theHight);
        Debug.Log("Generated!");
    }

    public void theOver()
    {
        Time.timeScale = 0;
        Debug.Log("GameOver");
    }

    void TheReset()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
