
using DesingPatterns.Behavior.Observer.Interface;


namespace DesingPatterns.Behavior.Observer
{
    public class Comunication : IObserver
    {
        public Comunication(string notice)
        {
            Notice = notice;
        }

        public string Notice { get; set; }

        public void Update(ISubject subject)
        {
            int cont = 1;
            if (subject is Reception productReception)
            {
                Console.WriteLine("\n======================================");
                Console.WriteLine(
                    string.Format(
                        "Comunicado ao setor  : {0}  " +
                        "Notificação : {1} "
                        , productReception.Sector
                        , Notice)                    
                 );
                cont++;
            }
        }
    }
}
