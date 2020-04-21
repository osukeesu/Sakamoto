﻿using System;
using System.IO;
using System.Reflection;

namespace Sakamoto
{
	public static class Common
	{
		public static DateTime build_date = new FileInfo(Assembly.GetExecutingAssembly().Location).LastWriteTime;

		public static string bot_name = "Sakamoto";
		public static int bot_userid = 3;

		public static string osustring = "https://osu.ppy.sh/";
		public static string path_data = "Data";
		public static string path_beatmaps = Path.Combine(path_data, "Beatmaps");
		public static string path_replays = Path.Combine(path_data, "Replays");
	}
}