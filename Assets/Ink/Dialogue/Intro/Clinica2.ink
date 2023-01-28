INCLUDE ../globals.ink
->main

===main===
#speaker: Jeringuito #portrait: 0
Sí,  lo lamento. Su majestad quería una corona nueva y … decidió recortar gastos. 
Ahora solo compra medicamentos baratos que necesitan mucho tiempo para funcionar, 
por lo que a la larga se gastan muchos más y sale más caro para los pacientes.

#speaker: Nati #portrait: 1
Pero…yo no me puedo permitir todo eso así, de sopetón. ¡Mi tienda no gana tanto!

#speaker: Jeringuito #portrait: 0
…
Podría hacer algo para que lo pudieses pagar a plazos…¿eso te iría bien?

#speaker: Nati #portrait: 1
Definitivamente eso ayudaría, pero no sé si podré pagarlo cada mes.

#speaker: Jeringuito #portrait: 0
…
    * [Prestar dinero]
        ~ clinicaDonado = "true"
        #speaker: Jeringuito #portrait: 0
        Mira, podemos hacer esto: te presto el dinero y me lo vas devolviendo cuando puedas
        
        #speaker: Nati #portrait: 1
        ¿De verdad?
        ¡Eso sería una gran ayuda! ¡Muchas gracias!
        
        #speaker: Jeringuito #portrait: 0
        Je, no hay por qué darlas.
        Espero no arrepentirme de esto…
        ->siguiente
        
    * [Se las apañará]
        ~ clinicaDonado = "false"
        #speaker: Jeringuito #portrait: 0
        …ya, lo siento mucho…
        
        #speaker: Nati #portrait: 1
        Pero bueno, tú no tienes la culpa. Haré lo que pueda para pagarlo cada mes. 
        Gracias por el favor, eres muy considerado.
        ->siguiente

===siguiente===
#speaker: Jeringuito #portrait: 0
Definitivamente haber pedido la audiencia con el rey fue una decisión acertada. 
Estoy seguro de que una vez vea lo que sufre su gente cambiará su manera de comportarse.
Además, los rumores de que en uno de los pueblos cercanos los ciudadanos han contraído una grave enfermedad me preocupan,
ya que con los recortes al presupuesto no se pueden enviar medicamentos…

#speaker: Campanario
DIN DON

#speaker: Jeringuito #portrait: 0
Hablando de la audiencia…¡es casi la hora de ir!
->END