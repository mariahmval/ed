package org.institutoserpis.ed;

public class Vector {

	public static int indexOf(int[] v, int x) {
//		int indiceVector=0;
//		
//		//while (v[indiceVector] != x && indiceVector < v.length)
//		while (indiceVector < v.length && v[indiceVector] != x)
//			indiceVector++;
//		
//		
//		if (indiceVector == v.length)
//			return -1;
//		
//		return indiceVector;
		
		for (int index=0; index<v.length ; index++)
			if(v[index] == x)
				return index;
		return -1;
		
	}
	
	public static int min(int[] v) {
//		int menor=v[0];
//		
//		for (int indice=1 ; indice<v.length ; indice++) {
//			if (v[indice]<menor)
//				menor = v[indice];
//		}
//		
//		return menor;
//		
		
		int indexOfMin = indexOfMin(v);
		return v[indexOfMin];
		
	}
	
	public static int indexOfMin(int[] v) {
		
		int menor = 0;
		
		for (int indice=1 ; indice<v.length ; indice++) {
			if (v[indice]<v[menor])
				menor = indice;
		}
		
		return menor;
	}
	
	public static void sort(int[] v) {
		
		for(int indice=0 ; indice<v.length-1 ; indice++) {
			for(int posicion=indice+1 ; posicion<v.length ; posicion++){
				if(v[indice] > v[posicion]){
					int auxiliar=v[indice];
					v[indice]=v[posicion];
					v[posicion]=auxiliar;

				}
			}
		}
		
	}
	
	public static void main(String[] args) {
		/* Problema de búsqueda, el método debe mostrar la posición
		 * en el vector de un valor del vector */
		int[] v = new int[] {16,12,15,14,17};
		int x = 50;
		
		sort(v);
		System.out.println(min(v));
	
		// Condición 'for each' 'for ([tipo] [nombre] : [variable])
		// Recorre cada elemento de una colección.
		for (int item : v)
			System.out.println(item);
		
		System.out.printf("El valor %s está en la posición %s del vector.\n", x, indexOf(v,x));

	}

}
