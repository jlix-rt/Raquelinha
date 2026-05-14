using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoABCEmpleados.Estructuras
{
    internal class TablaHash
    {
        // ── Atributos ────────────────────────────────────────────────────
        private Empleado[] buckets;
        private int capacidad;
        private int total;

        private const double FACTOR_CARGA_MAX = 0.75;

        // ── Constructor ──────────────────────────────────────────────────
        public TablaHash(int capacidad = 10)
        {
            this.capacidad = capacidad;
            this.buckets = new Empleado[capacidad];
            this.total = 0;
        }

        // ── Factor de carga ──────────────────────────────────────────────
        private double FactorDeCarga() => (double)this.total / this.capacidad;

        // ── Función hash (sobrecarga para rehashing) ─────────────────────
        private int FuncionHash(string clave)
            => FuncionHash(clave, this.capacidad);

        private int FuncionHash(string clave, int cap)
        {
            int suma = 0;
            foreach (char c in clave)
                suma += (int)c;
            return suma % cap;
        }

        // ── Rehashing ────────────────────────────────────────────────────
        private void Rehashing()
        {
            int nuevaCapacidad = this.capacidad * 2;
            Empleado[] nuevoArray = new Empleado[nuevaCapacidad];

            Console.WriteLine($"\n⚙  Rehashing: {this.capacidad} → {nuevaCapacidad} buckets...");

            for (int i = 0; i < this.capacidad; i++)
            {
                Empleado actual = this.buckets[i];

                while (actual != null)
                {
                    if (actual.Siguiente != null)
                    {
                        Empleado siguiente = actual.Siguiente;
                        int nuevoIdx = FuncionHash(actual.GetClave(), nuevaCapacidad);
                        actual.Siguiente = nuevoArray[nuevoIdx];
                        nuevoArray[nuevoIdx] = actual;
                        actual = siguiente;
                    }
                }
            }

            this.buckets = nuevoArray;
            this.capacidad = nuevaCapacidad;
            Console.WriteLine($"✔  Rehashing completado. Nueva capacidad: {this.capacidad}" +
                              $" | Factor de carga actual: {FactorDeCarga():F2}\n");
        }

        // ── INSERTAR ─────────────────────────────────────────────────────
        public void Insertar(Empleado nuevo)
        {
            int idx = FuncionHash(nuevo.GetClave());
            Empleado actual = buckets[idx];

            // Si el email ya existe → actualizar datos
            while (actual != null)
            {
                if (actual.GetClave() == nuevo.GetClave())
                {
                    actual.SetNombre(nuevo.GetNombre());
                    actual.SetDireccion(nuevo.GetDireccion());
                    actual.SetCelular(nuevo.GetCelular());
                    actual.SetEdad(nuevo.GetEdad());
                    actual.SetSalario(nuevo.GetSalario());
                    actual.SetDescuentos(nuevo.GetDescuentos());
                    actual.SetFechaInicio(nuevo.GetFechaInicio());
                    actual.SetProfesion(nuevo.GetProfesion());
                    Console.WriteLine($"↺  Empleado '{nuevo.GetNombre()}' actualizado " +
                                      $"en bucket [{idx}].");
                    return;
                }
                actual = actual.Siguiente;
            }

            // No existe → insertar al frente del bucket
            nuevo.Siguiente = buckets[idx];
            buckets[idx] = nuevo;
            this.total++;

            Console.WriteLine($"✚  '{nuevo.GetNombre()}' → bucket [{idx}]" +
                              $" | Carga: {FactorDeCarga():F2}");

            // Verificar si hay que crecer
            if (FactorDeCarga() >= FACTOR_CARGA_MAX)
                Rehashing();
        }

        // ── BUSCAR ───────────────────────────────────────────────────────
        public Empleado Buscar(string email)
        {
            int idx = FuncionHash(email);
            Empleado actual = buckets[idx];

            while (actual != null)
            {
                if (actual.GetClave() == email)
                    return actual;
                actual = actual.Siguiente;
            }

            return null;
        }

        // ── ELIMINAR ─────────────────────────────────────────────────────
        public bool Eliminar(string email)
        {
            int idx = FuncionHash(email);
            Empleado actual = buckets[idx];
            Empleado anterior = null;

            while (actual != null)
            {
                if (actual.GetClave() == email)
                {
                    if (anterior == null)
                        buckets[idx] = actual.Siguiente;
                    else
                        anterior.Siguiente = actual.Siguiente;

                    this.total--;
                    Console.WriteLine($"✖  Empleado '{actual.GetNombre()}' eliminado." +
                                      $" | Carga: {FactorDeCarga():F2}");
                    return true;
                }
                anterior = actual;
                actual = actual.Siguiente;
            }

            Console.WriteLine($"✖  Email '{email}' no encontrado.");
            return false;
        }

        // ── MOSTRAR TABLA COMPLETA ────────────────────────────────────────
        public void MostrarTodos()
        {
            Console.WriteLine($"\n{'═',1}{'/',0}══ Tabla Hash ══" +
                              $" Capacidad: {capacidad} | Empleados: {total}" +
                              $" | Carga: {FactorDeCarga():F2} ══");

            for (int i = 0; i < capacidad; i++)
            {
                Console.Write($"  Bucket [{i,2}]: ");

                if (buckets[i] == null)
                {
                    Console.WriteLine("vacío");
                    continue;
                }

                Empleado actual = buckets[i];
                while (actual != null)
                {
                    Console.Write(actual.GetNombre());
                    if (actual.Siguiente != null)
                        Console.Write(" → ");
                    actual = actual.Siguiente;
                }
                Console.WriteLine();
            }

            Console.WriteLine(new string('═', 55) + "\n");
        }

        // ── MOSTRAR UN EMPLEADO ───────────────────────────────────────────
        public void MostrarEmpleado(string email)
        {
            Empleado e = Buscar(email);
            if (e != null)
                Console.WriteLine(e.ToString());
            else
                Console.WriteLine($"Empleado con email '{email}' no encontrado.");
        }

        // ── GETTERS INFORMATIVOS ──────────────────────────────────────────
        public int GetTotal() => this.total;
        public int GetCapacidad() => this.capacidad;
        public double GetFactorCarga() => FactorDeCarga();

        public string ObtenerEmpleados()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < capacidad; i++)
            {
                Empleado actual = buckets[i];

                while (actual != null)
                {
                    sb.AppendLine(actual.ToString());
                    actual = actual.Siguiente;
                }
            }

            // Si no hay empleados
            if (sb.Length == 0)
                return "No hay empleados registrados.";

            return sb.ToString();
        }
    }
}
