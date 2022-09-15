using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bancoPoo.Models
{
    class Banco
    {
        public string NumeroCuenta { get; set; }
        public string Identifica { get; set; }
        public string nombre { get; set; }
        public string dirección { get; set; }
        public int saldo { get; set; }



        public Banco(string cuenta, string identidad, string nombre, string direccion, int saldo)
        {
            this.NumeroCuenta = cuenta;
            this.Identifica = identidad;
            this.nombre = nombre;
            this.dirección = direccion;
            this.saldo = saldo;




        }

        public void Depositar(int cantidad)
        {
            this.saldo += cantidad;

        }

        public void retirar(int retiro)
        {
            this.saldo-= retiro;
        }

        public int consultaSaldo()
        {
            return saldo;
        }



    }   

   
}
