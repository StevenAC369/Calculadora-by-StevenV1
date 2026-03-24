using Entidad;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
            string patron = @"[0-9]+([.,][0-9]+)?";

            MatchCollection numeros = Regex.Matches(operacion, patron);
            char[] delimitadores = { '+', '-', '*', '/', '%' };
            List<char> operadores = new List<char>();
            operadores = operacion.Where(c => delimitadores.Contains(c)).ToList();
            foreach (Match valor_obtenido in numeros)
            {
                Console.WriteLine("Valor obtenido: " + valor_obtenido.Value);
                double valor = Double.Parse(valor_obtenido.Value, CultureInfo.InvariantCulture);
                Console.WriteLine("Valor obtenido: " + valor.ToString());
                agregarDigito(new Digitos { Valor = valor });

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
