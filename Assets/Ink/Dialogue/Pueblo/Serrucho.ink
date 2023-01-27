INCLUDE ../globals.ink

-> main

===main===
#speaker: Virto #portrait: 7
Hola, ¿Quieres iniciar el minijuego de navegar?
    * [Si]
        ~ minijuego = "MinigameDriving"
        ~ destino = "Desierto"
        ->DONE
        
    * [No]
        ¡Vuelve cuando quieras!
->END