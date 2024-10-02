# 15 Exceptions

## 15.1 Indeksering 
Betragt følgende kode:

        int iterationer = 10;
        int[] array = { 1, 2, 3, 4, 5 };
        // increment
        for (int i = 0 ; i < iterationer ; i++)
        {
        array[i]++;
        }
        // print
        for (int i = 0 ; i < array.Length ; i++)
        {
        Console.WriteLine(array[i]);
        }
I denne øvelse skal du:
    1. Oversæt og udfør ovenstående kode.
    2. Hvilken exception bliver kastet?
    3. Hvad forårsager at denne exception bliver kastet?
    4. Brug en try-catch konstruktion til at skippe de iterationer der kaster denne exception.
    5. Er dette den korrekte løsning på problemet, og hvorfor?

## 15.2 Kontoer
Betragt følgende kode:

        int[] accounts = { 903, 716, 67 };
        int GetAccountNumber()
        {
        Console.WriteLine("Enter an account number: ");
        return Convert.ToInt32(Console.ReadLine());
        }
        void PrintAccountState(int accountId)
        {
        Console.WriteLine("Account " + accountId + " contains " + accounts[accountId]);
        }
        while (true)
        {
        int accountId = GetAccountNumber();
        PrintAccountState(accountId);
        }
Funktionen Convert.ToInt32 konverterer den string som Console.ReadLine returnerer til en int.

I denne øvelse har følgende delopgaver:
    1. Hvad sker der hvis man giver dette programmet “3” som input?
    2. Lav en udgave af koden der ved hjælp af exception handling i while-loopet gør programmet robust over for dette input.
    3. Hvad sker der hvis man giver dette programmet “to” som input?
    4. Lav en udgave af koden der ved hjælp af exception handling gør programmet robust over for denne type input. 
    Hvor er det rigtige sted at udføre denne exception handling?

## 15.3 Gennemsnitlig Karakter
På mange uddannelsessteder udregnes en studerendes gennemsnitlige karakter udelukkende ud fra de beståede karakterer. 
I denne øvelse skal vi se på hvordan dette kunne implementeres.

I denne øvelse skal du:
    1. Lave et nyt program via en klasse der hedder AvgGradeError.
    2. I denne fil erklæres en int[] variabel kaldet grades og denne initialiseres til at indeholde karaktererne 4, 7, 02, 00, 10, 4, og 12.
    3. Dernæst erklæres der i samme fil en GetGrade funktion, der tager en int some parameter og returnerer en int. 
       Parameteren gives navnet courseid.
    4. I kroppen på denne metode udtrækkes – ved indeksering – først en værdi fra courseid positionen af grades. 
       Denne gemmes i en grade variabel af typen int. Hvis karakteren er bestået returneres denne. 
       Ellers kastes der en exception.
    5. Slutteligt skrives hovedprogrammet, der er opdelt i tre dele:
       * (a) Initialisering Der erklæres to variable af typen int kaldet count og sum.
       * (b) Udregning Gennemløb alle indexer (kald dem courseid) fra grades med et for-loop (der ikke hardcoder antallet19). 
         For hvert courseid kaldes GetGrade. Sørg for at netop de kald der ikke resulterer i en exception, 
         resulterer i at (i) count bliver inkrementeret, og (ii) at sum bliver forøget med returværdien.
       * (c) Udprint Gennemsnittet (sum/count) udregnes og printes ud til brugeren.
    6. Verificer at koden virker korrekt.
