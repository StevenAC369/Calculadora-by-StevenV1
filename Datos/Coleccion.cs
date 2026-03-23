using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace Datos
{
    public class Coleccion
    {
        public List<Digitos> Digito { get; set; }
        public List<Operador> Operadores { get; set; }
        char[] delimitadores = { '+', '-', '*', '/', '%' };
        public Coleccion()
        {
            Digito = new List<Digitos>();
            Operadores = new List<Operador>();
        }

        public void agregarDigito(Digitos digitos)
        {
            Digito.Add(digitos);
        }
        public void agregarOperador(Operador operador)
        {
            Operadores.Add(operador);
        }

        public void agregarDigitos(Digitos digitos)
        {
            Digito.Add(digitos);
        }
        public void calcular_resultado(string operacion)
        {
            char[] delimitadores = { '+', '-', '*', '/', '%' };
            List<double> numeros = new List<double>();
            numeros = operacion.Split(delimitadores).Select(double.Parse).ToList();
            List<char> operadores = new List<char>();
            operadores = operacion.Where(c => delimitadores.Contains(c)).ToList();
            for (int i = 0; i < numeros.Count; i++)
            {
                agregarDigito(new Digitos { Valor = numeros[i] });
            }
            for (int i = 0; i < operadores.Count; i++)
            {
                agregarOperador(new Operador { Simbolos = operadores[i] });
            }

        }
        public void Limpiar()
        {
            Digito.Clear();
            Operadores.Clear();
        }
    }
}
