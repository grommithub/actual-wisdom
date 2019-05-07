using TMPro;
using UnityEngine;

public class ShowTime : MonoBehaviour
{
    TMP_Text time;
    float timer;
    float newtimer;
    // Start is called before the first frame update
    void Start()
    {
        time = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        newtimer = timer - (timer % 0.01f);
        time.text = newtimer.ToString();

    }
}
