using System;
using System.Reflection.Metadata;
using System.Security;

namespace _16._05._2020csharpabstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Redactor redactor = new Redactor("test.txt");
            redactor.Open();
            redactor.Edit();
            redactor.Save();
        }
    }

    abstract class AbsrtractHandler
    {
        public abstract void Save();
        public abstract void Open();
        public abstract void Edit();


        protected string name;
        public  AbsrtractHandler(string name)
        {
            this.name = name;
        }
    }

    class XMLHandler : AbsrtractHandler
    {
        public XMLHandler(string name) :base(name){}

       
        public override void Edit()
        {
            Console.WriteLine($"{name}XML file edited");
        }

        public override void Open()
        {
            Console.WriteLine($"{name}XML file opened");
        }

        public override void Save( )
        {
            Console.WriteLine($"{name}XML file saved");
        }
    }

    class TXTHandler : AbsrtractHandler
    {
        public TXTHandler(string name) : base(name) { }

        public override void Edit()
        {
            Console.WriteLine($"{name}TXT file edited");
        }

        public override void Open()
        {
            Console.WriteLine($"{name}TXT file opened");
        }

        public override void Save( )
        {
            Console.WriteLine($"{name}TXT file saved");
        }
    }
    class HTMLHandler : AbsrtractHandler
    {
        public HTMLHandler(string name) : base(name) { }

        public override void Edit()
        {
            Console.WriteLine($"{name}HTML file edited");
        }

        public override void Open()
        {
            Console.WriteLine($"{name}HTML file opened");
        }

        public override void Save( )
        {
            Console.WriteLine($"{name}HTML file saved");
        }
    }

    class Redactor
    {
        string str="";
        string name = "";

        AbsrtractHandler handler;
        public Redactor(string filename)
        {
            str = filename.Substring(filename.IndexOf('.') + 1);
            name= filename.Substring(0,filename.IndexOf('.') + 1);
            switch (str)
            {
                case "txt":
                    handler = new TXTHandler(name);
                    break;
                case "html":
                    handler = new HTMLHandler(name);
                    break;
                case "xml":
                    handler = new XMLHandler(name);
                    break;
                default:
                    break;
            }
        }

        public void Open()
        {
            handler.Open();
        }

        public void Save()
        {
            handler.Save();
        }

        public void Edit()
        {
            handler.Edit();
        }
    }












    //abstract class  Operator
    // {
    //     public abstract void IncreaseBalance();
    //}

    // class Azercell : Operator
    // {
    //     public override void IncreaseBalance()
    //     {
    //         Console.WriteLine("Azercell increase");
    //     }
    // }

    // class Bakcell : Operator
    // {
    //     public override void IncreaseBalance()
    //     {
    //         Console.WriteLine("Bakcell increase");
    //     }
    // }
}
