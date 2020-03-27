using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using XInputDotNetPure;

public class XInput : MonoBehaviour
{
    [SerializeField] private float Vibration1;
    [SerializeField] private float Vibration2;
    [SerializeField] Slider sliderOne;
    [SerializeField] Slider sliderTwo;
    [SerializeField] TextMeshProUGUI ControllerText;


    bool playerIndexSet = false;
    PlayerIndex playerIndex;
    GamePadState state;
    GamePadState prevState;
    


    private void FixedUpdate()
    {
        GamePad.SetVibration(playerIndex, sliderOne.value, sliderTwo.value);

        if (!playerIndexSet || !prevState.IsConnected)
        {
            for (int i = 0; i < 4; ++i)
            {
                PlayerIndex testPlayerIndex = (PlayerIndex)i;
                GamePadState testState = GamePad.GetState(testPlayerIndex);
                if (testState.IsConnected)
                { 
                    Debug.Log(string.Format("GamePad found {0}", testPlayerIndex));
                    playerIndex = testPlayerIndex;
                    playerIndexSet = true;
                }
            }
        }
        if (GamePad.GetState(playerIndex).IsConnected)
        {
            ControllerText.text = "Controller is Connected";
        }
        else
        {
            ControllerText.text = "No Controller Detected";
        }
    }
}
