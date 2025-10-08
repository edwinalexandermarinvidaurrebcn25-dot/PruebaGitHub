Console.WriteLine("Nombre de la nave");
string nave = Console.ReadLine();
Console.WriteLine("Velocidad de la nave");
float velocity = float.Parse(Console.ReadLine());
Console.WriteLine("Tiempo de viaje");
float time = float.Parse(Console.ReadLine());
Console.WriteLine("Combustible disponible");
float combustible = float.Parse(Console.ReadLine());
Console.WriteLine("Consumo por segundo (l/s)");
float consumo = float.Parse(Console.ReadLine());
Console.WriteLine("Consumo por tripulante (l/s)");
float consumoTripulante = float.Parse(Console.ReadLine());
Console.WriteLine("Numero de tripulantes");
int tripulantes = int.Parse(Console.ReadLine());

//Cálculos

float distance = velocity * time;
bool missionDistance = distance >= 1000;
float naveConsumo = time * consumo;
float tripulantesConsumo = tripulantes * consumoTripulante * time;
float combustibleFinal = combustible - naveConsumo - tripulantesConsumo;
bool quedaCombustible = combustibleFinal >= 1000;
bool missionCompletada = missionDistance && quedaCombustible;

//Output
                                Console.WriteLine("-----------------");
                                Console.WriteLine("Nave: " + nave);
                                Console.WriteLine("Distancia Recorrida: " + distance);
Console.WriteLine("Ha recorrido la distancia necesaria? " + missionDistance);
Console.WriteLine("Nos queda combustible para la colonia? " + quedaCombustible);
Console.WriteLine("Mision completada: " + missionCompletada);