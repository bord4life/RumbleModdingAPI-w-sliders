//Is there more I can supply here?

using System.Numerics;
using Il2CppRUMBLE.Interactions.InteractionBase;
using Il2CppTMPro;
using Microsoft.VisualBasic;
using UnityEngine;

namespace RumbleModdingAPI.RMAPI
{
    public class Create
    {
        public static GameObject newTextGameObject;
        public static GameObject newButtonGameObject;
        public static GameObject newSwitchGameObject;
        public static GameObject newSliderGameObject;

        /// <summary>
        /// Creates and returns a new Text GameObject
        /// </summary>
        public static GameObject NewText()
        {
            GameObject newTextGO = GameObject.Instantiate(newTextGameObject);
            newTextGO.SetActive(true);
            newTextGO.GetComponent<TextMeshPro>().autoSizeTextContainer = true;
            return newTextGO;
        }

        /// <summary>
        /// Creates and returns a new Text GameObject with the specified Text, size, color, position, and rotation
        /// </summary>
        /// <param name="text"></param>
        /// <param name="textSize"></param>
        /// <param name="textColor"></param>
        /// <param name="textPosition"></param>
        /// <param name="textRotation"></param>
        public static GameObject NewText(string text, float textSize, Color textColor, Vector3 textPosition, Quaternion textRotation)
        {
            GameObject newTextGO = GameObject.Instantiate(newTextGameObject);
            newTextGO.SetActive(true);
            TextMeshPro tmp = newTextGO.GetComponent<TextMeshPro>();
            tmp.text = text;
            tmp.fontSize = textSize;
            tmp.color = textColor;
            tmp.autoSizeTextContainer = true;
            newTextGO.transform.position = textPosition;
            newTextGO.transform.rotation = textRotation;
            return newTextGO;
        }

        /// <summary>
        /// Creates and returns a new Button
        /// </summary>
        public static GameObject NewButton()
        {
            GameObject newButtonGO = GameObject.Instantiate(newButtonGameObject);
            newButtonGO.SetActive(true);
            return newButtonGO;
        }

        /// <summary>
        /// Creates and returns a new Button at the Specified Position/Rotation
        /// </summary>
        /// <param name="buttonPosition"></param>
        /// <param name="buttonRotation"></param>
        public static GameObject NewButton(Vector3 buttonPosition, Quaternion buttonRotation)
        {
            GameObject newButtonGO = GameObject.Instantiate(newButtonGameObject);
            newButtonGO.transform.position = buttonPosition;
            newButtonGO.transform.rotation = buttonRotation;
            newButtonGO.SetActive(true);
            return newButtonGO;
        }

        /// <summary>
        /// Creates and returns a new Button with a Listener of the supplied Action
        /// </summary>
        /// <param name="action"></param>
        public static GameObject NewButton(Action action)
        {
            GameObject newButtonGO = GameObject.Instantiate(newButtonGameObject);
            newButtonGO.SetActive(true);
            newButtonGO.transform.GetChild(0).gameObject.GetComponent<InteractionButton>().onPressed.AddListener(action);
            return newButtonGO;
        }

        /// <summary>
        /// Creates and returns a new Button at the Specified Position/Rotation with a Listener of the supplied Action
        /// </summary>
        /// <param name="buttonPosition"></param>
        /// <param name="buttonRotation"></param>
        /// <param name="action"></param>
        public static GameObject NewButton(Vector3 buttonPosition, Quaternion buttonRotation, Action action)
        {
            GameObject newButtonGO = GameObject.Instantiate(newButtonGameObject);
            newButtonGO.transform.position = buttonPosition;
            newButtonGO.transform.rotation = buttonRotation;
            newButtonGO.SetActive(true);
            newButtonGO.transform.GetChild(0).gameObject.GetComponent<InteractionButton>().onPressed.AddListener(action);
            return newButtonGO;
        }

        /// <summary>
        /// Creates and returns a new Switch
        /// </summary>
        public static GameObject NewSwitch()
        {
            GameObject newSwitchGO = GameObject.Instantiate(newSwitchGameObject);
            newSwitchGO.SetActive(true);
            newSwitchGO.GetChild(8).gameObject.GetComponent<InteractionSlider>().StepCount = 2;
            return newSwitchGO;
        }

        /// <summary>
        /// Creates and returns a new Switch at the Specified Position/Rotation
        /// </summary>
        /// <param name="switchPosition"></param>
        /// <param name="switchRotation"></param>
        public static GameObject NewSwitch(Vector3 switchPosition, Quaternion switchRotation)
        {
            GameObject newSwitchGO = GameObject.Instantiate(newSwitchGameObject);
            newSwitchGO.SetActive(true);
            newSwitchGO.GetChild(8).gameObject.GetComponent<InteractionSlider>().StepCount = 2;
            newSwitchGO.transform.position = switchPosition;
            newSwitchGO.transform.rotation = switchRotation;
            return newSwitchGO;
        }

        /// <summary>
        /// Creates and returns a new Switch with the Specified Step Count
        /// </summary>
        /// <param name="stepCount"></param>
        public static GameObject NewSwitch(int stepCount)
        {
            GameObject newSwitchGO = GameObject.Instantiate(newSwitchGameObject);
            newSwitchGO.SetActive(true);
            newSwitchGO.GetChild(8).gameObject.GetComponent<InteractionSlider>().StepCount = stepCount;
            return newSwitchGO;
        }

        /// <summary>
        /// Creates and returns a new Switch at the Specified Position/Rotation with the Specified Step Count
        /// </summary>
        /// <param name="switchPosition"></param>
        /// <param name="switchRotation"></param>
        /// <param name="stepCount"></param>
        public static GameObject NewSwitch(Vector3 switchPosition, Quaternion switchRotation, int stepCount)
        {
            GameObject newSwitchGO = GameObject.Instantiate(newSwitchGameObject);
            newSwitchGO.SetActive(true);
            newSwitchGO.GetChild(8).gameObject.GetComponent<InteractionSlider>().StepCount = stepCount;
            newSwitchGO.transform.position = switchPosition;
            newSwitchGO.transform.rotation = switchRotation;
            return newSwitchGO;
        }

        /// <summary>
        /// Creates and returns a new Slider
        /// </summary>
        public static GameObject NewSlider()
        {
            GameObject newSliderGO = GameObject.Instantiate(newSliderGameObject);
            newSliderGO.SetActive(true);
            newSliderGO.GetChild(7).gameObject.GetComponent<InteractionSlider>().StepCount = 2;
            return newSliderGO;
        }

        /// <summary>
        /// Creates and returns a new Slider at the Specified Position/Rotation
        /// </summary>
        /// <param name="sliderPosition"></param>
        /// <param name="sliderRotation"></param>
        public static GameObject NewSlider(Vector3 sliderPosition, Quaternion sliderRotation)
        {
            GameObject newSliderGO = GameObject.Instantiate(newSliderGameObject);
            newSliderGO.SetActive(true);
            newSliderGO.GetChild(7).gameObject.GetComponent<InteractionSlider>().StepCount = 2;
            newSliderGO.transform.position = sliderPosition;
            newSliderGO.transform.rotation = sliderRotation;
            return newSliderGO;
        }

        /// <summary>
        /// Creates and returns a new Slider with the Specified Step Count
        /// </summary>
        /// <param name="stepCount"></param>
        public static GameObject NewSlider(int stepCount)
        {
            GameObject newSliderGO = GameObject.Instantiate(newSliderGameObject);
            newSliderGO.SetActive(true);
            newSliderGO.GetChild(7).gameObject.GetComponent<InteractionSlider>().StepCount = stepCount;
            return newSliderGO;
        }

        /// <summary>
        /// Creates and returns a new Slider at the Specified Position/Rotation with the Specified Step Count
        /// </summary>
        /// <param name="sliderPosition"></param>
        /// <param name="sliderRotation"></param>
        /// <param name="stepCount"></param>
        public static GameObject NewSlider(Vector3 sliderPosition, Quaternion sliderRotation, int stepCount)
        {
            GameObject newSliderGO = GameObject.Instantiate(newSliderGameObject);
            newSliderGO.SetActive(true);
            newSliderGO.GetChild(7).gameObject.GetComponent<InteractionSlider>().StepCount = stepCount;
            newSliderGO.transform.position = sliderPosition;
            newSliderGO.transform.rotation = sliderRotation;
            return newSliderGO;
        }

        internal static void SetupAPIItems()
        {
            if (RumbleModdingAPI.parentAPIItems == null)
            {
                RumbleModdingAPI.parentAPIItems = new GameObject();
                RumbleModdingAPI.parentAPIItems.name = "APIItems";
                GameObject.DontDestroyOnLoad(RumbleModdingAPI.parentAPIItems);
            }
            if (newTextGameObject == null)
            {
                newTextGameObject = GameObject.Instantiate(RMAPI.GameObjects.Gym.INTERACTABLES.Leaderboard.PlayerTags.HighscoreTag.Nr.GetGameObject());
                TextMeshPro tmp = RMAPI.Create.newTextGameObject.GetComponent<TextMeshPro>();
                newTextGameObject.name = "NewTextGameObject";
                tmp.text = "new Text";
                tmp.color = Color.black;
                newTextGameObject.SetActive(false);
                newTextGameObject.transform.parent = RumbleModdingAPI.parentAPIItems.transform;
            }
            if (newButtonGameObject == null)
            {
                newButtonGameObject = GameObject.Instantiate(RMAPI.GameObjects.Gym.TUTORIAL.Statictutorials.RUMBLEStarterGuide.NextPageButton.InteractionButton.GetGameObject());
                newButtonGameObject.name = "newButton";
                newButtonGameObject.SetActive(false);
                newButtonGameObject.transform.parent = RumbleModdingAPI.parentAPIItems.transform;
            }
            if (newSwitchGameObject == null)
            {
                newSwitchGameObject = GameObject.Instanstiate(GameObjects.Gym.INTERACTABLES.MenuSlab.Content.Input.StickMovementSetting.Slider.GetGameObject());
                newSwitchGameObject.name = "newSwitch";
                newSwitchGameObject.SetActive(false);
                newSwitchGameObject.transform.parent = RumbleModdingAPI.parentAPIItems.transform
            }
            if (newSliderGameObject == null)
            {
                newSliderGameObject = GameObject.Instanstiate(GameObjects.Gym.INTERACTABLES.MenuSlab.SideBlock.PageSelectionSlider.GetGameObject());
                newSliderGameObject.name = "newSlider";
                newSliderGameObject.SetActive(false);
                newSliderGameObject.transform.parent = RumbleModdingAPI.parentAPIItems.transform
            }
        }
    }
}
