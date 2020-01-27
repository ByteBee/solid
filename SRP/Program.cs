using System;

namespace ByteBee.SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            BenutzerBegrüßen();

            Benutzer benutzer = NeuenBenutzerAbfragen();

            if (SindDieBenutzerdatenGültig(benutzer) == false)
            {
                AnwendungBeenden();
            }

            NeuenBenutzerSpeichern(benutzer);

            AnwendungBeenden();
        }

        static void BenutzerBegrüßen()
        {
            Console.WriteLine(" - BENUTZER ERSTELLEN -");
        }

        static Benutzer NeuenBenutzerAbfragen()
        {
            Benutzer benutzer = new Benutzer();
            benutzer.Vorname = VornameAbfragen();
            benutzer.Nachname = NachnameAbfragen();
            benutzer.Email = EmailAdressenGenerieren(benutzer.Vorname, benutzer.Nachname);
            benutzer.Passwort = ZufälligesPasswortGenerieren();

            return benutzer;
        }

        static string VornameAbfragen()
        {
            Console.Write("Vorname  : ");
            return Console.ReadLine();
        }

        static string NachnameAbfragen()
        {
            Console.Write("Nachname : ");
            return Console.ReadLine();
        }

        static bool SindDieBenutzerdatenGültig(Benutzer benutzer)
        {
            if (IstDerVornameGültig(benutzer.Vorname) == false)
            {
                return false;
            }

            if (IstDerNachnameGültig(benutzer.Nachname) == false)
            {
                return false;
            }

            return true;
        }


        static bool IstDerVornameGültig(string vorname)
        {
            if (string.IsNullOrWhiteSpace(vorname))
            {
                Console.WriteLine("Der eingegebene Vorname ist nicht gültig.");
                return false;
            }

            return true;
        }

        static bool IstDerNachnameGültig(string nachname)
        {
            if (string.IsNullOrWhiteSpace(nachname))
            {
                Console.WriteLine("Der eingegebene Nachname ist nicht gültig.");
                return false;
            }

            return true;
        }

        static string EmailAdressenGenerieren(string vorname, string nachname)
        {
            return $"{vorname}.{nachname}@acme.com";
        }

        static string ZufälligesPasswortGenerieren()
        {
            string gültigeZeichenFürPasswörter = "abcdefghijklmnopqrstuvwxyz0123456789";
            string passwort = "";
            var zufallszahlGenerator = new Random((int)DateTime.Now.Ticks);

            for (int i = 0; i < 8; i++)
            {
                int zufallszahl = zufallszahlGenerator.Next(gültigeZeichenFürPasswörter.Length);
                passwort += gültigeZeichenFürPasswörter[zufallszahl];
            }

            return passwort;
        }

        static void NeuenBenutzerSpeichern(Benutzer benutzer)
        {
            Console.WriteLine(" - NEUER BENUTZER WIRD ANGELEGT - ");

            Console.WriteLine($"Name     : {benutzer.Nachname}, {benutzer.Vorname}");
            Console.WriteLine($"E-Mail   : {benutzer.Email}");
            Console.WriteLine($"Passwort : {benutzer.Passwort}");
        }

        static void AnwendungBeenden()
        {
            Console.WriteLine("Anwendung mit einer beliebigen Taste beenden.");
            Console.Read();
            Environment.Exit(0);
        }

        class Benutzer
        {
            public string Vorname { get; set; }
            public string Nachname { get; set; }
            public string Email { get; set; }
            public string Passwort { get; set; }
        }
    }
}
