using System;

namespace ITDEV110_Ass2
{
	class MainClass
	{
		public static void Main (string[] args) {
			var name = "Splitty";
			Console.WriteLine ("Char\tHex\tOct\tBin");
			foreach (var c in name)
				Console.WriteLine ("{0:2}\t0x{1:X2}\t{2:000}h\tb{3}", c, (byte)c, Convert.ToString (c, 8), Convert.ToString (c, 2));
			Console.Read ();
		}
	}
}
