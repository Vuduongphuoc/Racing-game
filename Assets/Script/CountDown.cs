using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class CountDown : MonoBehaviour
{
    public GameObject Countdown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public LapTimeManager LapTimer;
    public AudioSource LevelMusic;
    public CarController[] CarControls;
    public GameObject AICar;

    void Start()
    {
        CarControls = FindObjectsOfType<CarController>();
        LapTimer = FindObjectOfType<LapTimeManager>();
        StartCoroutine(CountStart());
    }
    IEnumerator CountStart()
    {
        
        yield return new WaitForSeconds(0.5f);
        Countdown.GetComponent<Text>().text = "3";
        GetReady.Play();
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        Countdown.GetComponent<Text>().text = "2";
        GetReady.Play();
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        Countdown.GetComponent<Text>().text = "1";
        GetReady.Play();
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        GoAudio.Play();
        LevelMusic.Play();
        LapTimer.enabled = true;
        foreach (var controller in CarControls) 
        {
            controller.enabled = true;
            Debug.Log("123");
        };

    }
   
}
