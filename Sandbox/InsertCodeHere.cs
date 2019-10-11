using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            //Opgave 1 Types and variables 
            //see page 21 i C# noten
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Opgave 1  \n\n");
            Console.WriteLine("-------------------------------------");
            //Erklær en variabel, SongTitle, der kan indeholde en sangtitel
            // Tildel den en santitel
            

            //Erklær en variabel, songDurationInSek, der kan indeholde længden af et album i sekunder
            // Giv den værdien 240

            //Erklær en variabel, albumDuration, der kan anvendes til at registrere om en sang har været spillet
            // giv den værdien 16000

            //Erklær en variabel, recommeded, der kan anvendes til at registrere om en sang anbefalet
            // Giv den værdien false

            //Erklær variabel, songPrice, der kan indeholde prisen på en sang uden moms
            // Giv den værdien 8.5
            // Intet at udskrive

            // Opgave 2 Arithmetic
            // see page 25
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\n\n Opgave 2  \n\n");
            Console.WriteLine("-------------------------------------");
            
            //Lav en beregning af hvor mange procent (heltal) sangen udgør af hele albummet og gem resutatet i en variabel, songPercentageOfAlbumInt. Udskriv resultatet
            

            //Lav en beregning af hvor mange procent (decimaltal) sangen udgør af hele albummet og gem resutatet i en variabel, songPercentageOfAlbumDouble. Udskriv resultatet med to decimaler

            
            
            //Beregn momsen på en sang. Gem resultatet i en variabel songTax og skriv den ud med to decimaler
            

            // Opgave 3
            // logik s.33
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\n\n Opgave 3  \n\n");
            Console.WriteLine("-------------------------------------");

            // Hvis sangen ikke er anbefalet og den varer mindre end 4 minutter 
            // eller at det gælder at sangen udgør under 10 procent af albummet 
            // så skal der udskrives, at der er et særligt tilbud "Special offer - reduced price" 
            // og prisen reduceres med 20 % 

            


            // Opgave 4
            // Funktioner s. 36 - 38 + 68 -69
            // Lav følgende funktioner i klassen SongCalculation 
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\n\n Opgave 4  \n\n");
            Console.WriteLine("-------------------------------------");

            // Lav en static funktion songTax i klassen SongCalculation der kan returnere den beregnede moms
            

            // lav en static funktion, SongAmountDiscount. Der skal beregnes den samlede pris på en bestilling af en sang. 
            // Parameterne til funktionen er SongPrice og antal bestillinger
            // Et kald af funktionen kan se således ud.
            // double discount4 = SongCalculation.SongAmountDiscount(songPrice, 4);
            // Hvis der bestillet mere end 5 gives der 5 % rabat
            // Hvis der bestilles mere end 10 gives der 12 % rabat
            // Hvis der bestilles mere 20 gives der 50% rabat
            // Udskriv rabatten efterfølgende efter kald af funktionen med henholdsvis bestillinger på 4, 8, 12 og 30 eksemplarer af sangen
            // Lav to udgaver af funktionen. En der anvender if-sætninger og en der anvender switch

            

            // Opgave 5
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\n\n Opgave 5  \n\n");
            Console.WriteLine("-------------------------------------");
            // S 48 - 67 i C# noten
            // Færdigør klassen Animal
            // Lav properties for Age, TypeName og Sound (lyd som dyret siger)
            // Lav  konstruktør, der initialiserer properties med parametere til at initialisere alle properties
            // Lav en metode der hedder, AllInformation, som returnerer en tekststreng, som indeholder værdierne af alle properties

            // Opgave 6
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\n\n Opgave 6  \n\n");
            Console.WriteLine("-------------------------------------");
            // Lav et array som kan indeholde 5 objekter af klassen Animal
           


            // Repetition s.79-84 + datastructures s. 88 - 
            // Lav en forløkke som løber arrayet igennem og beregner den samlede alder
            // den samlede alder skal udskrives
            


            // Lav en  løkke som løber arrayet igennem bagfra og udskrivet AllInformation om alle dyrene
            

            // Lav en While løkke som løber arrayet igennem og finder det animal animal objekt, som har den højeste alder
            // Efterfølgende skal den højeste alder udskrives
            


            // Opgave 7
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\n\n Opgave 7 \n\n");
            Console.WriteLine("-------------------------------------");
            // List s. 93 - 99
            // Lav en datastruktur af typen List,animalList, som kan indeholde objekter af typen Animal
            // Tilføj 5 objekter
            



            // Lav en foreach løkke og skriv alle dyrens lyde ud
            


            // Fjern det tredje dyr fra listen
            


            // Dictionary s. 97 -99
            // Lav en datastruktur Dictionary, animalDictionary, som kan gemme dyrene udfra deres lyde
            

            //Tilføj alle dyrene til Dictionary
            //Det antages, at hver art af dyrene har en unik lyd

            

            // Udskriv alle keys i Dictionariet 
            


            // Udskriv alle values i Dictionariet. TypeName skal udskrives
            


            //Tilføj 3 nye Animals til Listen, animalList, på henholdsvis den første plads, den anden plads og sidste plads i listen
            

            // Iterer (gennemløb) gennem animalList og udskriv de animals, som ikke i forvejen eksisterer i animalDictionary
            // Anvend animalDictionary til at checke om deres lyd eksisterer i forvejen
            // Det antages at lyden er unik

            

            // Opgave 8
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\n\n Opgave 8 \n\n");
            Console.WriteLine("-------------------------------------");
            // Arv og polymorfi
            // Lav to subklasser til Animal klassen, Horse og Whale
            // Horse skal have en property, CanTrot. Implementer klassen
            // Whale skal have en property, HaveFlippers. Implementer klassen.
            // Override metoden AllInformation fra Animal klassen i klasserne Horse og Whale. 
            // Tilføj information om HaveFlippers og CanTrot når returnerer information om klassen
            // Lav en ny liste der kan indeholde Animal objekter, listPolymorphism, og tilføj 3 Whale objekter og 2 Horse objekter og 2 Animal Objekter.

            // Gennemløb listen og kald metoden AllInformation og udskriv teksten
            // Udskrives den rigtige information?

            

            

            // The LAST line of code should be ABOVE this line
        }
    }
}