using System;

namespace Task4
{
    class Program
    {
        /*static void Main(string[] args)
        {

            SmartPhone[] PhoneListOne = new SmartPhone[] {
                new IPhone(123, "Kurisu", "Karma helps ya"),
                new Android(123),
                new IPhone(4567, "AppleUser", "Apple forever"),
            };

            foreach (var p in PhoneListOne)
            {
                Console.WriteLine(p.TurnOnOff);

                if (p is IPhone) Console.WriteLine("Oh it is a IPhone");
                else Console.WriteLine("Oh it's just another cheap Android");
            }
        }/*
        static void Main()
        {
            
        }*/
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
        private int IPhoneNumber;
        public string NickName;
        public string SayIng;

        public IPhone(int IPhoneNumber, string UserNickName, string UserSayIng)
        {
            this.IPhoneNumber = IPhoneNumber;
            NickN = UserNickName;
            SayI = UserSayIng;
        }
        public int IPhoneN
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
        private int SerialNumber;
        public string LogoPath;

        public Android(int SerialNumber, string LogoPath = "")
        {
            SETSerialN = SerialNumber;
            if (LogoPath == "") LogoP = "default Logo";
        }

        public int GETSerialN
        {
            get => SerialNumber;
        }
        private int SETSerialN
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
