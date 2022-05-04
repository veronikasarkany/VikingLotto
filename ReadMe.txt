## Készítsen egy konzolos és grafikus alkalmazást Java vagy C# nyelven, amellyel a skandináv
lottósorsolást szimulálja. A viking lottóban azonban hat számot kell eltalálni a 48-ból. Megoldását
töltse fel a classroomba!

## 1) A konzolos alkalmazás egy paraméterként kapott állomány adatait ellenőrzi és importálja egy 
adattáblába (teszt adatok: VikingLottoSzamok.csv). 

Az adathalmaz pontosvesszővel elválasztva UTF-8 kódolással tartalmazza az adatokat, azonban 
sérült, csak azokat a sorokat vegye figyelembe a feltöltésnél, amelyek hibátlanok, megfelelő számú
egész számot tartalmaznak és ezek a számok 1 és 48 között vannak!

VikingLottoSzamok.csv:
-3;6;8;15;25;27
200;18;24;30;31;32
abc;6;11;16;27;32;35
;;20;22;25;27
1;2;;;;;
2;7;18;30;31;34
13;18;22;23;24;26;31
5;12; ;25;28;29 

- 1) Hozzon létre egy Ön által választott adatbáziskezelő-rendszerben egy adatbázist és abban 
egy adattáblát, amely alkalmas az adatok tárolására.

- 2) Ha alkalmazás nem kapott parancssori indításkor paramétert, vagy a paraméterként 
megadott helyen és/vagy néven nem található állomány, tájékoztassa a helyes 
paraméterezés szintaktikájáról a felhasználót és fejezze be a futást.
- 3) Olvassa be az állományt, ellenőrizze a sorok tartalmát, amennyiben a beolvasott sor 
megfelelő végezze el az importálást az adattáblába.
- 4) Ha a program végzett a feladattal tájékoztassa a felhasználót a sikeresen importált 
rekordok számáról!

## 2) Készítsen asztali alkalmazást, amely a skandináv lottó sorsolás szimulációja. 


- 1) A program jelenítsen meg, ízlésesen, 48 jelölőnégyzetet és két gombot (Sorsol és Bezár).
- 2) A Bezár gomb megnyomására az alkalmazás lépjen ki.
- 3) A Sorsol gomb indításkor legyen inaktív.
- 4) A felhasználó hat számot választhat, biztosítsa, hogy nehogy hetet esetleg többet is 
bejelölhessen.
- 5) Ha mind a hat tippet megtette, akkor váljon aktívvá a Sorsol feliratú gomb.
- 6) A Sorsol gomb megnyomása esetén generáljon 1-és48 között hat számot (melyek között az
ismétlődés természetesen nem megengedett). 
- 7) A generált számokat mentse el abba az adattáblába, amelyet a konzolos alkalmazás hozott 
létre. (Ha a konzolos alkalmazást nem készítette el, a grafikus alkalmazás egy az Ön által 
választott adatbázis-kezelőrendszerben hozzon létre egy adatbázist és annak adattáblájába 
mentse el a sorsolt számokat!).
- 8) Tájékoztassa a felhasználót, hogy hány számot sikerült eltalálnia
