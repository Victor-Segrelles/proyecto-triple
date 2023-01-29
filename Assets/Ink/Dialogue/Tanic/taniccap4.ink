INCLUDE ../globals.ink
->elegir
===elegir===
{paradesierto:
- "true": ->main
- else: ->main2
}
===main===
~ paradesierto = "false"
~ minijuego="Puerto3Cinematica"
->DONE

===main2===
#speaker: Tanic #portrait: 1
¿Nos vamos?
    * [Allá vamos]
        Allá vamos.
		~ destino = "DesiertoCinematica"
        ~ minijuego = "MinigameDriving"
        ->DONE
        
    * [Aún no]
        Avísame cuando estés listo.
->DONE