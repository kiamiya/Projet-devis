using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevisFacile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour et bienvenue dans l'éditeur de devis de Lordi33.\r\n");
            Console.WriteLine("Pour commencer, préférez vous un ordinateur\r\n-Apple?\r\n-Windows?");
            string PCouMAC = Console.ReadLine().ToLower();
            switch (PCouMAC)
            {
                case "apple": Console.WriteLine("Affinnons le choix vers Apple\r\n");
                    APPLE(); //renvoi a la fonction apple
                    break;

                case "windows": Console.WriteLine("Affinnons le choix vers Windows");
                    PC(); // renvoi a la fonction pc
                    break;
            }
            Console.Read();
//-----------------------------------------------------------------------------MAC--------------------------------------------------------------------------------------------------
        }
        static private void APPLE() //fonction apple

        {
            Console.WriteLine("Désirez-vous un ordinateur\r\n-Fix\r\n-Portable");
            string FixPotableMAC = Console.ReadLine().ToLower();
            switch (FixPotableMAC)
            {
                case "fix": Console.WriteLine("Regardons les IMac de plus près");
                    macfix();
                    break;
            

                case "portable": Console.WriteLine("Regardons les portables chez Apple");
                    Console.WriteLine("Il existe 4 tailles de Portable chez Apple :\r\n-11,6'\r\n-12'\r\n-13,6'\r\n-15'");
                    string MacbookSize = Console.ReadLine().ToLower();
                    switch (MacbookSize)
                    {
                        case "11,6": Console.WriteLine();
                            break;
                        case "12": Console.WriteLine();
                            break;
                        case "13,6": Console.WriteLine();
                            break;
                        case "15": Console.WriteLine();
                            break;
                    }

                    break;
            }
        }
        //------------------------------------------------------------------------IMAC-------------------------------------------------------------------------------//
            static private void macfix()

        {
            Console.WriteLine("Il existe 2 tailles d'écran pour les Mac : \r\n-21,5'\r\nou\r\n-27'\r\nQue désirez-vous?");
            string taillemac = Console.ReadLine();
            switch (taillemac)
            {
                case "21,5" : mac21();
                    break;
                case "27": mac27();
                    break;
            }
        }
        static private void mac21()
        {
            Console.WriteLine("La version 21' existe en 2 modèles :\r\n-Normal\r\nou\r\n-Retina 4k\r\nQue désirez-vous?");
            string model21 = Console.ReadLine().ToLower();
            switch (model21)
            {
                case "normal": procnormal();
                    break;
                case "retina 4k": proc21retina();
                    break;
            }
        }
        
        //---------------------------------------------------------Processeur IMac------------------------------------------------------
        static private void procnormal()
        {
            Console.WriteLine("Ce modèle existe avec 2 processeurs différents :\r\n-i5 1,6Ghz\r\nou\r\n-i5 2,8Ghz\r\nMerci d'indiquer uniquement le chiffre des Ghz\r\nex: 1,6 pour le processeur i5 1,6GHz");
            string procmac1 = Console.ReadLine().ToLower();
            switch (procmac1)
            {
                case "1,6": RAMmaclow1();
                    break;
                case "2,8": RAMmaclow2();
                    break;
            }
            
        }
        static private void proc21retina()
        {
            Console.WriteLine("Ce modèle existe avec 2 processeurs différents:\r\n- i5 3,1Ghz\r\nou\r\n- i7 3,3Ghz\r\nMerci d'indiquer uniquement le chiffre des Ghz\r\nex: 3,1 pour le processeur i5 3,1GHz");
            string procmac2 = Console.ReadLine().ToLower();
            switch (procmac2)
            {
                case "3,1": RAMmacMed();
                    break;
                case "3,3": RAMmacMed();
                    break;
            }
        }
        static private void mac27()
        {
            Console.WriteLine("Ce modèle existe avec 3 processeurs différents:\r\n- i5 3,2Ghz\r\n\r\nou\r\n-i5 3,3GHzou\r\n- i7 4,0Ghz\r\nMerci d'indiquer uniquement le chiffre des Ghz\r\nex: 3,2 pour le processeur i5 3,2GHz");
            string procmac3 = Console.ReadLine().ToLower();
            switch (procmac3)
            {
                case "3,2": RAMmacHigh1();
                    break;
                case "3,3": RAMmacHigh2();
                    break;
                case "4,0": RAMmacHigh3();
                    break;
            }
        }
        //----------------------------------------------------------------RAM----------------------------------------------------------
        static private void RAMmaclow1()
        {
            Console.WriteLine("Il existe 2 capacités de RAM pour cette version:\r\n-8Go\r\nou\r\n-16Go");
            string RAMlow1 = Console.ReadLine().ToLower();
            switch (RAMlow1)
            {
                case "8go": Disquelow1();
                    break;
                case "16go": Disquelow1();
                    break;
            }
        }
        static private void RAMmaclow2()
        {
            Console.WriteLine("Il existe 2 capacités de RAM pour cette version:\r\n-8Go\r\nou\r\n-16Go");
            string RAMlow2 = Console.ReadLine().ToLower();
            switch (RAMlow2)
            {
                case "8go":
                    Disquelow2();
                    break;
                case "16go":
                    Disquelow2();
                    break;
            }
        }
        static private void RAMmacMed()
        {
            Console.WriteLine("Il existe 2 capacités de RAM pour cette version:\r\n-8Go\r\nou\r\n-16Go");
            string RAMmed = Console.ReadLine().ToLower();
            switch (RAMmed)
            {
                case "8go":
                    DisqueMed();
                    break;
                case "16go":
                    DisqueMed();
                    break;
            }
        }
       static private void RAMmacHigh1()
        {
            Console.WriteLine("Il existe 3 capacités de RAM pour cette version: \r\n- 8Go\r\n- 16Go\r\n- 32Go");
            string RAMhigh1 = Console.ReadLine().ToLower();
            switch (RAMhigh1)
            {
                case "8go": DisqueHigh();
                    break;
                case "16go": DisqueHigh();
                    break;
                case "32go": DisqueHigh();
                    break;
            }
        }
        static private void RAMmacHigh2()
        {
            Console.WriteLine("Il existe 3 capacités de RAM pour cette version: \r\n- 8Go\r\n- 16Go\r\n- 32Go");
            string RAMhigh1 = Console.ReadLine().ToLower();
            switch (RAMhigh1)
            {
                case "8go":
                    DisqueHigh();
                    break;
                case "16go":
                    DisqueHigh();
                    break;
                case "32go":
                    DisqueHigh();
                    break;
            }
        }
        static private void RAMmacHigh3()
        {
            Console.WriteLine("Il existe 3 capacités de RAM pour cette version: \r\n- 8Go\r\n- 16Go\r\n- 32Go");
            string RAMhigh1 = Console.ReadLine().ToLower();
            switch (RAMhigh1)
            {
                case "8go":
                    DisqueHigh();
                    break;
                case "16go":
                    DisqueHigh();
                    break;
                case "32go":
                    DisqueHigh();
                    break;
            }
        }
        //-------------------------------------------------------Disque dur MAC---------------------------------------------------------
        static private void Disquelow1()
        {
            Console.WriteLine("Apple propose 3 types de stockages différents : HDD, Fusion drive et SSD");
            Console.WriteLine("Disponible pour ce modèle : \r\n- 1To HDD\r\n- 1To Fusion drive\r\n- 256Go SSD");
            string hdlow1 = Console.ReadLine().ToLower();
            switch (hdlow1)
            {
                case "1to hdd": Console.WriteLine("Merci d'avoir utilisé l éditeur de devis de Lordi33 ! =)");
                    break;
                case "1to fusion drive": Console.WriteLine("Merci d'avoir utilisé l'éditeur de devis de Lordi33 !");
                    break;
                case "256go ssd": Console.WriteLine("Merci d'avoir utilisé l'éditeur de devis de Lordi33");
                    break;
            }

        }
        static private void Disquelow2()
        {
            Console.WriteLine("Apple propose 3 types de stockages différents : HDD, Fusion drive et SSD");
            Console.WriteLine("Disponible pour ce modèle : \r\n- 1To HDD\r\n- 1To Fusion drive\r\n- 2To Fusion drive\r\n- 256Go SSD");
            string hdlow2 = Console.ReadLine().ToLower();
            switch (hdlow2)
            {
                case "1to hdd":
                    Console.WriteLine("Merci d'avoir utilisé l éditeur de devis de Lordi33 ! =)");
                    break;
                case "1to fusion drive":
                    Console.WriteLine("Merci d'avoir utilisé l'éditeur de devis de Lordi33 ! =)");
                    break;
                case "2to fusion drive":Console.WriteLine("Merci d'avoir utilisé l'éditeur de devis de Lordi33 ! =)");
                    break;
                case "256go ssd":
                    Console.WriteLine("Merci d'avoir utilisé l'éditeur de devis de Lordi33 ! =)");
                    break;
            }

        }
        static private void DisqueMed()
        {
            Console.WriteLine("Apple propose 3 types de stockages différents : HDD, Fusion drive et SSD");
            Console.WriteLine("Disponible pour ce modèle : \r\n- 1To HDD\r\n- 1To Fusion drive\r\n- 2To Fusion drive\r\n- 256Go SSD\r\n- 512Go SSD");
            string hdmed = Console.ReadLine().ToLower();
            switch (hdmed)
            {
                case "1to hdd":
                    Console.WriteLine("Merci d'avoir utilisé l éditeur de devis de Lordi33 ! =)");
                    break;
                case "1to fusion drive":
                    Console.WriteLine("Merci d'avoir utilisé l'éditeur de devis de Lordi33 ! =)");
                    break;
                case "2to fusion drive":
                    Console.WriteLine("Merci d'avoir utilisé l'éditeur de devis de Lordi33 ! =)");
                    break;
                case "256go ssd":
                    Console.WriteLine("Merci d'avoir utilisé l'éditeur de devis de Lordi33 ! =)");
                    break;
                case "512go ssd":
                    Console.WriteLine("Merci d'avoir utilisé l'éditeur de devis de Lordi33 ! =)");
                    break;
            }
        }

        static private void DisqueHigh()
        {

        }
        //----------------------------------------------------------------PC---------------------------------------------------------------------------------//
        static private void PC()  //fonction pc
        {
            Console.WriteLine("Désirez vous un ordinateur\r\n-Fix\r\n-Portable");
            string FixPortablePC = Console.ReadLine().ToLower();
            switch (FixPortablePC)
            {

                case "fix": Console.WriteLine("Ca risque de se compliquer un peu avec les prochaines questions. Merci de laisser vide si vous ne savez pas quoi choisir.");
                    PCfix(); //renvoi a la fonction PC fix
                    break;
                case "portable": Console.WriteLine("Avez vous une marque de fabriquant préférée?");
                    PCport(); //renvoi fonction pc portable
                    break;

            }


        }

        static private void PCport() //fonction pc portable
        {
            Console.WriteLine("Vous avec le choix entre:\r\n-Asus\r\n-Acer\r\n-Toshiba\r\n-Sony\r\n-");
            string MarquePCport = Console.ReadLine().ToLower();
            switch (MarquePCport)
            {
                case "asus" : Console.WriteLine("Merci d'avoir choisi Asus");
            break;
                case "acer" : Console.WriteLine("Merci d'avoir choisi Acer");
            break;
                case "toshiba" : Console.WriteLine("Merci d'avoir choisi Toshiba");
            break;
                case "sony" : Console.WriteLine("Merci d'avoir choisi Sony");
            break;
           }
       }

        static private void PCfix() //fonction PC fix
        {
            Console.WriteLine("Un ordinateur fix est composé d'une tour (unitée centrale) d'un écran et d'un pack ckavier/souris.\r\nNous allons commencer par définir la tour, puis l'écran et enfin le clavier et la souris.");
            Console.WriteLine("Il y a 3 grands types de tours : \r\n-Petite (~x cm),\r\n-Moyenne (~x cm), \r\n-Grande (~x cm).\r\nFaites votre choix:");
            string tailletour = Console.ReadLine().ToLower();
            switch (tailletour)
            { 
                case "petite" : Console.WriteLine("regardons maintenant la carte mère qu'il vous faudra :");
                    small(); //renvoi fonction petite tour 
            break;
                case "moyenne" : Console.WriteLine("regardons maintenant la carte mère qu'il vous faudra :");
                    medium(); //renvoi la fonction tour moyenne
            break;
                case "grande" : Console.WriteLine("regardons maintenant la carte mère qu'il vous faudra :");
                    large(); // renvoi la fonction grande tour
            break; 
            } 
           
        }
        static private void small() //fonction petite tour A FAIRE
        {
            Console.WriteLine("Le format standard est le MicroATX");
        }
        static private void medium() //fonction tour moyenne A FAIRE
        { 
            Console.WriteLine("le format standard est ATX");
        }
        static private void large() // fonction grande tour A FAIRE
        {
            Console.WriteLine("peu importe la carte ca rentrera!");
        }

    }


}

