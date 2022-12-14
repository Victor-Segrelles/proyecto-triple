INCLUDE ../globals.ink

->main

===main===
#speaker: Bola de nieve #portrait: 1
Hola, ¿Quieres iniciar el minijuego de rescate en el hielo?
    * [Si]
        ~ minijuego = "MinigameWhack-a-virus"
        ->DONE
        
    * [No]
        ¡Vuelve cuando quieras!
->END