using System;
using Newtonsoft.Json;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            SmartPhone[] PhoneListOne = new SmartPhone[] {
                new IPhone("0123", "Kurisu", "Karma helps ya"),
                new Android("A0123"),
                new IPhone("4567", "AppleUser", "Apple forever"),
            };

            Serialize(PhoneListOne);
            Deserialize();
        }
        public static void Serialize(SmartPhone[] toSerialize)
        {
            string path = Directory.GetCurrentDirectory()+"/de_serialize.json";
            if (File.Exists(path))
            {
                string text = "";
                foreach(var element in toSerialize)
                {
                    text += JsonConvert.SerializeObject(element);
                }
                File.WriteAllText(path, text);
            }
            else Console.WriteLine("File existiert nicht");
        }
        public static void Deserialize()
        {
            string path = Directory.GetCurrentDirectory() + "/de_serialize.json";
            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                string help = "";
                for (int i = 0; i < text.Length; i++)
                { 
                    help += text[i];
                    if (text[i] == '}')
                    {
                        SmartPhone OutPut = JsonConvert.DeserializeObject<SmartPhone>(help);
                        Console.WriteLine(OutPut.ToString());
                        Console.WriteLine(OutPut.TurnOnOff);
                        help = "";
                    }
                }
            }
            else Console.WriteLine("Fehler bei der Ausgabe");
        }
    }

    interface IEDevice
    {
        string TurnOnOff { get; }
    }

    class SmartPhone : IEDevice
    {
        private bool onof = false;

        public void GetStatus()
        {
            if (onof) onof = false;
            else onof = true;
        }

        public string TurnOnOff
        {
            get
            {
                GetStatus();

                if (onof)
                {
                    return "Willkomen";
                }
                return "Wiedersehen";
            }
        }
    }
    class IPhone : SmartPhone
    {
        private string IPhoneNumber;
        public string NickName;
        public string SayIng;

        public IPhone(string IPhoneNumber, string UserNickName, string UserSayIng)
        {
            this.IPhoneNumber = IPhoneNumber;
            NickN = UserNickName;
            SayI = UserSayIng;
        }
        public string IPhoneN
        {
            get => IPhoneNumber;
        }
        public string NickN
        {
            set => NickName = value;
            get => NickName;
        }
        public string SayI
        {
            set => SayIng = value;
            get => SayIng;
        }
        public string WelcomeDisc()
        {
            return NickN + "\n" + SayIng;
        }
    }
    class Android : SmartPhone
    {
        private string SerialNumber;
        public string LogoPath;

        public Android(string SerialNumber, string LogoPath = "")
        {
            SETSerialN = SerialNumber;
            if (LogoPath == "") LogoP = "default Logo";
        }

        public string GETSerialN
        {
            get => SerialNumber;
        }
        private string SETSerialN
        {
            set => SerialNumber = value;
        }

        public string LogoP
        {
            get => LogoPath;
            set => LogoPath = value;
        }
    }
}
