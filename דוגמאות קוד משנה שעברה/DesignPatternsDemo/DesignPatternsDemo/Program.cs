using DesignPatternsDemo.Creational.AbstractFactory;
using DesignPatternsDemo.Creational.Builder;
using DesignPatternsDemo.Creational.Prototype;
using DesignPatternsDemo.StructuralPatterns.Adapter;
using DesignPatternsDemo.StructuralPatterns.Composite;
using DesignPatternsDemo.StructuralPatterns.Decorator;
using DesignPatternsDemo.StructuralPatterns.Facade;
using System;
using System.Collections.Generic;
using static System.Console;

namespace DesignPatternsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileManager manager = new FileManager();//unable to create an instance because there is no public ctor
            //manager.Search();

            //FileManager manager2 = new FileManager();
            FileManager fileManager = FileManager.GetInstance();
            fileManager.Search("abc");

            //Structural Design Patterns
            #region Adapter

            Computer comp = new Computer();
            //do many stuff with computer....

            List<IPlayable> playable = new List<IPlayable>();
            playable.Add(new Doll());
            playable.Add(new Bird());
            playable.Add(new ComputerAdapter(comp));

            foreach (var item in playable)
            {
                Console.WriteLine(item.Play());
            }

            #endregion

            #region Decorator

            Margarita margaritaPizza = new Margarita();
            OnionDecorator onionDecorator = new OnionDecorator(margaritaPizza);
            OliveDecorator oliveDecorator = new OliveDecorator(onionDecorator);
            OliveDecorator oliveDecorator2 = new OliveDecorator(oliveDecorator);

            Console.WriteLine($"your margarita pizza costs {margaritaPizza.GetCost()}");
            Console.WriteLine($"your special (onion) pizza costs {onionDecorator.GetCost()}");
            Console.WriteLine($"your special (onion, olive,olive) pizza costs {oliveDecorator2.GetCost()}");

            #endregion

            #region Facade

            TaxAuthorityFacade facade = new TaxAuthorityFacade();
            var refund = facade.GetRefundService();
            Console.WriteLine(refund.GetService());
            var report = facade.GetRetroReport();
            Console.WriteLine(report.GetService());
            //facade.GetRefundService()
            //facade.getIndependentService()
            //facade.Get

            #endregion Facade

            #region Composite

            FolderComponent folder = new FolderComponent("Base");
            folder.AddComponent(new FileComponent("image.jpg"));
            folder.AddComponent(new FileComponent("document.pdf"));
            FolderComponent subFolder = new FolderComponent("Studies");
            subFolder.AddComponent(new FileComponent("designPattern.jpg"));
            subFolder.AddComponent(new FileComponent("designPattern2.docx"));
            subFolder.AddComponent(new FileComponent("designPattern3.jpg"));
            folder.AddComponent(subFolder);
            folder.AddComponent(new FolderComponent("abc"));
            Console.WriteLine(folder.ShowDetails());

            #endregion Composite

            #region Abstract Factory

            WriteLine("Abstract Factory Sample");
            WriteLine("Enter Vintage or Modern");
            string? furnitureType = ReadLine();

            FurnitureFactory absFactory = null;
            switch (furnitureType)
            {
                case "Vintage": absFactory = new VintageFactory(); break;
                case "Modern": absFactory = new ModernFactory(); break;

            }
            //ask user how many chairs.....
            //add furniture base class for Chair and Sofa
            if (absFactory != null)
            {
                List<Furniture> furnitures = new List<Furniture>();
                for (int i = 0; i < 10; i++)
                {
                    furnitures.Add(absFactory.CreateChair());
                }
                furnitures.Add(absFactory.CreateSofa());
            }

            #endregion Abstract Factory

            #region Builder
            //while (true)
            //{
            Console.WriteLine("Enter Visa or MasterCard");
            string? cardType = ReadLine();
            ATMMachine? machine = new ATMMachine();
            //switch (cardType)
            //{
            //    case "Visa": machine = new ATMMachine(new VisaReportBuilder()); break;
            //    case "Isracard": machine = new ATMMachine(new IsracardReportBuilder()); break;
            //    case "MasterCard": machine = new ATMMachine(new MasterCardReportBuilder()); break;
            //}
            ReportBuilder builder = null;
            switch (cardType)
            {
                case "Visa": builder = new VisaReportBuilder(); break;
                //case "Isracard": builder = new IsracardReportBuilder(); break;
                case "MasterCard": builder = new MasterCardReportBuilder(); break;
            }
            if (builder != null)
            {
                WriteLine(machine.DisplayReport(builder, ""));
            }
            //}
            #endregion Builder

            #region Prototype

            Circle c = new Circle(10);
            Circle c2 = new Circle();
            //1.unable to copy private members
            //2. We need to knwo the concrete type - Circle, Triangle etc. - they become our dependencies

            IEnumerable<string> list = new List<string>();
            IEnumerable<string> queue = new Queue<string>();
            IEnumerable<string> arr = new string[3];

            Shape[] shapes = new Shape[3];
            Shape[] clonedShapes = new Shape[3];
            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i]?.Clone();
            }

            //Solution:
            //create interface\ abstract function, usually it will be called Clone
            //1. Clone will be inside the class - and inside the class we

            #endregion Prototype

            Console.ReadLine();
        }
    }
}
