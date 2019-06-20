using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionRecursiveSum
{
    /// <summary>
    /// Ejemplo que evalua una lista de números para ordenarlos por tipo de acuerdo a la suma de conjuntos especificado en el parametro parametro
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Cavidades
            Listas listas = new Listas();
            listas.NoEvaluadas = new List<Cavidad>();
            listas.Evaluadas = new List<Cavidad>();

            Cavidad c = new Cavidad();
            c.Nombre = "C1";
            c.Valor = 25;
            listas.NoEvaluadas.Add(c);
            c = new Cavidad();
            c.Nombre = "C2";
            c.Valor = 25;
            listas.NoEvaluadas.Add(c);
            c = new Cavidad();
            c.Nombre = "C3";
            c.Valor = 25;
            listas.NoEvaluadas.Add(c);
            c = new Cavidad();
            c.Nombre = "C4";
            c.Valor = 25;
            listas.NoEvaluadas.Add(c);
            c = new Cavidad();
            c.Nombre = "C5";
            c.Valor = 25;
            listas.NoEvaluadas.Add(c);
            c = new Cavidad();
            c.Nombre = "C6";
            c.Valor = 25;
            listas.NoEvaluadas.Add(c);
            c = new Cavidad();
            c.Nombre = "C7";
            c.Valor = 25;
            listas.NoEvaluadas.Add(c);
            c = new Cavidad();
            c.Nombre = "C8";
            c.Valor = 25;
            listas.NoEvaluadas.Add(c);
            c = new Cavidad();
            c.Nombre = "C9";
            c.Valor = 50;
            listas.NoEvaluadas.Add(c);
            c = new Cavidad();
            c.Nombre = "C10";
            c.Valor = 50;
            listas.NoEvaluadas.Add(c);

            #endregion

            #region TiposCrudos

            Dictionary<string, int> parametros = new Dictionary<string, int>();
            parametros.Add("Maya", 100);
            parametros.Add("Istmo", 100);
            parametros.Add("Olmeca", 100);

            #endregion


            Listas resultado = EvaluarLista(listas, parametros);

        }

        private Listas EvaluarLista(Listas cavidades, Dictionary<string,int> parametros)
        {           

            if(cavidades.NoEvaluadas.Count > 0 && cavidades.NoEvaluadas[0].Valor == parametros.ElementAt(0).Value)
            {
                if (cavidades.Evaluadas == null)
                    cavidades.Evaluadas = new List<Cavidad>();
                cavidades.NoEvaluadas[0].Tipo = parametros.ElementAt(0).Key;
                cavidades.Evaluadas.Add(cavidades.NoEvaluadas[0]);
                cavidades.NoEvaluadas.RemoveAt(0);
                parametros.Remove(parametros.ElementAt(0).Key);
                if (cavidades.NoEvaluadas.Count > 0)
                    EvaluarLista(cavidades, parametros);

            }
            else
            {
                var sum = 0;

                var fixedSize = cavidades.NoEvaluadas.ToArray();
                foreach (var item in fixedSize)
                {
                    sum = sum + item.Valor;
                    item.Tipo = parametros.ElementAt(0).Key;
                    cavidades.Evaluadas.Add(item);
                    cavidades.NoEvaluadas.Remove(item);
                    if (sum == parametros.ElementAt(0).Value)
                    {
                        parametros.Remove(parametros.ElementAt(0).Key);
                        EvaluarLista(cavidades, parametros);
                        break;
                    }
                }

            }

            return cavidades;
        }
    }

    public class Cavidad
    {
        public string Nombre { get; set; }
        public int Valor { get; set; }
        public string Tipo { get; set; }
    }

    public class Listas
    {
        public List<Cavidad> Evaluadas { get; set; }
        public List<Cavidad> NoEvaluadas { get; set; }
    }
}

