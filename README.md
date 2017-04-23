# Inyección de Dependencias (ID)

La idea detrás de esta clase es poder ver como inyectar dependencias entre las capas de nuestra aplicación para reducir el acoplamiento
entre las mismas y favorecer la extensibilidad, flexibilidad y reuso de componentes en nuestra aplicación.

Nuestra hoja de ruta consiste en ver:

1) ¿Qué es una dependencia?
2) ¿Qué es inyectar una dependencia?
3) Ventajas de la inyección de dependencias
4) Problema de la construcción de dependencias: Unity como contenedor de ID
5) Abstrayendo la lógica de la resolución de las dependencias ensamblado aparte

## ¿Qué es una dependencia?

En software, cuando hablamos de que dos piezas, componentes, librerías, módulos, clases, funciones (o lo que se nos pueda ocurrir relacionado al área), son dependientes entre sí, nos estamos refiriendo a que uno requiere del otro para funcionar. A nivel de clases, significa que una cierta **'Clase A'** tiene algún tipo de relación con una **'Clase B'**, delegándole el flujo de ejecución a la misma en cierta lógica.

De forma más concreta, una clase que se encarga de resolver la lógica de negocio de las mascotas en LUPI, llamémosla **PetsBusinessLogic**, debe interactuar con alguna clase que le permita mediar con la base de datos, llamémosla **PetsRepository**. Cuando queramos agregar una nueva mascota, la lógica de negocio PetsBusinessLogic deberá delegar el flujo a PetsRepository, para agregarla en la BD.

En consecuencia, **PetsBusinessLogic** *depende de* **PetsRepository**, o **PetsBusinessLogic** *--->* **PetsRepository**.

A nivel de código, esta puede ser una fórma válida de establecer una dependencia:

```c#

  public class BreedsBusinessLogic
  {
        public BreedsRepository breedsRepository;

        public BreedsBusinessLogic()
        {
            breedsRepository = new BreedsRepository();
        }
   }
```

## ¿Qué es inyectar una dependencia?

Actualmente nuestro diseño para Lupi consiste en diferentes proyectos, cada uno representando una .dll diferente, donde las dependencias son algo así:

##### Lupi.Web.Api ----> Lupi.BusinessLogic ----> Lupi.Repository ---> Lupi.DataAccess

Si bien la estructura es correcta, ¿cómo están las responsabilidades a nivel de cada módulo? En un principio parece bien, pero analicemos nuevamente el la forma en que las capas se comunican:

##### Web Api -> Business Logic


```c#

 public class BreedsController : ApiController
 {
        private IBreedsBusinessLogic breedsBusinessLogic { get; set; }

        public BreedsController()
        {
            breedsBusinessLogic = new BreedsBusinessLogic();
        }
 }
 ```
 
##### Business Logic -> Repository
 
 ```c#
  public class BreedsBusinessLogic : IBreedsBusinessLogic
  {
        //Posible mejora de esta clase:
        //Manejar un unico contexto para unificar las transacciones realizadas sobre Breeds a partir de una Unit Of Work

        public BreedsRepository breedsRepository;

        public BreedsBusinessLogic()
        {
            breedsRepository = new BreedsRepository();
        }
  }
 ```





