using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseEntityMenu : MonoBehaviour
{
    public GameObject Sun;
    public GameObject Mercury;
    public GameObject Venus;
    public GameObject Earth;
    public GameObject Mars;
    public GameObject Jupiter;
    public GameObject Saturn;
    public GameObject Uranus;
    public GameObject Neptune;
    public Camera FirstPersonCamera;
    public Interactivity InteractivityInstance;
    public void PickSun()
    {
        InteractivityInstance.PositionToRenderAt = FirstPersonCamera.transform.position + (FirstPersonCamera.transform.forward * 16);
        InteractivityInstance.RenderEntity(Sun);
    }
    public void PickMercury()
    {
        InteractivityInstance.PositionToRenderAt = FirstPersonCamera.transform.position + (FirstPersonCamera.transform.forward * 2);
        InteractivityInstance.RenderEntity(Mercury);
    }
    public void PickVenus()
    {
        InteractivityInstance.PositionToRenderAt = FirstPersonCamera.transform.position + (FirstPersonCamera.transform.forward * 2);
        InteractivityInstance.RenderEntity(Venus);
    }
    public void PickEarth()
    {
        InteractivityInstance.PositionToRenderAt = FirstPersonCamera.transform.position + (FirstPersonCamera.transform.forward * 2);
        InteractivityInstance.RenderEntity(Earth);
    }
    public void PickMars()
    {
        InteractivityInstance.PositionToRenderAt = FirstPersonCamera.transform.position + (FirstPersonCamera.transform.forward * 2);
        InteractivityInstance.RenderEntity(Mars);
    }
    public void PickSaturn()
    {
        InteractivityInstance.PositionToRenderAt = FirstPersonCamera.transform.position + (FirstPersonCamera.transform.forward * 2);
        InteractivityInstance.RenderEntity(Saturn);
    }
    public void PickJupiter()
    {
        InteractivityInstance.PositionToRenderAt = FirstPersonCamera.transform.position + (FirstPersonCamera.transform.forward * 2);
        InteractivityInstance.RenderEntity(Jupiter);
    }
    public void PickUranus()
    {
        InteractivityInstance.PositionToRenderAt = FirstPersonCamera.transform.position + (FirstPersonCamera.transform.forward * 2);
        InteractivityInstance.RenderEntity(Uranus);
    }
    public void PickNeptune()
    {
        InteractivityInstance.PositionToRenderAt = FirstPersonCamera.transform.position + (FirstPersonCamera.transform.forward * 2);
        InteractivityInstance.RenderEntity(Neptune);
    }
    public void Reset()
    {
        InteractivityInstance.Reset();
    }
    public void Compare()
    {
        InteractivityInstance.CompareCall();
    }
}
