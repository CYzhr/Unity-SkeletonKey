﻿using UnityEngine;

namespace Payload.MonoScript
{
    public class InjectedMonoManager : MonoBehaviour
    {
        public static new GameObject gameObject { get; private set; }

        private void Awake()
        {
            gameObject = base.gameObject;

            gameObject.AddComponent<Console>();
            gameObject.AddComponent<Statistic>();
            gameObject.AddComponent<TransformMover>();
            //gameObject.AddComponent<InjectAssetBundle>();

            RefreshCamScript();
        }

        private void RefreshCamScript()
        {
            if (!Camera.main.gameObject.GetComponent<FreeMainCamera>())
                Camera.main.gameObject.AddComponent<FreeMainCamera>();


            if (!Camera.main.gameObject.GetComponent<TriggerDrawer>())
                Camera.main.gameObject.AddComponent<TriggerDrawer>();

            Invoke("RefreshCamScript", 3f);
        }
        
    }
}
