<Query Kind="Program" />

class Program {
	public struct Coordinate
	{
		public int _Longitude;
		public int _Latitude;
		
		public Coordinate (int longitude, int latitude) {
			_Longitude = longitude;
			_Latitude = latitude;
		}
		
		public override string ToString() => $"({_Longitude}, {_Latitude})";		
	}
	
	static void Main(string[] args) 
	{
		Coordinate point = new Coordinate (17, 68);
		Console.WriteLine($"Geographic range to Dominican Republic, Coordinate (s): {point}");
	}
}

// Define other methods and classes here
