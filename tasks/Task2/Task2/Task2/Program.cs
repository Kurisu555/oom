using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Song R_as_randome = new Song("Amaranthe", "Mechanical Illusion", 1);

            Console.WriteLine(R_as_randome.GetTitleAndInterpreter());
            Console.WriteLine(R_as_randome.GetPlayOutput());
            R_as_randome.PressPlayButton();
            Console.WriteLine(R_as_randome.GetPlayOutput());
            R_as_randome.PressPlayButton();
            Console.WriteLine(R_as_randome.GetPlayOutput());

        }
    }

    public class Song
    {
        private String title;
        private String interpreter;
        public int PlaceNumber;
        public bool play = true;

        public int PlaceN
        {
            get => PlaceN;
            set => PlaceNumber = value;
        }


        public Song(String title, String interpreter, int PlaceNumber = 0)
        {
            this.title = title;
            this.interpreter = interpreter;
            PlaceN = PlaceNumber;
        }

        /*public void SetPlaceNumber(int PlaceNumber)
        {
            this.PlaceNumber = PlaceNumber;
        }*/

        public String GetTitleAndInterpreter()
        {
            return title + " - " + interpreter + "at place Number" + PlaceNumber;
        }

        public void PressPlayButton()
        {
            if (play == false) play = true;
            else play = false;
        }
        public String GetPlayOutput()
        {
            if (play == false) return "stop";
            return "play";
        }
    }
    
}
