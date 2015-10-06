using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace EclairProject
{
    public class Persist
    {
        private static string x = ("Operação não utilizada! Parâmetro vazio");
        private static string id = null;

        public void setId(String valor)
        {
            id = valor;
        }
        public String getId()
        {
            return id;
        }
    }
}
