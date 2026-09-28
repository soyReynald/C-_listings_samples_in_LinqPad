<Query Kind="Program" />

void Main()
{
	
	Console.WriteLine("Welcome to your Agenda \n");

	string[] agenda_contacts = {"None (+1 949 443905)", "Pae (+1 949 443905)", "Lei (+1 949 443905)", "Shu (+1 949 443905)"};
	
	for (int i = 0; i < agenda_contacts.GetLength(0); i++){
		Console.WriteLine(agenda_contacts[i]);
	}
	
}
