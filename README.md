# 🚗 Sistema de Control de Acceso a Vehículos Deportivos Todo Terreno 🏞️

## Descripción del Proyecto

Este proyecto implementa un sistema de control de acceso para un predio dedicado a vehículos deportivos todo terreno. El predio cuenta con dunas de arena, lagos, y otros terrenos variados, por lo que se espera la entrada de diferentes tipos de vehículos. El sistema verifica si el vehículo tiene un ticket de acceso y, si no lo tiene, emite uno con el costo correspondiente.

## Tipos de Vehículos y Tarifas 🚙

Los costos de acceso dependen del tipo de vehículo:

| Tipo de Vehículo    | Costo Base (USD) |
|---------------------|------------------|
| Sin Vehículo        | 100              |
| Moto                | 800              |
| Auto                | 1000             |
| Camioneta           | 1500             |
| Buggy               | 5000             |
| Vehículo Náutico    | 1200             |

## Cálculo del Costo del Ticket 🎟️

El ticket es válido por un número determinado de días. Se aplica un porcentaje al valor base para calcular el costo final:

| Días  | Porcentaje |
|-------|------------|
| 1     | 100%       |
| 2     | 120%       |
| 3     | 220%       |
| 4     | 320%       |
| 5-10  | 380%       |

A continuación, se aplican los siguientes impuestos:
- IVA: 21%
- Impuesto para salvar los peces en la cima del Aconcagua: 15% sobre el valor con IVA incluido

El detalle de los valores cobrados se muestra en el ticket emitido.

## Funcionalidades 🛠️

1. **Verificar Acceso**
2. **Imprimir Recaudación**
3. **Mostrar Cantidad de Accesos**
4. **Mostrar Patentes**
5. **Buscar Patente**
6. **Salir**

## Parte 2: Registro de Identificadores de Vehículos 📋

Nuestra empresa ha firmado un convenio con el Ministerio de Seguridad de la Nación para registrar el identificador del vehículo al ingresar al predio. 

### Nuevas Funcionalidades

1. **Registrar Identificación del Vehículo**
2. **Listar Identificaciones Ordenadas**
3. **Buscar Identificación en el Registro**

---

Este README.md utiliza emojis para hacer más visual y atractiva la presentación del proyecto, manteniendo la información estructurada y fácil de entender. Puedes copiar y pegar este contenido en tu archivo README.md y personalizarlo según tus necesidades adicionales.
