using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace OSUtoGMD {
	public class GMDBuilder {
		private string[] OSUFileLines;
		private string LevelName;
		private string? LevelData;
		private int SongID;

		/*
		 * 0 = Level Name
		 * 1 = Level Data
		 * 2 = Song ID
		 */
		private const string gmdFormat = "<d><k>kCEK</k><i>4</i><k>k2</k><s>{0}</s><k>k3</k><s></s><k>k4</k><s>{1}</s><k>k45</k><i>{2}</i><k>k13</k><t/><k>k21</k><i>2</i><k>k50</k><i>35</i></d>";
		private const string colorHeaders = "kS38,1_40_2_125_3_255_11_255_12_255_13_255_4_-1_6_1000_7_1_15_1_18_0_8_1|1_0_2_102_3_255_11_255_12_255_13_255_4_-1_6_1001_7_1_15_1_18_0_8_1|1_0_2_102_3_255_11_255_12_255_13_255_4_-1_6_1009_7_1_15_1_18_0_8_1|1_255_2_255_3_255_11_255_12_255_13_255_4_-1_6_1002_5_1_7_1_15_1_18_0_8_1|1_0_2_125_3_255_11_255_12_255_13_255_4_-1_6_1005_5_1_7_1_15_1_18_0_8_1|1_255_2_255_3_255_11_255_12_255_13_255_4_-1_6_1006_5_1_7_1_15_1_18_0_8_1|,kA14,";

		public GMDBuilder(string file, string levelName, int songID) {
			OSUFileLines = File.ReadAllLines(file);
			LevelName = levelName;
			SongID = songID;
		}

		public bool ProcessOSUFile() {
			bool success = false;
			StringBuilder s = new StringBuilder(colorHeaders);
			foreach (string line in OSUFileLines) {
				if(line.Contains("[HitObjects]")) {
					success = true;
					continue;
				}
				if(success) {
					string[] obj = line.Split(',');
					int type = 0;
					if(obj[4] != "0") {
						type = 1;
					}
					s.Append($"{double.Parse(obj[2]) / 1000}~{type}~");
				}
			}
			LevelData = s.ToString();
			return success;
		}
		
		public string GMDFile() {
			return string.Format(gmdFormat, LevelName, LevelData, SongID);
		}
		
	}
}
