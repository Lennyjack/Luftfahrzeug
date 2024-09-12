namespace Luftfahrzeug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Hangar h = new Hangar("Hangar A51","Genf");

                Flugzeug f = new Flugzeug("Airbus", 2012, 80.0)
                {
                    Power = new Motor("Düsenjet", "Airbus")
                };

                h.Luftfahrzeug.Add(f);


                //List<Luftfahrzeug> Ruedi = new List<Luftfahrzeug>();
                
                //Hangar GenferFlugplatz = new Hangar("Rüedis Hangar", "Genf");


                //Flugzeug Boeing9090 = new Flugzeug("Gustavson", 1990, 90);
                //Boeing9090.Power.Gewicht = 2000;
                //Boeing9090.Power.Leistung = 50;
                //Boeing9090.Power.Hersteller = "BMW";
                //Boeing9090.Power.Name = "Das Flugwerk";


                //Zeppelin Dreamparadise = new Zeppelin();
                //Dreamparadise.Power.Gewicht = 290;

                //Console.WriteLine(Boeing9090.Power);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
