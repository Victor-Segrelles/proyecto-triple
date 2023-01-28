INCLUDE ../globals.ink
->elegir
===elegir===
{partir:
- "true": ->main
- else: ->main2
}
===main===
#speaker: Tanic #portrait: 1
~ partir = "false"
~ minijuego="Puerto2Cinematica"
->DONE

===main2===
#speaker: Tanic #portrait: 1
¿Nos vamos?
    * [Allá vamos]
        El viaje a Lianba es algo más difícil que el de Cayeferro así que…¡agárrate bien!
		~ destino = "Selva"
        ~ minijuego = "MinigameDriving"
        ->DONE
        
    * [Aún no]
        Avísame cuando estés listo.
->END