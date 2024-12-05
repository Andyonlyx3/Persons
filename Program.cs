namespace Persons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Erstelle ein Programm in dem ein User seinen Namen angeben kann
            //Erstelle zudem eine Klasse Person mit den Feldern Name Alter und Beruf
            //Die Klasse hat zudem zwei Methoden, einmal die Methode <Begruessung> die den User mit seinem Namen begrüsst und sich selbst vorstellt.
            //Die zweite Methode heißt <Infos> und gibt im Format Name: ... Alter: ... Beruf: ... die Information über das jeweilige Objekt aus (Person)
            //Erstelle aus der Klasse Person zwei Objekte und befülle die Felder.
            //Erstelle dann ein Menü, wo man auf jedes Objekt zugreifen kann und die Methoden von diesen Objekten ausführen kann. 


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Bitte geben sie ihren namen ein: ");
            string userName = Console.ReadLine();
            Console.Clear();

            Person person1 = new Person("Andy", 29, "Sattler");
            Person person2 = new Person("Vanessa", 31, "Nurse");

            while (true)
            {
                Console.WriteLine("Menü:");
                Console.WriteLine("1. Andy");
                Console.WriteLine("2. Vanessa");
                Console.WriteLine("3. Programm beenden");
                Console.Write("Bitte wähle 1, 2 oder 3: ");
                string auswahl = Console.ReadLine().Trim();

                if (auswahl == "1")
                {
                    person1.Begruessung(userName);
                    person1.Infos();
                    break;
                }
                else if (auswahl == "2")
                {
                    person2.Begruessung(userName);
                    person2.Infos();
                    break;
                }
                else if (auswahl == "3")
                {
                    Console.WriteLine("Schönen Tag noch, bis zum nächsten Mal.");
                    return;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Die Eingabe war ungültig!\n");
                }

            }
        }
    }
}
