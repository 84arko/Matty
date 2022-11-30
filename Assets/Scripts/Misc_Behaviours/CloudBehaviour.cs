using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudBehaviour : MonoBehaviour
{
    [SerializeField]
    private Sprite[] cloudSprites;
    [SerializeField]
    private Vector2[] rightPos;
    [SerializeField]
    private Vector2[] leftPos;
    [SerializeField]
    private int sortOrder;


    GameObject cloud;
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("TriggerCloud", 2f, 45f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    GameObject NewCloud()
    {
        cloud = new GameObject();
        cloud.AddComponent<SpriteRenderer>();
        cloud.GetComponent<SpriteRenderer>().sprite = cloudSprites[Random.Range(0, cloudSprites.Length)];
        cloud.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.5f);
        cloud.GetComponent<SpriteRenderer>().sortingOrder = sortOrder;
        cloud.transform.localScale = new Vector2(0.5f, 0.5f);
        return cloud;
    }

    IEnumerator MoveCloud()
    {
        float counter = 0f;
        float travelDuration = Random.Range(60, 75);
        int pos = Random.Range(0, rightPos.Length);
        GameObject cloud = NewCloud();
        cloud.transform.position = rightPos[pos];



        while (counter < travelDuration)
        {
            cloud.transform.position = Vector3.Lerp(rightPos[pos], leftPos[pos], counter / travelDuration);
            counter += Time.deltaTime;
            yield return null;
        }

        transform.position = leftPos[pos];
        Destroy(cloud);

    }

    void TriggerCloud()
    {
        if(this.isActiveAndEnabled)
        {
            StartCoroutine(MoveCloud());
        }
        
    }
}
