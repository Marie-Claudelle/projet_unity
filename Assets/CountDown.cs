using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;


public class CountDown : MonoBehaviour 
{
    public int countdownValue = 1;
    public Text TxtTimeLeft;
    DateTime target;
    public enum _unite { seconde,minutes};
    public _unite unite;

    public void Setcountdown()
    {
        switch (unite.ToString())
        {
            case "secondes":
                target = DateTime.Now.AddSeconds(countdownValue);
                break;
            case "minutes":
                target = DateTime.Now.AddMinutes(countdownValue);
                break;
        }

        PlayerPrefs.SetString("target", target.ToBinary().ToString());
       ActiveCountdown();

    }

     void Start()
    {
        ActiveCountdown();
    }

    void ActiveCountdown()
    {
       if (PlayerPrefs.HasKey("target"))
        {
            target=DateTime.FromBinary(Convert.ToInt64 (PlayerPrefs.GetString("target")));
            StartCoroutine(GetDateTimeLeft(target));

        }
    }

    string GetTimeLeft(DateTime targetdate)
    {
        TimeSpan difference = targetdate.Subtract(DateTime.Now);
        if (difference >= TimeSpan.Zero)
        {
            return string.Format("{1:D2}:{2:D2}", difference.Hours, difference.Minutes, difference.Seconds);
        }
        else
        {
            return null;
        }
    }

    IEnumerator GetDateTimeLeft(DateTime targetDateTime)
    {
        while(GetTimeLeft(targetDateTime) != null)
        {
            TxtTimeLeft.text = GetTimeLeft(targetDateTime);
            yield return new WaitForSeconds (1);
        }

        Debug.Log("Désolé vous ne pouvez pas regarder la vidéo simultanément");
    }
}
