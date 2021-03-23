using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basic_events : MonoBehaviour ,IMixedRealityPointerHandler
{
    public void Proba()
    {
        Debug.Log("Gomb megnyomva");
        GameObject cube = GameObject.Find("Teglalap");
        var cubeRenderer = cube.GetComponent<Renderer>();
        cubeRenderer.material.color = Color.white;
    }
    public void OnPointerClicked(MixedRealityPointerEventData eventData)
    {
        Debug.Log("OnPointerClicked");
    }

    public void OnPointerDown(MixedRealityPointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }

    public void OnPointerDragged(MixedRealityPointerEventData eventData)
    {
        //Debug.Log("OnPointerDragged");
    }

    public void OnPointerUp(MixedRealityPointerEventData eventData)
    {
        Debug.Log("OnPointerUp");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
