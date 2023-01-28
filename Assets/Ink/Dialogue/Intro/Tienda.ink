INCLUDE ../globals.ink
->main

===main===
#speaker: Nati #portrait: 1
Buenos días ¿En qué puedo ayudarte?
¡Uy! ¡Si eres el médico de esta mañana! ¿Qué necesitas?
#speaker: Jeringuito #portrait: 0
¡Uy, hola! ¿Así que es esta tu tienda?
#speaker: Nati #portrait: 1
Sí, aquí puedes encontrar una gran variedad de productos de todo tipo ¿En qué puedo ayudarte?
#speaker: Jeringuito #portrait: 0
Pues… he escuchado que un pueblo cercano necesita ayuda y he decidido ir a ayudarles.
#speaker: Nati #portrait: 1
¡Ah! Es cierto que he escuchado rumores que hablan sobre una enfermedad terrible que está afectando a los habitantes de <b>Cayeferro</b>.
#speaker: Jeringuito #portrait: 0
Sí, me he propuesto ayudarlos y para empezar quería conseguir suministros. 
No sé a lo que me voy a enfrentar, pero supongo que llevar algunos medicamentos básicos será mejor que nada ¿Me los podrías proporcionar?
#speaker: Nati #portrait: 1
Claro que sí, y también te los puedo cargar en tu barco sin coste adicional.
#speaker: Jeringuito #portrait: 0
¿Barco? ¿qué barco?
#speaker: Nati #portrait: 1
¿Oh?¿Has contratado un servicio de transporte marítimo entonces? ¡Qué suerte! Últimamente no había ninguna actividad en el puerto. 
No hay problema, también puedo cargar tu compra en el barco que hayas contratado. Tú solo dime cuál es y allí estaré.
#speaker: Jeringuito #portrait: 0
No, no, no he contratado ningún servicio de transporte ni tengo un barco ¿Necesito uno? Nunca había oído hablar de Cayeferro.
#speaker: Nati #portrait: 1
...Cayeferro está al otro lado del mar, ¿Cómo pensabas llegar si no?
#speaker: Jeringuito #portrait: 0
Pues no me lo había planteado ¡¿qué hago yo ahora?!
#speaker: Nati #portrait: 1
Mhmmm…da la casualidad que tengo un barco en el puerto que era de mi padre y lleva años acumulando polvo  ¿Estarías dispuesto a comprármelo?
#speaker: Jeringuito #portrait: 0
¡Ay madre! Y yo que pensaba controlar mis gastos ahora que ya no tengo trabajo. Venga, de perdidos al río ¿por cuánto me venderías el barco?
{clinicaDonado:
- "true": ->elec0
- else: ->elec1
}

===elec0===
#speaker: Nati #portrait: 1
Mira…tenía pensado vender el barco por 15.000 monedas, pero como te debo una por pagar mi tratamiento te lo voy a regalar.
De normal todo lo que has comprado te costaría 5000 monedas, pero por ser tú te lo dejo todo a 2500 ¿Qué te parece?
#speaker: Jeringuito #portrait: 0
Ostras, pues me harías un favorazo. ¡Muchas gracias!
->siguiente

===elec1===
#speaker: Nati #portrait: 1
Mira…tenía pensado vender el barco por 15.000 monedas. Realmente necesitaría el dinero para mi tratamiento, 
pero ya que me ayudaste permitiéndome pagarlo a plazos con el precio del barco puedo incluirte los suministros que me pides ¿Qué te parece?
#speaker: Jeringuito #portrait: 0
¡Uf! es mucho dinero, no sé qué decirte.
#speaker: Nati #portrait: 1
Esta es la mejor oferta que te puedo ofrecer y dudo que nadie más te proporcione este servicio por menos dinero del que te pido.

#speaker: Jeringuito #portrait: 0
Vale, acepto. Tú ganas. 
-> siguiente

===siguiente===
#speaker: Nati #portrait: 1
Perfecto, ya tienes todo lo que me has pedido preparado en el puerto.
#speaker: Jeringuito #portrait: 0
…Pero ¿cuándo lo has hecho? Estabas hablando conmigo todo el tiempo.
#speaker: Nati #portrait: 1
Conveniencias del guion. ¡Andando!
#speaker: Jeringuito #portrait: 0
¡Ostras! que buen servicio, gracias. Hasta la vista.

->END