INCLUDE ../globals.ink

->elegir
===elegir===
{recursosprueba:
- "true": ->main
- else: ->main2
}
===main===
#speaker: Vendi #portrait: 7
No tienes suficientes recursos, ven cuando los tengas.
~recursosprueba = "false"
->DONE

===main2===
{parahielo:
- "true": ->main3
- else: ->main4
}

===main3===
~ minijuego = "VendiCinematica"
->DONE

===main4===
~ minijuego = "SelvaCinematica"
->END