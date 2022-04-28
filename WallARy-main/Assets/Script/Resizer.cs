using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Resizer : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    private Vector3 startPos;

    public Transform target;


    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

        startPos = transform.position;
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;

        var distance = curPosition - startPos;
        target.position = new Vector3(distance.x/2, distance.y/2, 0);
        target.localScale = new Vector3(1 + distance.x, 1-distance.y, .1f);

        var mf = GetComponent<MeshFilter>();
        if (mf != null)
        {
            var bounds = mf.mesh.bounds;

            var size = Vector3.Scale(bounds.size, target.localScale); //* factor;
            var scale = 1f;
            if (target.localScale.x > target.localScale.y)
            {
                scale = target.localScale.y / target.localScale.x;
                size.x = 1;
                size.y = scale;
            }
            else
            {
                scale = target.localScale.x / target.localScale.y;
                size.x = scale;
                size.y = 1;
            }


            //if (size.y < .001)
            //    size.y = size.z;

            target.GetComponent<MeshRenderer>().material.mainTextureScale = size;
        }
    }

    //void Update()
    //{
    //    // Animates main texture scale in a funky way!
    //    float scaleX = Mathf.Cos(Time.time) * 0.5f + 1;
    //    float scaleY = Mathf.Sin(Time.time) * 0.5f + 1;
    //    target.GetComponent<MeshRenderer>().material.mainTextureScale = new Vector2(scaleX, scaleY);
    //}
}
