// See https://aka.ms/new-console-template for more information
//while looppia toistetaan niin kauan kuin ehto on voimassa
//kysellään lukuja kunnes käyttäjä antaa luvun nolla
//sitten tulostetaan annettujen lukujen summa


int number=1;
int sum=0;
/*
while(number != 0){
    Console.WriteLine("Anna luku ");
    number=int.Parse(Console.ReadLine());
    sum = sum+number;
}
Console.WriteLine("Antamiesi lukujen summa = "+sum);
*/

//ilmoitetaan myös kuinka monta lukua annettiin
int counter=0;
while(number != 0){
    Console.WriteLine("Anna luku ");
    number=int.Parse(Console.ReadLine());
    sum = sum+number;
    //counter = counter+1;
    counter++;
}
counter--; //ei lasketa nollaa mukaan
Console.WriteLine("Annoit "+counter+" lukua ja niiden summa="+sum);
//lasketaan keskiarvo annetuille luvuille
float average = (float)sum/(float)counter;
Console.WriteLine("Lukujen keskiarvo = "+average);
Console.WriteLine("Lukujen keskiarvo = "+Math.Round(average,2));
Console.WriteLine("Luvun 4 neliöjuuri on "+Math.Sqrt(4));
//Math on .NETin sisältämä luokka.
//Koska se on staattinen luokka siitä ei tarvitse luoda oliota.