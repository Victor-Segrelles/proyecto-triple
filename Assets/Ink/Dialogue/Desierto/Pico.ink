INCLUDE ../globals.ink

->elegir
===elegir===
{parafinal:
- "true": ->main
- else: ->main2
}
===main===
#speaker: Copi #portrait: 3
Soy muy bueno rompiendo el hielo.
->DONE

===main2===
#speaker: Jeringuito #portrait: 0
¡Hola!
#speaker: Copi #portrait: 3
¡Ah, hola! Tú eres el que nos trajo comida.
¿Querías algo?
#speaker: Jeringuito #portrait: 0
La verdad, quería pedirte una cosa. En Refebre hay gente atrapada en el hielo, y creo que tú podrías ayudarnos a sacarlos.
#speaker: Copi #portrait: 3
¿Yo? ¡Por supuesto!
Haré lo que pueda.
#speaker: Jeringuito #portrait: 0
¡Muchas gracias!
¿Cómo te llamas? Yo soy Jeringuito.
#speaker: Copi #portrait: 3
Soy Copi. 
#speaker: Jeringuito #portrait: 0
¡Pues venga, vámonos!
~minijuego = "MinigameWhack-a-virus"
->END