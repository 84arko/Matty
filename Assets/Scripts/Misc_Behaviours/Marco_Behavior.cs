using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marco_Behavior : MonoBehaviour
{

    public GameObject obj;
    public bool isUp;
    public bool bob;
    public bool slide;
    public float speed;
    public float offset;

    private Vector2 pos1, pos2;
    // Start is called before the first frame update
    void Awake()
    {
        if(bob)
        {
            pos1 = new Vector2(obj.transform.position.x, obj.transform.position.y + offset);
            pos2 = new Vector2(obj.transform.position.x, obj.transform.position.y - offset);
        }

        if(slide)
        {
            pos1 = new Vector2(obj.transform.position.x + offset, obj.transform.position.y);
            pos2 = new Vector2(obj.transform.position.x - offset, obj.transform.position.y);
        }
  
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(isUp)
        {
            Move();
        }
           

        
    }

    private void Move()
    {
        
        transform.position = Vector3.Lerp(pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
    }

    public void SetBob(bool value)
    {
        bob = value;
    }

    public void SetSlide(bool value)
    {
        slide = value;
    }

    public void SetUp(bool val)
    {
        isUp = val;
    }
}
