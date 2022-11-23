VAR eleccion = ""
-> main

=== main ===
Buenas tardes, soy un texto de prueba.
Elige una fruta.
    * Manzana
        ~ eleccion = "la manzana"
        Las manzanas están bastante buenas.
    * Azul
        ~ eleccion = "el azul"
        El azul no es una fruta, imbécil.
- Ahora probaré las variables para recordar la fruta.
Elegiste {eleccion} 
{eleccion:
- "la manzana": Buena elección.
- "el azul": ...
             Tonto.
}
->END