namespace chorégraphie;

class Program
{
   static void Main(string[] args)
    {
        string[] moves =new string [32];

        int index = 0;

        bool done = false;


        while (!done)
        {

            Console.WriteLine("Entrez un pas de danse:");
            string saisieUtilisateur = Console.ReadLine();

            if (saisieUtilisateur == "done")
            {
                done = true;
            }

            else
            {

                if (index ==31)
                {
                    done = true;
                }
                else
                {


                    moves[index] = saisieUtilisateur;

                    index++;


                    Console.WriteLine("You " + moves[index]);

                }

               
                

            }

          

        }

        Console.WriteLine("You finished your danse!!");

       




    }
}

