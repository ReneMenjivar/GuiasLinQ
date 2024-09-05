#region Introduccion 
/*string[]palabras;
palabras = new string[] { "gato", "perro", "lagarto", "tortuga", "cocdrilo","serpiente", "123456789" };
Console.WriteLine("Mas de 5 letras");

List<string> resultado = new List<string>();

foreach (string str in palabras) {
    if (str.Length >5) {
        resultado.Add(str);
    }
}

foreach (var r in resultado) 
    Console.WriteLine(r);
*/
#endregion
#region utilizando Linq
/*Console.WriteLine("-----------------------------------------------------");    
IEnumerable<string> list = from r in palabras where r.Length > 8 select r;
foreach(var listado in list)
    Console.WriteLine(listado);
Console.WriteLine("-----------------------------------------------------");
*/
#endregion

using IntroduccionLinQ;
using IntroduccionLinQ;
#region ListaModelos
// Listas para almacenar casas y habitantes
List<Casa> ListaCasas = new List<Casa>();
List<Habitante> ListaHabitantes = new List<Habitante>();

// Añadir casas a la lista
#region listaCasa
// Añadiendo casas a la lista ListaCasas
ListaCasas.Add(new Casa
{
    Id = 1, // Identificador de la casa
    Direccion = "3 av Norte ArcanCity", // Dirección de la casa
    Ciudad = "Gothan City", // Ciudad en la que se encuentra la casa
    numeroHabitaciones = 20 // Número de habitaciones en la casa
});
ListaCasas.Add(new Casa
{
    Id = 2,
    Direccion = "6 av Sur SmollVille",
    Ciudad = "Metropolis",
    numeroHabitaciones = 5
});
ListaCasas.Add(new Casa
{
    Id = 3,
    Direccion = "Forest Hills, Queens, NY 11375",
    Ciudad = "New York"
});
#endregion

// Añadir habitantes a la lista
#region ListaHabitante
// Añadiendo habitantes a la lista ListaHabitantes
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1, // Identificador del habitante
    Nombre = "Bruno Diaz", // Nombre del habitante
    Edad = 36, // Edad del habitante
    IdCasa = 1 // Identificador de la casa en la que vive
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 2,
    Nombre = "Clark Kent",
    Edad = 40,
    IdCasa = 2
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 3,
    Nombre = "Peter Parker",
    Edad = 25,
    IdCasa = 3
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 4, // Corrección en el IdHabitante
    Nombre = "Tia Mey",
    Edad = 85,
    IdCasa = 3
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 5, // Corrección en el IdHabitante
    Nombre = "Luise Lain",
    Edad = 40,
    IdCasa = 2
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 6, // Corrección en el IdHabitante
    Nombre = "Selina Kyle",
    Edad = 30,
    IdCasa = 1
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 7, // Corrección en el IdHabitante
    Nombre = "Alfred",
    Edad = 65,
    IdCasa = 1
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 8, // Corrección en el IdHabitante
    Nombre = "Nathan Drake",
    Edad = 36,
    IdCasa = 1
});
#endregion

// Consultas LINQ
#region SentenciasLinQ
// Consulta LINQ para filtrar habitantes mayores de 40 años
IEnumerable<Habitante> ListaEdad = from ObjetoProvicional
                                   in ListaHabitantes
                                   where ObjetoProvicional.Edad > 40 // Condición: Edad mayor de 40
                                   select ObjetoProvicional;

// Imprimir datos de habitantes mayores de 40 años
foreach (Habitante objetoProcicional2 in ListaEdad)
{
    Console.WriteLine(objetoProcicional2.datosHabitante());
}

// Consulta LINQ con Join para encontrar habitantes en "Gothan City"
IEnumerable<Habitante> listaCasaGothan = from objetoTemporalHabitante in ListaHabitantes
                                         join objetoTemporalCasa in ListaCasas
                                         on objetoTemporalHabitante.IdCasa equals objetoTemporalCasa.Id // Join basado en el identificador de la casa
                                         where objetoTemporalCasa.Ciudad == "Gothan City" // Filtrar por ciudad
                                         select objetoTemporalHabitante;

// Imprimir datos de habitantes que viven en "Gothan City"
Console.WriteLine("----------------------------------------------------------------------------------------------");
foreach (Habitante h in listaCasaGothan)
{
    Console.WriteLine(h.datosHabitante());
}


#endregion
#region FirsthAndFirsthOrDefault
/* Console.WriteLine("----------------------------------------------------------------------------------------------");
var primeraCasa = ListaCasas.First(); //esto no es linQ es  una fucnin de los Ienumarable
Console.WriteLine(primeraCasa.dameDatosCasa());

//aplicando una restriccion sin restricion lambda
Habitante personaEdad = (from variableTemporalHabitante in ListaHabitantes where variableTemporalHabitante.Edad > 25 select variableTemporalHabitante).First();
Console.WriteLine(personaEdad.datosHabitante());
Console.WriteLine("---------------------------Lo mismo pero con lambdas---------------------------------------------------------");
var Habitante1 = ListaHabitantes.First(objectTemp => objectTemp.Edad >25);
Console.WriteLine(Habitante1.datosHabitante());

// Si no tenemos el elemento que buscamos entoences la sonsulta devolvera una exepcion esto detendra el codigo en su totalidad

//Casa EdadError = (from vCasaTemp in ListaCasas where vCasaTemp.Id >10 select vCasaTemp).First() ;
//Console.WriteLine(EdadError.dameDatosCasa());

Casa CasaConFirsthOrDedault = ListaCasas.FirstOrDefault(vCasa => vCasa.Id > 200);
if (CasaConFirsthOrDedault == null ) {
    Console.WriteLine("No existe !No hay!");
    return;
}
Console.WriteLine("existe !Si existe!");
*/
#endregion
#endregion