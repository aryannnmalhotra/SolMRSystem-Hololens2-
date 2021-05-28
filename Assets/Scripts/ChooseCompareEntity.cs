using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCompareEntity : MonoBehaviour
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
        InteractivityInstance.PositionToRenderAt = InteractivityInstance.GetCurrentEntity().transform.position + FirstPersonCamera.transform.right * (((InteractivityInstance.GetCurrentEntity().transform.localScale.x + Sun.transform.localScale.x) / 2) + 1.5f);
        InteractivityInstance.RenderEntity(Sun);
        float offset = ((((InteractivityInstance.GetCurrentEntity().transform.localScale.x + Sun.transform.localScale.x) / 2) + 1.5f) / 2);
        InteractivityInstance.GetCurrentEntity().transform.position -= FirstPersonCamera.transform.right * offset;
        InteractivityInstance.GetCompareEntity().transform.position += FirstPersonCamera.transform.right * offset;
    }
    public void PickMercury()
    {
        InteractivityInstance.PositionToRenderAt = InteractivityInstance.GetCurrentEntity().transform.position + FirstPersonCamera.transform.right * (((InteractivityInstance.GetCurrentEntity().transform.localScale.x + Mercury.transform.localScale.x) / 2) + 1.5f);
        InteractivityInstance.RenderEntity(Mercury);
        float offset = ((((InteractivityInstance.GetCurrentEntity().transform.localScale.x + Mercury.transform.localScale.x) / 2) + 1.5f) / 2);
        InteractivityInstance.GetCompareEntity().transform.position += FirstPersonCamera.transform.right * offset;
    }
    public void PickVenus()
    {
        InteractivityInstance.PositionToRenderAt = InteractivityInstance.GetCurrentEntity().transform.position + FirstPersonCamera.transform.right * (((InteractivityInstance.GetCurrentEntity().transform.localScale.x + Venus.transform.localScale.x) / 2) + 1.5f);
        InteractivityInstance.RenderEntity(Venus);
        float offset = ((((InteractivityInstance.GetCurrentEntity().transform.localScale.x + Venus.transform.localScale.x) / 2) + 1.5f) / 2);
        InteractivityInstance.GetCurrentEntity().transform.position -= FirstPersonCamera.transform.right * offset;
        InteractivityInstance.GetCompareEntity().transform.position += FirstPersonCamera.transform.right * offset;
    }
    public void PickEarth()
    {
        InteractivityInstance.PositionToRenderAt = InteractivityInstance.GetCurrentEntity().transform.position + FirstPersonCamera.transform.right * (((InteractivityInstance.GetCurrentEntity().transform.localScale.x + Earth.transform.localScale.x) / 2) + 1.5f);
        InteractivityInstance.RenderEntity(Earth);
        float offset = ((((InteractivityInstance.GetCurrentEntity().transform.localScale.x + Earth.transform.localScale.x) / 2) + 1.5f) / 2);
        InteractivityInstance.GetCurrentEntity().transform.position -= FirstPersonCamera.transform.right * offset;
        InteractivityInstance.GetCompareEntity().transform.position += FirstPersonCamera.transform.right * offset;
    }
    public void PickMars()
    {
        InteractivityInstance.PositionToRenderAt = InteractivityInstance.GetCurrentEntity().transform.position + FirstPersonCamera.transform.right * (((InteractivityInstance.GetCurrentEntity().transform.localScale.x + Mars.transform.localScale.x) / 2) + 1.5f);
        InteractivityInstance.RenderEntity(Mars);
        float offset = ((((InteractivityInstance.GetCurrentEntity().transform.localScale.x + Mars.transform.localScale.x) / 2) + 1.5f) / 2);
        InteractivityInstance.GetCurrentEntity().transform.position -= FirstPersonCamera.transform.right * offset;
        InteractivityInstance.GetCompareEntity().transform.position += FirstPersonCamera.transform.right * offset;
    }
    public void PickSaturn()
    {
        InteractivityInstance.PositionToRenderAt = InteractivityInstance.GetCurrentEntity().transform.position + FirstPersonCamera.transform.right * (((InteractivityInstance.GetCurrentEntity().transform.localScale.x + Saturn.transform.localScale.x) / 2) + 1.5f);
        InteractivityInstance.RenderEntity(Saturn);
        float offset = ((((InteractivityInstance.GetCurrentEntity().transform.localScale.x + Saturn.transform.localScale.x) / 2) + 1.5f) / 2);
        InteractivityInstance.GetCurrentEntity().transform.position -= FirstPersonCamera.transform.right * offset;
        InteractivityInstance.GetCompareEntity().transform.position += FirstPersonCamera.transform.right * offset;
    }
    public void PickJupiter()
    {
        InteractivityInstance.PositionToRenderAt = InteractivityInstance.GetCurrentEntity().transform.position + FirstPersonCamera.transform.right * (((InteractivityInstance.GetCurrentEntity().transform.localScale.x + Jupiter.transform.localScale.x) / 2) + 1.5f);
        InteractivityInstance.RenderEntity(Jupiter);
        float offset = ((((InteractivityInstance.GetCurrentEntity().transform.localScale.x + Jupiter.transform.localScale.x) / 2) + 1.5f) / 2);
        InteractivityInstance.GetCurrentEntity().transform.position -= FirstPersonCamera.transform.right * offset;
        InteractivityInstance.GetCompareEntity().transform.position += FirstPersonCamera.transform.right * offset;
    }
    public void PickUranus()
    {
        InteractivityInstance.PositionToRenderAt = InteractivityInstance.GetCurrentEntity().transform.position + FirstPersonCamera.transform.right * (((InteractivityInstance.GetCurrentEntity().transform.localScale.x + Uranus.transform.localScale.x) / 2) + 1.5f);
        Debug.Log((((InteractivityInstance.GetCurrentEntity().transform.localScale.x + Uranus.transform.localScale.x) / 2) + 1.5f));
        InteractivityInstance.RenderEntity(Uranus);
        float offset = ((((InteractivityInstance.GetCurrentEntity().transform.localScale.x + Uranus.transform.localScale.x) / 2) + 1.5f) / 2);
        InteractivityInstance.GetCurrentEntity().transform.position -= FirstPersonCamera.transform.right * offset;
        InteractivityInstance.GetCompareEntity().transform.position += FirstPersonCamera.transform.right * offset;
    }
    public void PickNeptune()
    {
        InteractivityInstance.PositionToRenderAt = InteractivityInstance.GetCurrentEntity().transform.position + FirstPersonCamera.transform.right * (((InteractivityInstance.GetCurrentEntity().transform.localScale.x + Neptune.transform.localScale.x) / 2) + 1.5f);
        InteractivityInstance.RenderEntity(Neptune);
        float offset = ((((InteractivityInstance.GetCurrentEntity().transform.localScale.x + Neptune.transform.localScale.x) / 2) + 1.5f) / 2);
        InteractivityInstance.GetCurrentEntity().transform.position -= FirstPersonCamera.transform.right * offset;
        InteractivityInstance.GetCompareEntity().transform.position += FirstPersonCamera.transform.right * offset;
    }
}
