using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marco_Lines : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer[] mySprites;

    [SerializeField]
    private float fadeDuration;

    private IEnumerator coroutine;
    [SerializeField]
    Color darker ;
    [SerializeField]
    Color lighter;
    void Start()
    {
        
        Debug.Log(fadeDuration);
        //StartCoroutine(FadeTo(mySprites[2], mySprites[2].color, darker));
        InvokeRepeating("Fader", 1, (float)(fadeDuration*4 + 2));
    }

    void Fader()
    {
        if(coroutine!=null)
        {
            StopCoroutine(coroutine);
        }
        int index = Random.Range(0, mySprites.Length);
        coroutine = Fade(mySprites[index]);
        StartCoroutine(coroutine);
       

    }

    //private IEnumerator Fade(SpriteRenderer rend, Color color1, Color color2)
    //{


    //    float elapsedTime = 0f;

    //    while (elapsedTime < fadeDuration)
    //    {
    //        elapsedTime += Time.deltaTime;
    //        rend.color = Color.Lerp(color1, color2, elapsedTime / fadeDuration);
    //        yield return null;
    //    }
    //    rend.color = color2;
    //    Debug.Log("In fade1");


    //    //for(float i = 0f;  i<=fadeDuration; i+=0.1f)
    //    //{
    //    //    rend.color = col;
    //    //    yield return new WaitForSeconds(fadeDuration);


    //}

    private IEnumerator Fade(SpriteRenderer rend)
    {
        yield return FadeTo(rend,lighter, darker);
        yield return new WaitForSeconds(fadeDuration*2);
        yield return FadeTo(rend, darker, lighter);
    }

    private IEnumerator FadeTo(SpriteRenderer rend,Color older, Color newer)
    {
       

        for (float t = 0.01f; t < fadeDuration; t += Time.deltaTime)
        {
            rend.color = Color.Lerp(older, newer, t / fadeDuration);
            yield return null;
        }

        rend.color = newer;
    }




}
