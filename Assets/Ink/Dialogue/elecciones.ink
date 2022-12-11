INCLUDE globals.ink

{eleccion == "": -> main | -> alreadyChosen}


=== main ===
Buenas tardes, soy un texto de <color=\#F8FF30>prueba</color>. #speaker: Tanic #portrait: tanic_neutral 
Elige una fruta.
    * [Manzana]
        ~ eleccion = "la manzana"
        Las manzanas están bastante buenas.
    * [Azul]
        ~ eleccion = "el azul"
        El azul no es una fruta, imbécil.
- Ahora probaré las variables para recordar la fruta.
Elegiste {eleccion}. 
{eleccion:
- "la manzana": Buena elección.
- "el azul": ...
             Tonto.
}
Bruh #speaker: Jeringuito #portrait: jeringuito_neutral
->END

==alreadyChosen==
Ya has hecho tu elección #speaker: Tanic #portrait: tanic_neutral
->END
