using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
	
	public class Nodo{

	//atributos
		public Nodo padre;
		public Estado estado { get; set;}
		public bool meta;

		public void setEstadoNodo(int j1, int j2){
		
			estado.setEstado (0, 0);
		
		}

		public Nodo(Nodo padre, Estado estadoActual){
			this.padre = padre;
			this.estado = estadoActual;
		
		}
	

		//Inicializa el nodo padre
		private void iniciarNodoPadre(){
			//

		}

		public List <Nodo> expandir(){
			
			List<Nodo> listaNodosHijos = new List<Nodo>();

			//Crea la lista 
			List<Estado> listaEstados = this.estado.expandir ();

			for (int i = 0;  i < listaEstados.Count ; i++) {
				//ELIMINA LOS BUCLES
				//Comprueba si es igual que el padre y si lo es, se descarta
				if (listaEstados[i] ==  this.padre.estado) {
					listaEstados.RemoveAt (i);
				} else {
					//Si no se encuentra en la lista de candidatos, lo añade
					Nodo nuevoNodo = new Nodo (this, listaEstados[i]);
					listaNodosHijos.Add (nuevoNodo);
				}
			}




			return listaNodosHijos;

		}


		/* esto lo tiene q preguntar al estado
		public void isMeta(){
			if(estado.jarra4 == 2){
				meta = true;	
			}
		}/*

	}
}