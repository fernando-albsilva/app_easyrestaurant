using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Pedido
    {
        private string numero_pedido;
        private Array lista_produto;
        private string mesa_numero;
        private string id_garcom;
        private string id_usuario;

        public Pedido(string numero_pedido, Array lista_produto, string mesa_numero, string id_garcom, string id_usuario)
        {
            this.Numero_pedido = numero_pedido;
            this.Lista_produto = lista_produto;
            this.Mesa_numero = mesa_numero;
            this.Id_garcom = id_garcom;
            this.Id_usuario = id_usuario;
        }

        public string Numero_pedido { get => numero_pedido; set => numero_pedido = value; }
        public Array Lista_produto { get => lista_produto; set => lista_produto = value; }
        public string Mesa_numero { get => mesa_numero; set => mesa_numero = value; }
        public string Id_garcom { get => id_garcom; set => id_garcom = value; }
        public string Id_usuario { get => id_usuario; set => id_usuario = value; }

        public decimal Valor_total_pedido()
        {
            return 1;
        }

        public void Adiciona_produto()
        {

        }

        public void Exclui_produto()
        {

        }
    }
}
