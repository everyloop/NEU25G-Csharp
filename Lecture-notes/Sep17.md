# September 17

## Binära och hexdecimala talsystemen

Ett positionssystem är ett sätt att skriva tal där en siffers värde bestäms av dess plats, eller position, i talet. Till skillnad från till exempel det romerska talsystemet, där ett tals värde är enbart bestämt av de ingående symbolerna, ändras värdet på en siffra i ett positionssystem beroende på var den står.

### Hur ett positionssystem fungerar:
**Bas:** Varje positionssystem har en bas, som är lika med antalet siffror som används i systemet. I tiosystemet är basen 10, eftersom vi har 10 siffror (0-9). 

**Platsvärde:** Siffrornas position bestämmer deras värde. I tiosystemet representerar varje position ett visst värde, som är tio gånger större än platsen till höger om den. 

När en siffra har gått igenom alla dess tillåtna värden (t.ex. 0-9 i tiosystemet), "varvar" systemet och siffran på nästa position till vänster ökar. 

### Binärt och hexadecimalt

Eftersom datorer är uppbyggda med transistorer - en slags strömbrytare som kan representera två olika värden - så använder man det binära talsystemet för att representera dessa värden och bilda tal.

Det binära talsystem har basen 2 och endast sifforna 0 och 1.

I dator- och programmeringssammanhang använder man också ofta det hexadecimala talsystem, eftersom detta ger en mer kompakt representation av talen, samtidigt som det är enkelt att omvandla till och från binärt. Varje hexadecimalt tecken representerar ett 4 bitars tal, och man kan alltså dela in längre binära tal i grupper om 4 bitar och översätta dessa individuellt till en hexadecimal siffra.

![Positionssystem](https://github.com/everyloop/NEU25G-Csharp/blob/master/Lecture-notes/Images/PositionalNumberSystems.png)

## Enheter och prefix

Den minsta enheten - en etta eller noll - kalla för **bit** (**B**inary dig**it**). En annan vanlig enhet är **byte** som är en grupp om 8 bitar.

Därutöver använder man SI-prefixen för att bilda större enheter. T.ex är en kilobyte (kB) 1000 byte, eller 8000 bitar.

![Prefix](https://github.com/everyloop/NEU25G-Csharp/blob/master/Lecture-notes/Images/Prefixes.png)

## Numeriska datatyper

### Heltal (integers)

Heltal kan vara antingen "unsigned" (endast positiva heltal) eller "signed" (plus och minus). För att representera negativa tal används [tvåkomplementsmetoden](https://en.wikipedia.org/wiki/Two%27s_complement).

### Bråktal

Klassiskt finns två sätt att representera bråktal: **fixed point** och **floating point** (flyttal). I moderna system används dock nästan uteslutande flyttal.

### Fixed point
**Fast position:** Antalet siffror före och efter kommatecknet är bestämt och ändras inte.

**Enkelhet:** En enklare representation som kan vara snabbare för vissa operationer, men begränsad i precision och räckvidd.

**Användning:** Användbart när talen har en förutsägbar storlek och precision.

### Flyttal
**Variabel position:** Kommatecknet "flyttas", vilket gör att antalet siffror före och efter kommatecknet kan variera. 

**Större räckvidd och precision:** Kan representera både mycket stora och mycket små tal, men med en varierad noggrannhet. 

**Användning:** Standard för de flesta decimaltal inom programmering (t.ex. float), särskilt när talens storlek kan variera mycket. 

![Numeriska datatyper](https://github.com/everyloop/NEU25G-Csharp/blob/master/Lecture-notes/Images/NumericalDataTypes.png)

## ASCII och Unicode

ASCII (American Standard Code for Information Interchange) och Unicode är teckenkodningssystem. ASCII är en äldre, enklare standard som ursprungligen bara stödde engelska tecken, medan Unicode är en universell, modern standard som kan representera tecken från alla världens språk, inklusive symboler och emojis. Unicode är den bredare och mer flexibla standarden som används i dag för att hantera text på en global skala. 

### ASCII
**Begränsat antal tecken:** Stödde ursprungligen enbart upp till 128 tecken (7 bitar) för engelska alfabetsbokstäver, siffror och grundläggande skiljetecken, även om en utökad version på 256 tecken (8 bitar) också finns.

**Historisk betydelse:** Användes för elektronisk kommunikation och tidiga datorsystem. 

**Begränsad användning:** Kan inte representera tecken från andra språk än engelska, vilket är en stor nackdel i en globaliserad värld. 

![ASCII](https://github.com/everyloop/NEU25G-Csharp/blob/master/Lecture-notes/Images/ASCII.png)

### Unicode
**Universell teckenkodning:** En global standard som är utformad för att representera alla tecken, symboler och emojis som används i alla språk. 

**Stort teckenurval:** Omfattar hundratusentals tecken och fortsätter att utökas. 

**Flexibla kodningsformat:** Använder olika enkodningar, som UTF-8, UTF-16 och UTF-32, för att representera dessa tecken. 

**Modern standard:** Används i modern datorkommunikation och programspråk som Java och för webbdata för att garantera kompatibilitet över olika plattformar och språk. 

**Ökad minnesanvändning:** Eftersom den stöder så många tecken kräver Unicode mer lagringsutrymme per tecken jämfört med ASCII. 

![Unicode](https://github.com/everyloop/NEU25G-Csharp/blob/master/Lecture-notes/Images/Unicode.png)
