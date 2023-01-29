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
{recursosprueba2:
- "true": ->main3
- else: ->main4
}

===main3===
#speaker: Tanic #portrait: 1
Aún no tienes suficiente dinero (necesitas 15000 monedas)
~ recursosprueba2 = "false"
->DONE

===main4===
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