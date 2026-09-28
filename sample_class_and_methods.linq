<Query Kind="Program" />

class ServiceStatus 
{
  int stage = 1;
  string description = "Sample name of a game";

  static void Main(string[] args)
  {
    ServiceStatus status = new ServiceStatus();
	if (status.stage == 1) {
    	Console.WriteLine(status.description);
	}
  }
}
// Define other methods and classes here
