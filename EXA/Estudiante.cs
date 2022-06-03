using System;

namespace EXA

{
    class Estudiante
    {
        string Nombre { set; get; }
        string Apellido { set; get; }
        string Nombre_institucion { set; get; }
        int Cedula_identidad { set; get; }

        public Estudiante (string N_ombre, string A_pellido, string I_nstitucion, int C_edula)
        {
            this.Nombre = N_ombre;
            this.Apellido = A_pellido;
            this.Nombre_institucion = I_nstitucion;
            this.Cedula_identidad = C_edula;
        }

        public void imprimir()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("la informacion del estudiante de primaria");
            Console.WriteLine();
            Console.WriteLine();




        }

        
    }
}
