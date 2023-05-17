using ParcialPresentacionWeb3Modelo;
namespace ParcialPresentacionWeb3Servicio
{
    public class ClienteServicio : IClienteServicio
    {
        private List<ClienteModelo> listaDeClientes = new List<ClienteModelo>();

        public double RegistrarVenta(String cliente, int cantidadVendida, int precioUnitario) {

        ClienteModelo cli = new ClienteModelo();
            if (!listaDeClientes.Contains(cli)) {
                double id = GenerateId();
                cli.id = (int)id;
            }
            
            cli.Cliente = cliente;
            cli.CantidadVendida = cantidadVendida;
            cli.PrecioUnitario = precioUnitario;
            cli.Iva = (double)((cantidadVendida * precioUnitario) * 0.21m);
            cli.TotalVenta = cli.CantidadVendida * cli.PrecioUnitario + cli.Iva;
            double resultado = cli.TotalVenta;
            listaDeClientes.Add(cli);
            return resultado;




            /* if (cantidadVendida < 1 || cantidadVendida > 250) {
                 throw new Exception("La cantidad vendida debe ser mayor a 1 y menor igual a 250.");
             }

             if (precioUnitario < 10 || precioUnitario > 1000)
             {
                 throw new Exception(". El precio unitario debe ser mayor o igual a 10 y menor a 1000.");
             }*/

            /*else {

                ClienteModelo cli = new ClienteModelo();

                cli.Cliente = cliente;
                cli.CantidadVentida = cantidadVendida;
                cli.PrecioUnitario = precioUnitario;
                cli.Iva = (int)(cantidadVendida * precioUnitario * 0.21m);
                cli.TotalVenta = cli.CantidadVentida + cli.PrecioUnitario + cli.Iva;
                listaDeClientes.Add(cli);
                return cli.TotalVenta;

            } */



        }

        public List<ClienteModelo> listaClientes() {

            return listaDeClientes;
        }

        public double GenerateId()
        {
            int id = 1;

            if (listaDeClientes.Count != 0)
            {

                id = listaDeClientes.Max(o => o.id + 1);

            }

            return id;
        }


    }
}