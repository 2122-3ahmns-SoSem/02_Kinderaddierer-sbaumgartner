Kinderaddierer

Introduction
Das Spiel "Kinderaddierer" soll Kindern im Alter von 6-10 Jahren dabei helfen, spielerisch ein Gefühl für Zahlen und Mengen zu entwickeln. Inhalt des Spiels sind mehr oder weniger simple Additionsrechnungen die mittels Drag & Drop, Richtig oder Falsch und einer einfachen Eingabe der Zahlen zu lösen sind.
Am Ende des Spiels wird dem Player sein Punktestand inkl. Feedback präsentiert.

Development Platform: Unity Version 2020.3.18f1, Visual Studio Community 2019, macOS Monterey Version 12.3.1
Target Platform: WebGL
Auflösung: 1280x720

Aufbau
Das Spiel besteht aus 3 verschiedenen Levels mit steigendem Schwierigkeitsgrad.
Aufgeteilt wird das ganze in 5 Szenen:

- Szene 1 - Startbildschirm
  Am Startbildschirm kann der Spieler einen Charakter auswählen und in das Eingabefeld einen beliebigen Name schreiben.
  Hat der Spieler das geschafft, muss er nur noch seine Eingabe bestätigen, indem er auf einen Button rechts unten klickt.
  Dieser Button befördert den Spieler in das erste Level.
  
- Szene 2 - Level easy
  Im ersten Level muss der Spieler mittels Drag und Drop Zahlenfelder zu den dazupassenden Marienkäfern mit der passenden Punkteanzahl zuordnen.
  Insgesamt befinden sich vier solcher Scheiben, bzw. Marienkäfer, auf dem Screen.
  Rechts unten befindet sich ein Button um seine Auswahl zu bestätigen und ins nächste Level zu wechseln.
  Links oben sieht der Spieler den Character und den Name, den er sich bzw. ihm gegeben hat.
  
- Szene 3 - Level medium
  Im zweiten Level werden dem Spieler vier Additionsrechnungen präsentiert, in denen jeweils entweder der erste/zweite Summand oder die Summe fehlt.
  Rechts daneben stehen insgesamt 6 Zahlenfelder, die mittels Drag & Drop in die leeren Felder gezogen werden müssen, um die Rechnungen zu
  vervollständigen. Rechts unten befindet sich ein Button um seine Auswahl zu bestätigen und ins nächste Level zu wechseln.
  Links oben sieht der Spieler den Character und den Name, den er sich bzw. ihm gegeben hat.
  
- Szene 4 - Level hard
  Im dritten Level warten auf den Spieler ebenfalls wieder vier Additionen, in denen wieder jeweils entweder der erste/zweite Summand oder die Summe
  fehlt. In diesem Level muss der Spieler die Zahlen allerdings händisch (über ein Eingabefeld) in die Rechnung schreiben.
  Rechts unten befindet sich ein Button um seine Auswahl zu bestätigen und zur End-Szene zu wechseln.
  Links oben sieht der Spieler den Character und den Name, den er sich bzw. ihm gegeben hat.
  
- Szene 5 - End-Screen
  Auf der Endszene bekommt der Spieler leistungsabhängiges Feedback und erstmals seinen Punktestand präsentiert.
  Unten rechts findet der Spieler einen Restart-Button, der ihn wieder zum Startmenü (Szene 1) befördert.
  
  
Quellen:
  - seekpng.com
  - pngkit.com
