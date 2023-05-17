using ParcialPresentacionWeb3Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPresentacionWeb3Servicio
{
    public interface IClienteServicio
    {
        public double RegistrarVenta(String cliente, int cantidadVendida, int precioUnitario);
        public List<ClienteModelo> listaClientes();

        public double GenerateId();




    }
}
