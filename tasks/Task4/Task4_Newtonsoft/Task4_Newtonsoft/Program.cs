using System;
using Newtonsoft.Json;

namespace Task3
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

            foreach (var p in PhoneListOne)
            {
                Console.WriteLine(p.TurnOnOff);

                //if (p is IPhone) Console.WriteLine("Oh it is a IPhone");
                //else Console.WriteLine("Oh it's just another cheap Android");

                // Wollte den Teil mit Newtonsoft nicht auslassen 
                // habe aber keinen anderen Ausweg gefunden als diesen hier

                string s = JsonConvert.SerializeObject(p);

                var deserialize = JsonConvert.DeserializeObject(s);
                Console.WriteLine(deserialize);
            }
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

        public SmartPhone()
        {
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
