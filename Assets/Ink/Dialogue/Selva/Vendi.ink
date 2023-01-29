INCLUDE ../globals.ink

->elegir
===elegir===
{recursosprueba:
- "true": ->main
- else: ->elegir2
}
===main===
#speaker: Vendi #portrait: 7
No tienes suficientes recursos (7 madera, 2 suministros y 1 medicina), ven cuando los tengas.
->DONE

===elegir2==
{cinematicavista:
- "true": ->main2
- else: -> main5
}

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
->DONE

===main5===
#speaker: Vendi #portrait: 7
Gracias por ayudarme a arreglar el laboratorio.
->END