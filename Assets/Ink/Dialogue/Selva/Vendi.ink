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
- else: -> main3
}

===main2===
~ minijuego = "VendiCinematica"
->DONE


===main3===
{parahielo:
- "true": ->main5
- else: ->main4
}
->DONE

===main4===
~ minijuego = "SelvaCinematica"
->DONE

===main5===
#speaker: Vendi #portrait: 7
Gracias por ayudarme a arreglar el laboratorio.
->END