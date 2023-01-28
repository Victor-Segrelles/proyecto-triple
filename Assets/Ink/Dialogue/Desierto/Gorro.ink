INCLUDE ../globals.ink

->main

===main===
#speaker: Gorro #portrait: 2
Hola, ¿Quieres iniciar el minijuego de limpiar óxido?
    * [Si]
        ~ minijuego = "MinigameRust"
        ->DONE
        
    * [No]
        ¡Vuelve cuando quieras!
->END