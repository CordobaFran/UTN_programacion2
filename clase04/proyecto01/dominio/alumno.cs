namespace proyecto01.Dominio;
public class Alumno : Persona
    {

        public Alumno(string legajo, float promedio)
        {
            this.Legajo = legajo;
            this.Promedio = promedio;        
        }

// se puede heredar el consturctor del padre usando base()
        public Alumno(string nombre, string apellido, string email, string legajo, float promedio) : base(nombre,apellido,email)
        {  
            this.Legajo = legajo;
            this.Promedio = promedio;
        }

        public string Legajo {get; set;}
        public float Promedio {get; set;}

        public override string Saludar()
        {
            return $"Hola mi nombre es {this.GetNombre()} {this.GetApellido()} y mi legajo es {Legajo}";
        }
    }