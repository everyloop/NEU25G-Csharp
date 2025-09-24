
// Namespaces används för att organisera klasser och andra definitioner i olika områden/"mappar".
// Detta används för att namnen inte ska krocka, och för att organisera sin kod.

// Jämför med hur mappar används i filsystemet för att organiser filer, och för att filnamn inte ska krocka.

// Using används högst upp i filer för att ange vilka namespace som används i filen.
using MyNamespace.MyOtherNamespace;
// using MyNamespace;  // <= Om denna också används har vi två klasser "Car" i olika namespaces som krockar.

// Utan using behöver man skriva hela "sökvägen":
MyNamespace.MyOtherNamespace.Car.Engine = string.Empty;

// ... men eftersom vi använder using MyNamespace.MyOtherNamespace; ovan så räcker:
Car.Engine = string.Empty;

// File scoped name space - Det vanliga i modern C#; anger namespace för allt innehåll i filen.
// namespace MyNameSpace;

// Block scoped names space;
namespace MyNamespace
{
    class Car
    {
        public static string Model;
    }

    // En name space kan ligga i en annan name space, men gör det inte med denna syntax (nästlade block) ...
    namespace MyOtherNamespace
    { 
        class Boat
        {

        }
    }
}

// ... utan på detta sättet; Både Boat ovan och klassen Car nedan ligger i samma namespace: MyNamespace.MyOtherNamespace
namespace MyNamespace.MyOtherNamespace
{
    class Car
    {
        public static string Engine;
    }
}
