# Documento de Diseño de Juego: Apicultor Astral

## 1. Concepto General

[cite_start]**Apicultor Astral** es un juego de simulación y gestión en 3D del género "cozy" (acogedor)[cite: 3]. [cite_start]El jugador asume el rol de un apicultor en el espacio, cuidando de abejas cósmicas en un pequeño asteroide personalizable[cite: 4]. [cite_start]El objetivo es cultivar flora exótica, criar especies de abejas mágicas, recolectar su miel única y usarla para crear productos fantásticos que se venden a viajeros intergalácticos[cite: 5].

[cite_start]Es una experiencia relajante centrada en la creatividad, la recolección y el descubrimiento, sin combate ni estrés[cite: 6].

-   [cite_start]**Género:** Simulador, Gestión, Crafteo, "Cozy Game"[cite: 7].
-   [cite_start]**Plataforma:** PC (inicialmente)[cite: 8].
-   [cite_start]**Audiencia:** Jugadores que disfrutan de juegos relajantes y creativos como *Stardew Valley*, *Slime Rancher* o *Animal Crossing*[cite: 9].
-   [cite_start]**Estilo Visual:** Low-poly, estilizado, con colores vibrantes y efectos de partículas mágicas[cite: 10].

---

## 2. Pilares del Juego

-   [cite_start]**Relajación ante todo:** La experiencia debe ser tranquila y satisfactoria[cite: 12].
    -   [cite_start]No hay castigos severos, enemigos ni límite de tiempo estresante[cite: 13].
    -   [cite_start]La música y los sonidos son clave para crear una atmósfera pacífica[cite: 14].
-   [cite_start]**Descubrimiento constante:** Siempre hay una nueva abeja que criar, una nueva flor que plantar o una nueva receta que descubrir[cite: 15].
    -   [cite_start]La curiosidad del jugador es el motor principal de la progresión[cite: 16].
-   [cite_start]**Creatividad y Expresión:** El jugador debe sentir que su asteroide es *suyo*[cite: 17].
    -   [cite_start]La personalización del entorno, la disposición del jardín y la decoración son mecánicas fundamentales[cite: 18].
-   [cite_start]**Un Bucle Adictivo:** El ciclo de cuidar-recolectar-crear-vender debe ser simple de entender pero profundo en sus posibilidades, invitando al jugador a "jugar un día más"[cite: 19].

---

## 3. Bucle de Jugabilidad Principal

[cite_start]El juego se estructura en un ciclo de "día" y "noche" astral que el jugador repite[cite: 21].

### Fase de Cuidado (Mañana Astral)
-   [cite_start]El jugador riega sus plantas y cuida de su jardín[cite: 23].
-   [cite_start]Recolecta la miel y la cera de las colmenas que estén listas[cite: 24].
-   [cite_start]Gestiona los criaderos para incubar nuevas abejas[cite: 25].

### Fase de Producción y Comercio (Día Astral)
-   [cite_start]El jugador lleva los recursos a su taller para el crafteo[cite: 27].
-   [cite_start]Experimenta combinando mieles en la **Mesa de Alquimia** o procesando cera en la **Mesa de Artesanía**[cite: 28].
-   [cite_start]Atiende a los **Viajeros Estelares** que aterrizan en el puerto de su asteroide, cumpliendo sus pedidos a cambio de moneda galáctica[cite: 29].

### Fase de Expansión y Planificación (Noche Astral)
-   [cite_start]El jugador utiliza la moneda ganada para comprar mejoras, nuevas semillas o expansiones para su asteroide[cite: 31].
-   [cite_start]Usa el **Telescopio** para observar el cosmos, descubriendo nuevas constelaciones que desbloquean contenido (abejas, flores, recetas)[cite: 32].
-   [cite_start]Planifica y rediseña su jardín, preparando el terreno para el siguiente ciclo[cite: 33].

---

## 4. Mecánicas Detalladas

### 4.1. Abejas Cósmicas

[cite_start]Cada especie de abeja tiene un comportamiento, una flor preferida y produce un tipo de miel con propiedades únicas[cite: 36].

-   **Abeja Solar:**
    -   **Comportamiento:** Activa y dócil. [cite_start]La abeja inicial[cite: 38].
    -   [cite_start]**Flor Preferida:** Flor de Polvo Estelar[cite: 39].
    -   [cite_start]**Miel:** Miel Dorada (ingrediente base para muchas recetas)[cite: 40].
-   **Abeja de Cometa:**
    -   [cite_start]**Comportamiento:** Muy rápida y errática, difícil de seguir con la vista[cite: 42].
    -   [cite_start]**Flor Preferida:** Girasol de Fuego[cite: 43].
    -   [cite_start]**Miel:** Miel Efervescente (usada en pociones de velocidad y bebidas energéticas)[cite: 44].
-   **Abeja de Roca Lunar:**
    -   [cite_start]**Comportamiento:** Lenta, robusta y brilla suavemente en la oscuridad[cite: 46].
    -   [cite_start]**Flor Preferida:** Cristal de Cuarzo (una planta-mineral)[cite: 47].
    -   [cite_start]**Miel:** Miel Cristalizada (se puede procesar para obtener Azúcar Cósmico o usarse en recetas de dulces que otorgan resistencia)[cite: 48].
-   **Abeja de Nebulosa:**
    -   [cite_start]**Comportamiento:** Tímida, solo sale de noche y se esconde si el jugador se mueve muy rápido cerca de ella[cite: 50].
    -   [cite_start]**Flor Preferida:** Loto de Sombras[cite: 51].
    -   [cite_start]**Miel:** Miel Cromática (cambia de color, se usa para tintes, cosméticos y objetos decorativos)[cite: 52].

[cite_start]**Sistema de Crianza:** El jugador podrá construir un **Apiario de Fusión** donde, al colocar dos tipos de abejas y una flor híbrida, tendrá una pequeña probabilidad de generar una nueva especie de abeja con rasgos combinados[cite: 53].

### 4.2. Flora Astral

[cite_start]Las plantas son el alimento de las abejas y el primer paso en la cadena de producción[cite: 55].

-   [cite_start]**Flor de Polvo Estelar:** La planta básica, fácil de cultivar[cite: 56].
-   **Girasol de Fuego:** Necesita estar cerca de un **Géiser de Vapor** para crecer. [cite_start]Sus pétalos emiten un calor suave[cite: 57, 58].
-   **Cristal de Cuarzo:** No necesita agua, pero crece muy lentamente. [cite_start]Se planta en "suelo rocoso"[cite: 59].
-   [cite_start]**Loto de Sombras:** Solo puede crecer en zonas de sombra, lejos de la luz directa del sol cósmico[cite: 60].

[cite_start]**Hibridación:** El jugador podrá usar un **Polinizador Manual** para cruzar dos tipos de flores y crear una nueva variedad híbrida, necesaria para atraer a las abejas más raras[cite: 61].

### 4.3. Crafteo y Alquimia

[cite_start]El taller del jugador tendrá varias estaciones de trabajo[cite: 63]:

-   [cite_start]**Mesa de Alquimia:** Para mezclar mieles y otros ingredientes[cite: 64].
    -   [cite_start]*Ejemplo 1:* Miel Dorada + Miel Efervescente = **Poción de Agilidad**[cite: 65].
    -   [cite_start]*Ejemplo 2:* Miel Cristalizada + Néctar de Loto de Sombras = **Caramelo de Invisibilidad Temporal**[cite: 66].
-   [cite_start]**Mesa de Artesanía:** Para trabajar con la cera[cite: 67].
    -   [cite_start]*Ejemplo 1:* Cera Solar = **Vela Iluminadora** (decoración)[cite: 68].
    -   [cite_start]*Ejemplo 2:* Cera de Roca Lunar = **Figura Pulida** (objeto de venta de alto valor)[cite: 69].

[cite_start]**El Gran Libro de Recetas:** Al principio estará casi vacío[cite: 70]. [cite_start]El jugador lo irá llenando al experimentar con combinaciones y al descubrir secretos en el cosmos[cite: 71].

### 4.4. Progresión y Desbloqueos

[cite_start]El jugador siempre tendrá un objetivo claro[cite: 73].

-   [cite_start]**Moneda:** La moneda principal son los **"Lúmenes"**, obtenidos al vender productos[cite: 74].
-   [cite_start]**Tienda Galáctica:** Un menú accesible desde el puerto estelar donde se pueden comprar[cite: 75]:
    -   [cite_start]Semillas y Larvas[cite: 76].
    -   [cite_start]Mejoras para herramientas (regadera, recolector, telescopio...)[cite: 77].
    -   [cite_start]Expansiones de Asteroide para añadir nuevos biomas[cite: 78].
-   [cite_start]**Árbol de Habilidades (Opcional):** Un sistema simple donde el jugador gasta "Puntos de Experiencia" (ganados al completar pedidos) para mejorar sus habilidades, como "Probabilidad de obtener miel rara" o "Velocidad de crafteo"[cite: 79].

---

## 5. Dirección Artística y Sonora

### Arte
-   [cite_start]Estilo 3D "low-poly" con colores pastel y saturados[cite: 81].
-   [cite_start]El cielo es un tapiz de nebulosas de colores, estrellas parpadeantes y galaxias lejanas[cite: 82].
-   [cite_start]Los efectos visuales (partículas de polen, brillo de la miel, estelas de las abejas) son clave para dar vida al mundo[cite: 83].

### Sonido
-   [cite_start]La banda sonora debe ser minimalista, ambiental y relajante (pianos suaves, sintetizadores etéreos)[cite: 84].
-   [cite_start]Los efectos de sonido deben ser satisfactorios y "suaves" (el "plop" de la miel, el zumbido melódico de las abejas, el tintineo de las herramientas)[cite: 85].

---

## 6. Plan de Prototipo (Producto Mínimo Viable)

[cite_start]El objetivo es crear la versión más simple posible del juego para probar si el bucle principal es divertido[cite: 87].

### Movimiento y Entorno
-   [cite_start]Un personaje en tercera persona que puede caminar y saltar[cite: 89].
-   [cite_start]Un pequeño asteroide plano[cite: 90].

### Ciclo de Cultivo Básico
-   [cite_start]Implementar la acción de plantar una sola semilla (Flor de Polvo Estelar)[cite: 92].
-   [cite_start]Hacer que la planta crezca con el tiempo[cite: 93].
-   [cite_start]Implementar la acción de recolectar un recurso (Miel Dorada) de la planta madura[cite: 94].

### Ciclo de Abejas Básico
-   [cite_start]Crear una colmena[cite: 96].
-   [cite_start]Una abeja (Abeja Solar) que vuela desde la colmena hasta la flor y de vuelta[cite: 97].
-   [cite_start]Cuando la abeja completa varios viajes, la colmena se puede recolectar[cite: 98].

### UI Sencilla
-   [cite_start]Un inventario simple para ver cuánta miel tienes[cite: 100].
-   [cite_start]Un contador de "Lúmenes"[cite: 101].

### Venta Simple
-   [cite_start]Un botón en la UI que permita "Vender 1 de Miel" por 10 Lúmenes[cite: 103].

Con estos 5 puntos, ya tienes un bucle jugable. [cite_start]Si te divierte, el resto es añadir más contenido y pulir las mecánicas[cite: 104].