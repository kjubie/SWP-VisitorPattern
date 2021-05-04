# SWP-VisitorPattern

Implementation eines Visitor Patterns

Dieses Programm "simuliert" einen Flipperautomaten auf dem gespielt wurde. Ein Visitor Pattern soll dabei helfen die Punkte zu Zählen, 
den Zustand auszugeben und die Elemente zurückzusetzten.

Wenn wir in ein anderes Level wechseln, oder den Flipper neu starten, dann müssen wir die
Elemente in den Ausgangszustand versetzen.
Wir betrachten folgende Elemente mit den folgenden Eigenschaften:
- Rampe – name, geoeffnet, punktezahl, durchlauefe, blinkt
- Led – nummer, aktiv, farbe (rot / gruen / blau), punktezahl
- Target – buchstabe, position (oben / unten), punktezahl

1. PunkteVisitor
Zählt die erreichten Punkte, wobei für die Rampe die Anzahl der Durchläufe mit der
Punktezahl multipliziert wird. Leds werden nur dann gezählt, wenn sie in einer bestimmten
Farbe leuchten. Für Targets gilt, dass die Punkte gezählt werden, wenn sie getroffen wurden.

2. ResetVisitor
Versetzt die Elemente in den Ausgangszustand:
-  Alle Rampen werden geschlossen, Zähler werden auf 0 gesetzt.
-  Leds werden ausgeschalten.
-  Targets werden hochgefahren.

3. ReportVisitor
Gibt den aktuellen Zustand aller Elemente auf der Konsole aus.
