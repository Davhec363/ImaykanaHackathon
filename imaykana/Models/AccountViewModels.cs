using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Amaykana.Models
{
    public class AccountModel
    {
        private string codigo;
        private string descripcion;
        private int cantidad;
        private double precio;
        private double precioTotal;

        [Display(Name = "Code")]
        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        [Display(Name = "Description")]
        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        [Display(Name = "Quantity")]
        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }
        [Display(Name = "Green coins")]
        public double Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }


        [Display(Name = "Total green coins")]
        public double PrecioTotal
        {
            get
            {
                return precioTotal;
            }

            set
            {
                precioTotal = cantidad * precio;
            }
        }
    }

    public class ListaUsuarios
    {
        public List<AccountModel> ListaUsuariosApp = new List<AccountModel>();


        public void Usuarios()
        {
            var account = new AccountModel();
            account.Codigo = "0001";
            account.Descripcion = "Botella plastica 365ml";
            account.Cantidad = 1;
            account.Precio = 5;
            account.PrecioTotal = account.Precio * account.Cantidad;
            ListaUsuariosApp.Add(account);

            var account2 = new AccountModel();
            account2.Codigo = "0002";
            account2.Descripcion = "Botella plastica 1000ml";
            account2.Cantidad = 15;
            account2.Precio = 6;
            account2.PrecioTotal = account2.Precio * account2.Cantidad;
            ListaUsuariosApp.Add(account2);

            var account3 = new AccountModel();
            account3.Codigo = "0003";
            account3.Descripcion = "Botella plastica 850ml";
            account3.Cantidad = 10;
            account3.Precio = 7;
            account3.PrecioTotal = account3.Precio * account3.Cantidad;
            ListaUsuariosApp.Add(account3);

        }

        public double Total()
        {
            var total = 0.0;
            foreach (AccountModel item in ListaUsuariosApp)
            {
                total = item.PrecioTotal + total;
            }

            return total;
        }

    }
}