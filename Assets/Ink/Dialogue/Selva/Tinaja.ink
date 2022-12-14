INCLUDE ../globals.ink

->main

===main===
#speaker: Tinaja #portrait: 6
Hola, ¿Quieres iniciar el minijuego de curar?
    * [Si]
        ~ minijuego = "MinigameCures"
        ->DONE
        
    * [No]
        ¡Vuelve cuando quieras!
->END