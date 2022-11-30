using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class Sceneloader : MonoBehaviour
{
    public Flowchart flowChart;
    void Start()
    {
        //Invoke("Broadcaster", 0.5f);
    }

    public void Loader(int index)
    {
        SceneManager.LoadScene(index);
    }

    private void Broadcaster()
    {
        Fungus.Flowchart.BroadcastFungusMessage("startNow");
    }
}
