package org.institutoserpis.ed;

import java.util.Scanner;

public class Adivina {

	public static void main(String[] args) {
		
		int numAdivinanza, num, intentos=0;
		Scanner teclado = new Scanner(System.in);
		
		numAdivinanza = (int) (Math.random() * ((1000-1) + 1) + 1);
		
		System.out.println("Estoy pensando un número del 1 al 1000 y tienes que adivinarlo.");
		System.out.println("Dime un número:");
		
		num = teclado.nextInt();
		
		while (num != numAdivinanza) {
			
			if (num > numAdivinanza) {
				intentos++;
				System.out.println("Ese número es mayor al que estoy pensando, dime otro:");
				num = teclado.nextInt();
			}
			
			else {
				intentos++;
				System.out.println("Ese número es menor al que estoy pensando, dime otro:");
				num = teclado.nextInt();
			}
			
		}
		
		System.out.printf("¡Has acertado! El número era el %d y te ha llevado %d intentos.", numAdivinanza, intentos);
		
	}

}
