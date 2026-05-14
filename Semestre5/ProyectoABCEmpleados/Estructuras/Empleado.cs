using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoABCEmpleados.Estructuras
{
    internal class Empleado
    {
        private string Dpi;
        private string Nombre;
        private string Direccion;
        private string Email;
        private string Celular;
        private int Edad;
        private double Salario;
        private string Descuentos;
        private string Fecha_inicio;
        private string Profesion;

        public Empleado? Siguiente;

        public Empleado()
        {
            this.Dpi = string.Empty;
            this.Nombre = string.Empty;
            this.Direccion = string.Empty;
            this.Email = string.Empty;
            this.Celular = string.Empty;
            this.Edad = 0;
            this.Salario = 0;
            this.Descuentos = string.Empty;
            this.Fecha_inicio = string.Empty;
            this.Profesion = string.Empty;
            this.Siguiente = null;
        }

        public string GetDpi() => this.Dpi;
        public void SetDpi(string v) => this.Dpi = v;


        public string GetNombre() => this.Nombre;
        public void SetNombre(string v) => this.Nombre = v;

        public string GetDireccion() => this.Direccion;
        public void SetDireccion(string v) => this.Direccion = v;

        public string GetEmail() => this.Email;
        public void SetEmail(string v) => this.Email = v;

        public string GetCelular() => this.Celular;
        public void SetCelular(string v) => this.Celular = v;

        public int GetEdad() => this.Edad;
        public void SetEdad(int v) => this.Edad = v;

        public double GetSalario() => this.Salario;
        public void SetSalario(double v) => this.Salario = v;

        public string GetDescuentos() => this.Descuentos;
        public void SetDescuentos(string v) => this.Descuentos = v;

        public string GetFechaInicio() => this.Fecha_inicio;
        public void SetFechaInicio(string v) => this.Fecha_inicio = v;

        public string GetProfesion() => this.Profesion;
        public void SetProfesion(string v) => this.Profesion = v;

        public string GetClave() => this.Email;


        public override string ToString()
        {
            return $"[Empleado] Nombre: {Nombre} | Email: {Email} | " +
                   $"Celular: {Celular} | Edad: {Edad} | Salario: {Salario:C} | " +
                   $"Dirección: {Direccion} | Profesión: {Profesion} | " +
                   $"Descuentos: {Descuentos} | Inicio: {Fecha_inicio}";
        }


    }
}
