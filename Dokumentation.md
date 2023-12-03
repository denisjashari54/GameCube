# Projekt-Dokumentation

Angelov, Bajramovic, Jashari, Marku

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|15.09.2023 |	0.0.1	| Kickoff-Meeting und Einführung in das Projekt. Ideen für Spielmenü gesammelt. |
|22.09.2023 |	0.0.2 |	Entscheidung für die Entwicklung von Tic Tac Toe und Hangman in C#. Beginn der Programmierung von Tic Tac Toe. Erste Tests der Benutzereingabe.  |
|29.08.2023 |	0.0.3 |	Implementierung des Hangman-Spiels begonnen. Design des Spielmenüs erstellt. |
|06.10.2023	| 0.0.4	| Tic Tac Toe: Logik für Gewinnerkennung implementiert. Hangman: Wortgenerator implementiert. |
|13.10.2023 | 0.0.5	| Die Integration der beiden Spiele in das gemeinsame Menü wurde erfolgreich umgesetzt, und die Entwicklung an den Spielen selbst wurde kontinuierlich vorangetrieben.|
|20.10.2023 |	0.0.6	| Die beiden Spiele wurden fertig programmiert.   |
|27.10.2023	| 0.0.7 |	Verfeinerung der Benutzerinteraktionen für beide Spiele und Verbesserung des Menüdesigns. |
|03.11.2023 | 1.0.0 | Abschluss der Entwicklung, finale Tests durchgeführt. Projektdokumentation finalisiert. |

## 1 Informieren

### 1.1 Ihr Projekt

Wir werden ein Spiel Menü mit den beiden <Spielen Tic Tac To und Hangmann programmieren in c#

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
|Hangmann |
| 1    |       muss          |  Funktional    | Als ein User möchte ich, ein Wort generiert bekommen. |
| 2    |       muss          |  Funktional    | Als ein User möchte ich, eine Option erhalten ein Buchstabe einzugeben. |
| 3    |       muss          |  Funktional    | Als ein User möchte ich sehen, ob dieser Buchstabe im Wort vorkommt oder nicht. |
| 4    |       muss          |  Funktional    | Als ein User möchte ich, dass falls es im Wort vorkommt ich sehe wo. |
| 5    |       muss          |  Funktional    | Als ein User möchte ich sehen, wie viele versuche ich noch besitze. |
| 6    |       muss          |  Funktional    | Als ein User möchte ich, eine Siegesnachricht erhallten, sobald ich das Wort erraten habe. |
| 7    |       muss          |  Funktional    | Als ein User möchte ich, eine Nachricht erhallten, wenn cih eine Fehleingabe eingegeben habe. |
| 8    |       muss          |  Funktional    | Als ein User möchte ich, die Option erhallten nochmals zu spielen |
| 9    |       muss          |  Funktional    | Als ein User möchte ich, die Option erhallten zurück zum Game Menu zu gehen. |
|Tic Tac Toe |
| 10    |       muss          |  Funktional    | Als ein User möchte ich, die Möglichkeit erhallten mit einem/einer Freund/in abwechslungsweise ein Zeichen in ein Feld einzugeben |
| 11    |       muss          |  Funktional    | Als ein User möchte ich, dass wenn jemand gewonnen hat eine Siegesnachricht erhallten. |
| 12    |       muss          |  Funktional    | Als ein User möchte ich, eine Nachricht erhallten, wenn ich eine Fehleingabe eingegeben habe. |
| 13    |       muss          |  Funktional    | Als ein User möchte ich, die Option erhallten nochmals zu spielen |
| 14    |       muss          |  Funktional    | Als ein User möchte ich, die Option erhallten zurück zum Game Menu zu gehen. |
| Game Menü |
| 15   |       muss          |  Funktional    | Als ein User möchte ich, die Option erhallten eines der beiden Spiele auszuwählen. |
| 16   |       muss          |  Funktional    | Als ein User möchte ich, die Option erhallten, dass Programm zu beenden |


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |   Im Game Menu        |     Hangamann    |      -             |
| 2.1  |     Im Game Hangmann         |   -        |       "Eingabefeld"            |
| 3.1  |       Im Game Hangmann       |     "Buchstabe"    |     Ist im Wort drin /nicht drin.              |
| 4.1  |        Im Game Hangmann      |    "Buchstabe"     |     Wo im Wort es vorkommt.              |
| 5.1  |       Im Game Hangmann          |    -     |        (Bsp. 5 veruche übrig)           |
| 6.1  |     Im Game Hangmann            |   "Buchstabe"      |       "Das korrekte Wort wurde rechtzeitig erraten!!"            |
| 7.1  |     Im Game Hangmann            |    (Bsp. #,¢,@)     |     "Ihre eingabe ish ungültig geben sie nur Buchstaben ein!!"              |
| 8.1  |        "Das korrekte Wort wurde rechtzeitig erraten!!"          |    -     |         "Möchten Sie nochmals spielen/zurück zum Game Menu?"          |
| 9.1  |       "Das korrekte Wort wurde rechtzeitig erraten!!"         |    -     |         "Möchten Sie nochmals spielen/zurück zum Game Menu?"           |
| 10.1  |    Im Game Tic Tac To          |      -   |          Muster vom Freien Tic Tac To Feld.         |
| 11.1  |      "Möchten Sie nochmals spielen/zurück zum Game Menu?"           |    3 in einer reihe oder diagonal.     |        "Bsp. X hat gewonnen!!"           |
| 12.1  |     Im Game Tic Tac To          |   "Bsp. c,6,?"      |    "Dies ist eine ungültige Eingabe."               |
| 13.1  |        "X Hat gewonnen!!"          |    -     |         "Möchten Sie nochmals spielen/zurück zum Game Menu?"          |
| 14.1  |       "O hat gewonnen!!"         |    -     |         "Möchten Sie nochmals spielen/zurück zum Game Menu?"           |
| 15.1  |      Im Game Menu        |    -     |       "Welches speil möchten sie spiuelen (Hangamnn/ Tic Tac To)?            |
| 16.1  |     Im Game Menu         |  -       |         "Keins"          |


### 1.4 Diagramme

![image](https://github.com/denisjashari54/GameCube/assets/110892575/0917ec8b-e7c8-4a10-b6e0-9687166176ba)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A | 15.09.2023 | Marku, Jashari | Entwicklung der Funktion, um in Hangman ein Wort zu generieren. | 60' |
| 2.A | 22.09.2023 | Marku, Jashari | Implementierung einer Option in Hangman, um einen Buchstaben einzugeben. | 60' |
| 3.A | 29.09.2023 | Marku, Jashari | Programmierung der Logik in Hangman, um zu überprüfen, ob der Buchstabe im Wort enthalten ist. | 60' |
| 4.A | 06.10.2023 | Marku, Jashari | Entwicklung der Anzeige in Hangman, wo der Buchstabe im Wort vorkommt. | 60' |
| 5.A | 15.09.2023 | Angelov, Bajramovic | Entwicklung der Eingabefunktion für Tic Tac Toe. | 60' |
| 6.A | 22.09.2023 | Angelov, Bajramovic | Implementierung der Logik für Gewinnermittlung in Tic Tac Toe. | 60' |
| 7.A | 29.09.2023 | Angelov, Bajramovic | Programmierung der Fehlermeldung bei Fehleingaben in Tic Tac Toe. | 60' |
| 8.A | 06.10.2023 | Angelov, Bajramovic | Implementierung einer Option, um zum Hauptmenü zurückzukehren oder Tic Tac Toe erneut zu spielen. | 60' |
| 9.A | 13.10.2023 | Marku, Jashari | Erstellung der Optionen zum erneuten Spielen oder Rückkehr ins Menü nach einem Spiel in beiden Spielen. | 60' |
| 10.A | 13.10.2023 | Marku, Jashari| Entwicklung des Hauptmenüs mit der Option, eines der beiden Spiele auszuwählen. | 60' |
| 11.A | 20.10.2023 | Marku, Jashari, Angelov, Bajramovic | Implementierung der Option, das Programm zu beenden. | 60' |
| 12.A | 20.10.2023 | Marku, Jashari | Entwicklung einer Fehlermeldung bei Fehleingaben in Hangman. | 60' |
| 13.A | 27.10.2023 | Marku, Jashari | Erstellung der Optionen zum erneuten Spielen oder Rückkehr ins Menü nach einem Spiel in Hangman. | 60' |
| 14.A | 27.10.2023 | Marku, Jashari, Angelov, Bajramovic | Integration der beiden Spiele in das gemeinsame Menü. | 60' |
| 15.A | 03.11.2023 | Marku, Jashari, Angelov, Bajramovic | Finalisierung der Benutzeroberfläche für das Hauptmenü und die Spiele. | 60' |
| 16.A | 03.11.2023 | Angelov, Bajramovic | Durchführung von Integrationstests für das gesamte Spielmenü. | 60' |
| 17.A | 15.09.2023 - 03.11.2023 |  Marku, Jashari, Angelov, Bajramovic | Dokumentation immer wieder erweitern | 120' |
| 18.A | 03.11.2023 | Marku, Jashari, Angelov, Bajramovic | Durchführung von Integrationstests für das gesamte Spielmenü. | 180' |


## 3 Entscheiden

Für unser Projekt haben wir folgende Kernentscheidungen getroffen:

1. Programmiersprache: Wir nutzen C# wegen seiner Stärken in der objektorientierten Programmierung.
2. Benutzeroberfläche: Ein einfaches und intuitives Design wird verwendet, um Benutzerfreundlichkeit zu gewährleisten.

## 4 Realisieren

| AP-№ | Datum      | Zuständig   | geplante Zeit | tatsächliche Zeit |
| ---- | ---------- | ----------- | ------------- | ----------------- |
| 1.A  | 15.09.2023 | Marku, Jashari | 60'       | 60'               |
| 2.A  | 22.09.2023 | Marku, Jashari | 60'       | 55'               |
| 3.A  | 29.09.2023 | Marku, Jashari | 60'       | 60'               |
| 4.A  | 06.10.2023 | Marku, Jashari | 60'       | 50'               |
| 5.A  | 15.09.2023 | Angelov, Bajramovic | 60' | 55'               |
| 6.A  | 22.09.2023 | Angelov, Bajramovic | 60' | 60'               |
| 7.A  | 29.09.2023 | Angelov, Bajramovic | 60' | 50'               |
| 8.A  | 06.10.2023 | Angelov, Bajramovic | 60' | 55'               |
| 9.A  | 13.10.2023 | Marku, Jashari | 60'       | 60'               |
| 10.A | 13.10.2023 | Marku, Jashari | 60'       | 55'               |
| 11.A | 20.10.2023 | Marku, Jashari, Angelov, Bajramovic | 60' | 50'      |
| 12.A | 20.10.2023 | Marku, Jashari | 60'       | 55'               |
| 13.A | 27.10.2023 | Marku, Jashari | 60'       | 60'               |
| 14.A | 27.10.2023 | Marku, Jashari, Angelov, Bajramovic | 60' | 55'      |
| 15.A | 03.11.2023 | Marku, Jashari, Angelov, Bajramovic | 60' | 60'      |
| 16.A | 03.11.2023 | Angelov, Bajramovic | 60' | 55'               |


## 5 Kontrollieren

| TC-№ | Datum      | Resultat | Tester    |
| ---- | ---------- | -------- | --------- |
| 1.1  | 03.11.2023 | OK       | Angelov   |
| 2.1  | 03.11.2023 | OK       | Bajramovic |
| 3.1  | 03.11.2023 | OK       | Jashari   |
| 4.1  | 03.11.2023 | OK       | Marku     |
| 5.1  | 03.11.2023 | OK       | Angelov   |
| 6.1  | 03.11.2023 | OK       | Bajramovic |
| 7.1  | 03.11.2023 | OK       | Jashari   |
| 8.1  | 03.11.2023 | OK       | Marku     |
| 9.1  | 03.11.2023 | OK       | Angelov   |
| 10.1 | 03.11.2023 | OK       | Bajramovic |
| 11.1 | 03.11.2023 | OK       | Jashari   |
| 12.1 | 03.11.2023 | OK       | Marku     |
| 13.1 | 03.11.2023 | OK       | Angelov   |
| 14.1 | 03.11.2023 | OK       | Bajramovic |
| 15.1 | 03.11.2023 | OK       | Jashari   |
| 16.1 | 03.11.2023 | OK       | Marku     |


Das Testprotokoll vom 03.11.2023 zeigt, dass alle Tests erfolgreich waren, und die Software ist bereit für den Produktionsbereich. Alle Tester haben die Testfälle bestanden, was auf eine hohe Qualität und Zuverlässigkeit hinweist.




