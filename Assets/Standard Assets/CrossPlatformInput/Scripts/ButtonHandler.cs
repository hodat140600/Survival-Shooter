using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityStandardAssets.CrossPlatformInput
{
    public class ButtonHandler : MonoBehaviour
    {

        public string Name = "Shoot";



        public void SetDownState()
        {
            CrossPlatformInputManager.SetButtonDown("Shoot");
        }


        public void SetUpState()
        {
            CrossPlatformInputManager.SetButtonUp("Shoot");
        }


        public void SetAxisPositiveState()
        {
            CrossPlatformInputManager.SetAxisPositive("Shoot");
        }


        public void SetAxisNeutralState()
        {
            CrossPlatformInputManager.SetAxisZero("Shoot");
        }


        public void SetAxisNegativeState()
        {
            CrossPlatformInputManager.SetAxisNegative("Shoot");
        }


    }
}
