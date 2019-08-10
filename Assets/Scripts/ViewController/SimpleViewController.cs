using Guido.Arkesteijn.DeepLink.Runtime;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngineObject = UnityEngine.Object;

public static class SimpleViewController
{
    public class Data
    {
        public string Identifier { get; private set; }
        public GameObject ScreenObject { get; private set; }
        public bool HasPayload { get { return Payload != null; } }
        public Dictionary<string, object> Payload { get; private set; }

        public Data(string identifier, GameObject screenObject, Dictionary<string, object> payload)
        {
            Identifier = identifier;
            ScreenObject = screenObject;
            Payload = payload;
        }
    }
    
    private static ViewControllerSettings viewControllerSettings;

    private static List<Data> screens = new List<Data>();
    private static int depth = 0;

    [RuntimeInitializeOnLoadMethod]
    static void Main()
    {
        DeepLink.Initialize();

        new GameObject("Event System", typeof(EventSystem), typeof(StandaloneInputModule));

        GameObject cameraObject = new GameObject("Background Camera");
        cameraObject.AddComponent<SimpleViewControllerInput>();
        Camera camera = cameraObject.AddComponent<Camera>();
        camera.clearFlags = CameraClearFlags.Color;
        camera.backgroundColor = Color.black;

        viewControllerSettings = Resources.Load<ViewControllerSettings>("ViewControllerSettings") as ViewControllerSettings;

        ViewControllerSettingsData data = viewControllerSettings.GetStartPointData();
        LoadView(data);
    }

    public static void LoadView(ViewControllerSettingsData data)
    {
        LoadView(data, null);
    }

    public static void LoadMain()
    {
        ViewControllerSettingsData data = viewControllerSettings.GetDataForID("MAIN");

        UnloadAllViews();
        LoadView(data);
    }

    public static void LoadCompany()
    {
        LoadCompany(null);
    }

    public static void LoadCompany(Dictionary<string, object> payload)
    {
        ViewControllerSettingsData data = viewControllerSettings.GetDataForID("COMPANY");
        LoadView(data, payload);
    }

    public static void LoadProduct()
    {
        LoadProduct(null);
    }

    public static void LoadProduct(Dictionary<string,object> payload)
    {
        ViewControllerSettingsData data = viewControllerSettings.GetDataForID("PRODUCT");
        LoadView(data, payload);
    }

    public static void LoadView(ViewControllerSettingsData data, Dictionary<string, object> payload)
    {
        if(data != null)
        {
            GameObject prefab = Resources.Load<GameObject>(data.ResourcePath);

            if(prefab != null)
            {
                GameObject go = UnityEngineObject.Instantiate(prefab, Vector3.back * depth, Quaternion.identity);

                foreach (var item in go.GetComponentsInChildren<Camera>())
                {
                    item.depth = depth;
                }

                depth++;

                IView view = go.GetComponent<IView>();
                view.Setup(payload);

                screens.Add(new Data(data.ID, go, payload));
            }
        }
    }

    public static void UnloadTopView()
    {
        if(screens.Count > 1)
        {
            Data data = screens[screens.Count - 1];

            UnityEngineObject.Destroy(data.ScreenObject);

            depth--;

            screens.Remove(data);
        }
        else
        {
            Application.Quit();
        }
    }

    public static void UnloadAllViews()
    {
        for (int i = screens.Count - 1; i >= 0; i--)
        {
            Data data = screens[i];
            UnityEngineObject.Destroy(data.ScreenObject);
        }

        screens.Clear();
        depth = 0;
    }
}
