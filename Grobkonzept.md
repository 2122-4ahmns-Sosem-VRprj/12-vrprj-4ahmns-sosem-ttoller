<h1 align="center">Grobkonzept</h1>
<div align="center">Grundkonzept für das VR Game bei Frau Susanne Meerwald-Stadler</div>
<div align="center">2021/2022</div>
<div align="center">13 - Tim Toller</div>
<div align="center"><a href="https://gist.github.com/TimToller/558f270d5411bf91caba89d1918abd8a">Diese Datei auf Github ansehen</a></div>
  
### Requirements

- Oster-theme
- Zwei Minigames
- Viele Sounds und auditive Atmosphäre
- Spielt in einem vorgegebenen Labyrinth

### Feeling & Gründe das Spiel zu spielen

Obwohl das Thema "Ostern" klassischerweise auf eine fröhliche, bunte Welt hinweist, möchte ich mit diesem Spiel den User genau in die Entgegengesetzte Richtung leiten. Das Spiel sollte gruslig und mystisch aussehen und klingen. Genau dieser Gruselfaktor bringt aber schlussendlich Spieler dazu die unheimliche Welt des verrückt gewordenen Osterhasen's erforschen zu wollen. Ein Adrenalin kick, ein so einzigartiges Erlebnis, dass die Gänsehaut auch noch Wochen später zu spüren sein wird. Um den Gruselfaktor zu erhöhen und zu verhindern dass der Spieler zu schnell durch das Spiel spielt wird nicht die klassische Teleportation als Fortbewegung genutzt, sondern das Continuos Movement.

### Story

Mitten in der Nacht, weit entfernt von jeglicher Zivilisation steht der Spieler gestrandet am Rande eines Waldes. Die dicht gepflanzten Bäume lassen den Spieler nicht durch, die einzige Möglichkeit weiterzukommen ist in das verlassene Labyrinth vor dem Spieler einzutreten. In Sagen hieß es einst, der Osterhase hätte genau hier seinen Bau und verstarb aber nach vielen Jahrhunderten. Die viele Arbeit, die vielen Eier hätten ihn verrückt gemacht. Doch sobald der Spieler eintritt, verschließt sich der Eingang wieder. Nur wenn der Spieler es durch den Ganzen Parkour schafft, kann er fliehen. Zum Glück ist der Spieler allein... oder etwa doch nicht?

### Sounds

- Spinnen-Eier sounds
- Atmosphäre
- Musik
- Verschiedene Sounds für Props im Maze
- Tür öffnen/schließen
- Button korrekt
- Button nicht korrekt
- Button click sound
- 9 Glockensounds in verschiedener Tonhöhe für Minigame 2

<div style="page-break-after: always;"></div>

### Minigame 1

Das erste Minigame stellt die Geschicklichkeit und Schnelligkeit des Users auf die Beine. Am Boden und auf der Wand des Labyrinths sind Ostereier mit Spinnenbeinen ausgekommen. Sie zufällig rennen herum und der User muss eine bestimmte Anzahl an Eier aufheben und in eine Bestimmte Kiste legen. Ober der Kiste ist ein counter welcher anzeigt wie viele Eier derzeit in der Kiste sind. Nur wenn eine bestimmte Anzahl an Eiern vorhanden ist, kann der Spieler fortschreiten.

Mockup des Spinnen-Ei:

![Spinnen-Ei](https://user-images.githubusercontent.com/72389363/159365022-99aa9e74-90b1-4298-9584-349baab5dee3.png)

[Spider Asset](https://sketchfab.com/3d-models/hi-fi-spider-ff8a4433a5d449a3a0fc54989185a024)

[Egg Asset](https://sketchfab.com/3d-models/easter-eggs-ac0b0892e538449da59f2f9beb66f855#download)

### Minigame 2

Beim zweiten Minigame ist es entscheidend eine hohe Merkfähigkeit zu haben. Auf einer wand ist ein 3x3 Raster aus andersfarbigen Quadraten zu sehen.

Sobald der Spieler näher kommt leuchtet eines der Quadrate auf und macht ein klingendes Glockengeräusch in einer ganz bestimmten Ton. Der Spieler muss nun im umgebenden Raum einen Gleichfarbigen Knopf finden. Wird der Knopf gedrückt, so ertönt beim betätigen der gleiche Ton auf wie zuvor und ein bestimmter Glockenspiel Sound wird abgespielt um den Spieler zu vermitteln dass er richtig gehandelt hat. Das soeben richtig gelöste Quadrat leuchtet permanent weiter und das nächste Quadrat leuchtet auf usw. bis alle dran kamen.

Drückt der Spieler auf einen Falschen Knopf wird ein dramatischer Sound abgespielt um dem Spieler zu vermitteln dass er was falsch gemacht hat. Alle richtig gelösten Quadrate werden zurückgesetzt und man muss von vorne anfangen.

<div style="page-break-after: always;"></div>

### Skizze

![Maze Skizze](https://user-images.githubusercontent.com/72389363/159537930-e4d44436-428c-4c46-a890-6fe061b32fc8.png)

<div style="page-break-after: always;"></div>

### Arbeitsschritte

1. Unity korrekt für den ersten Build aufsetzen
2. Unity Test build
3. Continuous Movement implementieren
4. Movement play testen und verändern falls notwendig
5. Script schreiben um die Spinnen-Eier zufällig zu bewegen
6. Spinnen-Eier object und Animation hinzufügen
7. Sicherstellen dass man die Spinnen-Eier hochheben und tragen kann
8. Kiste für Minigame 1 erstellen mit script um zu checken wie viele Spinnen-Eier schon in der Kiste sind
9. Counter anzeige einbauen und die erste Tür öffnen wenn die mindset Anzahl an Spinnen-Eier erreicht wurde
10. Erstes Minigame vollständig testen und Bugs beheben
11. Build erstellen (um sicherzugehen, dass nichts kaputt gegangen ist)
12. Script für Minigame 2 anfangen: Zufällige Reihenfolge wie die Quadrate angezeigt werden sollten erstellen
13. Quadrate aufleuchten lassen wenn der richtige button gedrückt wurde
14. Logik fertig stellen (reset bei falschem button) und die richtigen sounds abspielen
15. Minigame 2 vollständig testen und Bugs beheben
16. Buttons über der Map verstreuen und verstecken
17. Restliche Map Dekoration fertigstellen
18. Sauberes Ende und Anfang für das Spiel machen (zB. fade from/to black)
19. Spiel komplett play testen
20. Build erstellen
21. Endabgabe