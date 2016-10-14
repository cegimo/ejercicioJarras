using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Assets
{
	public class Estado 
	{
		public int jarra3 { get; set;}
		public int jarra4 { get; set;}

		public Estado(int j3, int j4)
		{
			jarra3 = j3;
			jarra4 = j4;
		}

		public void setEstado(int j3, int j4){
			jarra3 = j3;
			jarra4 = j4;
		}
			
		//Sirve para el caso particular
		public bool esMeta(){
			return J4 == 2;
		}

		/*/Para el caso general hay que pasarle la lista de estados para que las compare
		public bool EsMeta(lista de estados){
			return J4 == 2;
		}*/

		//Si la lista está vacia, es que el nodo no se puede expandir
		public List<Estado> Expandir()
		{
			List<Estado> estadosCandidatos = new List<Estado> ();

			//Lenado de Jarras
			if (jarra3 < 3) {
				estadosCandidatos.Add (llenarJarra3 ());
			}
			if (jarra3 < 4){
				estadosCandidatos.Add (llenarJarra4());
			}

			//Vaciado de jarras
			if (jarra3 > 0){
				estadosCandidatos.Add (vaciarJarra3 ());
			}
			if (jarra4 > 0) {
				estadosCandidatos.Add (vaciarJarra4 ());
			}

			// Intercambio de una jarra a otra
			if (jarra4 < 4) {
				estadosCandidatos.Add (vaciarJarra3enJarra4());
			}
			if (jarra3 < 3) {
				estadosCandidatos.Add (vaciarJarra4enJarra3 ());
			}
				

			return estadosCandidatos;

			
		}

		//Calculo de acciones posibles (llenado y vaciado de jarras)
		private Estado llenarJarra3(){
			Estado estado = new Estado (3, jarra4);
			return estado;

		}
		private Estado llenarJarra4(){
			Estado estado = new Estado (jarra3, 4);
			return estado;
		
		}
		private Estado vaciarJarra4(){
			Estado estado = new Estado (jarra3, 0);
			return estado;
		}
		private Estado vaciarJarra3(){
			Estado estado = new Estado (0, jarra4);
			return estado;

		}
		private Estado vaciarJarra3enJarra4(){
			int x = Math.Max (0, jarra3 + (jarra4 - 4));  
			int y = Math.Min (4, jarra4 + (jarra3 - x));	
			Estado estado = new Estado (x, y);
			return estado;

		}
		private Estado vaciarJarra4enJarra3(){
			int y = Math.Max (0, jarra4 + (jarra3 - 3));
			int x = jarra3 + (jarra4 - y);

			Estado estado = new Estado (x, y);
			return estado;

		}
	}
}

