using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Operadores
    {
        Digitos digitos;
        public Operadores()
        {

        }

        public double calcular(Coleccion coleccion)
        {
            if (coleccion.Digito == null || coleccion.Digito.Count == 0)
                throw new InvalidOperationException("No hay números para calcular.");

            double result = coleccion.Digito[0].Valor;

            for (int i = 0; i < coleccion.Operadores.Count; i++)
            {
                char op = coleccion.Operadores[i].Simbolos;
                double operand = coleccion.Digito[i + 1].Valor;

                switch (op)
                {
                    case '+':
                        result += operand;
                        break;
                    case '-':
                        result -= operand;
                        break;
                    case '*':
                        result *= operand;
                        break;
                    case '/':
                        if (operand == 0) throw new DivideByZeroException("No se puede dividir por cero.");
                        result /= operand;
                        break;
                    case '%':
                        if (operand == 0) throw new DivideByZeroException("No se puede dividir por cero.");
                        result %= operand;
                        break;
                    default:
                        throw new InvalidOperationException($"Operador desconocido: {op}");
                }
            }

            return result;
            }
        }
    }
