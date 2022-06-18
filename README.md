<h1 align="center">HTL-VRProject with XRInteractionToolkit</h1>
<div align="center">Documentation of my VR Game</div>
<div align="center">2021/2022</div>
<div align="center">13 - Tim Toller</div>

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

### Skizze

![Maze Skizze](https://user-images.githubusercontent.com/72389363/159537930-e4d44436-428c-4c46-a890-6fe061b32fc8.png)

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

### Development platform

| Technology  | Name                                 |
| ----------- | ------------------------------------ |
| OS          | Windows 10                           |
| Game Engine | Unity 2020.3.18f1                    |
| IDE         | Visual Studio Code (With extensions) |

Wie Sie VS-Code mit Unity einrichten können, erfahren Sie [hier](https://code.visualstudio.com/docs/other/unity).

### Packages

| Package Name              | Package ID                           | Version |
| :------------------------ | :----------------------------------- | :------ |
| JetBrains Rider Editor    | com.unity.ide.rider                  | 2.0.7   |
| Oculus XR Plugin          | com.unity.xr.oculus                  | 1.10.0  |
| Test Framework            | com.unity.test-framework             | 1.1.29  |
| TextMeshPro               | com.unity.textmeshpro                | 3.0.6   |
| Timeline                  | com.unity.timeline                   | 1.4.8   |
| Unity UI                  | com.unity.ugui                       | 1.0.0   |
| Universal RP              | com.unity.render-pipelines.universal | 10.6.0  |
| Version Control           | com.unity.collab-proxy               | 1.9.0   |
| Visual Studio Code Editor | com.unity.ide.vscode                 | 1.2.5   |
| Visual Studio Editor      | com.unity.ide.visualstudio           | 2.0.11  |
| XR Interaction Toolkit    | com.unity.xr.interaction.toolkit     | 2.0.2   |
| XR Plugin Management      | com.unity.xr.management              | 4.0.7   |

Generiert mit meinem [Unity manifest to markdown converter](https://timtoller.github.io/unity-manifest-to-markdown/).

## Sounds und Assets

Sounds bereitgestellt von [videvo](https://www.videvo.net/royalty-free-sound-effects/).

### Objects

- [Laterne](https://sketchfab.com/3d-models/lantern-f0b0ea89f20b4f10bb583c449ae04d9c)
- [Bäume](https://sketchfab.com/3d-models/trees-dbd3f20966de4cae9170413b9c6f891d)
- [Radio](https://sketchfab.com/3d-models/old-radio-ab346aeda5ab4c7882999f491d974619)
- [Hase](https://sketchfab.com/3d-models/fnaf-security-breach-burntrap-056ddc9b449046de80f3128a982f7fb2)
- [Door](https://sketchfab.com/3d-models/wooden-door-0643dee368fe4ed983910cf182ff64b8)
- [Table](https://sketchfab.com/3d-models/bedside-table-2-915fffa0a7d943d0980c835784340c77)
- [Eggs Red](https://sketchfab.com/3d-models/easter-eggs-red-collection-b79af3f7aa8543518628590f39cd2d31)
- [Eggs Blue](https://sketchfab.com/3d-models/easter-eggs-blue-collection-a9d3459970b348d7b93741e45f494035)
- [House](https://sketchfab.com/3d-models/abandoned-house-2f220af6ed4a45c792574da843093c3f)

### Texturen

- [Mauern](https://freepbr.com/materials/dirty-red-bricks1/)
- [Erde](https://freepbr.com/materials/rocky-dirt/)
- [Boden](https://freepbr.com/materials/gross-dirty-tiles-pbr/)
- [Dach](https://freepbr.com/materials/rocky-asphalt-1/)

## Software/Hardware-Anforderungen

[Oculus Hardware-Anforderungen](https://support.oculus.com/248749509016567/)
S
ie benötigen ein VR-Headset, in diesem Fall ein Oculus Rift/Quest/Quest2

[Beispiele](https://github.com/Unity-Technologies/XR-Interaction-Toolkit-Examples)

Beim Herunterladen treten Kompilierzeitfehler im Projekt auf. Um diese zu beheben, installieren Sie das XR Interaction Toolkit Paket über den Package Manager.

## Beschränkungen und Änderungen

Da wir nur ein relativ kleines Zeitfenster hatten das Spiel fertig zu stellen, war es nur noch notwendig ein Minigame umzusetzen, vorausgesetzt es gibt ein Intro und Outro. Darauf hin habe ich beschlossen nur das zweite Minigame, leicht zu modifizieren und umzusetzen.

Das Spiel wurde modifiziert zu einem gruseligen Suchspiel. Der User wird zu buttons geleitet die er in der richtigen Reihenfolge betätigen muss, als Unterstützung hat der Spieler einen Kompass im UI und der nächste Button spielt regelmäßig einen Glocken sound ab, damit man auch auditiv den Weg dorthin finden kann. Außerdem leuchtet der nächste Button auf und blinkt, damit ein visuelles Feedback auch entsteht. Die Reihenfolge und Farbe der Buttons ist randomized. Schafft es der Spieler alle Buttons in der Richtigen Reihenfolge zu betätigen, so öffnet sich die Ausgangstür und der Spieler gewinnt.

### Target platform

Oculus Rift/S; Quest/2

### Third party material

Für Tests ohne Headset verwenden Sie den XR Device Simulator (im xr interaction toolkit Paket enthalten) [tutorial](https://www.youtube.com/watch?v=d4bTpkvBwrs)

> Copyright by Tim Toller
