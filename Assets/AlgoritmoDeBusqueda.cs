using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Assets
{
	public class AlgoritmoDeBusqueda{

		List<Nodo> listaAbiertos = new List<Nodo> ();
		List<Nodo> candidatos = new List<Nodos>();

		public void busquedaGeneral(){
			//Anadir el padre a la lista de nodos (  abierta <---s0)
			Nodo padre = new Nodo();
			padre.setEstadoNodo (0, 0);
			listaAbiertos.Add (padre);



			//Repetir
			do{
				//Si vacia(abierta)? devolver negativo
				if(listaAbiertos.Count !=0){
					
					//Devolver negativo
				}
				//nodo <-- primero(abierta)
				Nodo nodoPorExpandir = listaAbiertos[0];
				listaAbiertos.RemoveAt(0);

				//Si meta?(nodo) entonces devolver(nodo)
				if(nodoPorExpandir.estado.esMeta())
					return nodoPorExpandir;

				//sucesores <-- expandir(nodo)
				candidatos.AddRange(nodoPorExpandir.expandir()); 


				//Para cada n sucesores hacer n.padre <-- nodo
				for(int i=0; i < candidatos.Count ;i++){
					candidatos[i].padre = nodoPorExpandir;

					//OrdenarInsertar
				}

				
			



				/*List<Nodo> candidatos = nodoPorExpandir.expandir();

				}*/
		

		

		//Añade nodos a la lista de nodos explorados
		public void aniadirNodoAListaExplorados(Nodo nodo){
			listaAbiertos.Add (nodo);

		}
	}	

