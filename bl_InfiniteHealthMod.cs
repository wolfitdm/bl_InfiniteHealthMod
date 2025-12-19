using Den.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Mono.Security.X509.X520;
using static UnityEngine.Rendering.VolumeComponent;

namespace BitchLand//must have this namespace
{
	class bl_InifiniteHealthModDoWork 
	{
		public bl_InifiniteHealthModDoWork() 
		{ 
		}
		
		public void OnEnable()
		{
			Main.Instance.Player.NoEnergyLoss = true;
			Main.Instance.Player.CantBeHit = true;
		}

        public void OnDisable()
        {
            Main.Instance.Player.NoEnergyLoss = false;
            Main.Instance.Player.CantBeHit = false;
        }

		public void OnStart()
		{
		}

        public static bl_InifiniteHealthModDoWork Instance = new bl_InifiniteHealthModDoWork();
    }

	public class Mod//must have this class name
	{
		public static bl_InifiniteHealthMod ThisMod;

		public static void Init() //must have this name, and MUST be static
		{
			ThisMod = Main.Instance.gameObject.AddComponent<bl_InifiniteHealthMod>();
		}



		public static void EnableMod(bool value)
		{
			if(value)
			{//mod was enabled in the settings
				bl_InifiniteHealthModDoWork.Instance.OnEnable();
            }
			else
			{
				bl_InifiniteHealthModDoWork.Instance.OnDisable();
			}
		}
	}

	public class bl_InifiniteHealthMod : MonoBehaviour
	{
		public void Start()
		{
            bl_InifiniteHealthModDoWork.Instance.OnStart();
        }

	}
}

