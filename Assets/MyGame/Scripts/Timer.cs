
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timer;

    private float timeInSec;

    // Start is called before the first frame update
    void Start()
    {
        timeInSec = 60f;
    }

    // Update is called once per frame
    void Update()
    {
        float minutes = Mathf.FloorToInt(timeInSec/60);
        float seconds =Mathf.FloorToInt(timeInSec%60);
        timeInSec -= Time.deltaTime;

        if(timeInSec > 0)
        {
            //timeInSec = timer;
            timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
        {
            Debug.Log("stop");
        }
        if (timeInSec <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
