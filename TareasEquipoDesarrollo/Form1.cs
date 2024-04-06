using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TareasEquipoDesarrollo
{
    public partial class Form1 : Form
    {
        ArbolBinarioBusqueda arbolTareas = new ArbolBinarioBusqueda();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            string nombreTarea = txtNombreTarea.Text;
            int duracion = int.Parse(txtDuracion.Text);
            int porcentajeAvance = int.Parse(txtPorcentajeAvance.Text);
            string programadorAsignado = txtProgramadorAsignado.Text;

            Tarea tarea = new Tarea(nombreTarea, duracion, porcentajeAvance, programadorAsignado);
            arbolTareas.insertar(tarea);
            ActualizarListBox();
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            string nombreTarea = listBoxTareas.SelectedItem?.ToString();
            if (nombreTarea != null)
            {
                Tarea tarea = new Tarea(nombreTarea);
                arbolTareas.eliminar(tarea);
                ActualizarListBox();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una tarea para eliminar.");
            }
        }

        private void btnBuscarPorNombre_Click(object sender, EventArgs e)
        {
            string nombreTarea = txtBuscarPorNombre.Text;
            if (!string.IsNullOrEmpty(nombreTarea))
            {
                Tarea tareaBuscada = new Tarea(nombreTarea);
                Nodo nodoEncontrado = arbolTareas.buscar(tareaBuscada);
                if (nodoEncontrado != null)
                {
                    MessageBox.Show($"Tarea encontrada:\nNombre: {((Tarea)nodoEncontrado.getDato()).Nombre}\nDuración: {((Tarea)nodoEncontrado.getDato()).Duracion}\nPorcentaje Avance: {((Tarea)nodoEncontrado.getDato()).PorcentajeAvance}%\nProgramador Asignado: {((Tarea)nodoEncontrado.getDato()).ProgramadorAsignado}");
                }
                else
                {
                    MessageBox.Show("La tarea no fue encontrada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese el nombre de la tarea a buscar.");
            }
        }

        private void ActualizarListBox()
        {
            listBoxTareas.Items.Clear();
            List<Tarea> listaTareas = arbolTareas.EnOrden();
            foreach (Tarea tarea in listaTareas)
            {
                listBoxTareas.Items.Add(tarea.Nombre);
            }
        }
    }

    public class Tarea : Comparador
    {
        public string Nombre { get; set; }
        public int Duracion { get; set; }
        public int PorcentajeAvance { get; set; }
        public string ProgramadorAsignado { get; set; }

        public Tarea(string nombre)
        {
            Nombre = nombre;
        }

        public Tarea(string nombre, int duracion, int porcentajeAvance, string programadorAsignado)
        {
            Nombre = nombre;
            Duracion = duracion;
            PorcentajeAvance = porcentajeAvance;
            ProgramadorAsignado = programadorAsignado;
        }

        public bool igualQue(object q)
        {
            return Nombre.CompareTo(((Tarea)q).Nombre) == 0;
        }

        public bool menorQue(object q)
        {
            return Nombre.CompareTo(((Tarea)q).Nombre) < 0;
        }

        public bool mayorQue(object q)
        {
            return Nombre.CompareTo(((Tarea)q).Nombre) > 0;
        }
    }

    public interface Comparador
    {
        bool igualQue(object q);
        bool menorQue(object q);
        bool mayorQue(object q);
    }

    public class Nodo
    {
        private Comparador dato;
        private Nodo izquierda;
        private Nodo derecha;

        public Nodo(Comparador dato)
        {
            this.dato = dato;
            izquierda = null;
            derecha = null;
        }

        public Comparador getDato()
        {
            return dato;
        }

        public Nodo getIzquierda()
        {
            return izquierda;
        }

        public Nodo getDerecha()
        {
            return derecha;
        }

        public void setIzquierda(Nodo nodo)
        {
            izquierda = nodo;
        }

        public void setDerecha(Nodo nodo)
        {
            derecha = nodo;
        }
    }


    public class ArbolBinarioBusqueda
    {
        private Nodo raiz;

        public ArbolBinarioBusqueda()
        {
            raiz = null;
        }

        public void insertar(Object valor)
        {
            Comparador dato;
            dato = (Comparador)valor;
            raiz = insertar(raiz, dato);
        }

        protected Nodo insertar(Nodo raizSub, Comparador dato)
        {
            if (raizSub == null)
                raizSub = new Nodo(dato);
            else if (dato.menorQue(raizSub.getDato()))
            {
                Nodo iz;
                iz = insertar(raizSub.getIzquierda(), dato);
                raizSub.setIzquierda(iz);
            }
            else if (dato.mayorQue(raizSub.getDato()))
            {
                Nodo dr;
                dr = insertar(raizSub.getDerecha(), dato);
                raizSub.setDerecha(dr);
            }
            else throw new Exception("Nodo duplicado");
            return raizSub;
        }

        public void eliminar(Object valor)
        {
            Comparador dato;
            dato = (Comparador)valor;
            raiz = eliminar(raiz, dato);
        }

        protected Nodo eliminar(Nodo raizSub, Comparador dato)
        {
            if (raizSub == null)
                throw new Exception("No encontrado el nodo con la clave");
            else if (dato.menorQue(raizSub.getDato()))
            {
                Nodo iz;
                iz = eliminar(raizSub.getIzquierda(), dato);
                raizSub.setIzquierda(iz);
            }
            else if (dato.mayorQue(raizSub.getDato()))
            {
                Nodo dr;
                dr = eliminar(raizSub.getDerecha(), dato);
                raizSub.setDerecha(dr);
            }
            else // Nodo encontrado
            {
                Nodo q;
                q = raizSub; // nodo a quitar del árbol
                if (q.getIzquierda() == null)
                    raizSub = q.getDerecha();
                else if (q.getDerecha() == null)
                    raizSub = q.getIzquierda();
                else
                { // tiene rama izquierda y derecha
                    q = reemplazar(q);
                }
                q = null;
            }
            return raizSub;
        }

        private Nodo reemplazar(Nodo act)
        {
            Nodo a, p;
            p = act;
            a = act.getIzquierda(); // rama de nodos menores
            while (a.getDerecha() != null)
            {
                p = a;
                a = a.getDerecha();
            }
            act = a;
            if (p == act)
                p.setIzquierda(a.getIzquierda());
            else
                p.setDerecha(a.getIzquierda());
            return act;
        }

        public Nodo buscar(Object buscado)
        {
            Comparador dato;
            dato = (Comparador)buscado;
            if (raiz == null)
                return null;
            else
                return buscar(raiz, dato);
        }

        protected Nodo buscar(Nodo raizSub, Comparador buscado)
        {
            if (raizSub == null)
                return null;
            else if (buscado.igualQue(raizSub.getDato()))
                return raizSub;
            else if (buscado.menorQue(raizSub.getDato()))
                return buscar(raizSub.getIzquierda(), buscado);
            else
                return buscar(raizSub.getDerecha(), buscado);
        }

        public List<Tarea> EnOrden()
        {
            List<Tarea> lista = new List<Tarea>();
            EnOrden(raiz, lista);
            return lista;
        }

        private void EnOrden(Nodo nodo, List<Tarea> lista)
        {
            if (nodo != null)
            {
                EnOrden(nodo.getIzquierda(), lista);
                lista.Add((Tarea)nodo.getDato());
                EnOrden(nodo.getDerecha(), lista);
            }
        }
    }
}
