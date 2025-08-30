# Documento de Diseño de Juego: Apicultor Astral

## 1. Concepto General

**Apicultor Astral** es un juego de simulación y gestión en 3D del género "cozy" (acogedor). El jugador asume el rol de un apicultor en el espacio, cuidando de abejas cósmicas en un pequeño asteroide personalizable. El objetivo es cultivar flora exótica, criar especies de abejas mágicas, recolectar su miel única y usarla para crear productos fantásticos que se venden a viajeros intergalácticos.

Es una experiencia relajante centrada en la creatividad, la recolección y el descubrimiento, sin combate ni estrés.

-   **Género:** Simulador, Gestión, Crafteo, "Cozy Game".
-   **Plataforma:** PC (inicialmente).
-   **Audiencia:** Jugadores que disfrutan de juegos relajantes y creativos como *Stardew Valley*, *Slime Rancher* o *Animal Crossing*.
-   **Estilo Visual:** Low-poly, estilizado, con colores vibrantes y efectos de partículas mágicas.

---

## 2. Pilares del Juego

-   **Relajación ante todo:** La experiencia debe ser tranquila y satisfactoria.
    -   No hay castigos severos, enemigos ni límite de tiempo estresante.
    -   La música y los sonidos son clave para crear una atmósfera pacífica.
-   **Descubrimiento constante:** Siempre hay una nueva abeja que criar, una nueva flor que plantar o una nueva receta que descubrir.
    -   La curiosidad del jugador es el motor principal de la progresión.
-   **Creatividad y Expresión:** El jugador debe sentir que su asteroide es *suyo*.
    -   La personalización del entorno, la disposición del jardín y la decoración son mecánicas fundamentales.
-   **Un Bucle Adictivo:** El ciclo de cuidar-recolectar-crear-vender debe ser simple de entender pero profundo en sus posibilidades, invitando al jugador a "jugar un día más".

---

## 3. Bucle de Jugabilidad Principal

El juego se estructura en un ciclo de "día" y "noche" astral que el jugador repite.

### Fase de Cuidado (Mañana Astral)
-   El jugador riega sus plantas y cuida de su jardín.
-   Recolecta la miel y la cera de las colmenas que estén listas.
-   Gestiona los criaderos para incubar nuevas abejas.

### Fase de Producción y Comercio (Día Astral)
-   El jugador lleva los recursos a su taller para el crafteo.
-   Experimenta combinando mieles en la **Mesa de Alquimia** o procesando cera en la **Mesa de Artesanía**.
-   Atiende a los **Viajeros Estelares** que aterrizan en el puerto de su asteroide, cumpliendo sus pedidos a cambio de moneda galáctica.

### Fase de Expansión y Planificación (Noche Astral)
-   El jugador utiliza la moneda ganada para comprar mejoras, nuevas semillas o expansiones para su asteroide.
-   Usa el **Telescopio** para observar el cosmos, descubriendo nuevas constelaciones que desbloquean contenido (abejas, flores, recetas).
-   Planifica y rediseña su jardín, preparando el terreno para el siguiente ciclo.

---

## 4. Mecánicas Detalladas

### 4.1. Abejas Cósmicas

Cada especie de abeja tiene un comportamiento, una flor preferida y produce un tipo de miel con propiedades únicas.

-   **Abeja Solar:**
    -   **Comportamiento:** Activa y dócil. La abeja inicial.
    -   **Flor Preferida:** Flor de Polvo Estelar.
    -   **Miel:** Miel Dorada (ingrediente base para muchas recetas).
-   **Abeja de Cometa:**
    -   **Comportamiento:** Muy rápida y errática, difícil de seguir con la vista.
    -   **Flor Preferida:** Girasol de Fuego.
    -   **Miel:** Miel Efervescente (usada en pociones de velocidad y bebidas energéticas).
-   **Abeja de Roca Lunar:**
    -   **Comportamiento:** Lenta, robusta y brilla suavemente en la oscuridad.
    -   **Flor Preferida:** Cristal de Cuarzo (una planta-mineral).
    -   **Miel:** Miel Cristalizada (se puede procesar para obtener Azúcar Cósmico o usarse en recetas de dulces que otorgan resistencia).
-   **Abeja de Nebulosa:**
    -   **Comportamiento:** Tímida, solo sale de noche y se esconde si el jugador se mueve muy rápido cerca de ella.
    -   **Flor Preferida:** Loto de Sombras.
    -   **Miel:** Miel Cromática (cambia de color, se usa para tintes, cosméticos y objetos decorativos).

**Sistema de Crianza:** El jugador podrá construir un **Apiario de Fusión** donde, al colocar dos tipos de abejas y una flor híbrida, tendrá una pequeña probabilidad de generar una nueva especie de abeja con rasgos combinados.

### 4.2. Flora Astral

Las plantas son el alimento de las abejas y el primer paso en la cadena de producción.

-   **Flor de Polvo Estelar:** La planta básica, fácil de cultivar.
-   **Girasol de Fuego:** Necesita estar cerca de un **Géiser de Vapor** para crecer. Sus pétalos emiten un calor suave.
-   **Cristal de Cuarzo:** No necesita agua, pero crece muy lentamente. Se planta en "suelo rocoso".
-   **Loto de Sombras:** Solo puede crecer en zonas de sombra, lejos de la luz directa del sol cósmico.

**Hibridación:** El jugador podrá usar un **Polinizador Manual** para cruzar dos tipos de flores y crear una nueva variedad híbrida, necesaria para atraer a las abejas más raras.

### 4.3. Crafteo y Alquimia

El taller del jugador tendrá varias estaciones de trabajo:

-   **Mesa de Alquimia:** Para mezclar mieles y otros ingredientes.
    -   *Ejemplo 1:* Miel Dorada + Miel Efervescente = **Poción de Agilidad**.
    -   *Ejemplo 2:* Miel Cristalizada + Néctar de Loto de Sombras = **Caramelo de Invisibilidad Temporal**.
-   **Mesa de Artesanía:** Para trabajar con la cera.
    -   *Ejemplo 1:* Cera Solar = **Vela Iluminadora** (decoración).
    -   *Ejemplo 2:* Cera de Roca Lunar = **Figura Pulida** (objeto de venta de alto valor).

**El Gran Libro de Recetas:** Al principio estará casi vacío. El jugador lo irá llenando al experimentar con combinaciones y al descubrir secretos en el cosmos.

### 4.4. Progresión y Desbloqueos

El jugador siempre tendrá un objetivo claro.

-   **Moneda:** La moneda principal son los **"Lúmenes"**, obtenidos al vender productos.
-   **Tienda Galáctica:** Un menú accesible desde el puerto estelar donde se pueden comprar:
    -   Semillas y Larvas.
    -   Mejoras para herramientas (regadera, recolector, telescopio...).
    -   Expansiones de Asteroide para añadir nuevos biomas.
-   **Árbol de Habilidades (Opcional):** Un sistema simple donde el jugador gasta "Puntos de Experiencia" (ganados al completar pedidos) para mejorar sus habilidades, como "Probabilidad de obtener miel rara" o "Velocidad de crafteo".

---

## 5. Dirección Artística y Sonora

### Arte
-   Estilo 3D "low-poly" con colores pastel y saturados.
-   El cielo es un tapiz de nebulosas de colores, estrellas parpadeantes y galaxias lejanas.
-   Los efectos visuales (partículas de polen, brillo de la miel, estelas de las abejas) son clave para dar vida al mundo.

### Sonido
-   La banda sonora debe ser minimalista, ambiental y relajante (pianos suaves, sintetizadores etéreos).
-   Los efectos de sonido deben ser satisfactorios y "suaves" (el "plop" de la miel, el zumbido melódico de las abejas, el tintineo de las herramientas).

---

## 6. Plan de Prototipo (Producto Mínimo Viable)

El objetivo es crear la versión más simple posible del juego para probar si el bucle principal es divertido.

### Movimiento y Entorno
-   Un personaje en tercera persona que puede caminar y saltar.
-   Un pequeño asteroide plano.

### Ciclo de Cultivo Básico
-   Implementar la acción de plantar una sola semilla (Flor de Polvo Estelar).
-   Hacer que la planta crezca con el tiempo.
-   Implementar la acción de recolectar un recurso (Miel Dorada) de la planta madura.

### Ciclo de Abejas Básico
-   Crear una colmena.
-   Una abeja (Abeja Solar) que vuela desde la colmena hasta la flor y de vuelta.
-   Cuando la abeja completa varios viajes, la colmena se puede recolectar.

### UI Sencilla
-   Un inventario simple para ver cuánta miel tienes.
-   Un contador de "Lúmenes".

### Venta Simple
-   Un botón en la UI que permita "Vender 1 de Miel" por 10 Lúmenes.

Con estos 5 puntos, ya tienes un bucle jugable. Si te divierte, el resto es añadir más contenido y pulir las mecánicas.