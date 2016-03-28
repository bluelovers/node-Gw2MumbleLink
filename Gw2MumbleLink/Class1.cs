using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.InteropServices;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Gw2MumbleLink
{
    public class Class1
    {

	}

	// Number of inches per meter
	const float InchesPerMeter = 39.37010F;

	//
	static MemoryMappedFile mappedFile;
	static MemoryMappedViewAccessor accessor;
	static LinkedMem data = new LinkedMem();
	static PlayerInfo playerInfo = new PlayerInfo();

	public unsafe struct LinkedMem
	{
		public uint uiVersion;
		public uint uiTick;
		public fixed float fAvatarPosition[3];
		public fixed float fAvatarFront[3];
		public fixed float fAvatarTop[3];
		public fixed byte name[512];
		public fixed float fCameraPosition[3];
		public fixed float fCameraFront[3];
		public fixed float fCameraTop[3];
		public fixed byte identity[512];
		public uint context_len;
		public fixed byte context[512];
		public fixed byte description[4096];
	};

	public class PlayerInfo
	{
		public float x, y, z = 0;
		public int map = 0;
		public string identity = "";
		public double camRotationX = 0;
		public double camRotationY = 0;
		public double playerRotationX = 0;
		public double playerRotationY = 0;
	}

	private static class GlobalVars
	{
		public static int currentMap = 0;
		public static int mLeft;
		public static int mTop;
		public static int mWidth;
		public static int mHeight;
		public static int cLeft;
		public static int cTop;
		public static int cWidth;
		public static int cHeight;
		public static float playerPosX;
		public static float playerPosY;
		public static string json;
		public static string mapName = "";
	}

	class Coordinate
	{
		public string posX { get; set; }
		public string posY { get; set; }
		public string camRotation { get; set; }
		public string playerRotation { get; set; }
		public string mapName { get; set; }
	}
}
}
