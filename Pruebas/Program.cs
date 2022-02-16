using System;
using System.Collections.Generic;

namespace Pruebas
{
    class Program
    {

        abstract class Persona
        {
            public int edad;
            public string sexo;

            public Rango range
            {
                get
                {
                    if (edad > 0 && edad <= 19) return Rango.MuyJoven;
                    if (edad >= 20 && edad <= 29) return Rango.Joven;
                    if (edad >= 30 && edad <= 39) return Rango.Plenitud;
                    if (edad >= 40 && edad <= 49) return Rango.Madurez;
                    return Rango.Vejez;
                }
            }

            class personas : Persona
            {

                private string nombre { get; set; }
                private int edad { get; set; }

                private string sexo { get; set; }


                public personas(string nombre, int edad, string sexo)
                {
                    this.nombre = nombre;
                    this.edad = edad;
                    this.sexo = sexo;
                }
            }
            public enum Rango
            {
                MuyJoven, Joven, Plenitud, Madurez, Vejez

            }

                public string AdmitenDescendencia()
                {
                    List<Persona> personas = new()
                    {
                        new personas("Pedro", 44, "H"),
                        new personas("Maria", 32, "F"),
                        new personas("Ane", 25, "F"),
                        new personas("Mikel", 55, "H"),
                        new personas("Marcos", 25, "H"),
                        new personas("Naiara", 17, "F"),
                        new personas("Itziar", 45, "F"),
                        new personas("Martin", 15, "H"),
                        new personas("Ane", 14, "H"),
                        new personas("Maiali", 57, "F"),
                    };

                    List<(Persona, Persona)> parejas = new();

                    for (var i = 0; i < personas.Count - 1; i++)
                    {
                        for (var j = i + 1; j < personas.Count; j++)
                        {
                            if ((personas[i].edad - personas[j].edad < 12) && (personas[i].sexo != personas[j].sexo))
                            {
                                if (Math.Abs(personas[i].range - personas[j].range) <= 1)
                                {
                                    parejas.Add((personas[i], personas[j]));
                                    return$"{parejas}";
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}


