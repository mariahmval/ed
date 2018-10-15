package org.institutoserpis.ed;

import java.util.Scanner;

public class Adivina {

	public static void main(String[] args) {
		
		int numAdivinanza, num, intentos, min, max;
		Scanner teclado = new Scanner(System.in);
		
		min = 1;
		max = 1000;
		intentos = 1;
		numAdivinanza = (int) (Math.random() * 1000) + 1;
		
		System.out.println("Estoy pensando un número del 1 al 1000 y tienes que adivinarlo.");
		System.out.printf("Dime un número (intento %d):\n", intentos);
		
		num = teclado.nextInt();
		
		while (num != numAdivinanza) {
			
			if (num < numAdivinanza) {
				intentos++;
				
				if (num > min) {
					min = num + 1;
				}
				
				System.out.println("Es mayor que ese.");
				System.out.printf("El número se encuentra entre %d y %d (intento %d):\n", min, max, intentos);
				System.out.println("Prueba de nuevo:");
				num = teclado.nextInt();
			}
			
			else {
				intentos++;
				if (num < max) {
					max = num - 1;
				}
				System.out.println("Es menor que ese.");
				System.out.printf("El número se encuentra entre %d y %d (intento %d):\n", min, max, intentos);
				System.out.println("Prueba de nuevo:");
				num = teclado.nextInt();
			}
			
		}
		
		System.out.printf("¡Has acertado! El número era el %d y te ha llevado %d intentos.", numAdivinanza, intentos);
		
	}

}
