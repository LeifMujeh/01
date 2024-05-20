List<Zombie> zombies = new List<Zombie>();
List<Dinosaurier> dinosauriers = new List<Dinosaurier>();

// number of dinos/zombies
int num = -1;
bool success = false;
while (success == false)
{
  Console.Write("Skriv antal zombies och dinosaurier per lag: ");
  string inputNum = Console.ReadLine();

  success = int.TryParse(inputNum, out num);

  if (success && num < 1)
  {
    success = false;
  }
}

// Create dinos & zombies
for (int i = 0; i < num; i++)
{
  Dinosaurier dino = new Dinosaurier();
  Zombie zombie = new Zombie();
  dinosauriers.Add(dino);
  zombies.Add(zombie);
}

// Type out the number of dinos/zombies
Console.WriteLine("Created " + dinosauriers.Count() + " dinosaurs.");
Console.WriteLine("Created " + zombies.Count() + " zombies.");

Console.ReadLine();